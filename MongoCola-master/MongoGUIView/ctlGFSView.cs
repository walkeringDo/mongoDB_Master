﻿using System;
using System.IO;
using System.Windows.Forms;
using MongoUtility.Aggregation;
using MongoUtility.Basic;
using MongoUtility.Command;
using MongoUtility.Core;
using ResourceLib.Method;
using ResourceLib.UI;

namespace MongoGUIView
{
    public partial class CtlGfsView : CtlDataView
    {
        public CtlGfsView(DataViewInfo dataViewInfo)
        {
            InitializeComponent();
            InitTool();
            MDataViewInfo = dataViewInfo;
            DataShower.Add(lstData);
            if (!GuiConfig.IsUseDefaultLanguage)
            {
                DeleteFileToolStripMenuItem.Text = GuiConfig.GetText(TextType.MainMenuOperationFileSystemDelFile);
                DeleteFileStripButton.Text = DeleteFileToolStripMenuItem.Text;

                UploadFileToolStripMenuItem.Text = GuiConfig.GetText(TextType.MainMenuOperationFileSystemUploadFile);
                UploadFileStripButton.Text = UploadFileToolStripMenuItem.Text;

                UploadFolderToolStripMenuItem.Text =
                    GuiConfig.GetText(TextType.MainMenuOperationFileSystemUploadFolder);
                UpLoadFolderStripButton.Text = UploadFolderToolStripMenuItem.Text;

                DownloadFileToolStripMenuItem.Text = GuiConfig.GetText(TextType.MainMenuOperationFileSystemDownload);
                DownloadFileStripButton.Text = DownloadFileToolStripMenuItem.Text;

                OpenFileToolStripMenuItem.Text = GuiConfig.GetText(TextType.MainMenuOperationFileSystemOpenFile);
                OpenFileStripButton.Text = OpenFileToolStripMenuItem.Text;
            }
        }

        private void ctlGFSView_Load(object sender, EventArgs e)
        {
            OpenFileToolStripMenuItem.Click += OpenFileStripButton_Click;
            DownloadFileToolStripMenuItem.Click += DownloadFileStripButton_Click;
            UploadFileToolStripMenuItem.Click += UploadFileStripButton_Click;
            UploadFolderToolStripMenuItem.Click += UpLoadFolderStripButton_Click;
            DeleteFileToolStripMenuItem.Click += DeleteFileStripButton_Click;


            UploadFileStripButton.Enabled = true;
            UploadFileToolStripMenuItem.Enabled = true;

            UpLoadFolderStripButton.Enabled = true;
            UploadFolderToolStripMenuItem.Enabled = true;

            cmbListViewStyle.Visible = true;
            cmbListViewStyle.SelectedIndexChanged += (x, y) => { lstData.View = (View) cmbListViewStyle.SelectedIndex; };
        }

        private void lstData_SelectedIndexChanged(object sender, EventArgs e)
        {
            //文件系统
            UploadFileToolStripMenuItem.Enabled = true;
            UploadFileStripButton.Enabled = true;

            UpLoadFolderStripButton.Enabled = true;
            UploadFolderToolStripMenuItem.Enabled = true;
            switch (lstData.SelectedItems.Count)
            {
                case 0:
                    //禁止所有操作
                    OpenFileStripButton.Enabled = false;
                    OpenFileToolStripMenuItem.Enabled = false;

                    DownloadFileToolStripMenuItem.Enabled = false;
                    DownloadFileStripButton.Enabled = false;

                    DeleteFileStripButton.Enabled = false;
                    DeleteFileToolStripMenuItem.Enabled = false;

                    lstData.ContextMenuStrip = null;
                    break;
                case 1:
                    //可以进行所有操作
                    OpenFileStripButton.Enabled = true;
                    OpenFileToolStripMenuItem.Enabled = true;
                    DownloadFileToolStripMenuItem.Enabled = true;
                    DownloadFileStripButton.Enabled = true;
                    if (!MDataViewInfo.IsReadOnly)
                    {
                        DeleteFileStripButton.Enabled = true;
                        DeleteFileToolStripMenuItem.Enabled = true;
                    }
                    break;
                default:
                    //可以删除多个文件
                    OpenFileStripButton.Enabled = false;
                    OpenFileToolStripMenuItem.Enabled = false;

                    DownloadFileToolStripMenuItem.Enabled = false;
                    DownloadFileStripButton.Enabled = false;
                    if (!MDataViewInfo.IsReadOnly)
                    {
                        DeleteFileStripButton.Enabled = true;
                        DeleteFileToolStripMenuItem.Enabled = true;
                    }
                    break;
            }
        }

        protected void lstData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileStripButton_Click(sender, e);
        }

        protected void lstData_MouseClick(object sender, MouseEventArgs e)
        {
            RuntimeMongoDbContext.SelectObjectTag = MDataViewInfo.StrDbTag;
            if (lstData.SelectedItems.Count > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    contextMenuStripMain = new ContextMenuStrip();
                    contextMenuStripMain.Items.Add(OpenFileToolStripMenuItem.Clone());
                    contextMenuStripMain.Items.Add(UploadFileToolStripMenuItem.Clone());
                    contextMenuStripMain.Items.Add(UploadFolderToolStripMenuItem.Clone());
                    contextMenuStripMain.Items.Add(DownloadFileToolStripMenuItem.Clone());
                    contextMenuStripMain.Items.Add(DeleteFileToolStripMenuItem.Clone());
                    contextMenuStripMain.Show(lstData.PointToScreen(e.Location));
                }
            }
        }

        #region"管理：GFS"

        /// <summary>
        ///     Upload File
        /// </summary>
        private void UploadFileStripButton_Click(object sender, EventArgs e)
        {
            var upfile = new OpenFileDialog();
            if (upfile.ShowDialog() == DialogResult.OK)
            {
                var opt = new Gfs.UpLoadFileOption();
                var frm = new FrmGfsOption();
                frm.ShowDialog();
                opt.AlreadyOpt = frm.Option;
                opt.DirectorySeparatorChar = frm.DirectorySeparatorChar;
                opt.FileNameOpt = frm.Filename;
                opt.IgnoreSubFolder = frm.IgnoreSubFolder;
                Gfs.UpLoadFile(upfile.FileName, opt, null);
                RefreshGui();
            }
        }

        /// <summary>
        ///     上传文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpLoadFolderStripButton_Click(object sender, EventArgs e)
        {
            var upfolder = new FolderBrowserDialog();
            if (upfolder.ShowDialog() == DialogResult.OK)
            {
                var opt = new Gfs.UpLoadFileOption();
                var frm = new FrmGfsOption();
                frm.ShowDialog();
                opt.AlreadyOpt = frm.Option;
                opt.DirectorySeparatorChar = frm.DirectorySeparatorChar;
                opt.FileNameOpt = frm.Filename;
                opt.IgnoreSubFolder = frm.IgnoreSubFolder;
                var uploadDir = new DirectoryInfo(upfolder.SelectedPath);
                var count = 0;
                UploadFolder(uploadDir, ref count, opt);
                MyMessageBox.ShowMessage("Upload", "Upload Completed! Upload Files Count: " + count);
                RefreshGui();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="uploadDir"></param>
        /// <param name="fileCount"></param>
        /// <param name="opt"></param>
        /// <returns>是否继续执行后续的所有操作</returns>
        private bool UploadFolder(DirectoryInfo uploadDir, ref int fileCount, Gfs.UpLoadFileOption opt)
        {
            foreach (var file in uploadDir.GetFiles())
            {
                var rtn = Gfs.UpLoadFile(file.FullName, opt, RuntimeMongoDbContext.GetCurrentDataBase());
                switch (rtn)
                {
                    case Gfs.UploadResult.Complete:
                        fileCount++;
                        break;
                    case Gfs.UploadResult.Skip:
                        if (opt.AlreadyOpt == Gfs.EnumGfsAlready.Stop)
                        {
                            //这个操作返回为False，停止包括父亲过程在内的所有操作
                            return false;
                        }
                        break;
                    case Gfs.UploadResult.Exception:
                        return MyMessageBox.ShowConfirm("Upload Exception", "Is Continue?");
                }
            }
            if (!opt.IgnoreSubFolder)
            {
                foreach (var dir in uploadDir.GetDirectories())
                {
                    //递归文件夹操作，如果下层有任何停止的意愿，则立刻停止，并且使上层也立刻停止
                    var isContinue = UploadFolder(dir, ref fileCount, opt);
                    if (!isContinue)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        ///     DownLoad File
        /// </summary>
        public void DownloadFileStripButton_Click(object sender, EventArgs e)
        {
            var downfile = new SaveFileDialog();
            var strFileName = lstData.SelectedItems[0].Text;
            //For Winodws,Linux user DirectorySeparatorChar Replace with @"\"
            downfile.FileName =
                strFileName.Split(Path.DirectorySeparatorChar)[strFileName.Split(Path.DirectorySeparatorChar).Length - 1
                    ];
            if (downfile.ShowDialog() == DialogResult.OK)
            {
                Gfs.DownloadFile(downfile.FileName, strFileName, null);
            }
            RefreshGui();
        }

        /// <summary>
        ///     Open File
        /// </summary>
        private void OpenFileStripButton_Click(object sender, EventArgs e)
        {
            if (lstData.SelectedItems.Count == 1)
            {
                var strFileName = lstData.SelectedItems[0].Text;
                Gfs.OpenFile(strFileName, null);
            }
        }

        /// <summary>
        ///     Delete File
        /// </summary>
        public void DeleteFileStripButton_Click(object sender, EventArgs e)
        {
            var strTitle = "Delete Files";
            var strMessage = "Are you sure to delete selected File(s)?";
            if (!GuiConfig.IsUseDefaultLanguage)
            {
                strTitle = GuiConfig.GetText(TextType.DropData);
                strMessage = GuiConfig.GetText(TextType.DropDataConfirm);
            }
            if (MyMessageBox.ShowConfirm(strTitle, strMessage))
            {
                foreach (ListViewItem item in lstData.SelectedItems)
                {
                    Gfs.DelFile(item.Text, null);
                }
                RefreshGui();
            }
        }

        #endregion
    }
}
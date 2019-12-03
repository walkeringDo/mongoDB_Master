﻿using System;
using System.Windows.Forms;
using MongoUtility.EventArgs;
using MongoUtility.ToolKit;
using ResourceLib.Method;

namespace MongoGUICtl
{
    public partial class CtlMongodump : UserControl
    {
        private readonly MongoDumpInfo _mongodumpCommand = new MongoDumpInfo();
        public EventHandler<TextChangeEventArgs> CommandChanged;

        public CtlMongodump()
        {
            InitializeComponent();
            if (!GuiConfig.IsUseDefaultLanguage)
            {
                lblCollectionName.Text =
                    GuiConfig.GetText(TextType.DosCommandTabBackupDcName);
                lblDBName.Text =
                    GuiConfig.GetText(TextType.DosCommandTabBackupDbName);
                lblHostAddr.Text =
                    GuiConfig.GetText(TextType.DosCommandTabBackupServer);
                lblPort.Text =
                    GuiConfig.GetText(TextType.DosCommandTabBackupPort);
                ctlFilePickerOutput.Title =
                    GuiConfig.GetText(TextType.DosCommandTabBackupPath);
            }
        }

        private void ctlMongodump_Load(object sender, EventArgs e)
        {
            ctllogLvT.LoglvChanged += ctllogLvT_LoglvChanged;
            ctlFilePickerOutput.PathChanged += ctlFilePickerOutput_PathChanged;
        }

        protected virtual void OnCommandChange(TextChangeEventArgs e)
        {
            e.Raise(this, ref CommandChanged);
        }

        private void ctlFilePickerOutput_PathChanged(string filePath)
        {
            _mongodumpCommand.OutPutPath = filePath;
            OnCommandChange(new TextChangeEventArgs(string.Empty,
                MongoDumpInfo.GetMongodumpCommandLine(_mongodumpCommand)));
        }

        private void ctllogLvT_LoglvChanged(MongodbDosCommand.MongologLevel logLv)
        {
            _mongodumpCommand.LogLv = logLv;
            OnCommandChange(new TextChangeEventArgs(string.Empty,
                MongoDumpInfo.GetMongodumpCommandLine(_mongodumpCommand)));
        }

        private void txtHostAddr_TextChanged(object sender, EventArgs e)
        {
            _mongodumpCommand.HostAddr = txtHostAddr.Text;
            OnCommandChange(new TextChangeEventArgs(string.Empty,
                MongoDumpInfo.GetMongodumpCommandLine(_mongodumpCommand)));
        }

        private void txtDBName_TextChanged(object sender, EventArgs e)
        {
            _mongodumpCommand.DbName = txtDBName.Text;
            OnCommandChange(new TextChangeEventArgs(string.Empty,
                MongoDumpInfo.GetMongodumpCommandLine(_mongodumpCommand)));
        }

        private void txtCollectionName_TextChanged(object sender, EventArgs e)
        {
            _mongodumpCommand.CollectionName = txtCollectionName.Text;
            OnCommandChange(new TextChangeEventArgs(string.Empty,
                MongoDumpInfo.GetMongodumpCommandLine(_mongodumpCommand)));
        }

        private void numPort_ValueChanged(object sender, EventArgs e)
        {
            _mongodumpCommand.Port = (int) numPort.Value;
            OnCommandChange(new TextChangeEventArgs(string.Empty,
                MongoDumpInfo.GetMongodumpCommandLine(_mongodumpCommand)));
        }
    }
}
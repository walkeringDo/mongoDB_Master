﻿using System;
using System.Windows.Forms;
using MongoUtility.EventArgs;
using MongoUtility.ToolKit;
using ResourceLib.Method;

namespace MongoGUICtl
{
    public partial class CtlMongoImportExport : UserControl
    {
        private readonly MongoImportExportInfo _mongoImportExportCommand =
            new MongoImportExportInfo();

        public EventHandler<TextChangeEventArgs> CommandChanged;

        public CtlMongoImportExport()
        {
            InitializeComponent();
        }

        private void ctlMongodump_Load(object sender, EventArgs e)
        {
            ctllogLvT.LoglvChanged += ctllogLvT_LoglvChanged;
            ctlFilePickerOutput.PathChanged += ctlFilePickerOutput_PathChanged;
            if (!GuiConfig.IsUseDefaultLanguage)
            {
                lblCollectionName.Text =
                    GuiConfig.GetText(
                        TextType.CollectionStatusCollectionName);
                lblDBName.Text =
                    GuiConfig.GetText(TextType.AddConnectionDbName);
                lblHost.Text = GuiConfig.GetText(TextType.CommonHost);
                lblFieldList.Text =
                    GuiConfig.GetText(
                        TextType.DosCommandTabExInColumnList);
                lblPort.Text = GuiConfig.GetText(TextType.CommonPort);
                grpDirect.Text =
                    GuiConfig.GetText(
                        TextType.DosCommandTabExInOperation);
                radImport.Text =
                    GuiConfig.GetText(TextType.DosCommandTabExInImport);
                radExport.Text =
                    GuiConfig.GetText(TextType.DosCommandTabExInExport);
                ctlFilePickerOutput.Title =
                    GuiConfig.GetText(TextType.DosCommandTabExInWorkfile);
            }
        }

        protected virtual void OnCommandChange(TextChangeEventArgs e)
        {
            e.Raise(this, ref CommandChanged);
        }

        private void ctlFilePickerOutput_PathChanged(string filePath)
        {
            _mongoImportExportCommand.FileName = filePath;
            OnCommandChange(new TextChangeEventArgs(string.Empty,
                MongoImportExportInfo.GetMongoImportExportCommandLine(_mongoImportExportCommand)));
        }

        private void ctllogLvT_LoglvChanged(MongodbDosCommand.MongologLevel logLv)
        {
            _mongoImportExportCommand.LogLv = logLv;
            OnCommandChange(new TextChangeEventArgs(string.Empty,
                MongoImportExportInfo.GetMongoImportExportCommandLine(_mongoImportExportCommand)));
        }

        private void txtHostAddr_TextChanged(object sender, EventArgs e)
        {
            _mongoImportExportCommand.HostAddr = txtHostAddr.Text;
            OnCommandChange(new TextChangeEventArgs(string.Empty,
                MongoImportExportInfo.GetMongoImportExportCommandLine(_mongoImportExportCommand)));
        }

        private void txtDBName_TextChanged(object sender, EventArgs e)
        {
            _mongoImportExportCommand.DbName = txtDBName.Text;
            OnCommandChange(new TextChangeEventArgs(string.Empty,
                MongoImportExportInfo.GetMongoImportExportCommandLine(_mongoImportExportCommand)));
        }

        private void txtCollectionName_TextChanged(object sender, EventArgs e)
        {
            _mongoImportExportCommand.CollectionName = txtCollectionName.Text;
            OnCommandChange(new TextChangeEventArgs(string.Empty,
                MongoImportExportInfo.GetMongoImportExportCommandLine(_mongoImportExportCommand)));
        }

        private void numPort_ValueChanged(object sender, EventArgs e)
        {
            _mongoImportExportCommand.Port = (int) numPort.Value;
            OnCommandChange(new TextChangeEventArgs(string.Empty,
                MongoImportExportInfo.GetMongoImportExportCommandLine(_mongoImportExportCommand)));
        }

        private void txtFieldList_TextChanged(object sender, EventArgs e)
        {
            _mongoImportExportCommand.FieldList = txtFieldList.Text;
            OnCommandChange(new TextChangeEventArgs(string.Empty,
                MongoImportExportInfo.GetMongoImportExportCommandLine(_mongoImportExportCommand)));
        }

        private void radExport_CheckedChanged(object sender, EventArgs e)
        {
            _mongoImportExportCommand.Direct = radExport.Checked
                ? MongoImportExportInfo.ImprotExport.Export
                : MongoImportExportInfo.ImprotExport.Import;
            OnCommandChange(new TextChangeEventArgs(string.Empty,
                MongoImportExportInfo.GetMongoImportExportCommandLine(_mongoImportExportCommand)));
        }

        private void radImport_CheckedChanged(object sender, EventArgs e)
        {
            _mongoImportExportCommand.Direct = radExport.Checked
                ? MongoImportExportInfo.ImprotExport.Export
                : MongoImportExportInfo.ImprotExport.Import;
            OnCommandChange(new TextChangeEventArgs(string.Empty,
                MongoImportExportInfo.GetMongoImportExportCommandLine(_mongoImportExportCommand)));
        }
    }
}
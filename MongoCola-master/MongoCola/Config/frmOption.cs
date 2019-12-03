﻿using System;
using System.IO;
using System.Windows.Forms;
using ResourceLib.Method;

namespace MongoCola.Config
{
    public partial class FrmOption : Form
    {
        public FrmOption()
        {
            InitializeComponent();
        }

        private void frmOption_Load(object sender, EventArgs e)
        {
            fileMongoBinPath.SelectedPathOrFileName = SystemManager.SystemConfig.MongoBinPath;
            if (SystemManager.SystemConfig.IsUTC)
            {
                radUTC.Checked = true;
            }
            else
            {
                radLocal.Checked = true;
            }
            //intRefreshStatusTimer.Value = SystemManager.SystemConfig.RefreshStatusTimer;
            cmbLanguage.Items.Add(StringResource.LanguageEnglish);
            if (Directory.Exists("Language"))
            {
                foreach (var fileName in Directory.GetFiles("Language"))
                {
                    cmbLanguage.Items.Add(new FileInfo(fileName).Name.Substring(0,
                        new FileInfo(fileName).Name.Length - 4));
                }
            }

            if (!GuiConfig.IsUseDefaultLanguage)
            {
                if (
                    File.Exists("Language" + Path.DirectorySeparatorChar +
                                SystemManager.SystemConfig.LanguageFileName))
                {
                    cmbLanguage.Text = SystemManager.SystemConfig.LanguageFileName.Substring(0,
                        SystemManager.SystemConfig.LanguageFileName.Length - 4);
                }
                else
                {
                    cmbLanguage.Text = StringResource.LanguageEnglish;
                }
            }
            else
            {
                cmbLanguage.Text = StringResource.LanguageEnglish;
            }
            GuiConfig.Translateform(this);
        }

        /// <summary>
        ///     OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdOK_Click(object sender, EventArgs e)
        {
            _ctlReadWriteConfig1.SaveConfig();
            SystemManager.SystemConfig.IsUTC = radUTC.Checked;
            SystemManager.SystemConfig.MongoBinPath = fileMongoBinPath.SelectedPathOrFileName;
            SystemManager.SystemConfig.RefreshStatusTimer = (int) intRefreshStatusTimer.Value;
            SystemManager.SystemConfig.LanguageFileName = cmbLanguage.Text + ".xml";
            SystemManager.SystemConfig.SaveSystemConfig();
            Close();
        }

        /// <summary>
        ///     Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
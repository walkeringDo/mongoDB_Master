﻿using System.ComponentModel;
using System.Windows.Forms;
using ResourceLib.UI;

namespace MongoGUICtl
{
    partial class CtlMongod
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.chkIsAppend = new System.Windows.Forms.CheckBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.chkAuth = new System.Windows.Forms.CheckBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.radNormal = new System.Windows.Forms.RadioButton();
            this.radMaster = new System.Windows.Forms.RadioButton();
            this.radSlave = new System.Windows.Forms.RadioButton();
            this.lblWarning = new System.Windows.Forms.Label();
            this.chkSmallfiles = new System.Windows.Forms.CheckBox();
            this.ctlFilePickerDBPath = new CtlFilePicker();
            this.ctllogLvT = new CtllogLv();
            this.ctlFilePickerLogPath = new CtlFilePicker();
            this.grpLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLog
            // 
            this.grpLog.Controls.Add(this.chkSmallfiles);
            this.grpLog.Controls.Add(this.ctllogLvT);
            this.grpLog.Controls.Add(this.chkIsAppend);
            this.grpLog.Controls.Add(this.ctlFilePickerLogPath);
            this.grpLog.Location = new System.Drawing.Point(19, 75);
            this.grpLog.Name = "grpLog";
            this.grpLog.Size = new System.Drawing.Size(745, 95);
            this.grpLog.TabIndex = 0;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "Log";
            this.grpLog.Enter += new System.EventHandler(this.grpLog_Enter);
            // 
            // chkIsAppend
            // 
            this.chkIsAppend.AutoSize = true;
            this.chkIsAppend.Location = new System.Drawing.Point(64, 62);
            this.chkIsAppend.Name = "chkIsAppend";
            this.chkIsAppend.Size = new System.Drawing.Size(93, 17);
            this.chkIsAppend.TabIndex = 0;
            this.chkIsAppend.Text = "Append Mode";
            this.chkIsAppend.UseVisualStyleBackColor = true;
            this.chkIsAppend.CheckedChanged += new System.EventHandler(this.chkIsAppend_CheckedChanged);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(41, 15);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(32, 13);
            this.lblPort.TabIndex = 7;
            this.lblPort.Text = "Port：";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(100, 13);
            this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPort.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(67, 20);
            this.numPort.TabIndex = 8;
            this.numPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPort.Value = new decimal(new int[] {
            27017,
            0,
            0,
            0});
            this.numPort.ValueChanged += new System.EventHandler(this.numPort_ValueChanged);
            // 
            // chkAuth
            // 
            this.chkAuth.AutoSize = true;
            this.chkAuth.Location = new System.Drawing.Point(593, 16);
            this.chkAuth.Name = "chkAuth";
            this.chkAuth.Size = new System.Drawing.Size(78, 17);
            this.chkAuth.TabIndex = 16;
            this.chkAuth.Text = "Auth Mode";
            this.chkAuth.UseVisualStyleBackColor = true;
            this.chkAuth.CheckedChanged += new System.EventHandler(this.chkAuth_CheckedChanged);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(399, 15);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(77, 13);
            this.lblSource.TabIndex = 17;
            this.lblSource.Text = "Slave Source：";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(482, 13);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(105, 20);
            this.txtSource.TabIndex = 18;
            this.txtSource.TextChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // radNormal
            // 
            this.radNormal.AutoSize = true;
            this.radNormal.Checked = true;
            this.radNormal.Location = new System.Drawing.Point(193, 13);
            this.radNormal.Name = "radNormal";
            this.radNormal.Size = new System.Drawing.Size(58, 17);
            this.radNormal.TabIndex = 19;
            this.radNormal.TabStop = true;
            this.radNormal.Text = "Normal";
            this.radNormal.UseVisualStyleBackColor = true;
            this.radNormal.CheckedChanged += new System.EventHandler(this.MongodType_CheckedChanged);
            // 
            // radMaster
            // 
            this.radMaster.AutoSize = true;
            this.radMaster.Location = new System.Drawing.Point(257, 13);
            this.radMaster.Name = "radMaster";
            this.radMaster.Size = new System.Drawing.Size(57, 17);
            this.radMaster.TabIndex = 20;
            this.radMaster.Text = "Master";
            this.radMaster.UseVisualStyleBackColor = true;
            this.radMaster.CheckedChanged += new System.EventHandler(this.MongodType_CheckedChanged);
            // 
            // radSlave
            // 
            this.radSlave.AutoSize = true;
            this.radSlave.Location = new System.Drawing.Point(320, 13);
            this.radSlave.Name = "radSlave";
            this.radSlave.Size = new System.Drawing.Size(52, 17);
            this.radSlave.TabIndex = 21;
            this.radSlave.Text = "Slave";
            this.radSlave.UseVisualStyleBackColor = true;
            this.radSlave.CheckedChanged += new System.EventHandler(this.MongodType_CheckedChanged);
            // 
            // lblWarning
            // 
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(16, 173);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(748, 32);
            this.lblWarning.TabIndex = 22;
            this.lblWarning.Text = "Deprecated since version 1.6: Replica sets replace master-slave replication. Use " +
    "replica sets rather than master-slave replication for all new production deploym" +
    "ents.";
            // 
            // chkSmallfiles
            // 
            this.chkSmallfiles.AutoSize = true;
            this.chkSmallfiles.Location = new System.Drawing.Point(163, 62);
            this.chkSmallfiles.Name = "chkSmallfiles";
            this.chkSmallfiles.Size = new System.Drawing.Size(69, 17);
            this.chkSmallfiles.TabIndex = 23;
            this.chkSmallfiles.Text = "Smallfiles";
            this.chkSmallfiles.UseVisualStyleBackColor = true;
            // 
            // ctlFilePickerDBPath
            // 
            this.ctlFilePickerDBPath.BackColor = System.Drawing.Color.Transparent;
            this.ctlFilePickerDBPath.FileFilter = "";
            this.ctlFilePickerDBPath.Location = new System.Drawing.Point(26, 41);
            this.ctlFilePickerDBPath.Name = "ctlFilePickerDBPath";
            this.ctlFilePickerDBPath.PickerType = CtlFilePicker.DialogType.Directory;
            this.ctlFilePickerDBPath.SelectedPathOrFileName = "";
            this.ctlFilePickerDBPath.Size = new System.Drawing.Size(739, 35);
            this.ctlFilePickerDBPath.TabIndex = 15;
            this.ctlFilePickerDBPath.Title = "DataBase Path";
            // 
            // ctllogLvT
            // 
            this.ctllogLvT.BackColor = System.Drawing.Color.Transparent;
            this.ctllogLvT.Location = new System.Drawing.Point(258, 60);
            this.ctllogLvT.Name = "ctllogLvT";
            this.ctllogLvT.Size = new System.Drawing.Size(199, 19);
            this.ctllogLvT.TabIndex = 14;
            // 
            // ctlFilePickerLogPath
            // 
            this.ctlFilePickerLogPath.BackColor = System.Drawing.Color.Transparent;
            this.ctlFilePickerLogPath.FileFilter = "";
            this.ctlFilePickerLogPath.Location = new System.Drawing.Point(9, 25);
            this.ctlFilePickerLogPath.Name = "ctlFilePickerLogPath";
            this.ctlFilePickerLogPath.PickerType = CtlFilePicker.DialogType.SaveFile;
            this.ctlFilePickerLogPath.SelectedPathOrFileName = "";
            this.ctlFilePickerLogPath.Size = new System.Drawing.Size(739, 37);
            this.ctlFilePickerLogPath.TabIndex = 14;
            this.ctlFilePickerLogPath.Title = "LogPath";
            // 
            // ctlMongod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.radSlave);
            this.Controls.Add(this.radMaster);
            this.Controls.Add(this.radNormal);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.chkAuth);
            this.Controls.Add(this.ctlFilePickerDBPath);
            this.Controls.Add(this.numPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.grpLog);
            this.Name = "CtlMongod";
            this.Size = new System.Drawing.Size(767, 209);
            this.Load += new System.EventHandler(this.ctlMongod_Load);
            this.grpLog.ResumeLayout(false);
            this.grpLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private GroupBox grpLog;
        private CheckBox chkIsAppend;
        private Label lblPort;
        private NumericUpDown numPort;
        private CtllogLv ctllogLvT;
        private CtlFilePicker ctlFilePickerLogPath;
        private CtlFilePicker ctlFilePickerDBPath;
        private CheckBox chkAuth;
        private Label lblSource;
        private TextBox txtSource;
        private RadioButton radNormal;
        private RadioButton radMaster;
        private RadioButton radSlave;
        private Label lblWarning;
        private CheckBox chkSmallfiles;
    }
}

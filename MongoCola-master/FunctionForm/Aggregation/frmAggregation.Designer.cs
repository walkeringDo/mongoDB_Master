﻿using System.ComponentModel;
using System.Windows.Forms;
using MongoGUICtl;

namespace FunctionForm.Aggregation
{
    partial class FrmAggregation
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResult = new System.Windows.Forms.Label();
            this.cmdRun = new System.Windows.Forms.Button();
            this.cmdAddCondition = new System.Windows.Forms.Button();
            this.lnkReference = new System.Windows.Forms.LinkLabel();
            this.cmdSaveAggregatePipeline = new System.Windows.Forms.Button();
            this.lblAggregatePipeline = new System.Windows.Forms.Label();
            this.cmbForAggregatePipeline = new System.Windows.Forms.ComboBox();
            this.cmdClear = new System.Windows.Forms.Button();
            this.trvCondition  = new CtlTreeViewColumns();
            this.trvResult = new CtlTreeViewColumns();
            this.btnAggrBuilder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Location = new System.Drawing.Point(434, 27);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 20;
            this.lblResult.Text = "Result";
            // 
            // cmdRun
            // 
            this.cmdRun.BackColor = System.Drawing.Color.Transparent;
            this.cmdRun.Location = new System.Drawing.Point(735, 388);
            this.cmdRun.Name = "cmdRun";
            this.cmdRun.Size = new System.Drawing.Size(82, 25);
            this.cmdRun.TabIndex = 21;
            this.cmdRun.Text = "Run";
            this.cmdRun.UseVisualStyleBackColor = false;
            this.cmdRun.Click += new System.EventHandler(this.cmdRun_Click);
            // 
            // cmdAddCondition
            // 
            this.cmdAddCondition.Location = new System.Drawing.Point(181, 389);
            this.cmdAddCondition.Name = "cmdAddCondition";
            this.cmdAddCondition.Size = new System.Drawing.Size(136, 24);
            this.cmdAddCondition.TabIndex = 23;
            this.cmdAddCondition.Text = "Add Aggregation";
            this.cmdAddCondition.UseVisualStyleBackColor = true;
            this.cmdAddCondition.Click += new System.EventHandler(this.cmdAddCondition_Click);
            // 
            // lnkReference
            // 
            this.lnkReference.AutoSize = true;
            this.lnkReference.Location = new System.Drawing.Point(430, 9);
            this.lnkReference.Name = "lnkReference";
            this.lnkReference.Size = new System.Drawing.Size(172, 13);
            this.lnkReference.TabIndex = 24;
            this.lnkReference.TabStop = true;
            this.lnkReference.Text = "Aggregation Framework Reference";
            this.lnkReference.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReference_LinkClicked);
            // 
            // cmdSaveAggregatePipeline
            // 
            this.cmdSaveAggregatePipeline.Location = new System.Drawing.Point(581, 388);
            this.cmdSaveAggregatePipeline.Name = "cmdSaveAggregatePipeline";
            this.cmdSaveAggregatePipeline.Size = new System.Drawing.Size(148, 25);
            this.cmdSaveAggregatePipeline.TabIndex = 25;
            this.cmdSaveAggregatePipeline.Text = "Save Aggregate Pipeline";
            this.cmdSaveAggregatePipeline.UseVisualStyleBackColor = true;
            this.cmdSaveAggregatePipeline.Click += new System.EventHandler(this.cmdSaveAggregatePipeline_Click);
            // 
            // lblAggregatePipeline
            // 
            this.lblAggregatePipeline.AutoSize = true;
            this.lblAggregatePipeline.BackColor = System.Drawing.Color.Transparent;
            this.lblAggregatePipeline.Location = new System.Drawing.Point(13, 25);
            this.lblAggregatePipeline.Name = "lblAggregatePipeline";
            this.lblAggregatePipeline.Size = new System.Drawing.Size(96, 13);
            this.lblAggregatePipeline.TabIndex = 26;
            this.lblAggregatePipeline.Text = "Aggregate Pipeline";
            // 
            // cmbForAggregatePipeline
            // 
            this.cmbForAggregatePipeline.FormattingEnabled = true;
            this.cmbForAggregatePipeline.Location = new System.Drawing.Point(127, 22);
            this.cmbForAggregatePipeline.Name = "cmbForAggregatePipeline";
            this.cmbForAggregatePipeline.Size = new System.Drawing.Size(278, 21);
            this.cmbForAggregatePipeline.TabIndex = 27;
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(323, 388);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(82, 24);
            this.cmdClear.TabIndex = 29;
            this.cmdClear.Text = "Clear ";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // trvCondition
            // 
            this.trvCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.trvCondition.Location = new System.Drawing.Point(12, 49);
            this.trvCondition.Name = "trvCondition";
            this.trvCondition.Padding = new System.Windows.Forms.Padding(1);
            this.trvCondition.Size = new System.Drawing.Size(393, 329);
            this.trvCondition.TabIndex = 22;
            // 
            // trvResult
            // 
            this.trvResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.trvResult.Location = new System.Drawing.Point(433, 45);
            this.trvResult.Name = "trvResult";
            this.trvResult.Padding = new System.Windows.Forms.Padding(1);
            this.trvResult.Size = new System.Drawing.Size(385, 333);
            this.trvResult.TabIndex = 0;
            // 
            // btnAggrBuilder
            // 
            this.btnAggrBuilder.Location = new System.Drawing.Point(31, 390);
            this.btnAggrBuilder.Name = "btnAggrBuilder";
            this.btnAggrBuilder.Size = new System.Drawing.Size(135, 23);
            this.btnAggrBuilder.TabIndex = 30;
            this.btnAggrBuilder.Text = "Aggregation Builder";
            this.btnAggrBuilder.UseVisualStyleBackColor = true;
            this.btnAggrBuilder.Click += new System.EventHandler(this.btnAggrBuilder_Click);
            // 
            // frmAggregation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 423);
            this.Controls.Add(this.btnAggrBuilder);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmbForAggregatePipeline);
            this.Controls.Add(this.lblAggregatePipeline);
            this.Controls.Add(this.cmdSaveAggregatePipeline);
            this.Controls.Add(this.lnkReference);
            this.Controls.Add(this.cmdAddCondition);
            this.Controls.Add(this.trvCondition);
            this.Controls.Add(this.cmdRun);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.trvResult);
            this.Name = "FrmAggregation";
            this.Text = "frmAggregation";
            this.Load += new System.EventHandler(this.frmAggregation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CtlTreeViewColumns trvResult;
        private Label lblResult;
        private Button cmdRun;
        private CtlTreeViewColumns trvCondition;
        private Button cmdAddCondition;
        private LinkLabel lnkReference;
        private Button cmdSaveAggregatePipeline;
        private Label lblAggregatePipeline;
        private ComboBox cmbForAggregatePipeline;
        private Button cmdClear;
        private Button btnAggrBuilder;
    }
}
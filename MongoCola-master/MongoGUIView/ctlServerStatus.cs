﻿using System;
using Common;
using MongoGUICtl.ClientTree;
using MongoUtility.Core;
using ResourceLib.Method;
using ResourceLib.Properties;

namespace MongoGUIView
{
    public partial class CtlServerStatus : MultiTabControl
    {
        public CtlServerStatus()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     刷新状态，不包含当前操作状态
        /// </summary>
        /// <param name="isAuto">是否自动刷新</param>
        public void RefreshStatus()
        {
            try
            {
                FillMongoDb.FillClientStatusToList(trvSvrStatus, RuntimeMongoDbContext.MongoConnClientLst);
                FillMongoDb.FillDataBaseStatusToList(trvDBStatus, RuntimeMongoDbContext.MongoConnSvrLst);
                FillMongoDb.FillCollectionStatusToList(trvColStatus, RuntimeMongoDbContext.MongoConnSvrLst);
            }
            catch (Exception ex)
            {
                Utility.ExceptionDeal(ex, "Refresh Status");
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ctlServerStatus_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            GuiConfig.Translateform(Controls);
        }

        /// <summary>
        ///     手动刷新所有状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshStripButton_Click(object sender, EventArgs e)
        {
            RefreshStatus();
        }

        /// <summary>
        ///     切换自动手动模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSwitch_Click(object sender, EventArgs e)
        {
        }

        public void ResetCtl()
        {
            btnSwitch.Enabled = true;
            RefreshStripButton.Enabled = true;
            btnSwitch.Image = Resources.Run;
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseStripButton_Click(object sender, EventArgs e)
        {
            RaiseCloseTabEvent();
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollapseAllStripButton_Click(object sender, EventArgs e)
        {
            trvSvrStatus.DatatreeView.BeginUpdate();
            trvSvrStatus.DatatreeView.CollapseAll();
            trvSvrStatus.DatatreeView.EndUpdate();
        }

        private void ExpandAllStripButton_Click(object sender, EventArgs e)
        {
            trvSvrStatus.DatatreeView.BeginUpdate();
            trvSvrStatus.DatatreeView.ExpandAll();
            trvSvrStatus.DatatreeView.EndUpdate();
        }

        public override void RefreshGui()
        {
            RefreshStatus();
        }
    }
}
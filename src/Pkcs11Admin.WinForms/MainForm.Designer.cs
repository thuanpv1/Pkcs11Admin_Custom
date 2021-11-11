/*
 *  Pkcs11Admin - GUI tool for administration of PKCS#11 enabled devices
 *  Copyright (c) 2014-2019 Jaroslav Imrich <jimrich@jimrich.sk>
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License version 3 
 *  as published by the Free Software Foundation.
 *  
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *  
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System.Windows.Forms;

namespace Net.Pkcs11Admin.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.MainFormStatusStrip = new System.Windows.Forms.StatusStrip();
            this.MainFormStatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuItemApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLoadLibrary = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOpenLogFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemApplicationSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemReloadLibrary = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRefreshSlot = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemApplicationSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.testingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSlot = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemToken = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUserLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProtectedUserLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSoLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProtectedSoLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChangePin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUserChange = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProtectedUserChange = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSoChange = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProtectedSoChange = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTokenSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemInitToken = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTokenInit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProtectedTokenInit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemInitPin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUserInit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProtectedUserInit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemObject = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemObjectNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemObjectNewData = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemObjectNewKey = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemObjectNewCsr = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemObjectNewCert = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemObjectEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemObjectDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemObjectView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemObjectViewData = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemObjectViewCert = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemObjectImport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemObjectImportData = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemObjectImportCert = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemObjectImportKey = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemObjectExport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemObjectExportData = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemObjectExportCert = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemObjectExportKey = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCsvExport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCsvExportAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCsvExportSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPkcs11Uri = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPkcs11UriEmpty = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPkcs11UriWithObject = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPkcs11UriWithoutObject = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCheckUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFormPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainFormTabControl = new System.Windows.Forms.TabControl();
            this.TabPageBasicInfo = new System.Windows.Forms.TabPage();
            this.ListViewBasicInfo = new Net.Pkcs11Admin.WinForms.Controls.EnhancedListView();
            this.ContextMenuBasicInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CtxMenuItemBasicInfoPkcs11Uri = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemBasicInfoCsvAll = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemBasicInfoCsvSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelBasicInfo = new System.Windows.Forms.Label();
            this.TabPageCertificates = new System.Windows.Forms.TabPage();
            this.ListViewCertificates = new Net.Pkcs11Admin.WinForms.Controls.EnhancedListView();
            this.ContextMenuCertificates = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CtxMenuItemCertificatesView = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemCertificatesEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemCertificatesDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemCertificatesImport = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemCertificatesExport = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemCertificatesPkcs11Uri = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemCertificatesCsvAll = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemCertificatesCsvSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemCertificatesCheckRoca = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelCertificates = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ContextMenuMechanisms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CtxMenuItemMechanismsCsvAll = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemMechanismsCsvSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuHwFeatures = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CtxMenuItemHwFeaturesEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemHwFeaturesCsvAll = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemHwFeaturesCsvSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuDataObjects = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CtxMenuItemDataObjectsView = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemDataObjectsNew = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemDataObjectsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemDataObjectsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemDataObjectsImport = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemDataObjectsExport = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemDataObjectsPkcs11Uri = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemDataObjectsCsvAll = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemDataObjectsCsvSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuKeys = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CtxMenuItemKeysNew = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemKeysEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemKeyDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemKeysImport = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemKeysExport = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemKeysNewCsr = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemKeysNewCert = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemKeysPkcs11Uri = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemKeysCsvAll = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemKeysCsvSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemKeysCheckRoca = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuDomainParams = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CtxMenuItemDomainParamsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemDomainParamsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemDomainParamsCsvAll = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemDomainParamsCsvSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.TabPageDomainParams = new System.Windows.Forms.TabPage();
            this.ListViewDomainParams = new Net.Pkcs11Admin.WinForms.Controls.EnhancedListView();
            this.LabelDomainParams = new System.Windows.Forms.Label();
            this.TabPageKeys = new System.Windows.Forms.TabPage();
            this.ListViewKeys = new Net.Pkcs11Admin.WinForms.Controls.EnhancedListView();
            this.LabelKeys = new System.Windows.Forms.Label();
            this.TabPageDataObjects = new System.Windows.Forms.TabPage();
            this.ListViewDataObjects = new Net.Pkcs11Admin.WinForms.Controls.EnhancedListView();
            this.LabelDataObjects = new System.Windows.Forms.Label();
            this.TabPageHwFeatures = new System.Windows.Forms.TabPage();
            this.ListViewHwFeatures = new Net.Pkcs11Admin.WinForms.Controls.EnhancedListView();
            this.LabelHwFeatures = new System.Windows.Forms.Label();
            this.TabPageMechanisms = new System.Windows.Forms.TabPage();
            this.ListViewMechanisms = new Net.Pkcs11Admin.WinForms.Controls.EnhancedListView();
            this.LabelMechanisms = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.oldPIN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.MainFormStatusStrip.SuspendLayout();
            this.MainFormMenuStrip.SuspendLayout();
            this.MainFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainFormTabControl.SuspendLayout();
            this.TabPageBasicInfo.SuspendLayout();
            this.ContextMenuBasicInfo.SuspendLayout();
            this.TabPageCertificates.SuspendLayout();
            this.ContextMenuCertificates.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ContextMenuMechanisms.SuspendLayout();
            this.ContextMenuHwFeatures.SuspendLayout();
            this.ContextMenuDataObjects.SuspendLayout();
            this.ContextMenuKeys.SuspendLayout();
            this.ContextMenuDomainParams.SuspendLayout();
            this.TabPageDomainParams.SuspendLayout();
            this.TabPageKeys.SuspendLayout();
            this.TabPageDataObjects.SuspendLayout();
            this.TabPageHwFeatures.SuspendLayout();
            this.TabPageMechanisms.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormStatusStrip
            // 
            this.MainFormStatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainFormStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainFormStatusStripLabel});
            this.MainFormStatusStrip.Location = new System.Drawing.Point(0, 545);
            this.MainFormStatusStrip.Name = "MainFormStatusStrip";
            this.MainFormStatusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 19, 0);
            this.MainFormStatusStrip.Size = new System.Drawing.Size(1045, 22);
            this.MainFormStatusStrip.SizingGrip = false;
            this.MainFormStatusStrip.TabIndex = 3;
            // 
            // MainFormStatusStripLabel
            // 
            this.MainFormStatusStripLabel.Name = "MainFormStatusStripLabel";
            this.MainFormStatusStripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemApplication,
            this.MenuItemSlot,
            this.MenuItemToken,
            this.MenuItemObject,
            this.MenuItemTools,
            this.MenuItemHelp});
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MainFormMenuStrip.Size = new System.Drawing.Size(1045, 28);
            this.MainFormMenuStrip.TabIndex = 2;
            this.MainFormMenuStrip.Visible = false;
            // 
            // MenuItemApplication
            // 
            this.MenuItemApplication.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemLoadLibrary,
            this.MenuItemOpenLogFile,
            this.MenuItemApplicationSeparator1,
            this.MenuItemReloadLibrary,
            this.MenuItemRefreshSlot,
            this.MenuItemApplicationSeparator2,
            this.testingToolStripMenuItem,
            this.MenuItemExit});
            this.MenuItemApplication.Name = "MenuItemApplication";
            this.MenuItemApplication.Size = new System.Drawing.Size(58, 24);
            this.MenuItemApplication.Text = "Menu";
            // 
            // MenuItemLoadLibrary
            // 
            this.MenuItemLoadLibrary.Name = "MenuItemLoadLibrary";
            this.MenuItemLoadLibrary.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuItemLoadLibrary.Size = new System.Drawing.Size(351, 26);
            this.MenuItemLoadLibrary.Text = "Chọn thư viện PKCS#11...";
            this.MenuItemLoadLibrary.Click += new System.EventHandler(this.MenuItemLoadLibrary_Click);
            // 
            // MenuItemOpenLogFile
            // 
            this.MenuItemOpenLogFile.Name = "MenuItemOpenLogFile";
            this.MenuItemOpenLogFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.MenuItemOpenLogFile.Size = new System.Drawing.Size(351, 26);
            this.MenuItemOpenLogFile.Text = "Mở File Log...";
            this.MenuItemOpenLogFile.Click += new System.EventHandler(this.MenuItemOpenLogFile_Click);
            // 
            // MenuItemApplicationSeparator1
            // 
            this.MenuItemApplicationSeparator1.Name = "MenuItemApplicationSeparator1";
            this.MenuItemApplicationSeparator1.Size = new System.Drawing.Size(348, 6);
            // 
            // MenuItemReloadLibrary
            // 
            this.MenuItemReloadLibrary.Name = "MenuItemReloadLibrary";
            this.MenuItemReloadLibrary.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.MenuItemReloadLibrary.Size = new System.Drawing.Size(351, 26);
            this.MenuItemReloadLibrary.Text = "Reload";
            this.MenuItemReloadLibrary.Click += new System.EventHandler(this.MenuItemReloadLibrary_Click);
            // 
            // MenuItemRefreshSlot
            // 
            this.MenuItemRefreshSlot.Name = "MenuItemRefreshSlot";
            this.MenuItemRefreshSlot.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.MenuItemRefreshSlot.Size = new System.Drawing.Size(351, 26);
            this.MenuItemRefreshSlot.Text = "Refresh Select SmartCard/USB Token";
            this.MenuItemRefreshSlot.Click += new System.EventHandler(this.MenuItemRefreshSlot_Click);
            // 
            // MenuItemApplicationSeparator2
            // 
            this.MenuItemApplicationSeparator2.Name = "MenuItemApplicationSeparator2";
            this.MenuItemApplicationSeparator2.Size = new System.Drawing.Size(348, 6);
            // 
            // testingToolStripMenuItem
            // 
            this.testingToolStripMenuItem.Name = "testingToolStripMenuItem";
            this.testingToolStripMenuItem.Size = new System.Drawing.Size(351, 26);
            this.testingToolStripMenuItem.Text = "Testing";
            this.testingToolStripMenuItem.Click += new System.EventHandler(this.testingToolStripMenuItem_Click);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MenuItemExit.Size = new System.Drawing.Size(351, 26);
            this.MenuItemExit.Text = "Exit";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // MenuItemSlot
            // 
            this.MenuItemSlot.Name = "MenuItemSlot";
            this.MenuItemSlot.Size = new System.Drawing.Size(132, 24);
            this.MenuItemSlot.Text = "Lựa chọn thiết bị";
            // 
            // MenuItemToken
            // 
            this.MenuItemToken.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemLogin,
            this.MenuItemLogout,
            this.MenuItemChangePin,
            this.MenuItemTokenSeparator1,
            this.MenuItemInitToken,
            this.MenuItemInitPin});
            this.MenuItemToken.Name = "MenuItemToken";
            this.MenuItemToken.Size = new System.Drawing.Size(60, 24);
            this.MenuItemToken.Text = "Token";
            // 
            // MenuItemLogin
            // 
            this.MenuItemLogin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemUserLogin,
            this.MenuItemProtectedUserLogin,
            this.MenuItemSoLogin,
            this.MenuItemProtectedSoLogin});
            this.MenuItemLogin.Name = "MenuItemLogin";
            this.MenuItemLogin.Size = new System.Drawing.Size(225, 26);
            this.MenuItemLogin.Text = "Đăng nhập thiết bị";
            // 
            // MenuItemUserLogin
            // 
            this.MenuItemUserLogin.Name = "MenuItemUserLogin";
            this.MenuItemUserLogin.Size = new System.Drawing.Size(353, 26);
            this.MenuItemUserLogin.Text = "Đăng nhập bằng tài khoản Người dùng...";
            this.MenuItemUserLogin.Click += new System.EventHandler(this.MenuItemUserLogin_Click);
            // 
            // MenuItemProtectedUserLogin
            // 
            this.MenuItemProtectedUserLogin.Name = "MenuItemProtectedUserLogin";
            this.MenuItemProtectedUserLogin.Size = new System.Drawing.Size(353, 26);
            this.MenuItemProtectedUserLogin.Text = "Protected user login...";
            this.MenuItemProtectedUserLogin.Click += new System.EventHandler(this.MenuItemProtectedUserLogin_Click);
            // 
            // MenuItemSoLogin
            // 
            this.MenuItemSoLogin.Name = "MenuItemSoLogin";
            this.MenuItemSoLogin.Size = new System.Drawing.Size(353, 26);
            this.MenuItemSoLogin.Text = "Đăng nhập bằng tài khoản quản trị...";
            this.MenuItemSoLogin.Click += new System.EventHandler(this.MenuItemSoLogin_Click);
            // 
            // MenuItemProtectedSoLogin
            // 
            this.MenuItemProtectedSoLogin.Name = "MenuItemProtectedSoLogin";
            this.MenuItemProtectedSoLogin.Size = new System.Drawing.Size(353, 26);
            this.MenuItemProtectedSoLogin.Text = "Protected SO login...";
            this.MenuItemProtectedSoLogin.Click += new System.EventHandler(this.MenuItemProtectedSoLogin_Click);
            // 
            // MenuItemLogout
            // 
            this.MenuItemLogout.Name = "MenuItemLogout";
            this.MenuItemLogout.Size = new System.Drawing.Size(225, 26);
            this.MenuItemLogout.Text = "Đăng xuất";
            this.MenuItemLogout.Click += new System.EventHandler(this.MenuItemLogout_Click);
            // 
            // MenuItemChangePin
            // 
            this.MenuItemChangePin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemUserChange,
            this.MenuItemProtectedUserChange,
            this.MenuItemSoChange,
            this.MenuItemProtectedSoChange});
            this.MenuItemChangePin.Name = "MenuItemChangePin";
            this.MenuItemChangePin.Size = new System.Drawing.Size(225, 26);
            this.MenuItemChangePin.Text = "Thay đổi mã PIN";
            // 
            // MenuItemUserChange
            // 
            this.MenuItemUserChange.Name = "MenuItemUserChange";
            this.MenuItemUserChange.Size = new System.Drawing.Size(360, 26);
            this.MenuItemUserChange.Text = "Thay đổi mã PIN ...";
            this.MenuItemUserChange.Click += new System.EventHandler(this.MenuItemUserChange_Click);
            // 
            // MenuItemProtectedUserChange
            // 
            this.MenuItemProtectedUserChange.Name = "MenuItemProtectedUserChange";
            this.MenuItemProtectedUserChange.Size = new System.Drawing.Size(360, 26);
            this.MenuItemProtectedUserChange.Text = "Thay đổi mã PIN bằng tài khoản quản trị...";
            this.MenuItemProtectedUserChange.Click += new System.EventHandler(this.MenuItemProtectedUserChange_Click);
            // 
            // MenuItemSoChange
            // 
            this.MenuItemSoChange.Name = "MenuItemSoChange";
            this.MenuItemSoChange.Size = new System.Drawing.Size(360, 26);
            this.MenuItemSoChange.Text = "Thay đổi mã PIN quản trị...";
            this.MenuItemSoChange.Click += new System.EventHandler(this.MenuItemSoChange_Click);
            // 
            // MenuItemProtectedSoChange
            // 
            this.MenuItemProtectedSoChange.Name = "MenuItemProtectedSoChange";
            this.MenuItemProtectedSoChange.Size = new System.Drawing.Size(360, 26);
            this.MenuItemProtectedSoChange.Text = "Protected SO PIN change...";
            this.MenuItemProtectedSoChange.Click += new System.EventHandler(this.MenuItemProtectedSoChange_Click);
            // 
            // MenuItemTokenSeparator1
            // 
            this.MenuItemTokenSeparator1.Name = "MenuItemTokenSeparator1";
            this.MenuItemTokenSeparator1.Size = new System.Drawing.Size(222, 6);
            // 
            // MenuItemInitToken
            // 
            this.MenuItemInitToken.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemTokenInit,
            this.MenuItemProtectedTokenInit});
            this.MenuItemInitToken.Name = "MenuItemInitToken";
            this.MenuItemInitToken.Size = new System.Drawing.Size(225, 26);
            this.MenuItemInitToken.Text = "Initialize token";
            // 
            // MenuItemTokenInit
            // 
            this.MenuItemTokenInit.Name = "MenuItemTokenInit";
            this.MenuItemTokenInit.Size = new System.Drawing.Size(284, 26);
            this.MenuItemTokenInit.Text = "Token initialization...";
            this.MenuItemTokenInit.Click += new System.EventHandler(this.MenuItemTokenInit_Click);
            // 
            // MenuItemProtectedTokenInit
            // 
            this.MenuItemProtectedTokenInit.Name = "MenuItemProtectedTokenInit";
            this.MenuItemProtectedTokenInit.Size = new System.Drawing.Size(284, 26);
            this.MenuItemProtectedTokenInit.Text = "Protected token initialization...";
            this.MenuItemProtectedTokenInit.Click += new System.EventHandler(this.MenuItemProtectedTokenInit_Click);
            // 
            // MenuItemInitPin
            // 
            this.MenuItemInitPin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemUserInit,
            this.MenuItemProtectedUserInit});
            this.MenuItemInitPin.Name = "MenuItemInitPin";
            this.MenuItemInitPin.Size = new System.Drawing.Size(225, 26);
            this.MenuItemInitPin.Text = "Initialize/unblock PIN";
            // 
            // MenuItemUserInit
            // 
            this.MenuItemUserInit.Name = "MenuItemUserInit";
            this.MenuItemUserInit.Size = new System.Drawing.Size(298, 26);
            this.MenuItemUserInit.Text = "User PIN initialization...";
            this.MenuItemUserInit.Click += new System.EventHandler(this.MenuItemUserInit_Click);
            // 
            // MenuItemProtectedUserInit
            // 
            this.MenuItemProtectedUserInit.Name = "MenuItemProtectedUserInit";
            this.MenuItemProtectedUserInit.Size = new System.Drawing.Size(298, 26);
            this.MenuItemProtectedUserInit.Text = "Protected user PIN initialization..";
            this.MenuItemProtectedUserInit.Click += new System.EventHandler(this.MenuItemProtectedUserInit_Click);
            // 
            // MenuItemObject
            // 
            this.MenuItemObject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemObjectNew,
            this.MenuItemObjectEdit,
            this.MenuItemObjectDelete,
            this.MenuItemObjectView,
            this.MenuItemObjectImport,
            this.MenuItemObjectExport});
            this.MenuItemObject.Name = "MenuItemObject";
            this.MenuItemObject.Size = new System.Drawing.Size(145, 24);
            this.MenuItemObject.Text = "Tùy chọn nâng cao";
            // 
            // MenuItemObjectNew
            // 
            this.MenuItemObjectNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemObjectNewData,
            this.MenuItemObjectNewKey,
            this.MenuItemObjectNewCsr,
            this.MenuItemObjectNewCert});
            this.MenuItemObjectNew.Name = "MenuItemObjectNew";
            this.MenuItemObjectNew.Size = new System.Drawing.Size(148, 26);
            this.MenuItemObjectNew.Text = "New";
            // 
            // MenuItemObjectNewData
            // 
            this.MenuItemObjectNewData.Name = "MenuItemObjectNewData";
            this.MenuItemObjectNewData.Size = new System.Drawing.Size(266, 26);
            this.MenuItemObjectNewData.Text = "Data object...";
            this.MenuItemObjectNewData.Click += new System.EventHandler(this.MenuItemObjectNewData_Click);
            // 
            // MenuItemObjectNewKey
            // 
            this.MenuItemObjectNewKey.Name = "MenuItemObjectNewKey";
            this.MenuItemObjectNewKey.Size = new System.Drawing.Size(266, 26);
            this.MenuItemObjectNewKey.Text = "Khóa...";
            this.MenuItemObjectNewKey.Click += new System.EventHandler(this.MenuItemObjectNewKey_Click);
            // 
            // MenuItemObjectNewCsr
            // 
            this.MenuItemObjectNewCsr.Name = "MenuItemObjectNewCsr";
            this.MenuItemObjectNewCsr.Size = new System.Drawing.Size(266, 26);
            this.MenuItemObjectNewCsr.Text = "Certificate signing request...";
            this.MenuItemObjectNewCsr.Click += new System.EventHandler(this.MenuItemObjectNewCsr_Click);
            // 
            // MenuItemObjectNewCert
            // 
            this.MenuItemObjectNewCert.Name = "MenuItemObjectNewCert";
            this.MenuItemObjectNewCert.Size = new System.Drawing.Size(266, 26);
            this.MenuItemObjectNewCert.Text = "Self-signed certificate...";
            this.MenuItemObjectNewCert.Click += new System.EventHandler(this.MenuItemObjectNewCert_Click);
            // 
            // MenuItemObjectEdit
            // 
            this.MenuItemObjectEdit.Name = "MenuItemObjectEdit";
            this.MenuItemObjectEdit.Size = new System.Drawing.Size(148, 26);
            this.MenuItemObjectEdit.Text = "Sửa...";
            this.MenuItemObjectEdit.Click += new System.EventHandler(this.MenuItemObjectEdit_Click);
            // 
            // MenuItemObjectDelete
            // 
            this.MenuItemObjectDelete.Name = "MenuItemObjectDelete";
            this.MenuItemObjectDelete.Size = new System.Drawing.Size(148, 26);
            this.MenuItemObjectDelete.Text = "Xóa";
            this.MenuItemObjectDelete.Click += new System.EventHandler(this.MenuItemObjectDelete_Click);
            // 
            // MenuItemObjectView
            // 
            this.MenuItemObjectView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemObjectViewData,
            this.MenuItemObjectViewCert});
            this.MenuItemObjectView.Name = "MenuItemObjectView";
            this.MenuItemObjectView.Size = new System.Drawing.Size(148, 26);
            this.MenuItemObjectView.Text = "Hiển thị";
            // 
            // MenuItemObjectViewData
            // 
            this.MenuItemObjectViewData.Name = "MenuItemObjectViewData";
            this.MenuItemObjectViewData.Size = new System.Drawing.Size(171, 26);
            this.MenuItemObjectViewData.Text = "Data object...";
            this.MenuItemObjectViewData.Click += new System.EventHandler(this.MenuItemObjectViewData_Click);
            // 
            // MenuItemObjectViewCert
            // 
            this.MenuItemObjectViewCert.Name = "MenuItemObjectViewCert";
            this.MenuItemObjectViewCert.Size = new System.Drawing.Size(171, 26);
            this.MenuItemObjectViewCert.Text = "Chứng thư ...";
            this.MenuItemObjectViewCert.Click += new System.EventHandler(this.MenuItemObjectViewCert_Click);
            // 
            // MenuItemObjectImport
            // 
            this.MenuItemObjectImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemObjectImportData,
            this.MenuItemObjectImportCert,
            this.MenuItemObjectImportKey});
            this.MenuItemObjectImport.Name = "MenuItemObjectImport";
            this.MenuItemObjectImport.Size = new System.Drawing.Size(148, 26);
            this.MenuItemObjectImport.Text = "Nhập vào";
            // 
            // MenuItemObjectImportData
            // 
            this.MenuItemObjectImportData.Name = "MenuItemObjectImportData";
            this.MenuItemObjectImportData.Size = new System.Drawing.Size(171, 26);
            this.MenuItemObjectImportData.Text = "Data object...";
            this.MenuItemObjectImportData.Click += new System.EventHandler(this.MenuItemObjectImportData_Click);
            // 
            // MenuItemObjectImportCert
            // 
            this.MenuItemObjectImportCert.Name = "MenuItemObjectImportCert";
            this.MenuItemObjectImportCert.Size = new System.Drawing.Size(171, 26);
            this.MenuItemObjectImportCert.Text = "Chưng thư...";
            this.MenuItemObjectImportCert.Click += new System.EventHandler(this.MenuItemObjectImportCert_Click);
            // 
            // MenuItemObjectImportKey
            // 
            this.MenuItemObjectImportKey.Name = "MenuItemObjectImportKey";
            this.MenuItemObjectImportKey.Size = new System.Drawing.Size(171, 26);
            this.MenuItemObjectImportKey.Text = "Khóa...";
            this.MenuItemObjectImportKey.Click += new System.EventHandler(this.MenuItemObjectImportKey_Click);
            // 
            // MenuItemObjectExport
            // 
            this.MenuItemObjectExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemObjectExportData,
            this.MenuItemObjectExportCert,
            this.MenuItemObjectExportKey});
            this.MenuItemObjectExport.Name = "MenuItemObjectExport";
            this.MenuItemObjectExport.Size = new System.Drawing.Size(148, 26);
            this.MenuItemObjectExport.Text = "Xuất ra";
            // 
            // MenuItemObjectExportData
            // 
            this.MenuItemObjectExportData.Name = "MenuItemObjectExportData";
            this.MenuItemObjectExportData.Size = new System.Drawing.Size(171, 26);
            this.MenuItemObjectExportData.Text = "Data object...";
            this.MenuItemObjectExportData.Click += new System.EventHandler(this.MenuItemObjectExportData_Click);
            // 
            // MenuItemObjectExportCert
            // 
            this.MenuItemObjectExportCert.Name = "MenuItemObjectExportCert";
            this.MenuItemObjectExportCert.Size = new System.Drawing.Size(171, 26);
            this.MenuItemObjectExportCert.Text = "Chứng thư...";
            this.MenuItemObjectExportCert.Click += new System.EventHandler(this.MenuItemObjectExportCert_Click);
            // 
            // MenuItemObjectExportKey
            // 
            this.MenuItemObjectExportKey.Name = "MenuItemObjectExportKey";
            this.MenuItemObjectExportKey.Size = new System.Drawing.Size(171, 26);
            this.MenuItemObjectExportKey.Text = "Khóa...";
            this.MenuItemObjectExportKey.Click += new System.EventHandler(this.MenuItemObjectExportKey_Click);
            // 
            // MenuItemTools
            // 
            this.MenuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCsvExport,
            this.MenuItemPkcs11Uri});
            this.MenuItemTools.Name = "MenuItemTools";
            this.MenuItemTools.Size = new System.Drawing.Size(75, 24);
            this.MenuItemTools.Text = "Công cụ";
            // 
            // MenuItemCsvExport
            // 
            this.MenuItemCsvExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCsvExportAll,
            this.MenuItemCsvExportSelected});
            this.MenuItemCsvExport.Name = "MenuItemCsvExport";
            this.MenuItemCsvExport.Size = new System.Drawing.Size(207, 26);
            this.MenuItemCsvExport.Text = "Xuất ra File CSV";
            // 
            // MenuItemCsvExportAll
            // 
            this.MenuItemCsvExportAll.Name = "MenuItemCsvExportAll";
            this.MenuItemCsvExportAll.Size = new System.Drawing.Size(194, 26);
            this.MenuItemCsvExportAll.Text = "All items...";
            this.MenuItemCsvExportAll.Click += new System.EventHandler(this.MenuItemCsvExportAll_Click);
            // 
            // MenuItemCsvExportSelected
            // 
            this.MenuItemCsvExportSelected.Name = "MenuItemCsvExportSelected";
            this.MenuItemCsvExportSelected.Size = new System.Drawing.Size(194, 26);
            this.MenuItemCsvExportSelected.Text = "Lựa chọn tất cả...";
            this.MenuItemCsvExportSelected.Click += new System.EventHandler(this.MenuItemCsvExportSelected_Click);
            // 
            // MenuItemPkcs11Uri
            // 
            this.MenuItemPkcs11Uri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemPkcs11UriEmpty,
            this.MenuItemPkcs11UriWithObject,
            this.MenuItemPkcs11UriWithoutObject});
            this.MenuItemPkcs11Uri.Name = "MenuItemPkcs11Uri";
            this.MenuItemPkcs11Uri.Size = new System.Drawing.Size(207, 26);
            this.MenuItemPkcs11Uri.Text = "Build PKCS#11 URI";
            // 
            // MenuItemPkcs11UriEmpty
            // 
            this.MenuItemPkcs11UriEmpty.Name = "MenuItemPkcs11UriEmpty";
            this.MenuItemPkcs11UriEmpty.Size = new System.Drawing.Size(251, 26);
            this.MenuItemPkcs11UriEmpty.Text = "Empty...";
            this.MenuItemPkcs11UriEmpty.Click += new System.EventHandler(this.MenuItemPkcs11UriEmpty_Click);
            // 
            // MenuItemPkcs11UriWithObject
            // 
            this.MenuItemPkcs11UriWithObject.Name = "MenuItemPkcs11UriWithObject";
            this.MenuItemPkcs11UriWithObject.Size = new System.Drawing.Size(251, 26);
            this.MenuItemPkcs11UriWithObject.Text = "With selected object...";
            this.MenuItemPkcs11UriWithObject.Click += new System.EventHandler(this.MenuItemPkcs11UriWithObject_Click);
            // 
            // MenuItemPkcs11UriWithoutObject
            // 
            this.MenuItemPkcs11UriWithoutObject.Name = "MenuItemPkcs11UriWithoutObject";
            this.MenuItemPkcs11UriWithoutObject.Size = new System.Drawing.Size(251, 26);
            this.MenuItemPkcs11UriWithoutObject.Text = "Without selected object...";
            this.MenuItemPkcs11UriWithoutObject.Click += new System.EventHandler(this.MenuItemPkcs11UriWithoutObject_Click);
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCheckUpdates,
            this.MenuItemAbout});
            this.MenuItemHelp.Name = "MenuItemHelp";
            this.MenuItemHelp.Size = new System.Drawing.Size(74, 24);
            this.MenuItemHelp.Text = "Giúp đỡ";
            // 
            // MenuItemCheckUpdates
            // 
            this.MenuItemCheckUpdates.Name = "MenuItemCheckUpdates";
            this.MenuItemCheckUpdates.Size = new System.Drawing.Size(243, 26);
            this.MenuItemCheckUpdates.Text = "Cập nhật phiên bản mới";
            this.MenuItemCheckUpdates.Click += new System.EventHandler(this.MenuItemCheckUpdates_Click);
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.Size = new System.Drawing.Size(243, 26);
            this.MenuItemAbout.Text = "About...";
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // MainFormPanel
            // 
            this.MainFormPanel.Controls.Add(this.pictureBox1);
            this.MainFormPanel.Controls.Add(this.MainFormTabControl);
            this.MainFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFormPanel.Location = new System.Drawing.Point(0, 0);
            this.MainFormPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainFormPanel.Name = "MainFormPanel";
            this.MainFormPanel.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.MainFormPanel.Size = new System.Drawing.Size(1045, 545);
            this.MainFormPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "https://egt.vn:8998/uploads/i_Green_Logo_2818ef9c70.png";
            this.pictureBox1.Location = new System.Drawing.Point(16, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1011, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainFormTabControl
            // 
            this.MainFormTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainFormTabControl.Controls.Add(this.TabPageBasicInfo);
            this.MainFormTabControl.Controls.Add(this.TabPageCertificates);
            this.MainFormTabControl.Controls.Add(this.tabPage1);
            this.MainFormTabControl.Controls.Add(this.tabPage2);
            this.MainFormTabControl.Location = new System.Drawing.Point(16, 159);
            this.MainFormTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.MainFormTabControl.Name = "MainFormTabControl";
            this.MainFormTabControl.SelectedIndex = 0;
            this.MainFormTabControl.Size = new System.Drawing.Size(1011, 366);
            this.MainFormTabControl.TabIndex = 1;
            this.MainFormTabControl.SelectedIndexChanged += new System.EventHandler(this.MainFormTabControl_SelectedIndexChanged);
            // 
            // TabPageBasicInfo
            // 
            this.TabPageBasicInfo.Controls.Add(this.ListViewBasicInfo);
            this.TabPageBasicInfo.Controls.Add(this.LabelBasicInfo);
            this.TabPageBasicInfo.Location = new System.Drawing.Point(4, 25);
            this.TabPageBasicInfo.Margin = new System.Windows.Forms.Padding(4);
            this.TabPageBasicInfo.Name = "TabPageBasicInfo";
            this.TabPageBasicInfo.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TabPageBasicInfo.Size = new System.Drawing.Size(1003, 337);
            this.TabPageBasicInfo.TabIndex = 7;
            this.TabPageBasicInfo.Text = "Thông tin chung";
            this.TabPageBasicInfo.UseVisualStyleBackColor = true;
            // 
            // ListViewBasicInfo
            // 
            this.ListViewBasicInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewBasicInfo.ContextMenuStrip = this.ContextMenuBasicInfo;
            this.ListViewBasicInfo.FullRowSelect = true;
            this.ListViewBasicInfo.HideSelection = false;
            this.ListViewBasicInfo.Location = new System.Drawing.Point(18, 32);
            this.ListViewBasicInfo.Margin = new System.Windows.Forms.Padding(4);
            this.ListViewBasicInfo.Name = "ListViewBasicInfo";
            this.ListViewBasicInfo.Size = new System.Drawing.Size(964, 281);
            this.ListViewBasicInfo.Sortable = true;
            this.ListViewBasicInfo.TabIndex = 1;
            this.ListViewBasicInfo.UseCompatibleStateImageBehavior = false;
            this.ListViewBasicInfo.View = System.Windows.Forms.View.Details;
            // 
            // ContextMenuBasicInfo
            // 
            this.ContextMenuBasicInfo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuBasicInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtxMenuItemBasicInfoPkcs11Uri,
            this.CtxMenuItemBasicInfoCsvAll,
            this.CtxMenuItemBasicInfoCsvSelected});
            this.ContextMenuBasicInfo.Name = "ContextMenuBasicInfo";
            this.ContextMenuBasicInfo.ShowImageMargin = false;
            this.ContextMenuBasicInfo.ShowItemToolTips = false;
            this.ContextMenuBasicInfo.Size = new System.Drawing.Size(253, 76);
            // 
            // CtxMenuItemBasicInfoPkcs11Uri
            // 
            this.CtxMenuItemBasicInfoPkcs11Uri.Name = "CtxMenuItemBasicInfoPkcs11Uri";
            this.CtxMenuItemBasicInfoPkcs11Uri.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemBasicInfoPkcs11Uri.Text = "Build PKCS#11 URI...";
            this.CtxMenuItemBasicInfoPkcs11Uri.Click += new System.EventHandler(this.CtxMenuItemBasicInfoPkcs11Uri_Click);
            // 
            // CtxMenuItemBasicInfoCsvAll
            // 
            this.CtxMenuItemBasicInfoCsvAll.Name = "CtxMenuItemBasicInfoCsvAll";
            this.CtxMenuItemBasicInfoCsvAll.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemBasicInfoCsvAll.Text = "Export all items to CSV...";
            this.CtxMenuItemBasicInfoCsvAll.Click += new System.EventHandler(this.CtxMenuItemBasicInfoCsvAll_Click);
            // 
            // CtxMenuItemBasicInfoCsvSelected
            // 
            this.CtxMenuItemBasicInfoCsvSelected.Name = "CtxMenuItemBasicInfoCsvSelected";
            this.CtxMenuItemBasicInfoCsvSelected.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemBasicInfoCsvSelected.Text = "Export selected items to CSV...";
            this.CtxMenuItemBasicInfoCsvSelected.Click += new System.EventHandler(this.CtxMenuItemBasicInfoCsvSelected_Click);
            // 
            // LabelBasicInfo
            // 
            this.LabelBasicInfo.AutoSize = true;
            this.LabelBasicInfo.Location = new System.Drawing.Point(13, 12);
            this.LabelBasicInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelBasicInfo.Name = "LabelBasicInfo";
            this.LabelBasicInfo.Size = new System.Drawing.Size(364, 17);
            this.LabelBasicInfo.TabIndex = 0;
            this.LabelBasicInfo.Text = "Basic information about PKCS#11 library, slot and token:";
            this.LabelBasicInfo.Click += new System.EventHandler(this.LabelBasicInfo_Click);
            // 
            // TabPageCertificates
            // 
            this.TabPageCertificates.Controls.Add(this.ListViewCertificates);
            this.TabPageCertificates.Controls.Add(this.LabelCertificates);
            this.TabPageCertificates.Location = new System.Drawing.Point(4, 25);
            this.TabPageCertificates.Margin = new System.Windows.Forms.Padding(4);
            this.TabPageCertificates.Name = "TabPageCertificates";
            this.TabPageCertificates.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TabPageCertificates.Size = new System.Drawing.Size(1003, 337);
            this.TabPageCertificates.TabIndex = 5;
            this.TabPageCertificates.Text = "Certificates";
            this.TabPageCertificates.UseVisualStyleBackColor = true;
            // 
            // ListViewCertificates
            // 
            this.ListViewCertificates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewCertificates.ContextMenuStrip = this.ContextMenuCertificates;
            this.ListViewCertificates.FullRowSelect = true;
            this.ListViewCertificates.HideSelection = false;
            this.ListViewCertificates.Location = new System.Drawing.Point(18, 32);
            this.ListViewCertificates.Margin = new System.Windows.Forms.Padding(4);
            this.ListViewCertificates.Name = "ListViewCertificates";
            this.ListViewCertificates.Size = new System.Drawing.Size(964, 294);
            this.ListViewCertificates.Sortable = true;
            this.ListViewCertificates.TabIndex = 1;
            this.ListViewCertificates.UseCompatibleStateImageBehavior = false;
            this.ListViewCertificates.View = System.Windows.Forms.View.Details;
            // 
            // ContextMenuCertificates
            // 
            this.ContextMenuCertificates.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuCertificates.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtxMenuItemCertificatesView,
            this.CtxMenuItemCertificatesEdit,
            this.CtxMenuItemCertificatesDelete,
            this.CtxMenuItemCertificatesImport,
            this.CtxMenuItemCertificatesExport,
            this.CtxMenuItemCertificatesPkcs11Uri,
            this.CtxMenuItemCertificatesCsvAll,
            this.CtxMenuItemCertificatesCsvSelected,
            this.CtxMenuItemCertificatesCheckRoca});
            this.ContextMenuCertificates.Name = "ContextMenuCertificates";
            this.ContextMenuCertificates.ShowImageMargin = false;
            this.ContextMenuCertificates.ShowItemToolTips = false;
            this.ContextMenuCertificates.Size = new System.Drawing.Size(253, 220);
            // 
            // CtxMenuItemCertificatesView
            // 
            this.CtxMenuItemCertificatesView.Name = "CtxMenuItemCertificatesView";
            this.CtxMenuItemCertificatesView.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemCertificatesView.Text = "View...";
            this.CtxMenuItemCertificatesView.Click += new System.EventHandler(this.CtxMenuItemCertificatesView_Click);
            // 
            // CtxMenuItemCertificatesEdit
            // 
            this.CtxMenuItemCertificatesEdit.Name = "CtxMenuItemCertificatesEdit";
            this.CtxMenuItemCertificatesEdit.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemCertificatesEdit.Text = "Edit attributes...";
            this.CtxMenuItemCertificatesEdit.Click += new System.EventHandler(this.CtxMenuItemCertificatesEdit_Click);
            // 
            // CtxMenuItemCertificatesDelete
            // 
            this.CtxMenuItemCertificatesDelete.Name = "CtxMenuItemCertificatesDelete";
            this.CtxMenuItemCertificatesDelete.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemCertificatesDelete.Text = "Delete...";
            this.CtxMenuItemCertificatesDelete.Click += new System.EventHandler(this.CtxMenuItemCertificatesDelete_Click);
            // 
            // CtxMenuItemCertificatesImport
            // 
            this.CtxMenuItemCertificatesImport.Name = "CtxMenuItemCertificatesImport";
            this.CtxMenuItemCertificatesImport.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemCertificatesImport.Text = "Import from file...";
            this.CtxMenuItemCertificatesImport.Click += new System.EventHandler(this.CtxMenuItemCertificatesImport_Click);
            // 
            // CtxMenuItemCertificatesExport
            // 
            this.CtxMenuItemCertificatesExport.Name = "CtxMenuItemCertificatesExport";
            this.CtxMenuItemCertificatesExport.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemCertificatesExport.Text = "Export to file...";
            this.CtxMenuItemCertificatesExport.Click += new System.EventHandler(this.CtxMenuItemCertificatesExport_Click);
            // 
            // CtxMenuItemCertificatesPkcs11Uri
            // 
            this.CtxMenuItemCertificatesPkcs11Uri.Name = "CtxMenuItemCertificatesPkcs11Uri";
            this.CtxMenuItemCertificatesPkcs11Uri.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemCertificatesPkcs11Uri.Text = "Build PKCS#11 URI...";
            this.CtxMenuItemCertificatesPkcs11Uri.Click += new System.EventHandler(this.CtxMenuItemCertificatesPkcs11Uri_Click);
            // 
            // CtxMenuItemCertificatesCsvAll
            // 
            this.CtxMenuItemCertificatesCsvAll.Name = "CtxMenuItemCertificatesCsvAll";
            this.CtxMenuItemCertificatesCsvAll.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemCertificatesCsvAll.Text = "Export all items to CSV...";
            this.CtxMenuItemCertificatesCsvAll.Click += new System.EventHandler(this.CtxMenuItemCertificatesCsvAll_Click);
            // 
            // CtxMenuItemCertificatesCsvSelected
            // 
            this.CtxMenuItemCertificatesCsvSelected.Name = "CtxMenuItemCertificatesCsvSelected";
            this.CtxMenuItemCertificatesCsvSelected.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemCertificatesCsvSelected.Text = "Export selected items to CSV...";
            this.CtxMenuItemCertificatesCsvSelected.Click += new System.EventHandler(this.CtxMenuItemCertificatesCsvSelected_Click);
            // 
            // CtxMenuItemCertificatesCheckRoca
            // 
            this.CtxMenuItemCertificatesCheckRoca.Name = "CtxMenuItemCertificatesCheckRoca";
            this.CtxMenuItemCertificatesCheckRoca.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemCertificatesCheckRoca.Text = "Check for ROCA vulnerability...";
            this.CtxMenuItemCertificatesCheckRoca.Click += new System.EventHandler(this.CtxMenuItemCertificatesCheckRoca_Click);
            // 
            // LabelCertificates
            // 
            this.LabelCertificates.AutoSize = true;
            this.LabelCertificates.Location = new System.Drawing.Point(13, 12);
            this.LabelCertificates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCertificates.Name = "LabelCertificates";
            this.LabelCertificates.Size = new System.Drawing.Size(240, 17);
            this.LabelCertificates.TabIndex = 0;
            this.LabelCertificates.Text = "These certificate objects were found:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.oldPIN);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1003, 337);
            this.tabPage1.TabIndex = 8;
            this.tabPage1.Text = "Đổi PIN";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1003, 337);
            this.tabPage2.TabIndex = 9;
            this.tabPage2.Text = "About";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ContextMenuMechanisms
            // 
            this.ContextMenuMechanisms.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuMechanisms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtxMenuItemMechanismsCsvAll,
            this.CtxMenuItemMechanismsCsvSelected});
            this.ContextMenuMechanisms.Name = "ContextMenuMechanisms";
            this.ContextMenuMechanisms.ShowImageMargin = false;
            this.ContextMenuMechanisms.ShowItemToolTips = false;
            this.ContextMenuMechanisms.Size = new System.Drawing.Size(253, 52);
            // 
            // CtxMenuItemMechanismsCsvAll
            // 
            this.CtxMenuItemMechanismsCsvAll.Name = "CtxMenuItemMechanismsCsvAll";
            this.CtxMenuItemMechanismsCsvAll.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemMechanismsCsvAll.Text = "Export all items to CSV...";
            this.CtxMenuItemMechanismsCsvAll.Click += new System.EventHandler(this.CtxMenuItemMechanismsCsvAll_Click);
            // 
            // CtxMenuItemMechanismsCsvSelected
            // 
            this.CtxMenuItemMechanismsCsvSelected.Name = "CtxMenuItemMechanismsCsvSelected";
            this.CtxMenuItemMechanismsCsvSelected.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemMechanismsCsvSelected.Text = "Export selected items to CSV...";
            this.CtxMenuItemMechanismsCsvSelected.Click += new System.EventHandler(this.CtxMenuItemMechanismsCsvSelected_Click);
            // 
            // ContextMenuHwFeatures
            // 
            this.ContextMenuHwFeatures.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuHwFeatures.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtxMenuItemHwFeaturesEdit,
            this.CtxMenuItemHwFeaturesCsvAll,
            this.CtxMenuItemHwFeaturesCsvSelected});
            this.ContextMenuHwFeatures.Name = "ContextMenuHwFeatures";
            this.ContextMenuHwFeatures.ShowImageMargin = false;
            this.ContextMenuHwFeatures.ShowItemToolTips = false;
            this.ContextMenuHwFeatures.Size = new System.Drawing.Size(253, 76);
            // 
            // CtxMenuItemHwFeaturesEdit
            // 
            this.CtxMenuItemHwFeaturesEdit.Name = "CtxMenuItemHwFeaturesEdit";
            this.CtxMenuItemHwFeaturesEdit.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemHwFeaturesEdit.Text = "Edit attributes...";
            this.CtxMenuItemHwFeaturesEdit.Click += new System.EventHandler(this.CtxMenuItemHwFeaturesEdit_Click);
            // 
            // CtxMenuItemHwFeaturesCsvAll
            // 
            this.CtxMenuItemHwFeaturesCsvAll.Name = "CtxMenuItemHwFeaturesCsvAll";
            this.CtxMenuItemHwFeaturesCsvAll.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemHwFeaturesCsvAll.Text = "Export all items to CSV...";
            this.CtxMenuItemHwFeaturesCsvAll.Click += new System.EventHandler(this.CtxMenuItemHwFeaturesCsvAll_Click);
            // 
            // CtxMenuItemHwFeaturesCsvSelected
            // 
            this.CtxMenuItemHwFeaturesCsvSelected.Name = "CtxMenuItemHwFeaturesCsvSelected";
            this.CtxMenuItemHwFeaturesCsvSelected.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemHwFeaturesCsvSelected.Text = "Export selected items to CSV...";
            this.CtxMenuItemHwFeaturesCsvSelected.Click += new System.EventHandler(this.CtxMenuItemHwFeaturesCsvSelected_Click);
            // 
            // ContextMenuDataObjects
            // 
            this.ContextMenuDataObjects.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuDataObjects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtxMenuItemDataObjectsView,
            this.CtxMenuItemDataObjectsNew,
            this.CtxMenuItemDataObjectsEdit,
            this.CtxMenuItemDataObjectsDelete,
            this.CtxMenuItemDataObjectsImport,
            this.CtxMenuItemDataObjectsExport,
            this.CtxMenuItemDataObjectsPkcs11Uri,
            this.CtxMenuItemDataObjectsCsvAll,
            this.CtxMenuItemDataObjectsCsvSelected});
            this.ContextMenuDataObjects.Name = "ContextMenuDataObjects";
            this.ContextMenuDataObjects.ShowImageMargin = false;
            this.ContextMenuDataObjects.ShowItemToolTips = false;
            this.ContextMenuDataObjects.Size = new System.Drawing.Size(253, 220);
            // 
            // CtxMenuItemDataObjectsView
            // 
            this.CtxMenuItemDataObjectsView.Name = "CtxMenuItemDataObjectsView";
            this.CtxMenuItemDataObjectsView.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemDataObjectsView.Text = "View...";
            this.CtxMenuItemDataObjectsView.Click += new System.EventHandler(this.CtxMenuItemDataObjectsView_Click);
            // 
            // CtxMenuItemDataObjectsNew
            // 
            this.CtxMenuItemDataObjectsNew.Name = "CtxMenuItemDataObjectsNew";
            this.CtxMenuItemDataObjectsNew.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemDataObjectsNew.Text = "Create new...";
            this.CtxMenuItemDataObjectsNew.Click += new System.EventHandler(this.CtxMenuItemDataObjectsNew_Click);
            // 
            // CtxMenuItemDataObjectsEdit
            // 
            this.CtxMenuItemDataObjectsEdit.Name = "CtxMenuItemDataObjectsEdit";
            this.CtxMenuItemDataObjectsEdit.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemDataObjectsEdit.Text = "Edit attributes...";
            this.CtxMenuItemDataObjectsEdit.Click += new System.EventHandler(this.CtxMenuItemDataObjectsEdit_Click);
            // 
            // CtxMenuItemDataObjectsDelete
            // 
            this.CtxMenuItemDataObjectsDelete.Name = "CtxMenuItemDataObjectsDelete";
            this.CtxMenuItemDataObjectsDelete.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemDataObjectsDelete.Text = "Delete...";
            this.CtxMenuItemDataObjectsDelete.Click += new System.EventHandler(this.CtxMenuItemDataObjectsDelete_Click);
            // 
            // CtxMenuItemDataObjectsImport
            // 
            this.CtxMenuItemDataObjectsImport.Name = "CtxMenuItemDataObjectsImport";
            this.CtxMenuItemDataObjectsImport.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemDataObjectsImport.Text = "Import file...";
            this.CtxMenuItemDataObjectsImport.Click += new System.EventHandler(this.CtxMenuItemDataObjectsImport_Click);
            // 
            // CtxMenuItemDataObjectsExport
            // 
            this.CtxMenuItemDataObjectsExport.Name = "CtxMenuItemDataObjectsExport";
            this.CtxMenuItemDataObjectsExport.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemDataObjectsExport.Text = "Export to file...";
            this.CtxMenuItemDataObjectsExport.Click += new System.EventHandler(this.CtxMenuItemDataObjectsExport_Click);
            // 
            // CtxMenuItemDataObjectsPkcs11Uri
            // 
            this.CtxMenuItemDataObjectsPkcs11Uri.Name = "CtxMenuItemDataObjectsPkcs11Uri";
            this.CtxMenuItemDataObjectsPkcs11Uri.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemDataObjectsPkcs11Uri.Text = "Build PKCS#11 URI...";
            this.CtxMenuItemDataObjectsPkcs11Uri.Click += new System.EventHandler(this.CtxMenuItemDataObjectsPkcs11Uri_Click);
            // 
            // CtxMenuItemDataObjectsCsvAll
            // 
            this.CtxMenuItemDataObjectsCsvAll.Name = "CtxMenuItemDataObjectsCsvAll";
            this.CtxMenuItemDataObjectsCsvAll.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemDataObjectsCsvAll.Text = "Export all items to CSV...";
            this.CtxMenuItemDataObjectsCsvAll.Click += new System.EventHandler(this.CtxMenuItemDataObjectsCsvAll_Click);
            // 
            // CtxMenuItemDataObjectsCsvSelected
            // 
            this.CtxMenuItemDataObjectsCsvSelected.Name = "CtxMenuItemDataObjectsCsvSelected";
            this.CtxMenuItemDataObjectsCsvSelected.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemDataObjectsCsvSelected.Text = "Export selected items to CSV...";
            this.CtxMenuItemDataObjectsCsvSelected.Click += new System.EventHandler(this.CtxMenuItemDataObjectsCsvSelected_Click);
            // 
            // ContextMenuKeys
            // 
            this.ContextMenuKeys.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuKeys.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtxMenuItemKeysNew,
            this.CtxMenuItemKeysEdit,
            this.CtxMenuItemKeyDelete,
            this.CtxMenuItemKeysImport,
            this.CtxMenuItemKeysExport,
            this.CtxMenuItemKeysNewCsr,
            this.CtxMenuItemKeysNewCert,
            this.CtxMenuItemKeysPkcs11Uri,
            this.CtxMenuItemKeysCsvAll,
            this.CtxMenuItemKeysCsvSelected,
            this.CtxMenuItemKeysCheckRoca});
            this.ContextMenuKeys.Name = "ContextMenuKeys";
            this.ContextMenuKeys.ShowImageMargin = false;
            this.ContextMenuKeys.ShowItemToolTips = false;
            this.ContextMenuKeys.Size = new System.Drawing.Size(298, 268);
            // 
            // CtxMenuItemKeysNew
            // 
            this.CtxMenuItemKeysNew.Name = "CtxMenuItemKeysNew";
            this.CtxMenuItemKeysNew.Size = new System.Drawing.Size(297, 24);
            this.CtxMenuItemKeysNew.Text = "Generate new...";
            this.CtxMenuItemKeysNew.Click += new System.EventHandler(this.CtxMenuItemKeysNew_Click);
            // 
            // CtxMenuItemKeysEdit
            // 
            this.CtxMenuItemKeysEdit.Name = "CtxMenuItemKeysEdit";
            this.CtxMenuItemKeysEdit.Size = new System.Drawing.Size(297, 24);
            this.CtxMenuItemKeysEdit.Text = "Edit attributes...";
            this.CtxMenuItemKeysEdit.Click += new System.EventHandler(this.CtxMenuItemKeysEdit_Click);
            // 
            // CtxMenuItemKeyDelete
            // 
            this.CtxMenuItemKeyDelete.Name = "CtxMenuItemKeyDelete";
            this.CtxMenuItemKeyDelete.Size = new System.Drawing.Size(297, 24);
            this.CtxMenuItemKeyDelete.Text = "Delete...";
            this.CtxMenuItemKeyDelete.Click += new System.EventHandler(this.CtxMenuItemKeyDelete_Click);
            // 
            // CtxMenuItemKeysImport
            // 
            this.CtxMenuItemKeysImport.Name = "CtxMenuItemKeysImport";
            this.CtxMenuItemKeysImport.Size = new System.Drawing.Size(297, 24);
            this.CtxMenuItemKeysImport.Text = "Import from file...";
            this.CtxMenuItemKeysImport.Click += new System.EventHandler(this.CtxMenuItemKeysImport_Click);
            // 
            // CtxMenuItemKeysExport
            // 
            this.CtxMenuItemKeysExport.Name = "CtxMenuItemKeysExport";
            this.CtxMenuItemKeysExport.Size = new System.Drawing.Size(297, 24);
            this.CtxMenuItemKeysExport.Text = "Export to file...";
            this.CtxMenuItemKeysExport.Click += new System.EventHandler(this.CtxMenuItemKeysExport_Click);
            // 
            // CtxMenuItemKeysNewCsr
            // 
            this.CtxMenuItemKeysNewCsr.Name = "CtxMenuItemKeysNewCsr";
            this.CtxMenuItemKeysNewCsr.Size = new System.Drawing.Size(297, 24);
            this.CtxMenuItemKeysNewCsr.Text = "Generate certificate signing request...";
            this.CtxMenuItemKeysNewCsr.Click += new System.EventHandler(this.CtxMenuItemKeysNewCsr_Click);
            // 
            // CtxMenuItemKeysNewCert
            // 
            this.CtxMenuItemKeysNewCert.Name = "CtxMenuItemKeysNewCert";
            this.CtxMenuItemKeysNewCert.Size = new System.Drawing.Size(297, 24);
            this.CtxMenuItemKeysNewCert.Text = "Generate self-signed certificate...";
            this.CtxMenuItemKeysNewCert.Click += new System.EventHandler(this.CtxMenuItemKeysNewCert_Click);
            // 
            // CtxMenuItemKeysPkcs11Uri
            // 
            this.CtxMenuItemKeysPkcs11Uri.Name = "CtxMenuItemKeysPkcs11Uri";
            this.CtxMenuItemKeysPkcs11Uri.Size = new System.Drawing.Size(297, 24);
            this.CtxMenuItemKeysPkcs11Uri.Text = "Build PKCS#11 URI...";
            this.CtxMenuItemKeysPkcs11Uri.Click += new System.EventHandler(this.CtxMenuItemKeysPkcs11Uri_Click);
            // 
            // CtxMenuItemKeysCsvAll
            // 
            this.CtxMenuItemKeysCsvAll.Name = "CtxMenuItemKeysCsvAll";
            this.CtxMenuItemKeysCsvAll.Size = new System.Drawing.Size(297, 24);
            this.CtxMenuItemKeysCsvAll.Text = "Export all items to CSV...";
            this.CtxMenuItemKeysCsvAll.Click += new System.EventHandler(this.CtxMenuItemKeysCsvAll_Click);
            // 
            // CtxMenuItemKeysCsvSelected
            // 
            this.CtxMenuItemKeysCsvSelected.Name = "CtxMenuItemKeysCsvSelected";
            this.CtxMenuItemKeysCsvSelected.Size = new System.Drawing.Size(297, 24);
            this.CtxMenuItemKeysCsvSelected.Text = "Export selected items to CSV...";
            this.CtxMenuItemKeysCsvSelected.Click += new System.EventHandler(this.CtxMenuItemKeysCsvSelected_Click);
            // 
            // CtxMenuItemKeysCheckRoca
            // 
            this.CtxMenuItemKeysCheckRoca.Name = "CtxMenuItemKeysCheckRoca";
            this.CtxMenuItemKeysCheckRoca.Size = new System.Drawing.Size(297, 24);
            this.CtxMenuItemKeysCheckRoca.Text = "Check for ROCA vulnerability...";
            this.CtxMenuItemKeysCheckRoca.Click += new System.EventHandler(this.CtxMenuItemKeysCheckRoca_Click);
            // 
            // ContextMenuDomainParams
            // 
            this.ContextMenuDomainParams.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuDomainParams.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtxMenuItemDomainParamsEdit,
            this.CtxMenuItemDomainParamsDelete,
            this.CtxMenuItemDomainParamsCsvAll,
            this.CtxMenuItemDomainParamsCsvSelected});
            this.ContextMenuDomainParams.Name = "ContextMenuDomainParams";
            this.ContextMenuDomainParams.ShowImageMargin = false;
            this.ContextMenuDomainParams.ShowItemToolTips = false;
            this.ContextMenuDomainParams.Size = new System.Drawing.Size(253, 100);
            // 
            // CtxMenuItemDomainParamsEdit
            // 
            this.CtxMenuItemDomainParamsEdit.Name = "CtxMenuItemDomainParamsEdit";
            this.CtxMenuItemDomainParamsEdit.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemDomainParamsEdit.Text = "Edit attributes...";
            this.CtxMenuItemDomainParamsEdit.Click += new System.EventHandler(this.CtxMenuItemDomainParamsEdit_Click);
            // 
            // CtxMenuItemDomainParamsDelete
            // 
            this.CtxMenuItemDomainParamsDelete.Name = "CtxMenuItemDomainParamsDelete";
            this.CtxMenuItemDomainParamsDelete.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemDomainParamsDelete.Text = "Xóa...";
            this.CtxMenuItemDomainParamsDelete.Click += new System.EventHandler(this.CtxMenuItemDomainParamsDelete_Click);
            // 
            // CtxMenuItemDomainParamsCsvAll
            // 
            this.CtxMenuItemDomainParamsCsvAll.Name = "CtxMenuItemDomainParamsCsvAll";
            this.CtxMenuItemDomainParamsCsvAll.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemDomainParamsCsvAll.Text = "Export all items to CSV...";
            this.CtxMenuItemDomainParamsCsvAll.Click += new System.EventHandler(this.CtxMenuItemDomainParamsCsvAll_Click);
            // 
            // CtxMenuItemDomainParamsCsvSelected
            // 
            this.CtxMenuItemDomainParamsCsvSelected.Name = "CtxMenuItemDomainParamsCsvSelected";
            this.CtxMenuItemDomainParamsCsvSelected.Size = new System.Drawing.Size(252, 24);
            this.CtxMenuItemDomainParamsCsvSelected.Text = "Export selected items to CSV...";
            this.CtxMenuItemDomainParamsCsvSelected.Click += new System.EventHandler(this.CtxMenuItemDomainParamsCsvSelected_Click);
            // 
            // TabPageDomainParams
            // 
            this.TabPageDomainParams.Controls.Add(this.ListViewDomainParams);
            this.TabPageDomainParams.Controls.Add(this.LabelDomainParams);
            this.TabPageDomainParams.Location = new System.Drawing.Point(4, 25);
            this.TabPageDomainParams.Margin = new System.Windows.Forms.Padding(4);
            this.TabPageDomainParams.Name = "TabPageDomainParams";
            this.TabPageDomainParams.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TabPageDomainParams.Size = new System.Drawing.Size(1003, 337);
            this.TabPageDomainParams.TabIndex = 8;
            this.TabPageDomainParams.Text = "Domain params";
            this.TabPageDomainParams.UseVisualStyleBackColor = true;
            // 
            // ListViewDomainParams
            // 
            this.ListViewDomainParams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewDomainParams.ContextMenuStrip = this.ContextMenuDomainParams;
            this.ListViewDomainParams.HideSelection = false;
            this.ListViewDomainParams.Location = new System.Drawing.Point(18, 32);
            this.ListViewDomainParams.Margin = new System.Windows.Forms.Padding(4);
            this.ListViewDomainParams.Name = "ListViewDomainParams";
            this.ListViewDomainParams.Size = new System.Drawing.Size(964, 294);
            this.ListViewDomainParams.Sortable = true;
            this.ListViewDomainParams.TabIndex = 1;
            this.ListViewDomainParams.UseCompatibleStateImageBehavior = false;
            this.ListViewDomainParams.View = System.Windows.Forms.View.Details;
            // 
            // LabelDomainParams
            // 
            this.LabelDomainParams.AutoSize = true;
            this.LabelDomainParams.Location = new System.Drawing.Point(13, 12);
            this.LabelDomainParams.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDomainParams.Name = "LabelDomainParams";
            this.LabelDomainParams.Size = new System.Drawing.Size(301, 17);
            this.LabelDomainParams.TabIndex = 0;
            this.LabelDomainParams.Text = "These domain parameters objects were found:";
            // 
            // TabPageKeys
            // 
            this.TabPageKeys.Controls.Add(this.ListViewKeys);
            this.TabPageKeys.Controls.Add(this.LabelKeys);
            this.TabPageKeys.Location = new System.Drawing.Point(4, 25);
            this.TabPageKeys.Margin = new System.Windows.Forms.Padding(4);
            this.TabPageKeys.Name = "TabPageKeys";
            this.TabPageKeys.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TabPageKeys.Size = new System.Drawing.Size(1003, 337);
            this.TabPageKeys.TabIndex = 3;
            this.TabPageKeys.Text = "Keys";
            this.TabPageKeys.UseVisualStyleBackColor = true;
            // 
            // ListViewKeys
            // 
            this.ListViewKeys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewKeys.ContextMenuStrip = this.ContextMenuKeys;
            this.ListViewKeys.FullRowSelect = true;
            this.ListViewKeys.HideSelection = false;
            this.ListViewKeys.Location = new System.Drawing.Point(18, 32);
            this.ListViewKeys.Margin = new System.Windows.Forms.Padding(4);
            this.ListViewKeys.Name = "ListViewKeys";
            this.ListViewKeys.Size = new System.Drawing.Size(964, 294);
            this.ListViewKeys.Sortable = true;
            this.ListViewKeys.TabIndex = 1;
            this.ListViewKeys.UseCompatibleStateImageBehavior = false;
            this.ListViewKeys.View = System.Windows.Forms.View.Details;
            // 
            // LabelKeys
            // 
            this.LabelKeys.AutoSize = true;
            this.LabelKeys.Location = new System.Drawing.Point(13, 12);
            this.LabelKeys.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelKeys.Name = "LabelKeys";
            this.LabelKeys.Size = new System.Drawing.Size(201, 17);
            this.LabelKeys.TabIndex = 0;
            this.LabelKeys.Text = "These key objects were found:";
            // 
            // TabPageDataObjects
            // 
            this.TabPageDataObjects.Controls.Add(this.ListViewDataObjects);
            this.TabPageDataObjects.Controls.Add(this.LabelDataObjects);
            this.TabPageDataObjects.Location = new System.Drawing.Point(4, 25);
            this.TabPageDataObjects.Margin = new System.Windows.Forms.Padding(4);
            this.TabPageDataObjects.Name = "TabPageDataObjects";
            this.TabPageDataObjects.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TabPageDataObjects.Size = new System.Drawing.Size(1003, 337);
            this.TabPageDataObjects.TabIndex = 2;
            this.TabPageDataObjects.Text = "Data objects";
            this.TabPageDataObjects.UseVisualStyleBackColor = true;
            // 
            // ListViewDataObjects
            // 
            this.ListViewDataObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewDataObjects.ContextMenuStrip = this.ContextMenuDataObjects;
            this.ListViewDataObjects.FullRowSelect = true;
            this.ListViewDataObjects.HideSelection = false;
            this.ListViewDataObjects.Location = new System.Drawing.Point(18, 32);
            this.ListViewDataObjects.Margin = new System.Windows.Forms.Padding(4);
            this.ListViewDataObjects.Name = "ListViewDataObjects";
            this.ListViewDataObjects.Size = new System.Drawing.Size(964, 294);
            this.ListViewDataObjects.Sortable = true;
            this.ListViewDataObjects.TabIndex = 1;
            this.ListViewDataObjects.UseCompatibleStateImageBehavior = false;
            this.ListViewDataObjects.View = System.Windows.Forms.View.Details;
            // 
            // LabelDataObjects
            // 
            this.LabelDataObjects.AutoSize = true;
            this.LabelDataObjects.Location = new System.Drawing.Point(13, 12);
            this.LabelDataObjects.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDataObjects.Name = "LabelDataObjects";
            this.LabelDataObjects.Size = new System.Drawing.Size(207, 17);
            this.LabelDataObjects.TabIndex = 0;
            this.LabelDataObjects.Text = "These data objects were found:";
            // 
            // TabPageHwFeatures
            // 
            this.TabPageHwFeatures.Controls.Add(this.ListViewHwFeatures);
            this.TabPageHwFeatures.Controls.Add(this.LabelHwFeatures);
            this.TabPageHwFeatures.Location = new System.Drawing.Point(4, 25);
            this.TabPageHwFeatures.Margin = new System.Windows.Forms.Padding(4);
            this.TabPageHwFeatures.Name = "TabPageHwFeatures";
            this.TabPageHwFeatures.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TabPageHwFeatures.Size = new System.Drawing.Size(1003, 337);
            this.TabPageHwFeatures.TabIndex = 1;
            this.TabPageHwFeatures.Text = "HW features";
            this.TabPageHwFeatures.UseVisualStyleBackColor = true;
            // 
            // ListViewHwFeatures
            // 
            this.ListViewHwFeatures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewHwFeatures.ContextMenuStrip = this.ContextMenuHwFeatures;
            this.ListViewHwFeatures.FullRowSelect = true;
            this.ListViewHwFeatures.HideSelection = false;
            this.ListViewHwFeatures.Location = new System.Drawing.Point(18, 32);
            this.ListViewHwFeatures.Margin = new System.Windows.Forms.Padding(4);
            this.ListViewHwFeatures.Name = "ListViewHwFeatures";
            this.ListViewHwFeatures.Size = new System.Drawing.Size(964, 294);
            this.ListViewHwFeatures.Sortable = true;
            this.ListViewHwFeatures.TabIndex = 1;
            this.ListViewHwFeatures.UseCompatibleStateImageBehavior = false;
            this.ListViewHwFeatures.View = System.Windows.Forms.View.Details;
            // 
            // LabelHwFeatures
            // 
            this.LabelHwFeatures.AutoSize = true;
            this.LabelHwFeatures.Location = new System.Drawing.Point(13, 12);
            this.LabelHwFeatures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelHwFeatures.Name = "LabelHwFeatures";
            this.LabelHwFeatures.Size = new System.Drawing.Size(287, 17);
            this.LabelHwFeatures.TabIndex = 0;
            this.LabelHwFeatures.Text = "These hardware feature objects were found:";
            // 
            // TabPageMechanisms
            // 
            this.TabPageMechanisms.Controls.Add(this.ListViewMechanisms);
            this.TabPageMechanisms.Controls.Add(this.LabelMechanisms);
            this.TabPageMechanisms.Location = new System.Drawing.Point(4, 25);
            this.TabPageMechanisms.Margin = new System.Windows.Forms.Padding(4);
            this.TabPageMechanisms.Name = "TabPageMechanisms";
            this.TabPageMechanisms.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TabPageMechanisms.Size = new System.Drawing.Size(1003, 337);
            this.TabPageMechanisms.TabIndex = 0;
            this.TabPageMechanisms.Text = " Danh sách hàm mật mã hỗ trợ ";
            this.TabPageMechanisms.UseVisualStyleBackColor = true;
            // 
            // ListViewMechanisms
            // 
            this.ListViewMechanisms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewMechanisms.ContextMenuStrip = this.ContextMenuMechanisms;
            this.ListViewMechanisms.FullRowSelect = true;
            this.ListViewMechanisms.HideSelection = false;
            this.ListViewMechanisms.Location = new System.Drawing.Point(18, 32);
            this.ListViewMechanisms.Margin = new System.Windows.Forms.Padding(4);
            this.ListViewMechanisms.Name = "ListViewMechanisms";
            this.ListViewMechanisms.Size = new System.Drawing.Size(964, 294);
            this.ListViewMechanisms.Sortable = true;
            this.ListViewMechanisms.TabIndex = 0;
            this.ListViewMechanisms.UseCompatibleStateImageBehavior = false;
            this.ListViewMechanisms.View = System.Windows.Forms.View.Details;
            // 
            // LabelMechanisms
            // 
            this.LabelMechanisms.AutoSize = true;
            this.LabelMechanisms.Location = new System.Drawing.Point(13, 12);
            this.LabelMechanisms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMechanisms.Name = "LabelMechanisms";
            this.LabelMechanisms.Size = new System.Drawing.Size(377, 17);
            this.LabelMechanisms.TabIndex = 1;
            this.LabelMechanisms.Text = "These mechanisms are supported by the PKCS#11 library:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PIN code cũ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // oldPIN
            // 
            this.oldPIN.Location = new System.Drawing.Point(57, 68);
            this.oldPIN.Name = "oldPIN";
            this.oldPIN.Size = new System.Drawing.Size(888, 22);
            this.oldPIN.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "PIN code mới (8 đến 64 ký tự)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Xác nhận PIN code mới (8 đến 64 ký tự)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(886, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(59, 222);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(886, 22);
            this.textBox2.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.MainFormPanel);
            this.Controls.Add(this.MainFormStatusStrip);
            this.Controls.Add(this.MainFormMenuStrip);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1059, 601);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.MainFormStatusStrip.ResumeLayout(false);
            this.MainFormStatusStrip.PerformLayout();
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            this.MainFormPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainFormTabControl.ResumeLayout(false);
            this.TabPageBasicInfo.ResumeLayout(false);
            this.TabPageBasicInfo.PerformLayout();
            this.ContextMenuBasicInfo.ResumeLayout(false);
            this.TabPageCertificates.ResumeLayout(false);
            this.TabPageCertificates.PerformLayout();
            this.ContextMenuCertificates.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ContextMenuMechanisms.ResumeLayout(false);
            this.ContextMenuHwFeatures.ResumeLayout(false);
            this.ContextMenuDataObjects.ResumeLayout(false);
            this.ContextMenuKeys.ResumeLayout(false);
            this.ContextMenuDomainParams.ResumeLayout(false);
            this.TabPageDomainParams.ResumeLayout(false);
            this.TabPageDomainParams.PerformLayout();
            this.TabPageKeys.ResumeLayout(false);
            this.TabPageKeys.PerformLayout();
            this.TabPageDataObjects.ResumeLayout(false);
            this.TabPageDataObjects.PerformLayout();
            this.TabPageHwFeatures.ResumeLayout(false);
            this.TabPageHwFeatures.PerformLayout();
            this.TabPageMechanisms.ResumeLayout(false);
            this.TabPageMechanisms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip MainFormStatusStrip;
        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.Panel MainFormPanel;
        private System.Windows.Forms.ToolStripStatusLabel MainFormStatusStripLabel;
        private System.Windows.Forms.ContextMenuStrip ContextMenuBasicInfo;
        private System.Windows.Forms.ContextMenuStrip ContextMenuMechanisms;
        private System.Windows.Forms.ContextMenuStrip ContextMenuHwFeatures;
        private System.Windows.Forms.ContextMenuStrip ContextMenuDataObjects;
        private System.Windows.Forms.ContextMenuStrip ContextMenuCertificates;
        private System.Windows.Forms.ContextMenuStrip ContextMenuKeys;
        private System.Windows.Forms.ContextMenuStrip ContextMenuDomainParams;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemBasicInfoPkcs11Uri;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemBasicInfoCsvAll;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemBasicInfoCsvSelected;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemMechanismsCsvAll;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemMechanismsCsvSelected;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemHwFeaturesEdit;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemHwFeaturesCsvAll;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemHwFeaturesCsvSelected;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDataObjectsNew;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDataObjectsEdit;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDataObjectsDelete;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDataObjectsImport;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDataObjectsExport;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDataObjectsPkcs11Uri;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDataObjectsCsvAll;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDataObjectsCsvSelected;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDataObjectsView;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemCertificatesPkcs11Uri;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemCertificatesCsvAll;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemCertificatesCsvSelected;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemKeysPkcs11Uri;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemKeysCsvAll;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemKeysCsvSelected;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDomainParamsCsvAll;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDomainParamsCsvSelected;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemCertificatesView;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemCertificatesEdit;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemCertificatesDelete;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemCertificatesImport;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemCertificatesExport;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemKeysNew;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemKeysEdit;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemKeyDelete;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemKeysImport;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemKeysExport;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemKeysNewCsr;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemKeysNewCert;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDomainParamsEdit;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemDomainParamsDelete;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemCertificatesCheckRoca;
        private System.Windows.Forms.ToolStripMenuItem CtxMenuItemKeysCheckRoca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ToolStripMenuItem MenuItemApplication;
        private ToolStripMenuItem MenuItemLoadLibrary;
        private ToolStripMenuItem MenuItemOpenLogFile;
        private ToolStripSeparator MenuItemApplicationSeparator1;
        private ToolStripMenuItem MenuItemReloadLibrary;
        private ToolStripMenuItem MenuItemRefreshSlot;
        private ToolStripSeparator MenuItemApplicationSeparator2;
        private ToolStripMenuItem testingToolStripMenuItem;
        private ToolStripMenuItem MenuItemExit;
        private ToolStripMenuItem MenuItemSlot;
        private ToolStripMenuItem MenuItemToken;
        private ToolStripMenuItem MenuItemLogin;
        private ToolStripMenuItem MenuItemUserLogin;
        private ToolStripMenuItem MenuItemProtectedUserLogin;
        private ToolStripMenuItem MenuItemSoLogin;
        private ToolStripMenuItem MenuItemProtectedSoLogin;
        private ToolStripMenuItem MenuItemLogout;
        private ToolStripMenuItem MenuItemChangePin;
        private ToolStripMenuItem MenuItemUserChange;
        private ToolStripMenuItem MenuItemProtectedUserChange;
        private ToolStripMenuItem MenuItemSoChange;
        private ToolStripMenuItem MenuItemProtectedSoChange;
        private ToolStripSeparator MenuItemTokenSeparator1;
        private ToolStripMenuItem MenuItemInitToken;
        private ToolStripMenuItem MenuItemTokenInit;
        private ToolStripMenuItem MenuItemProtectedTokenInit;
        private ToolStripMenuItem MenuItemInitPin;
        private ToolStripMenuItem MenuItemUserInit;
        private ToolStripMenuItem MenuItemProtectedUserInit;
        private ToolStripMenuItem MenuItemObject;
        private ToolStripMenuItem MenuItemObjectNew;
        private ToolStripMenuItem MenuItemObjectNewData;
        private ToolStripMenuItem MenuItemObjectNewKey;
        private ToolStripMenuItem MenuItemObjectNewCsr;
        private ToolStripMenuItem MenuItemObjectNewCert;
        private ToolStripMenuItem MenuItemObjectEdit;
        private ToolStripMenuItem MenuItemObjectDelete;
        private ToolStripMenuItem MenuItemObjectView;
        private ToolStripMenuItem MenuItemObjectViewData;
        private ToolStripMenuItem MenuItemObjectViewCert;
        private ToolStripMenuItem MenuItemObjectImport;
        private ToolStripMenuItem MenuItemObjectImportData;
        private ToolStripMenuItem MenuItemObjectImportCert;
        private ToolStripMenuItem MenuItemObjectImportKey;
        private ToolStripMenuItem MenuItemObjectExport;
        private ToolStripMenuItem MenuItemObjectExportData;
        private ToolStripMenuItem MenuItemObjectExportCert;
        private ToolStripMenuItem MenuItemObjectExportKey;
        private ToolStripMenuItem MenuItemTools;
        private ToolStripMenuItem MenuItemCsvExport;
        private ToolStripMenuItem MenuItemCsvExportAll;
        private ToolStripMenuItem MenuItemCsvExportSelected;
        private ToolStripMenuItem MenuItemPkcs11Uri;
        private ToolStripMenuItem MenuItemPkcs11UriEmpty;
        private ToolStripMenuItem MenuItemPkcs11UriWithObject;
        private ToolStripMenuItem MenuItemPkcs11UriWithoutObject;
        private ToolStripMenuItem MenuItemHelp;
        private ToolStripMenuItem MenuItemCheckUpdates;
        private ToolStripMenuItem MenuItemAbout;
        private TabControl MainFormTabControl;
        private TabPage TabPageBasicInfo;
        private Controls.EnhancedListView ListViewBasicInfo;
        private Label LabelBasicInfo;
        private TabPage TabPageMechanisms;
        private Controls.EnhancedListView ListViewMechanisms;
        private Label LabelMechanisms;
        private TabPage TabPageHwFeatures;
        private Controls.EnhancedListView ListViewHwFeatures;
        private Label LabelHwFeatures;
        private TabPage TabPageDataObjects;
        private Controls.EnhancedListView ListViewDataObjects;
        private Label LabelDataObjects;
        private TabPage TabPageCertificates;
        private Controls.EnhancedListView ListViewCertificates;
        private Label LabelCertificates;
        private TabPage TabPageKeys;
        private Controls.EnhancedListView ListViewKeys;
        private Label LabelKeys;
        private TabPage TabPageDomainParams;
        private Controls.EnhancedListView ListViewDomainParams;
        private Label LabelDomainParams;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox oldPIN;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
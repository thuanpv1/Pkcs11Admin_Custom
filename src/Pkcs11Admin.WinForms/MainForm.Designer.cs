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
            this.tabPageTokenManger = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panelDoiPinTokenManager = new System.Windows.Forms.Panel();
            this.panelDangNhapTokenManager = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonLoginTokenManager = new System.Windows.Forms.Button();
            this.textBoxPinCodeLoginTokenManager = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonDoiPinTabQuanLyToken = new System.Windows.Forms.Button();
            this.textBoxNewPinConfirm = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxNewPin = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxOldPin = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxDatTokenMacDinh = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxGhiChu = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxTrangThai = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxModelToken = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxManufacture = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxLabelToken = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxDanhSachTokenReader = new System.Windows.Forms.ComboBox();
            this.tabPageCertNew = new System.Windows.Forms.TabPage();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonCancelCertTab = new System.Windows.Forms.Button();
            this.textBoxLoginCertTab = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label4DangNhap = new System.Windows.Forms.Label();
            this.buttonLoginCertTab = new System.Windows.Forms.Button();
            this.treeViewCerts = new System.Windows.Forms.TreeView();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.textBoxAbout = new System.Windows.Forms.TextBox();
            this.TabPageBasicInfo = new System.Windows.Forms.TabPage();
            this.ContextMenuBasicInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CtxMenuItemBasicInfoPkcs11Uri = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemBasicInfoCsvAll = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemBasicInfoCsvSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageDoiPIN = new System.Windows.Forms.TabPage();
            this.panelLoginDoiPIN = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxLoginDoiPINTab = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonLoginDoiPINTab = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonChapNhan = new System.Windows.Forms.Button();
            this.newPINConfirm = new System.Windows.Forms.TextBox();
            this.newPIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oldPIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabPageCertificates = new System.Windows.Forms.TabPage();
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
            this.TabPageKeys = new System.Windows.Forms.TabPage();
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
            this.LabelKeys = new System.Windows.Forms.Label();
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
            this.ContextMenuDomainParams = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CtxMenuItemDomainParamsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemDomainParamsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemDomainParamsCsvAll = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuItemDomainParamsCsvSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.TabPageDomainParams = new System.Windows.Forms.TabPage();
            this.LabelDomainParams = new System.Windows.Forms.Label();
            this.TabPageDataObjects = new System.Windows.Forms.TabPage();
            this.LabelDataObjects = new System.Windows.Forms.Label();
            this.TabPageHwFeatures = new System.Windows.Forms.TabPage();
            this.LabelHwFeatures = new System.Windows.Forms.Label();
            this.TabPageMechanisms = new System.Windows.Forms.TabPage();
            this.LabelMechanisms = new System.Windows.Forms.Label();
            this.contextMenuStripForViewDetailCertKeys = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListViewBasicInfo = new Net.Pkcs11Admin.WinForms.Controls.EnhancedListView();
            this.ListViewCertificates = new Net.Pkcs11Admin.WinForms.Controls.EnhancedListView();
            this.ListViewKeys = new Net.Pkcs11Admin.WinForms.Controls.EnhancedListView();
            this.ListViewDomainParams = new Net.Pkcs11Admin.WinForms.Controls.EnhancedListView();
            this.ListViewDataObjects = new Net.Pkcs11Admin.WinForms.Controls.EnhancedListView();
            this.ListViewHwFeatures = new Net.Pkcs11Admin.WinForms.Controls.EnhancedListView();
            this.ListViewMechanisms = new Net.Pkcs11Admin.WinForms.Controls.EnhancedListView();
            this.MainFormStatusStrip.SuspendLayout();
            this.MainFormMenuStrip.SuspendLayout();
            this.MainFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainFormTabControl.SuspendLayout();
            this.tabPageTokenManger.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelDoiPinTokenManager.SuspendLayout();
            this.panelDangNhapTokenManager.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageCertNew.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.TabPageBasicInfo.SuspendLayout();
            this.ContextMenuBasicInfo.SuspendLayout();
            this.tabPageDoiPIN.SuspendLayout();
            this.panelLoginDoiPIN.SuspendLayout();
            this.TabPageCertificates.SuspendLayout();
            this.ContextMenuCertificates.SuspendLayout();
            this.TabPageKeys.SuspendLayout();
            this.ContextMenuKeys.SuspendLayout();
            this.ContextMenuMechanisms.SuspendLayout();
            this.ContextMenuHwFeatures.SuspendLayout();
            this.ContextMenuDataObjects.SuspendLayout();
            this.ContextMenuDomainParams.SuspendLayout();
            this.TabPageDomainParams.SuspendLayout();
            this.TabPageDataObjects.SuspendLayout();
            this.TabPageHwFeatures.SuspendLayout();
            this.TabPageMechanisms.SuspendLayout();
            this.contextMenuStripForViewDetailCertKeys.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormStatusStrip
            // 
            this.MainFormStatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainFormStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainFormStatusStripLabel});
            this.MainFormStatusStrip.Location = new System.Drawing.Point(0, 570);
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
            this.MainFormPanel.Size = new System.Drawing.Size(1045, 570);
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
            this.MainFormTabControl.Controls.Add(this.tabPageTokenManger);
            this.MainFormTabControl.Controls.Add(this.tabPageCertNew);
            this.MainFormTabControl.Controls.Add(this.tabPageAbout);
            this.MainFormTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainFormTabControl.ItemSize = new System.Drawing.Size(106, 30);
            this.MainFormTabControl.Location = new System.Drawing.Point(0, 159);
            this.MainFormTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.MainFormTabControl.Name = "MainFormTabControl";
            this.MainFormTabControl.SelectedIndex = 0;
            this.MainFormTabControl.Size = new System.Drawing.Size(1045, 420);
            this.MainFormTabControl.TabIndex = 1;
            this.MainFormTabControl.SelectedIndexChanged += new System.EventHandler(this.MainFormTabControl_SelectedIndexChanged);
            // 
            // tabPageTokenManger
            // 
            this.tabPageTokenManger.Controls.Add(this.groupBox3);
            this.tabPageTokenManger.Controls.Add(this.groupBox2);
            this.tabPageTokenManger.Controls.Add(this.groupBox1);
            this.tabPageTokenManger.Controls.Add(this.buttonRefresh);
            this.tabPageTokenManger.Controls.Add(this.label7);
            this.tabPageTokenManger.Controls.Add(this.comboBoxDanhSachTokenReader);
            this.tabPageTokenManger.Location = new System.Drawing.Point(4, 34);
            this.tabPageTokenManger.Name = "tabPageTokenManger";
            this.tabPageTokenManger.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTokenManger.Size = new System.Drawing.Size(1037, 382);
            this.tabPageTokenManger.TabIndex = 11;
            this.tabPageTokenManger.Text = "Quản lý token";
            this.tabPageTokenManger.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panelDoiPinTokenManager);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(634, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 203);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đổi PIN";
            // 
            // panelDoiPinTokenManager
            // 
            this.panelDoiPinTokenManager.Controls.Add(this.panelDangNhapTokenManager);
            this.panelDoiPinTokenManager.Controls.Add(this.buttonDoiPinTabQuanLyToken);
            this.panelDoiPinTokenManager.Controls.Add(this.textBoxNewPinConfirm);
            this.panelDoiPinTokenManager.Controls.Add(this.label16);
            this.panelDoiPinTokenManager.Controls.Add(this.textBoxNewPin);
            this.panelDoiPinTokenManager.Controls.Add(this.label15);
            this.panelDoiPinTokenManager.Controls.Add(this.textBoxOldPin);
            this.panelDoiPinTokenManager.Controls.Add(this.label14);
            this.panelDoiPinTokenManager.Location = new System.Drawing.Point(0, 30);
            this.panelDoiPinTokenManager.Name = "panelDoiPinTokenManager";
            this.panelDoiPinTokenManager.Size = new System.Drawing.Size(399, 172);
            this.panelDoiPinTokenManager.TabIndex = 0;
            // 
            // panelDangNhapTokenManager
            // 
            this.panelDangNhapTokenManager.Controls.Add(this.label18);
            this.panelDangNhapTokenManager.Controls.Add(this.buttonLoginTokenManager);
            this.panelDangNhapTokenManager.Controls.Add(this.textBoxPinCodeLoginTokenManager);
            this.panelDangNhapTokenManager.Controls.Add(this.label17);
            this.panelDangNhapTokenManager.Location = new System.Drawing.Point(0, 0);
            this.panelDangNhapTokenManager.Name = "panelDangNhapTokenManager";
            this.panelDangNhapTokenManager.Size = new System.Drawing.Size(399, 172);
            this.panelDangNhapTokenManager.TabIndex = 10;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(34, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 20);
            this.label18.TabIndex = 3;
            this.label18.Text = "PIN code";
            // 
            // buttonLoginTokenManager
            // 
            this.buttonLoginTokenManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginTokenManager.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonLoginTokenManager.Location = new System.Drawing.Point(254, 118);
            this.buttonLoginTokenManager.Name = "buttonLoginTokenManager";
            this.buttonLoginTokenManager.Size = new System.Drawing.Size(142, 36);
            this.buttonLoginTokenManager.TabIndex = 2;
            this.buttonLoginTokenManager.Text = "Login";
            this.buttonLoginTokenManager.UseVisualStyleBackColor = true;
            this.buttonLoginTokenManager.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPinCodeLoginTokenManager
            // 
            this.textBoxPinCodeLoginTokenManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPinCodeLoginTokenManager.Location = new System.Drawing.Point(143, 66);
            this.textBoxPinCodeLoginTokenManager.Name = "textBoxPinCodeLoginTokenManager";
            this.textBoxPinCodeLoginTokenManager.PasswordChar = '*';
            this.textBoxPinCodeLoginTokenManager.Size = new System.Drawing.Size(251, 27);
            this.textBoxPinCodeLoginTokenManager.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(34, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Đăng nhập";
            // 
            // buttonDoiPinTabQuanLyToken
            // 
            this.buttonDoiPinTabQuanLyToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDoiPinTabQuanLyToken.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonDoiPinTabQuanLyToken.Location = new System.Drawing.Point(204, 130);
            this.buttonDoiPinTabQuanLyToken.Name = "buttonDoiPinTabQuanLyToken";
            this.buttonDoiPinTabQuanLyToken.Size = new System.Drawing.Size(180, 32);
            this.buttonDoiPinTabQuanLyToken.TabIndex = 9;
            this.buttonDoiPinTabQuanLyToken.Text = "Chấp nhận";
            this.buttonDoiPinTabQuanLyToken.UseVisualStyleBackColor = true;
            this.buttonDoiPinTabQuanLyToken.Click += new System.EventHandler(this.buttonDoiPinTabQuanLyToken_Click);
            // 
            // textBoxNewPinConfirm
            // 
            this.textBoxNewPinConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPinConfirm.Location = new System.Drawing.Point(204, 89);
            this.textBoxNewPinConfirm.Name = "textBoxNewPinConfirm";
            this.textBoxNewPinConfirm.PasswordChar = '*';
            this.textBoxNewPinConfirm.Size = new System.Drawing.Size(180, 27);
            this.textBoxNewPinConfirm.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "Xác nhận PIN mới";
            // 
            // textBoxNewPin
            // 
            this.textBoxNewPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPin.Location = new System.Drawing.Point(204, 49);
            this.textBoxNewPin.Name = "textBoxNewPin";
            this.textBoxNewPin.PasswordChar = '*';
            this.textBoxNewPin.Size = new System.Drawing.Size(180, 27);
            this.textBoxNewPin.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "PIN code mới";
            // 
            // textBoxOldPin
            // 
            this.textBoxOldPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOldPin.Location = new System.Drawing.Point(204, 11);
            this.textBoxOldPin.Name = "textBoxOldPin";
            this.textBoxOldPin.PasswordChar = '*';
            this.textBoxOldPin.Size = new System.Drawing.Size(180, 27);
            this.textBoxOldPin.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "PIN code cũ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxDatTokenMacDinh);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(634, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 74);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cài đặt token";
            // 
            // checkBoxDatTokenMacDinh
            // 
            this.checkBoxDatTokenMacDinh.AutoSize = true;
            this.checkBoxDatTokenMacDinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDatTokenMacDinh.Location = new System.Drawing.Point(23, 40);
            this.checkBoxDatTokenMacDinh.Name = "checkBoxDatTokenMacDinh";
            this.checkBoxDatTokenMacDinh.Size = new System.Drawing.Size(230, 24);
            this.checkBoxDatTokenMacDinh.TabIndex = 0;
            this.checkBoxDatTokenMacDinh.Text = "Đặt làm lựa chọn mặc định";
            this.checkBoxDatTokenMacDinh.UseVisualStyleBackColor = true;
            this.checkBoxDatTokenMacDinh.CheckedChanged += new System.EventHandler(this.checkBoxDatTokenMacDinh_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxGhiChu);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBoxTrangThai);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxSerialNumber);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxModelToken);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxManufacture);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxLabelToken);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 285);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin token";
            // 
            // textBoxGhiChu
            // 
            this.textBoxGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGhiChu.Location = new System.Drawing.Point(167, 190);
            this.textBoxGhiChu.Multiline = true;
            this.textBoxGhiChu.Name = "textBoxGhiChu";
            this.textBoxGhiChu.ReadOnly = true;
            this.textBoxGhiChu.Size = new System.Drawing.Size(437, 76);
            this.textBoxGhiChu.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Ghi chú";
            // 
            // textBoxTrangThai
            // 
            this.textBoxTrangThai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTrangThai.Location = new System.Drawing.Point(167, 160);
            this.textBoxTrangThai.Name = "textBoxTrangThai";
            this.textBoxTrangThai.ReadOnly = true;
            this.textBoxTrangThai.Size = new System.Drawing.Size(437, 20);
            this.textBoxTrangThai.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Trạng Thái";
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSerialNumber.Location = new System.Drawing.Point(167, 130);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.ReadOnly = true;
            this.textBoxSerialNumber.Size = new System.Drawing.Size(437, 20);
            this.textBoxSerialNumber.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Serial Number";
            // 
            // textBoxModelToken
            // 
            this.textBoxModelToken.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxModelToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModelToken.Location = new System.Drawing.Point(167, 100);
            this.textBoxModelToken.Name = "textBoxModelToken";
            this.textBoxModelToken.ReadOnly = true;
            this.textBoxModelToken.Size = new System.Drawing.Size(437, 20);
            this.textBoxModelToken.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Model";
            // 
            // textBoxManufacture
            // 
            this.textBoxManufacture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxManufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxManufacture.Location = new System.Drawing.Point(167, 67);
            this.textBoxManufacture.Name = "textBoxManufacture";
            this.textBoxManufacture.ReadOnly = true;
            this.textBoxManufacture.Size = new System.Drawing.Size(437, 20);
            this.textBoxManufacture.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Manufacturer";
            // 
            // textBoxLabelToken
            // 
            this.textBoxLabelToken.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLabelToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLabelToken.Location = new System.Drawing.Point(167, 40);
            this.textBoxLabelToken.Name = "textBoxLabelToken";
            this.textBoxLabelToken.ReadOnly = true;
            this.textBoxLabelToken.Size = new System.Drawing.Size(437, 20);
            this.textBoxLabelToken.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Label";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(840, 16);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(193, 31);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Lựa chọn token reader";
            // 
            // comboBoxDanhSachTokenReader
            // 
            this.comboBoxDanhSachTokenReader.FormattingEnabled = true;
            this.comboBoxDanhSachTokenReader.Location = new System.Drawing.Point(273, 19);
            this.comboBoxDanhSachTokenReader.Name = "comboBoxDanhSachTokenReader";
            this.comboBoxDanhSachTokenReader.Size = new System.Drawing.Size(541, 28);
            this.comboBoxDanhSachTokenReader.TabIndex = 0;
            this.comboBoxDanhSachTokenReader.SelectedIndexChanged += new System.EventHandler(this.tokenManager_SelectedIndexChanged);
            // 
            // tabPageCertNew
            // 
            this.tabPageCertNew.Controls.Add(this.panelLogin);
            this.tabPageCertNew.Controls.Add(this.treeViewCerts);
            this.tabPageCertNew.Location = new System.Drawing.Point(4, 34);
            this.tabPageCertNew.Name = "tabPageCertNew";
            this.tabPageCertNew.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCertNew.Size = new System.Drawing.Size(1037, 382);
            this.tabPageCertNew.TabIndex = 10;
            this.tabPageCertNew.Text = "Quản lý Certificates";
            this.tabPageCertNew.UseVisualStyleBackColor = true;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.buttonCancelCertTab);
            this.panelLogin.Controls.Add(this.textBoxLoginCertTab);
            this.panelLogin.Controls.Add(this.label4);
            this.panelLogin.Controls.Add(this.label4DangNhap);
            this.panelLogin.Controls.Add(this.buttonLoginCertTab);
            this.panelLogin.Location = new System.Drawing.Point(0, 17);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(1037, 362);
            this.panelLogin.TabIndex = 1;
            // 
            // buttonCancelCertTab
            // 
            this.buttonCancelCertTab.ForeColor = System.Drawing.Color.Red;
            this.buttonCancelCertTab.Location = new System.Drawing.Point(461, 181);
            this.buttonCancelCertTab.Name = "buttonCancelCertTab";
            this.buttonCancelCertTab.Size = new System.Drawing.Size(119, 36);
            this.buttonCancelCertTab.TabIndex = 4;
            this.buttonCancelCertTab.Text = "Hủy bỏ";
            this.buttonCancelCertTab.UseVisualStyleBackColor = true;
            // 
            // textBoxLoginCertTab
            // 
            this.textBoxLoginCertTab.Location = new System.Drawing.Point(238, 111);
            this.textBoxLoginCertTab.Name = "textBoxLoginCertTab";
            this.textBoxLoginCertTab.PasswordChar = '*';
            this.textBoxLoginCertTab.Size = new System.Drawing.Size(489, 27);
            this.textBoxLoginCertTab.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "PIN code:";
            // 
            // label4DangNhap
            // 
            this.label4DangNhap.AutoSize = true;
            this.label4DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4DangNhap.Location = new System.Drawing.Point(126, 66);
            this.label4DangNhap.Name = "label4DangNhap";
            this.label4DangNhap.Size = new System.Drawing.Size(138, 29);
            this.label4DangNhap.TabIndex = 1;
            this.label4DangNhap.Text = "Đăng nhập";
            this.label4DangNhap.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttonLoginCertTab
            // 
            this.buttonLoginCertTab.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonLoginCertTab.Location = new System.Drawing.Point(326, 181);
            this.buttonLoginCertTab.Name = "buttonLoginCertTab";
            this.buttonLoginCertTab.Size = new System.Drawing.Size(119, 36);
            this.buttonLoginCertTab.TabIndex = 0;
            this.buttonLoginCertTab.Text = "Login";
            this.buttonLoginCertTab.UseVisualStyleBackColor = true;
            this.buttonLoginCertTab.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeViewCerts
            // 
            this.treeViewCerts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewCerts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewCerts.Location = new System.Drawing.Point(0, 17);
            this.treeViewCerts.Name = "treeViewCerts";
            this.treeViewCerts.ShowNodeToolTips = true;
            this.treeViewCerts.Size = new System.Drawing.Size(1037, 357);
            this.treeViewCerts.TabIndex = 0;
            this.treeViewCerts.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCerts_AfterSelect);
            this.treeViewCerts.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewCerts_NodeMouseClick);
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.textBoxAbout);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 34);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Size = new System.Drawing.Size(1037, 382);
            this.tabPageAbout.TabIndex = 9;
            this.tabPageAbout.Text = "About";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // textBoxAbout
            // 
            this.textBoxAbout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAbout.Location = new System.Drawing.Point(41, 33);
            this.textBoxAbout.Multiline = true;
            this.textBoxAbout.Name = "textBoxAbout";
            this.textBoxAbout.ReadOnly = true;
            this.textBoxAbout.Size = new System.Drawing.Size(570, 164);
            this.textBoxAbout.TabIndex = 1;
            this.textBoxAbout.Text = "Token Manager v1.0\r\n\r\nPhần mềm này đã được đăng ký thương hiệu tại Việt Nam.\r\n\r\nB" +
    "ản quyền 2021-2025";
            // 
            // TabPageBasicInfo
            // 
            this.TabPageBasicInfo.Controls.Add(this.ListViewBasicInfo);
            this.TabPageBasicInfo.Location = new System.Drawing.Point(4, 34);
            this.TabPageBasicInfo.Margin = new System.Windows.Forms.Padding(4);
            this.TabPageBasicInfo.Name = "TabPageBasicInfo";
            this.TabPageBasicInfo.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TabPageBasicInfo.Size = new System.Drawing.Size(1037, 382);
            this.TabPageBasicInfo.TabIndex = 7;
            this.TabPageBasicInfo.Text = "Thông tin chung";
            this.TabPageBasicInfo.UseVisualStyleBackColor = true;
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
            // tabPageDoiPIN
            // 
            this.tabPageDoiPIN.Controls.Add(this.panelLoginDoiPIN);
            this.tabPageDoiPIN.Controls.Add(this.buttonHuy);
            this.tabPageDoiPIN.Controls.Add(this.buttonChapNhan);
            this.tabPageDoiPIN.Controls.Add(this.newPINConfirm);
            this.tabPageDoiPIN.Controls.Add(this.newPIN);
            this.tabPageDoiPIN.Controls.Add(this.label3);
            this.tabPageDoiPIN.Controls.Add(this.label2);
            this.tabPageDoiPIN.Controls.Add(this.oldPIN);
            this.tabPageDoiPIN.Controls.Add(this.label1);
            this.tabPageDoiPIN.Location = new System.Drawing.Point(4, 34);
            this.tabPageDoiPIN.Name = "tabPageDoiPIN";
            this.tabPageDoiPIN.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDoiPIN.Size = new System.Drawing.Size(1037, 382);
            this.tabPageDoiPIN.TabIndex = 8;
            this.tabPageDoiPIN.Text = "Đổi PIN";
            this.tabPageDoiPIN.UseVisualStyleBackColor = true;
            // 
            // panelLoginDoiPIN
            // 
            this.panelLoginDoiPIN.Controls.Add(this.button1);
            this.panelLoginDoiPIN.Controls.Add(this.textBoxLoginDoiPINTab);
            this.panelLoginDoiPIN.Controls.Add(this.label5);
            this.panelLoginDoiPIN.Controls.Add(this.label6);
            this.panelLoginDoiPIN.Controls.Add(this.buttonLoginDoiPINTab);
            this.panelLoginDoiPIN.Location = new System.Drawing.Point(0, 17);
            this.panelLoginDoiPIN.Name = "panelLoginDoiPIN";
            this.panelLoginDoiPIN.Size = new System.Drawing.Size(1037, 360);
            this.panelLoginDoiPIN.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(461, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Hủy bỏ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxLoginDoiPINTab
            // 
            this.textBoxLoginDoiPINTab.Location = new System.Drawing.Point(238, 111);
            this.textBoxLoginDoiPINTab.Name = "textBoxLoginDoiPINTab";
            this.textBoxLoginDoiPINTab.PasswordChar = '*';
            this.textBoxLoginDoiPINTab.Size = new System.Drawing.Size(489, 22);
            this.textBoxLoginDoiPINTab.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "PIN code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đăng nhập";
            // 
            // buttonLoginDoiPINTab
            // 
            this.buttonLoginDoiPINTab.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonLoginDoiPINTab.Location = new System.Drawing.Point(326, 181);
            this.buttonLoginDoiPINTab.Name = "buttonLoginDoiPINTab";
            this.buttonLoginDoiPINTab.Size = new System.Drawing.Size(119, 36);
            this.buttonLoginDoiPINTab.TabIndex = 0;
            this.buttonLoginDoiPINTab.Text = "Login";
            this.buttonLoginDoiPINTab.UseVisualStyleBackColor = true;
            this.buttonLoginDoiPINTab.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonHuy
            // 
            this.buttonHuy.ForeColor = System.Drawing.Color.Red;
            this.buttonHuy.Location = new System.Drawing.Point(494, 266);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(119, 36);
            this.buttonHuy.TabIndex = 7;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = true;
            // 
            // buttonChapNhan
            // 
            this.buttonChapNhan.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonChapNhan.Location = new System.Drawing.Point(354, 266);
            this.buttonChapNhan.Name = "buttonChapNhan";
            this.buttonChapNhan.Size = new System.Drawing.Size(119, 36);
            this.buttonChapNhan.TabIndex = 6;
            this.buttonChapNhan.Text = "Chấp nhận";
            this.buttonChapNhan.UseVisualStyleBackColor = true;
            this.buttonChapNhan.Click += new System.EventHandler(this.buttonChapNhan_Click);
            // 
            // newPINConfirm
            // 
            this.newPINConfirm.Location = new System.Drawing.Point(59, 205);
            this.newPINConfirm.MaxLength = 68;
            this.newPINConfirm.Name = "newPINConfirm";
            this.newPINConfirm.PasswordChar = '*';
            this.newPINConfirm.Size = new System.Drawing.Size(886, 22);
            this.newPINConfirm.TabIndex = 5;
            // 
            // newPIN
            // 
            this.newPIN.Location = new System.Drawing.Point(59, 127);
            this.newPIN.MaxLength = 68;
            this.newPIN.Name = "newPIN";
            this.newPIN.PasswordChar = '*';
            this.newPIN.Size = new System.Drawing.Size(886, 22);
            this.newPIN.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Xác nhận PIN code mới (8 đến 64 ký tự)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "PIN code mới (8 đến 64 ký tự)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // oldPIN
            // 
            this.oldPIN.Location = new System.Drawing.Point(57, 49);
            this.oldPIN.MaxLength = 68;
            this.oldPIN.Name = "oldPIN";
            this.oldPIN.PasswordChar = '*';
            this.oldPIN.Size = new System.Drawing.Size(888, 22);
            this.oldPIN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PIN code cũ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // contextMenuStripForViewDetailCertKeys
            // 
            this.contextMenuStripForViewDetailCertKeys.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripForViewDetailCertKeys.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDetailToolStripMenuItem});
            this.contextMenuStripForViewDetailCertKeys.Name = "contextMenuStripForViewDetailCertKeys";
            this.contextMenuStripForViewDetailCertKeys.Size = new System.Drawing.Size(158, 28);
            // 
            // viewDetailToolStripMenuItem
            // 
            this.viewDetailToolStripMenuItem.Name = "viewDetailToolStripMenuItem";
            this.viewDetailToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.viewDetailToolStripMenuItem.Text = "Xem chi tiết";
            this.viewDetailToolStripMenuItem.Click += new System.EventHandler(this.viewDetailToolStripMenuItem_Click);
            // 
            // ListViewBasicInfo
            // 
            this.ListViewBasicInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewBasicInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewBasicInfo.ContextMenuStrip = this.ContextMenuBasicInfo;
            this.ListViewBasicInfo.FullRowSelect = true;
            this.ListViewBasicInfo.HideSelection = false;
            this.ListViewBasicInfo.Location = new System.Drawing.Point(0, 16);
            this.ListViewBasicInfo.Margin = new System.Windows.Forms.Padding(4);
            this.ListViewBasicInfo.Name = "ListViewBasicInfo";
            this.ListViewBasicInfo.Size = new System.Drawing.Size(1037, 361);
            this.ListViewBasicInfo.Sortable = true;
            this.ListViewBasicInfo.TabIndex = 1;
            this.ListViewBasicInfo.UseCompatibleStateImageBehavior = false;
            this.ListViewBasicInfo.View = System.Windows.Forms.View.Details;
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
            this.ListViewCertificates.Size = new System.Drawing.Size(978, 294);
            this.ListViewCertificates.Sortable = true;
            this.ListViewCertificates.TabIndex = 1;
            this.ListViewCertificates.UseCompatibleStateImageBehavior = false;
            this.ListViewCertificates.View = System.Windows.Forms.View.Details;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1045, 592);
            this.Controls.Add(this.MainFormPanel);
            this.Controls.Add(this.MainFormStatusStrip);
            this.Controls.Add(this.MainFormMenuStrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
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
            this.tabPageTokenManger.ResumeLayout(false);
            this.tabPageTokenManger.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panelDoiPinTokenManager.ResumeLayout(false);
            this.panelDoiPinTokenManager.PerformLayout();
            this.panelDangNhapTokenManager.ResumeLayout(false);
            this.panelDangNhapTokenManager.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageCertNew.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            this.TabPageBasicInfo.ResumeLayout(false);
            this.ContextMenuBasicInfo.ResumeLayout(false);
            this.tabPageDoiPIN.ResumeLayout(false);
            this.tabPageDoiPIN.PerformLayout();
            this.panelLoginDoiPIN.ResumeLayout(false);
            this.panelLoginDoiPIN.PerformLayout();
            this.TabPageCertificates.ResumeLayout(false);
            this.TabPageCertificates.PerformLayout();
            this.ContextMenuCertificates.ResumeLayout(false);
            this.TabPageKeys.ResumeLayout(false);
            this.TabPageKeys.PerformLayout();
            this.ContextMenuKeys.ResumeLayout(false);
            this.ContextMenuMechanisms.ResumeLayout(false);
            this.ContextMenuHwFeatures.ResumeLayout(false);
            this.ContextMenuDataObjects.ResumeLayout(false);
            this.ContextMenuDomainParams.ResumeLayout(false);
            this.TabPageDomainParams.ResumeLayout(false);
            this.TabPageDomainParams.PerformLayout();
            this.TabPageDataObjects.ResumeLayout(false);
            this.TabPageDataObjects.PerformLayout();
            this.TabPageHwFeatures.ResumeLayout(false);
            this.TabPageHwFeatures.PerformLayout();
            this.TabPageMechanisms.ResumeLayout(false);
            this.TabPageMechanisms.PerformLayout();
            this.contextMenuStripForViewDetailCertKeys.ResumeLayout(false);
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
        private TabPage tabPageDoiPIN;
        private TabPage tabPageAbout;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox oldPIN;
        private TextBox newPINConfirm;
        private TextBox newPIN;
        private Button buttonHuy;
        private Button buttonChapNhan;
        private TextBox textBoxAbout;
        private TabPage tabPageCertNew;
        private TreeView treeViewCerts;
        private Panel panelLogin;
        private Button buttonLoginCertTab;
        private Label label4DangNhap;
        private TextBox textBoxLoginCertTab;
        private Label label4;
        private Button buttonCancelCertTab;
        private ContextMenuStrip contextMenuStripForViewDetailCertKeys;
        private ToolStripMenuItem viewDetailToolStripMenuItem;
        private Panel panelLoginDoiPIN;
        private Button button1;
        private TextBox textBoxLoginDoiPINTab;
        private Label label5;
        private Label label6;
        private Button buttonLoginDoiPINTab;
        private TabPage tabPageTokenManger;
        private Label label7;
        private ComboBox comboBoxDanhSachTokenReader;
        private Button buttonRefresh;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox textBoxLabelToken;
        private Label label8;
        private TextBox textBoxSerialNumber;
        private Label label11;
        private TextBox textBoxModelToken;
        private Label label10;
        private TextBox textBoxManufacture;
        private Label label9;
        private GroupBox groupBox3;
        private CheckBox checkBoxDatTokenMacDinh;
        private TextBox textBoxGhiChu;
        private Label label13;
        private TextBox textBoxTrangThai;
        private Label label12;
        private Panel panelDoiPinTokenManager;
        private Panel panelDangNhapTokenManager;
        private Button buttonDoiPinTabQuanLyToken;
        private TextBox textBoxNewPinConfirm;
        private Label label16;
        private TextBox textBoxNewPin;
        private Label label15;
        private TextBox textBoxOldPin;
        private Label label14;
        private Label label18;
        private Button buttonLoginTokenManager;
        private TextBox textBoxPinCodeLoginTokenManager;
        private Label label17;
    }
}
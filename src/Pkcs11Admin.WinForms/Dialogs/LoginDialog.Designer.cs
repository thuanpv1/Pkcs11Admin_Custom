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

namespace Net.Pkcs11Admin.WinForms.Dialogs
{
    partial class LoginDialog
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
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.NumLockLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CapsLockLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.KeyboardLayoutLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.TextBoxPin = new System.Windows.Forms.TextBox();
            this.CheckBoxDisplayPin = new System.Windows.Forms.CheckBox();
            this.LabelPin = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.CheckBoxHexString = new System.Windows.Forms.CheckBox();
            this.MainStatusStrip.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NumLockLabel,
            this.CapsLockLabel,
            this.KeyboardLayoutLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 226);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.MainStatusStrip.Size = new System.Drawing.Size(600, 32);
            this.MainStatusStrip.SizingGrip = false;
            this.MainStatusStrip.TabIndex = 0;
            // 
            // NumLockLabel
            // 
            this.NumLockLabel.Name = "NumLockLabel";
            this.NumLockLabel.Size = new System.Drawing.Size(125, 25);
            this.NumLockLabel.Text = "Num Lock: On";
            // 
            // CapsLockLabel
            // 
            this.CapsLockLabel.Name = "CapsLockLabel";
            this.CapsLockLabel.Size = new System.Drawing.Size(125, 25);
            this.CapsLockLabel.Text = "Caps Lock: On";
            // 
            // KeyboardLayoutLabel
            // 
            this.KeyboardLayoutLabel.Name = "KeyboardLayoutLabel";
            this.KeyboardLayoutLabel.Size = new System.Drawing.Size(177, 25);
            this.KeyboardLayoutLabel.Text = "Keyboard Layout: EN";
            // 
            // ButtonOk
            // 
            this.ButtonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOk.Location = new System.Drawing.Point(346, 138);
            this.ButtonOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(112, 35);
            this.ButtonOk.TabIndex = 2;
            this.ButtonOk.Text = "OK";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(468, 138);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(112, 35);
            this.ButtonCancel.TabIndex = 3;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // TextBoxPin
            // 
            this.TextBoxPin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPin.Location = new System.Drawing.Point(20, 87);
            this.TextBoxPin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 15);
            this.TextBoxPin.Name = "TextBoxPin";
            this.TextBoxPin.Size = new System.Drawing.Size(559, 26);
            this.TextBoxPin.TabIndex = 0;
            this.TextBoxPin.UseSystemPasswordChar = true;
            // 
            // CheckBoxDisplayPin
            // 
            this.CheckBoxDisplayPin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CheckBoxDisplayPin.AutoSize = true;
            this.CheckBoxDisplayPin.Location = new System.Drawing.Point(20, 138);
            this.CheckBoxDisplayPin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckBoxDisplayPin.Name = "CheckBoxDisplayPin";
            this.CheckBoxDisplayPin.Size = new System.Drawing.Size(116, 24);
            this.CheckBoxDisplayPin.TabIndex = 1;
            this.CheckBoxDisplayPin.Text = "Display PIN";
            this.CheckBoxDisplayPin.UseVisualStyleBackColor = true;
            this.CheckBoxDisplayPin.CheckedChanged += new System.EventHandler(this.CheckBoxDisplayPin_CheckedChanged);
            // 
            // LabelPin
            // 
            this.LabelPin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelPin.AutoSize = true;
            this.LabelPin.Location = new System.Drawing.Point(15, 47);
            this.LabelPin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 15);
            this.LabelPin.Name = "LabelPin";
            this.LabelPin.Size = new System.Drawing.Size(166, 20);
            this.LabelPin.TabIndex = 5;
            this.LabelPin.Text = "Please enter your PIN:";
            this.LabelPin.Click += new System.EventHandler(this.LabelPin_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.CheckBoxHexString);
            this.MainPanel.Controls.Add(this.ButtonOk);
            this.MainPanel.Controls.Add(this.ButtonCancel);
            this.MainPanel.Controls.Add(this.TextBoxPin);
            this.MainPanel.Controls.Add(this.CheckBoxDisplayPin);
            this.MainPanel.Controls.Add(this.LabelPin);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(15, 46, 15, 46);
            this.MainPanel.Size = new System.Drawing.Size(600, 226);
            this.MainPanel.TabIndex = 6;
            // 
            // CheckBoxHexString
            // 
            this.CheckBoxHexString.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CheckBoxHexString.AutoSize = true;
            this.CheckBoxHexString.Location = new System.Drawing.Point(20, 173);
            this.CheckBoxHexString.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckBoxHexString.Name = "CheckBoxHexString";
            this.CheckBoxHexString.Size = new System.Drawing.Size(135, 24);
            this.CheckBoxHexString.TabIndex = 6;
            this.CheckBoxHexString.Text = "HEX encoded";
            this.CheckBoxHexString.UseVisualStyleBackColor = true;
            // 
            // LoginDialog
            // 
            this.AcceptButton = this.ButtonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(600, 258);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MainStatusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(613, 288);
            this.Name = "LoginDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.InputLanguageChanged += new System.Windows.Forms.InputLanguageChangedEventHandler(this.LoginDialog_InputLanguageChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginDialog_KeyDown);
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel NumLockLabel;
        private System.Windows.Forms.ToolStripStatusLabel CapsLockLabel;
        private System.Windows.Forms.ToolStripStatusLabel KeyboardLayoutLabel;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.TextBox TextBoxPin;
        private System.Windows.Forms.CheckBox CheckBoxDisplayPin;
        private System.Windows.Forms.Label LabelPin;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.CheckBox CheckBoxHexString;
    }
}
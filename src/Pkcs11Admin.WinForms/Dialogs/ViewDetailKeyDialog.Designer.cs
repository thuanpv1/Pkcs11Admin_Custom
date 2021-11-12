using System.Windows.Forms;

namespace Net.Pkcs11Admin.WinForms.Dialogs
{
    partial class ViewDetailKeyDialog
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
            this.StartPosition = FormStartPosition.CenterParent;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxPublicExponent = new System.Windows.Forms.TextBox();
            this.textBoxModulus = new System.Windows.Forms.TextBox();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Key Label:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Key Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Public Exponent:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Modulus:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(168, 96);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(685, 66);
            this.textBoxId.TabIndex = 6;
            // 
            // textBoxPublicExponent
            // 
            this.textBoxPublicExponent.Location = new System.Drawing.Point(168, 177);
            this.textBoxPublicExponent.Name = "textBoxPublicExponent";
            this.textBoxPublicExponent.ReadOnly = true;
            this.textBoxPublicExponent.Size = new System.Drawing.Size(685, 22);
            this.textBoxPublicExponent.TabIndex = 7;
            // 
            // textBoxModulus
            // 
            this.textBoxModulus.Location = new System.Drawing.Point(168, 214);
            this.textBoxModulus.Multiline = true;
            this.textBoxModulus.Name = "textBoxModulus";
            this.textBoxModulus.ReadOnly = true;
            this.textBoxModulus.Size = new System.Drawing.Size(685, 135);
            this.textBoxModulus.TabIndex = 8;
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Location = new System.Drawing.Point(168, 31);
            this.textBoxLabel.Multiline = true;
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.ReadOnly = true;
            this.textBoxLabel.Size = new System.Drawing.Size(685, 46);
            this.textBoxLabel.TabIndex = 9;
            // 
            // ViewDetailKeyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 386);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.textBoxModulus);
            this.Controls.Add(this.textBoxPublicExponent);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(17, 16);
            this.MaximizeBox = false;
            this.Name = "ViewDetailKeyDialog";
            this.Text = "Private Keys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxPublicExponent;
        private System.Windows.Forms.TextBox textBoxModulus;
        private System.Windows.Forms.TextBox textBoxLabel;
    }
}
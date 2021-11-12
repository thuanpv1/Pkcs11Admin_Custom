using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Net.Pkcs11Admin.WinForms.Dialogs
{
    public partial class ViewDetailKeyDialog : Form
    {
        public ViewDetailKeyDialog(String label, String id, String publicExponent, String modulus)
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Pkcs11Admin;
            this.textBoxLabel.Text = label;
            this.textBoxId.Text = id;
            this.textBoxPublicExponent.Text = publicExponent;
            this.textBoxModulus.Text = modulus;
        }
    }
}

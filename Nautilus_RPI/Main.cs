using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nautilus_RPI
{
    public partial class Nautilus_RPI : Form
    {
        public Nautilus_RPI()
        {
            InitializeComponent();
        }

        private void txtServer_Click(object sender, EventArgs e)
        {
            this.Hide();
            KeyboardManager.keyActivation();
            txtServer.Text = KeyboardManager.textString;
            this.Show();
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            KeyboardManager.keyActivation();
            txtUsuario.Text = KeyboardManager.textString;
            this.Show();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            KeyboardManager.keyActivation();
            txtPassword.Text = KeyboardManager.textString;
            this.Show();
        }

        private void txtBase_Click(object sender, EventArgs e)
        {
            this.Hide();
            KeyboardManager.keyActivation();
            txtBase.Text = KeyboardManager.textString;
            this.Show();
        }
    }
}

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
            KeyboardManager.textField = "INTRODUZCA EL SERVIDOR";
            KeyboardManager.keyActivation();
            txtServer.Text = KeyboardManager.textString;
            this.Show();
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            KeyboardManager.textField = "INTRODUZCA EL USUARIO";
            KeyboardManager.keyActivation();
            txtUsuario.Text = KeyboardManager.textString;
            this.Show();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            KeyboardManager.textField = "INTRODUZCA LA CONTRASEÑA";
            KeyboardManager.keyActivation();
            txtPassword.Text = KeyboardManager.textString;
            this.Show();
        }

        private void txtBase_Click(object sender, EventArgs e)
        {
            this.Hide();
            KeyboardManager.textField = "INTRODUZCA LA BASE DE DATOS";
            KeyboardManager.keyActivation();
            txtBase.Text = KeyboardManager.textString;
            this.Show();
        }

        private void btnLoginConf_Click(object sender, EventArgs e)
        {
            grpConfig.Visible = true;
        }

        private void Nautilus_RPI_Load(object sender, EventArgs e)
        {
            //Check internet connection method
            checkInternet();
            checkGPS();
            checkDB();
        }


        //Function that checks the device for an internet Connection.
        private void checkInternet()
        {
            if (MonitorManager.internetAccess()== true)
            {
                lblInternet.Text = "OK";
                lblInternet.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblInternet.Text = "FALLO";
                lblInternet.ForeColor = System.Drawing.Color.Red;
            }
        }

        //function that checks GPS availability
        private void checkGPS()
        {
            if (MonitorManager.gps() == true)
            {
                lblGPS.Text = "OK";
                lblGPS.ForeColor = System.Drawing.Color.Green; 
            }
            else
            {
                lblGPS.Text = "Error en el GPS";
                lblGPS.ForeColor = System.Drawing.Color.Red;
            }
        }

        //Function that checks DataBase connectivity
        private void checkDB()
        {
            if ( MonitorManager.checkDB() == true )
            {
                lblDB.Text = "OK";
                lblDB.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblDB.Text = "No hay conexion con la base de datos";
                lblDB.ForeColor = System.Drawing.Color.Red;
            }
        }
            /// <summary>
            /// It runs the Clock
            /// </summary>
         
        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text= DateTime.Now.ToString();
        }

        private void btnTestCon_Click(object sender, EventArgs e)
        {
            if (DBManager.testConn()== true)
            {
                MessageBox.Show("Base de datos Conectada");
            }
            else
            {
                MessageBox.Show("Base de datos NO Conectada");
            }
        }
    }
}

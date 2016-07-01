namespace Nautilus_RPI
{
    partial class Nautilus_RPI
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
            this.tabConfig = new System.Windows.Forms.TabControl();
            this.tabMonitor = new System.Windows.Forms.TabPage();
            this.grpMonitor = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDataWrite = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblGPS = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblInternet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TabConfiguracion = new System.Windows.Forms.TabPage();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.btnLoginConf = new System.Windows.Forms.Button();
            this.grpConfig = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardarConfig = new System.Windows.Forms.Button();
            this.btnCancelarConfig = new System.Windows.Forms.Button();
            this.btnTestCon = new System.Windows.Forms.Button();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TabAdministracion = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.lblClock = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabConfig.SuspendLayout();
            this.tabMonitor.SuspendLayout();
            this.grpMonitor.SuspendLayout();
            this.TabConfiguracion.SuspendLayout();
            this.grpLogin.SuspendLayout();
            this.grpConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.tabMonitor);
            this.tabConfig.Controls.Add(this.TabConfiguracion);
            this.tabConfig.Controls.Add(this.TabAdministracion);
            this.tabConfig.Controls.Add(this.tabPage1);
            this.tabConfig.Location = new System.Drawing.Point(12, 12);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.SelectedIndex = 0;
            this.tabConfig.Size = new System.Drawing.Size(984, 537);
            this.tabConfig.TabIndex = 0;
            this.tabConfig.Click += new System.EventHandler(this.tabConfig_Click);
            // 
            // tabMonitor
            // 
            this.tabMonitor.Controls.Add(this.grpMonitor);
            this.tabMonitor.Location = new System.Drawing.Point(4, 22);
            this.tabMonitor.Name = "tabMonitor";
            this.tabMonitor.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonitor.Size = new System.Drawing.Size(976, 511);
            this.tabMonitor.TabIndex = 0;
            this.tabMonitor.Text = "Monitor";
            this.tabMonitor.UseVisualStyleBackColor = true;
            // 
            // grpMonitor
            // 
            this.grpMonitor.Controls.Add(this.pictureBox2);
            this.grpMonitor.Controls.Add(this.lblClock);
            this.grpMonitor.Controls.Add(this.label12);
            this.grpMonitor.Controls.Add(this.label13);
            this.grpMonitor.Controls.Add(this.lblDataWrite);
            this.grpMonitor.Controls.Add(this.label11);
            this.grpMonitor.Controls.Add(this.lblGPS);
            this.grpMonitor.Controls.Add(this.label9);
            this.grpMonitor.Controls.Add(this.lblInternet);
            this.grpMonitor.Controls.Add(this.label3);
            this.grpMonitor.Controls.Add(this.lblDB);
            this.grpMonitor.Controls.Add(this.label1);
            this.grpMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMonitor.Location = new System.Drawing.Point(7, 0);
            this.grpMonitor.Name = "grpMonitor";
            this.grpMonitor.Size = new System.Drawing.Size(963, 505);
            this.grpMonitor.TabIndex = 0;
            this.grpMonitor.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(336, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 37);
            this.label12.TabIndex = 9;
            this.label12.Text = "OK";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(279, 37);
            this.label13.TabIndex = 8;
            this.label13.Text = "Conectado a PLC:";
            // 
            // lblDataWrite
            // 
            this.lblDataWrite.AutoSize = true;
            this.lblDataWrite.Location = new System.Drawing.Point(336, 151);
            this.lblDataWrite.Name = "lblDataWrite";
            this.lblDataWrite.Size = new System.Drawing.Size(63, 37);
            this.lblDataWrite.TabIndex = 7;
            this.lblDataWrite.Text = "OK";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(290, 37);
            this.label11.TabIndex = 6;
            this.label11.Text = "Escritura de Datos:";
            // 
            // lblGPS
            // 
            this.lblGPS.AutoSize = true;
            this.lblGPS.Location = new System.Drawing.Point(336, 77);
            this.lblGPS.Name = "lblGPS";
            this.lblGPS.Size = new System.Drawing.Size(63, 37);
            this.lblGPS.TabIndex = 5;
            this.lblGPS.Text = "OK";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 37);
            this.label9.TabIndex = 4;
            this.label9.Text = "GPS:";
            // 
            // lblInternet
            // 
            this.lblInternet.AutoSize = true;
            this.lblInternet.Location = new System.Drawing.Point(336, 40);
            this.lblInternet.Name = "lblInternet";
            this.lblInternet.Size = new System.Drawing.Size(63, 37);
            this.lblInternet.TabIndex = 3;
            this.lblInternet.Text = "OK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Conectado a Internet:";
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Location = new System.Drawing.Point(336, 114);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(63, 37);
            this.lblDB.TabIndex = 1;
            this.lblDB.Text = "OK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base de Datos:";
            // 
            // TabConfiguracion
            // 
            this.TabConfiguracion.Controls.Add(this.grpLogin);
            this.TabConfiguracion.Controls.Add(this.grpConfig);
            this.TabConfiguracion.Location = new System.Drawing.Point(4, 22);
            this.TabConfiguracion.Name = "TabConfiguracion";
            this.TabConfiguracion.Padding = new System.Windows.Forms.Padding(3);
            this.TabConfiguracion.Size = new System.Drawing.Size(976, 511);
            this.TabConfiguracion.TabIndex = 1;
            this.TabConfiguracion.Text = "Configuracion";
            this.TabConfiguracion.UseVisualStyleBackColor = true;
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.btnLoginConf);
            this.grpLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogin.Location = new System.Drawing.Point(4, 4);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(966, 100);
            this.grpLogin.TabIndex = 1;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login Control";
            // 
            // btnLoginConf
            // 
            this.btnLoginConf.Location = new System.Drawing.Point(46, 28);
            this.btnLoginConf.Name = "btnLoginConf";
            this.btnLoginConf.Size = new System.Drawing.Size(127, 55);
            this.btnLoginConf.TabIndex = 1;
            this.btnLoginConf.Text = "Login";
            this.btnLoginConf.UseVisualStyleBackColor = true;
            this.btnLoginConf.Click += new System.EventHandler(this.btnLoginConf_Click);
            // 
            // grpConfig
            // 
            this.grpConfig.Controls.Add(this.pictureBox1);
            this.grpConfig.Controls.Add(this.btnGuardarConfig);
            this.grpConfig.Controls.Add(this.btnCancelarConfig);
            this.grpConfig.Controls.Add(this.btnTestCon);
            this.grpConfig.Controls.Add(this.txtBase);
            this.grpConfig.Controls.Add(this.label5);
            this.grpConfig.Controls.Add(this.txtPassword);
            this.grpConfig.Controls.Add(this.label6);
            this.grpConfig.Controls.Add(this.txtUsuario);
            this.grpConfig.Controls.Add(this.label7);
            this.grpConfig.Controls.Add(this.txtServer);
            this.grpConfig.Controls.Add(this.label8);
            this.grpConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConfig.Location = new System.Drawing.Point(6, 118);
            this.grpConfig.Name = "grpConfig";
            this.grpConfig.Size = new System.Drawing.Size(964, 390);
            this.grpConfig.TabIndex = 0;
            this.grpConfig.TabStop = false;
            this.grpConfig.Text = "Configurar Base de Datos";
            this.grpConfig.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nautilus_RPI.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(602, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 368);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuardarConfig
            // 
            this.btnGuardarConfig.Location = new System.Drawing.Point(448, 306);
            this.btnGuardarConfig.Name = "btnGuardarConfig";
            this.btnGuardarConfig.Size = new System.Drawing.Size(147, 78);
            this.btnGuardarConfig.TabIndex = 23;
            this.btnGuardarConfig.Text = "Guardar";
            this.btnGuardarConfig.UseVisualStyleBackColor = true;
            this.btnGuardarConfig.Click += new System.EventHandler(this.btnGuardarConfig_Click);
            // 
            // btnCancelarConfig
            // 
            this.btnCancelarConfig.Location = new System.Drawing.Point(295, 306);
            this.btnCancelarConfig.Name = "btnCancelarConfig";
            this.btnCancelarConfig.Size = new System.Drawing.Size(147, 78);
            this.btnCancelarConfig.TabIndex = 21;
            this.btnCancelarConfig.Text = "Cancelar";
            this.btnCancelarConfig.UseVisualStyleBackColor = true;
            // 
            // btnTestCon
            // 
            this.btnTestCon.Location = new System.Drawing.Point(148, 185);
            this.btnTestCon.Name = "btnTestCon";
            this.btnTestCon.Size = new System.Drawing.Size(447, 78);
            this.btnTestCon.TabIndex = 19;
            this.btnTestCon.Text = "Probar Conexion";
            this.btnTestCon.UseVisualStyleBackColor = true;
            this.btnTestCon.Click += new System.EventHandler(this.btnTestCon_Click);
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(148, 136);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(447, 26);
            this.txtBase.TabIndex = 18;
            this.txtBase.Click += new System.EventHandler(this.txtBase_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Base de datos";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(148, 104);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(447, 26);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(148, 72);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(447, 26);
            this.txtUsuario.TabIndex = 16;
            this.txtUsuario.Click += new System.EventHandler(this.txtUsuario_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Usuario";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(148, 39);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(447, 26);
            this.txtServer.TabIndex = 15;
            this.txtServer.Click += new System.EventHandler(this.txtServer_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Servidor";
            // 
            // TabAdministracion
            // 
            this.TabAdministracion.Location = new System.Drawing.Point(4, 22);
            this.TabAdministracion.Name = "TabAdministracion";
            this.TabAdministracion.Padding = new System.Windows.Forms.Padding(3);
            this.TabAdministracion.Size = new System.Drawing.Size(976, 511);
            this.TabAdministracion.TabIndex = 2;
            this.TabAdministracion.Text = "Administracion";
            this.TabAdministracion.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 511);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "PLC";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 500;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Location = new System.Drawing.Point(6, 465);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(102, 37);
            this.lblClock.TabIndex = 10;
            this.lblClock.Text = "label2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Nautilus_RPI.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(508, 236);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(449, 263);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Nautilus_RPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.tabConfig);
            this.Name = "Nautilus_RPI";
            this.Text = "Nautilus";
            this.Load += new System.EventHandler(this.Nautilus_RPI_Load);
            this.tabConfig.ResumeLayout(false);
            this.tabMonitor.ResumeLayout(false);
            this.grpMonitor.ResumeLayout(false);
            this.grpMonitor.PerformLayout();
            this.TabConfiguracion.ResumeLayout(false);
            this.grpLogin.ResumeLayout(false);
            this.grpConfig.ResumeLayout(false);
            this.grpConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabConfig;
        private System.Windows.Forms.TabPage tabMonitor;
        private System.Windows.Forms.TabPage TabConfiguracion;
        private System.Windows.Forms.TabPage TabAdministracion;
        private System.Windows.Forms.GroupBox grpConfig;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Button btnLoginConf;
        private System.Windows.Forms.Button btnGuardarConfig;
        private System.Windows.Forms.Button btnCancelarConfig;
        private System.Windows.Forms.Button btnTestCon;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpMonitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.Label lblInternet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGPS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblDataWrite;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


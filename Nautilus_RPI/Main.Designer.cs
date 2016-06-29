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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMonitor = new System.Windows.Forms.TabPage();
            this.TabConfiguracion = new System.Windows.Forms.TabPage();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.btnLoginConf = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardarConfig = new System.Windows.Forms.Button();
            this.btnCancelarConfig = new System.Windows.Forms.Button();
            this.btnUnlock = new System.Windows.Forms.Button();
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
            this.tabControl1.SuspendLayout();
            this.TabConfiguracion.SuspendLayout();
            this.grpLogin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMonitor);
            this.tabControl1.Controls.Add(this.TabConfiguracion);
            this.tabControl1.Controls.Add(this.TabAdministracion);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 537);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMonitor
            // 
            this.tabMonitor.Location = new System.Drawing.Point(4, 22);
            this.tabMonitor.Name = "tabMonitor";
            this.tabMonitor.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonitor.Size = new System.Drawing.Size(976, 511);
            this.tabMonitor.TabIndex = 0;
            this.tabMonitor.Text = "Monitor";
            this.tabMonitor.UseVisualStyleBackColor = true;
            // 
            // TabConfiguracion
            // 
            this.TabConfiguracion.Controls.Add(this.grpLogin);
            this.TabConfiguracion.Controls.Add(this.groupBox1);
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnGuardarConfig);
            this.groupBox1.Controls.Add(this.btnCancelarConfig);
            this.groupBox1.Controls.Add(this.btnUnlock);
            this.groupBox1.Controls.Add(this.btnTestCon);
            this.groupBox1.Controls.Add(this.txtBase);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 390);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurar Base de Datos";
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
            // btnUnlock
            // 
            this.btnUnlock.Location = new System.Drawing.Point(6, 306);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(147, 78);
            this.btnUnlock.TabIndex = 20;
            this.btnUnlock.Text = "Unlock";
            this.btnUnlock.UseVisualStyleBackColor = true;
            // 
            // btnTestCon
            // 
            this.btnTestCon.Location = new System.Drawing.Point(148, 185);
            this.btnTestCon.Name = "btnTestCon";
            this.btnTestCon.Size = new System.Drawing.Size(447, 78);
            this.btnTestCon.TabIndex = 19;
            this.btnTestCon.Text = "Probar Conexion";
            this.btnTestCon.UseVisualStyleBackColor = true;
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
            // Nautilus_RPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "Nautilus_RPI";
            this.Text = "Nautilus";
            this.tabControl1.ResumeLayout(false);
            this.TabConfiguracion.ResumeLayout(false);
            this.grpLogin.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMonitor;
        private System.Windows.Forms.TabPage TabConfiguracion;
        private System.Windows.Forms.TabPage TabAdministracion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Button btnLoginConf;
        private System.Windows.Forms.Button btnGuardarConfig;
        private System.Windows.Forms.Button btnCancelarConfig;
        private System.Windows.Forms.Button btnUnlock;
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
    }
}


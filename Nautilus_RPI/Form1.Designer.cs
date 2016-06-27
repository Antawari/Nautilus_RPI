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
            this.TabAdministracion = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
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
            this.TabConfiguracion.Location = new System.Drawing.Point(4, 22);
            this.TabConfiguracion.Name = "TabConfiguracion";
            this.TabConfiguracion.Padding = new System.Windows.Forms.Padding(3);
            this.TabConfiguracion.Size = new System.Drawing.Size(976, 511);
            this.TabConfiguracion.TabIndex = 1;
            this.TabConfiguracion.Text = "Configuracion";
            this.TabConfiguracion.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMonitor;
        private System.Windows.Forms.TabPage TabConfiguracion;
        private System.Windows.Forms.TabPage TabAdministracion;
    }
}


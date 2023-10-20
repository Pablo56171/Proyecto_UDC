namespace Proyecto_UDC
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gENERADORQRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTROALUMNOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTROMAESTROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(352, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gENERADORQRToolStripMenuItem,
            this.rEGISTROALUMNOSToolStripMenuItem,
            this.rEGISTROMAESTROSToolStripMenuItem});
            this.mENUToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(94, 31);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // gENERADORQRToolStripMenuItem
            // 
            this.gENERADORQRToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gENERADORQRToolStripMenuItem.Name = "gENERADORQRToolStripMenuItem";
            this.gENERADORQRToolStripMenuItem.Size = new System.Drawing.Size(389, 28);
            this.gENERADORQRToolStripMenuItem.Text = "GENERADOR_QR_ALUMNOS";
            this.gENERADORQRToolStripMenuItem.Click += new System.EventHandler(this.gENERADORQRToolStripMenuItem_Click);
            // 
            // rEGISTROALUMNOSToolStripMenuItem
            // 
            this.rEGISTROALUMNOSToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rEGISTROALUMNOSToolStripMenuItem.Name = "rEGISTROALUMNOSToolStripMenuItem";
            this.rEGISTROALUMNOSToolStripMenuItem.Size = new System.Drawing.Size(389, 28);
            this.rEGISTROALUMNOSToolStripMenuItem.Text = "GENERADOR_QR_MAESTROS";
            this.rEGISTROALUMNOSToolStripMenuItem.Click += new System.EventHandler(this.rEGISTROALUMNOSToolStripMenuItem_Click);
            // 
            // rEGISTROMAESTROSToolStripMenuItem
            // 
            this.rEGISTROMAESTROSToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rEGISTROMAESTROSToolStripMenuItem.Name = "rEGISTROMAESTROSToolStripMenuItem";
            this.rEGISTROMAESTROSToolStripMenuItem.Size = new System.Drawing.Size(389, 28);
            this.rEGISTROMAESTROSToolStripMenuItem.Text = "ASISTENCIA_QR";
            this.rEGISTROMAESTROSToolStripMenuItem.Click += new System.EventHandler(this.rEGISTROMAESTROSToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 246);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 273);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gENERADORQRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEGISTROALUMNOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEGISTROMAESTROSToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}


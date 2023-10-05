namespace FUNDALZHEIMER_CR
{
    partial class FrmSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSistema));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mst_SISTEMA = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mst_Registro_Codigos = new System.Windows.Forms.ToolStripMenuItem();
            this.mst_Registro_Paciente = new System.Windows.Forms.ToolStripMenuItem();
            this.mst_RegistroCuidador = new System.Windows.Forms.ToolStripMenuItem();
            this.mst_Reporte = new System.Windows.Forms.ToolStripMenuItem();
            this.eXCELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mst_SISTEMA});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mst_SISTEMA
            // 
            this.mst_SISTEMA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.mst_Reporte,
            this.reporteToolStripMenuItem});
            this.mst_SISTEMA.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mst_SISTEMA.Name = "mst_SISTEMA";
            this.mst_SISTEMA.Size = new System.Drawing.Size(87, 23);
            this.mst_SISTEMA.Text = "SISTEMA";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mst_Registro_Paciente,
            this.mst_RegistroCuidador,
            this.mst_Registro_Codigos});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.opcionesToolStripMenuItem.Text = "OPCIONES";
            // 
            // mst_Registro_Codigos
            // 
            this.mst_Registro_Codigos.Name = "mst_Registro_Codigos";
            this.mst_Registro_Codigos.Size = new System.Drawing.Size(235, 24);
            this.mst_Registro_Codigos.Text = "REGISTRO CODIGOS";
            this.mst_Registro_Codigos.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // mst_Registro_Paciente
            // 
            this.mst_Registro_Paciente.Name = "mst_Registro_Paciente";
            this.mst_Registro_Paciente.Size = new System.Drawing.Size(235, 24);
            this.mst_Registro_Paciente.Text = "REGISTRO PACIENTE";
            this.mst_Registro_Paciente.Click += new System.EventHandler(this.mst_RegistroUsuario_Click);
            // 
            // mst_RegistroCuidador
            // 
            this.mst_RegistroCuidador.Name = "mst_RegistroCuidador";
            this.mst_RegistroCuidador.Size = new System.Drawing.Size(235, 24);
            this.mst_RegistroCuidador.Text = "REGISTRO CUIDADOR";
            this.mst_RegistroCuidador.Click += new System.EventHandler(this.mst_RegistroCuidador_Click);
            // 
            // mst_Reporte
            // 
            this.mst_Reporte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSUARIOPDFToolStripMenuItem,
            this.eXCELToolStripMenuItem});
            this.mst_Reporte.Name = "mst_Reporte";
            this.mst_Reporte.Size = new System.Drawing.Size(190, 24);
            this.mst_Reporte.Text = "REPORTES PDF";
            // 
            // eXCELToolStripMenuItem
            // 
            this.eXCELToolStripMenuItem.Name = "eXCELToolStripMenuItem";
            this.eXCELToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.eXCELToolStripMenuItem.Text = "CUIDADOR PDF";
            this.eXCELToolStripMenuItem.Click += new System.EventHandler(this.eXCELToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.reporteToolStripMenuItem.Text = "SALIR";
            this.reporteToolStripMenuItem.Click += new System.EventHandler(this.reporteToolStripMenuItem_Click);
            // 
            // uSUARIOPDFToolStripMenuItem
            // 
            this.uSUARIOPDFToolStripMenuItem.Name = "uSUARIOPDFToolStripMenuItem";
            this.uSUARIOPDFToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.uSUARIOPDFToolStripMenuItem.Text = "PACIENTE PDF";
            this.uSUARIOPDFToolStripMenuItem.Click += new System.EventHandler(this.uSUARIOPDFToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FUNDALZHEIMER_CR.Properties.Resources.logo_alz;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 376);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(510, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FUNDALZHEIMER_CR.Properties.Resources.Alzheimer_2;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 396);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmSistema";
            this.Text = "SISTEMA";
            this.Load += new System.EventHandler(this.FrmSistema_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mst_SISTEMA;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mst_Registro_Paciente;
        private System.Windows.Forms.ToolStripMenuItem mst_RegistroCuidador;
        private System.Windows.Forms.ToolStripMenuItem mst_Reporte;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXCELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mst_Registro_Codigos;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOPDFToolStripMenuItem;
    }
}
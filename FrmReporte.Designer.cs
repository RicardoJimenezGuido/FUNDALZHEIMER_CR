namespace FUNDALZHEIMER_CR
{
    partial class FrmReporte
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporte));
            this.dgv_Registro_Cuidador = new System.Windows.Forms.DataGridView();
            this.lbl_CED_CUIDADOR = new System.Windows.Forms.Label();
            this.txt_CEDULA = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Reporte = new System.Windows.Forms.Label();
            this.btn_Reporte = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Registro_Cuidador)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Registro_Cuidador
            // 
            this.dgv_Registro_Cuidador.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Registro_Cuidador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Registro_Cuidador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Registro_Cuidador.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Registro_Cuidador.Location = new System.Drawing.Point(54, 153);
            this.dgv_Registro_Cuidador.Name = "dgv_Registro_Cuidador";
            this.dgv_Registro_Cuidador.Size = new System.Drawing.Size(692, 191);
            this.dgv_Registro_Cuidador.TabIndex = 42;
            // 
            // lbl_CED_CUIDADOR
            // 
            this.lbl_CED_CUIDADOR.AutoSize = true;
            this.lbl_CED_CUIDADOR.Location = new System.Drawing.Point(68, 55);
            this.lbl_CED_CUIDADOR.Name = "lbl_CED_CUIDADOR";
            this.lbl_CED_CUIDADOR.Size = new System.Drawing.Size(110, 13);
            this.lbl_CED_CUIDADOR.TabIndex = 44;
            this.lbl_CED_CUIDADOR.Text = "CEDULA CUIDADOR";
            // 
            // txt_CEDULA
            // 
            this.txt_CEDULA.AutoRoundedCorners = true;
            this.txt_CEDULA.BorderRadius = 17;
            this.txt_CEDULA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CEDULA.DefaultText = "";
            this.txt_CEDULA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_CEDULA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_CEDULA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CEDULA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CEDULA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CEDULA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CEDULA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CEDULA.Location = new System.Drawing.Point(202, 42);
            this.txt_CEDULA.Name = "txt_CEDULA";
            this.txt_CEDULA.PasswordChar = '\0';
            this.txt_CEDULA.PlaceholderText = "CEDULA CUIDADOR";
            this.txt_CEDULA.SelectedText = "";
            this.txt_CEDULA.Size = new System.Drawing.Size(200, 36);
            this.txt_CEDULA.TabIndex = 43;
            this.txt_CEDULA.TextChanged += new System.EventHandler(this.txt_CEDULA_Text_Changed_1);
            // 
            // lbl_Reporte
            // 
            this.lbl_Reporte.AutoSize = true;
            this.lbl_Reporte.Location = new System.Drawing.Point(687, 115);
            this.lbl_Reporte.Name = "lbl_Reporte";
            this.lbl_Reporte.Size = new System.Drawing.Size(59, 13);
            this.lbl_Reporte.TabIndex = 46;
            this.lbl_Reporte.Text = "REPORTE";
            // 
            // btn_Reporte
            // 
            this.btn_Reporte.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Reporte.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reporte.Image")));
            this.btn_Reporte.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Reporte.ImageRotate = 0F;
            this.btn_Reporte.Location = new System.Drawing.Point(682, 42);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Reporte.Size = new System.Drawing.Size(64, 70);
            this.btn_Reporte.TabIndex = 45;
            this.btn_Reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Reporte);
            this.Controls.Add(this.btn_Reporte);
            this.Controls.Add(this.lbl_CED_CUIDADOR);
            this.Controls.Add(this.txt_CEDULA);
            this.Controls.Add(this.dgv_Registro_Cuidador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporte";
            this.Text = "REPORTE CUIDADOR";
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Registro_Cuidador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Registro_Cuidador;
        private System.Windows.Forms.Label lbl_CED_CUIDADOR;
        private Guna.UI2.WinForms.Guna2TextBox txt_CEDULA;
        private System.Windows.Forms.Label lbl_Reporte;
        private Guna.UI2.WinForms.Guna2ImageButton btn_Reporte;
    }
}
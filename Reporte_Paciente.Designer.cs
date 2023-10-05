namespace FUNDALZHEIMER_CR
{
    partial class Reporte_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte_Usuario));
            this.lbl_Reporte = new System.Windows.Forms.Label();
            this.lbl_CEDULA_PACIENTE = new System.Windows.Forms.Label();
            this.txt_CEDULA_PACIENTE = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv_Registro_Paciente = new System.Windows.Forms.DataGridView();
            this.btn_Reporte = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Registro_Paciente)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Reporte
            // 
            this.lbl_Reporte.AutoSize = true;
            this.lbl_Reporte.Location = new System.Drawing.Point(687, 147);
            this.lbl_Reporte.Name = "lbl_Reporte";
            this.lbl_Reporte.Size = new System.Drawing.Size(59, 13);
            this.lbl_Reporte.TabIndex = 51;
            this.lbl_Reporte.Text = "REPORTE";
            // 
            // lbl_CEDULA_PACIENTE
            // 
            this.lbl_CEDULA_PACIENTE.AutoSize = true;
            this.lbl_CEDULA_PACIENTE.Location = new System.Drawing.Point(68, 87);
            this.lbl_CEDULA_PACIENTE.Name = "lbl_CEDULA_PACIENTE";
            this.lbl_CEDULA_PACIENTE.Size = new System.Drawing.Size(106, 13);
            this.lbl_CEDULA_PACIENTE.TabIndex = 49;
            this.lbl_CEDULA_PACIENTE.Text = "CEDULA PACIENTE";
            // 
            // txt_CEDULA_PACIENTE
            // 
            this.txt_CEDULA_PACIENTE.AutoRoundedCorners = true;
            this.txt_CEDULA_PACIENTE.BorderRadius = 17;
            this.txt_CEDULA_PACIENTE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CEDULA_PACIENTE.DefaultText = "";
            this.txt_CEDULA_PACIENTE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_CEDULA_PACIENTE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_CEDULA_PACIENTE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CEDULA_PACIENTE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CEDULA_PACIENTE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CEDULA_PACIENTE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CEDULA_PACIENTE.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CEDULA_PACIENTE.Location = new System.Drawing.Point(202, 74);
            this.txt_CEDULA_PACIENTE.Name = "txt_CEDULA_PACIENTE";
            this.txt_CEDULA_PACIENTE.PasswordChar = '\0';
            this.txt_CEDULA_PACIENTE.PlaceholderText = "CEDULA PACIENTE";
            this.txt_CEDULA_PACIENTE.SelectedText = "";
            this.txt_CEDULA_PACIENTE.Size = new System.Drawing.Size(200, 36);
            this.txt_CEDULA_PACIENTE.TabIndex = 48;
            this.txt_CEDULA_PACIENTE.TextChanged += new System.EventHandler(this.txt_CEDULA_PACIENTE_TextChanged);
            // 
            // dgv_Registro_Paciente
            // 
            this.dgv_Registro_Paciente.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Registro_Paciente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Registro_Paciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Registro_Paciente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Registro_Paciente.Location = new System.Drawing.Point(54, 185);
            this.dgv_Registro_Paciente.Name = "dgv_Registro_Paciente";
            this.dgv_Registro_Paciente.Size = new System.Drawing.Size(692, 191);
            this.dgv_Registro_Paciente.TabIndex = 47;
            // 
            // btn_Reporte
            // 
            this.btn_Reporte.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Reporte.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reporte.Image")));
            this.btn_Reporte.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Reporte.ImageRotate = 0F;
            this.btn_Reporte.Location = new System.Drawing.Point(682, 74);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Reporte.Size = new System.Drawing.Size(64, 70);
            this.btn_Reporte.TabIndex = 50;
            this.btn_Reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
            // 
            // Reporte_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Reporte);
            this.Controls.Add(this.btn_Reporte);
            this.Controls.Add(this.lbl_CEDULA_PACIENTE);
            this.Controls.Add(this.txt_CEDULA_PACIENTE);
            this.Controls.Add(this.dgv_Registro_Paciente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reporte_Usuario";
            this.Text = "REPORTE PACIENTE";
            this.Load += new System.EventHandler(this.Reporte_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Registro_Paciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Reporte;
        private Guna.UI2.WinForms.Guna2ImageButton btn_Reporte;
        private System.Windows.Forms.Label lbl_CEDULA_PACIENTE;
        private Guna.UI2.WinForms.Guna2TextBox txt_CEDULA_PACIENTE;
        private System.Windows.Forms.DataGridView dgv_Registro_Paciente;
    }
}
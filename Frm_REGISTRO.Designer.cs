namespace FUNDALZHEIMER_CR
{
    partial class Frm_REGISTRO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_REGISTRO));
            this.lbl_Editar = new System.Windows.Forms.Label();
            this.lbl_Eliminar = new System.Windows.Forms.Label();
            this.lbl_Registrar = new System.Windows.Forms.Label();
            this.dgv_Registro = new System.Windows.Forms.DataGridView();
            this.lbl_FEC_REGISTRO = new System.Windows.Forms.Label();
            this.lbl_COD_ESTADO = new System.Windows.Forms.Label();
            this.lbl_ID_PARENTESCO = new System.Windows.Forms.Label();
            this.lbl_CEDULA = new System.Windows.Forms.Label();
            this.lbl_COD_USUARIO = new System.Windows.Forms.Label();
            this.datipi_FEC_REGISTRO = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_COD_ESTADO = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_ID_PARENTESCO = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_CEDULA = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_COD_USUARIO = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_CONSECUTIVO = new System.Windows.Forms.Label();
            this.txt_CONSECUTIVO = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Editar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_Eliminar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_Registrar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lbl_ID_ENFERMEDAD = new System.Windows.Forms.Label();
            this.txt_ID_ENFERMEDAD = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_COD_MEDICAMENTO = new System.Windows.Forms.Label();
            this.txt_COD_MEDICAMENTO = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_COD_TERAPIA = new System.Windows.Forms.Label();
            this.txt_COD_TERAPIA = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_NOTA = new System.Windows.Forms.Label();
            this.txt_NOTA = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_CED_CUIDADOR = new System.Windows.Forms.Label();
            this.txt_CED_CUIDADOR = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Registro)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Editar
            // 
            this.lbl_Editar.AutoSize = true;
            this.lbl_Editar.Location = new System.Drawing.Point(780, 182);
            this.lbl_Editar.Name = "lbl_Editar";
            this.lbl_Editar.Size = new System.Drawing.Size(47, 13);
            this.lbl_Editar.TabIndex = 51;
            this.lbl_Editar.Text = "EDITAR";
            // 
            // lbl_Eliminar
            // 
            this.lbl_Eliminar.AutoSize = true;
            this.lbl_Eliminar.Location = new System.Drawing.Point(780, 278);
            this.lbl_Eliminar.Name = "lbl_Eliminar";
            this.lbl_Eliminar.Size = new System.Drawing.Size(58, 13);
            this.lbl_Eliminar.TabIndex = 49;
            this.lbl_Eliminar.Text = "ELIMINAR";
            // 
            // lbl_Registrar
            // 
            this.lbl_Registrar.AutoSize = true;
            this.lbl_Registrar.Location = new System.Drawing.Point(771, 82);
            this.lbl_Registrar.Name = "lbl_Registrar";
            this.lbl_Registrar.Size = new System.Drawing.Size(70, 13);
            this.lbl_Registrar.TabIndex = 45;
            this.lbl_Registrar.Text = "REGISTRAR";
            // 
            // dgv_Registro
            // 
            this.dgv_Registro.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Registro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Registro.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Registro.Location = new System.Drawing.Point(28, 332);
            this.dgv_Registro.Name = "dgv_Registro";
            this.dgv_Registro.Size = new System.Drawing.Size(688, 150);
            this.dgv_Registro.TabIndex = 43;
            this.dgv_Registro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Registro_CellClick);
            // 
            // lbl_FEC_REGISTRO
            // 
            this.lbl_FEC_REGISTRO.AutoSize = true;
            this.lbl_FEC_REGISTRO.Location = new System.Drawing.Point(22, 256);
            this.lbl_FEC_REGISTRO.Name = "lbl_FEC_REGISTRO";
            this.lbl_FEC_REGISTRO.Size = new System.Drawing.Size(101, 13);
            this.lbl_FEC_REGISTRO.TabIndex = 42;
            this.lbl_FEC_REGISTRO.Text = "FECHA REGISTRO";
            // 
            // lbl_COD_ESTADO
            // 
            this.lbl_COD_ESTADO.AutoSize = true;
            this.lbl_COD_ESTADO.Location = new System.Drawing.Point(382, 160);
            this.lbl_COD_ESTADO.Name = "lbl_COD_ESTADO";
            this.lbl_COD_ESTADO.Size = new System.Drawing.Size(96, 13);
            this.lbl_COD_ESTADO.TabIndex = 41;
            this.lbl_COD_ESTADO.Text = "CODIGO ESTADO";
            // 
            // lbl_ID_PARENTESCO
            // 
            this.lbl_ID_PARENTESCO.AutoSize = true;
            this.lbl_ID_PARENTESCO.Location = new System.Drawing.Point(382, 212);
            this.lbl_ID_PARENTESCO.Name = "lbl_ID_PARENTESCO";
            this.lbl_ID_PARENTESCO.Size = new System.Drawing.Size(94, 13);
            this.lbl_ID_PARENTESCO.TabIndex = 40;
            this.lbl_ID_PARENTESCO.Text = "ID PARENTESCO";
            // 
            // lbl_CEDULA
            // 
            this.lbl_CEDULA.AutoSize = true;
            this.lbl_CEDULA.Location = new System.Drawing.Point(24, 59);
            this.lbl_CEDULA.Name = "lbl_CEDULA";
            this.lbl_CEDULA.Size = new System.Drawing.Size(50, 13);
            this.lbl_CEDULA.TabIndex = 36;
            this.lbl_CEDULA.Text = "CÉDULA";
            // 
            // lbl_COD_USUARIO
            // 
            this.lbl_COD_USUARIO.AutoSize = true;
            this.lbl_COD_USUARIO.Location = new System.Drawing.Point(386, 112);
            this.lbl_COD_USUARIO.Name = "lbl_COD_USUARIO";
            this.lbl_COD_USUARIO.Size = new System.Drawing.Size(101, 13);
            this.lbl_COD_USUARIO.TabIndex = 35;
            this.lbl_COD_USUARIO.Text = "CODIGO USUARIO";
            // 
            // datipi_FEC_REGISTRO
            // 
            this.datipi_FEC_REGISTRO.AutoRoundedCorners = true;
            this.datipi_FEC_REGISTRO.BorderRadius = 17;
            this.datipi_FEC_REGISTRO.Checked = true;
            this.datipi_FEC_REGISTRO.FillColor = System.Drawing.Color.Aqua;
            this.datipi_FEC_REGISTRO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datipi_FEC_REGISTRO.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datipi_FEC_REGISTRO.Location = new System.Drawing.Point(154, 250);
            this.datipi_FEC_REGISTRO.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datipi_FEC_REGISTRO.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datipi_FEC_REGISTRO.Name = "datipi_FEC_REGISTRO";
            this.datipi_FEC_REGISTRO.Size = new System.Drawing.Size(200, 36);
            this.datipi_FEC_REGISTRO.TabIndex = 34;
            this.datipi_FEC_REGISTRO.Value = new System.DateTime(2023, 6, 21, 20, 47, 48, 25);
            // 
            // txt_COD_ESTADO
            // 
            this.txt_COD_ESTADO.AutoRoundedCorners = true;
            this.txt_COD_ESTADO.BorderRadius = 17;
            this.txt_COD_ESTADO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_COD_ESTADO.DefaultText = "";
            this.txt_COD_ESTADO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_COD_ESTADO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_COD_ESTADO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_COD_ESTADO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_COD_ESTADO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_COD_ESTADO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_COD_ESTADO.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_COD_ESTADO.Location = new System.Drawing.Point(516, 155);
            this.txt_COD_ESTADO.Name = "txt_COD_ESTADO";
            this.txt_COD_ESTADO.PasswordChar = '\0';
            this.txt_COD_ESTADO.PlaceholderText = "CODIGO ESTADO";
            this.txt_COD_ESTADO.SelectedText = "";
            this.txt_COD_ESTADO.Size = new System.Drawing.Size(200, 36);
            this.txt_COD_ESTADO.TabIndex = 33;
            // 
            // txt_ID_PARENTESCO
            // 
            this.txt_ID_PARENTESCO.AutoRoundedCorners = true;
            this.txt_ID_PARENTESCO.BorderRadius = 17;
            this.txt_ID_PARENTESCO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ID_PARENTESCO.DefaultText = "";
            this.txt_ID_PARENTESCO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ID_PARENTESCO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ID_PARENTESCO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ID_PARENTESCO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ID_PARENTESCO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ID_PARENTESCO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ID_PARENTESCO.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ID_PARENTESCO.Location = new System.Drawing.Point(516, 205);
            this.txt_ID_PARENTESCO.Name = "txt_ID_PARENTESCO";
            this.txt_ID_PARENTESCO.PasswordChar = '\0';
            this.txt_ID_PARENTESCO.PlaceholderText = "ID PARENTESCO";
            this.txt_ID_PARENTESCO.SelectedText = "";
            this.txt_ID_PARENTESCO.Size = new System.Drawing.Size(200, 36);
            this.txt_ID_PARENTESCO.TabIndex = 32;
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
            this.txt_CEDULA.Location = new System.Drawing.Point(154, 54);
            this.txt_CEDULA.Name = "txt_CEDULA";
            this.txt_CEDULA.PasswordChar = '\0';
            this.txt_CEDULA.PlaceholderText = "CÉDULA";
            this.txt_CEDULA.SelectedText = "";
            this.txt_CEDULA.Size = new System.Drawing.Size(200, 36);
            this.txt_CEDULA.TabIndex = 28;
            this.txt_CEDULA.TextChanged += new System.EventHandler(this.txt_CEDULA_TextChanged_1);
            // 
            // txt_COD_USUARIO
            // 
            this.txt_COD_USUARIO.AutoRoundedCorners = true;
            this.txt_COD_USUARIO.BorderRadius = 17;
            this.txt_COD_USUARIO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_COD_USUARIO.DefaultText = "";
            this.txt_COD_USUARIO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_COD_USUARIO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_COD_USUARIO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_COD_USUARIO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_COD_USUARIO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_COD_USUARIO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_COD_USUARIO.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_COD_USUARIO.Location = new System.Drawing.Point(516, 107);
            this.txt_COD_USUARIO.Name = "txt_COD_USUARIO";
            this.txt_COD_USUARIO.PasswordChar = '\0';
            this.txt_COD_USUARIO.PlaceholderText = "CODIGO USUARIO";
            this.txt_COD_USUARIO.SelectedText = "";
            this.txt_COD_USUARIO.Size = new System.Drawing.Size(200, 36);
            this.txt_COD_USUARIO.TabIndex = 27;
            // 
            // lbl_CONSECUTIVO
            // 
            this.lbl_CONSECUTIVO.AutoSize = true;
            this.lbl_CONSECUTIVO.Location = new System.Drawing.Point(24, 13);
            this.lbl_CONSECUTIVO.Name = "lbl_CONSECUTIVO";
            this.lbl_CONSECUTIVO.Size = new System.Drawing.Size(84, 13);
            this.lbl_CONSECUTIVO.TabIndex = 53;
            this.lbl_CONSECUTIVO.Text = "CONSECUTIVO";
            // 
            // txt_CONSECUTIVO
            // 
            this.txt_CONSECUTIVO.AutoRoundedCorners = true;
            this.txt_CONSECUTIVO.BorderRadius = 17;
            this.txt_CONSECUTIVO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CONSECUTIVO.DefaultText = "";
            this.txt_CONSECUTIVO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_CONSECUTIVO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_CONSECUTIVO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CONSECUTIVO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CONSECUTIVO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CONSECUTIVO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CONSECUTIVO.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CONSECUTIVO.Location = new System.Drawing.Point(154, 8);
            this.txt_CONSECUTIVO.Name = "txt_CONSECUTIVO";
            this.txt_CONSECUTIVO.PasswordChar = '\0';
            this.txt_CONSECUTIVO.PlaceholderText = "CONSECUTIVO";
            this.txt_CONSECUTIVO.SelectedText = "";
            this.txt_CONSECUTIVO.Size = new System.Drawing.Size(200, 36);
            this.txt_CONSECUTIVO.TabIndex = 52;
            // 
            // btn_Editar
            // 
            this.btn_Editar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Editar.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Editar.Image")));
            this.btn_Editar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Editar.ImageRotate = 0F;
            this.btn_Editar.Location = new System.Drawing.Point(774, 109);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Editar.Size = new System.Drawing.Size(64, 70);
            this.btn_Editar.TabIndex = 50;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Eliminar.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.Image")));
            this.btn_Eliminar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Eliminar.ImageRotate = 0F;
            this.btn_Eliminar.Location = new System.Drawing.Point(774, 205);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Eliminar.Size = new System.Drawing.Size(64, 70);
            this.btn_Eliminar.TabIndex = 48;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Registrar.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Registrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Registrar.Image")));
            this.btn_Registrar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Registrar.ImageRotate = 0F;
            this.btn_Registrar.Location = new System.Drawing.Point(774, 9);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Registrar.Size = new System.Drawing.Size(64, 70);
            this.btn_Registrar.TabIndex = 44;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // lbl_ID_ENFERMEDAD
            // 
            this.lbl_ID_ENFERMEDAD.AutoSize = true;
            this.lbl_ID_ENFERMEDAD.Location = new System.Drawing.Point(24, 109);
            this.lbl_ID_ENFERMEDAD.Name = "lbl_ID_ENFERMEDAD";
            this.lbl_ID_ENFERMEDAD.Size = new System.Drawing.Size(96, 13);
            this.lbl_ID_ENFERMEDAD.TabIndex = 55;
            this.lbl_ID_ENFERMEDAD.Text = "ID ENFERMEDAD";
            // 
            // txt_ID_ENFERMEDAD
            // 
            this.txt_ID_ENFERMEDAD.AutoRoundedCorners = true;
            this.txt_ID_ENFERMEDAD.BorderRadius = 17;
            this.txt_ID_ENFERMEDAD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ID_ENFERMEDAD.DefaultText = "";
            this.txt_ID_ENFERMEDAD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ID_ENFERMEDAD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ID_ENFERMEDAD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ID_ENFERMEDAD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ID_ENFERMEDAD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ID_ENFERMEDAD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ID_ENFERMEDAD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ID_ENFERMEDAD.Location = new System.Drawing.Point(154, 104);
            this.txt_ID_ENFERMEDAD.Name = "txt_ID_ENFERMEDAD";
            this.txt_ID_ENFERMEDAD.PasswordChar = '\0';
            this.txt_ID_ENFERMEDAD.PlaceholderText = "ID_ENFERMEDAD";
            this.txt_ID_ENFERMEDAD.SelectedText = "";
            this.txt_ID_ENFERMEDAD.Size = new System.Drawing.Size(200, 36);
            this.txt_ID_ENFERMEDAD.TabIndex = 54;
            // 
            // lbl_COD_MEDICAMENTO
            // 
            this.lbl_COD_MEDICAMENTO.AutoSize = true;
            this.lbl_COD_MEDICAMENTO.Location = new System.Drawing.Point(24, 157);
            this.lbl_COD_MEDICAMENTO.Name = "lbl_COD_MEDICAMENTO";
            this.lbl_COD_MEDICAMENTO.Size = new System.Drawing.Size(132, 13);
            this.lbl_COD_MEDICAMENTO.TabIndex = 57;
            this.lbl_COD_MEDICAMENTO.Text = "CODIGO MEDICAMENTO";
            // 
            // txt_COD_MEDICAMENTO
            // 
            this.txt_COD_MEDICAMENTO.AutoRoundedCorners = true;
            this.txt_COD_MEDICAMENTO.BorderRadius = 17;
            this.txt_COD_MEDICAMENTO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_COD_MEDICAMENTO.DefaultText = "";
            this.txt_COD_MEDICAMENTO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_COD_MEDICAMENTO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_COD_MEDICAMENTO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_COD_MEDICAMENTO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_COD_MEDICAMENTO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_COD_MEDICAMENTO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_COD_MEDICAMENTO.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_COD_MEDICAMENTO.Location = new System.Drawing.Point(154, 152);
            this.txt_COD_MEDICAMENTO.Name = "txt_COD_MEDICAMENTO";
            this.txt_COD_MEDICAMENTO.PasswordChar = '\0';
            this.txt_COD_MEDICAMENTO.PlaceholderText = "CODIGO MEDICAMENTO";
            this.txt_COD_MEDICAMENTO.SelectedText = "";
            this.txt_COD_MEDICAMENTO.Size = new System.Drawing.Size(200, 36);
            this.txt_COD_MEDICAMENTO.TabIndex = 56;
            // 
            // lbl_COD_TERAPIA
            // 
            this.lbl_COD_TERAPIA.AutoSize = true;
            this.lbl_COD_TERAPIA.Location = new System.Drawing.Point(24, 205);
            this.lbl_COD_TERAPIA.Name = "lbl_COD_TERAPIA";
            this.lbl_COD_TERAPIA.Size = new System.Drawing.Size(98, 13);
            this.lbl_COD_TERAPIA.TabIndex = 59;
            this.lbl_COD_TERAPIA.Text = "CODIGO TERAPIA";
            // 
            // txt_COD_TERAPIA
            // 
            this.txt_COD_TERAPIA.AutoRoundedCorners = true;
            this.txt_COD_TERAPIA.BorderRadius = 17;
            this.txt_COD_TERAPIA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_COD_TERAPIA.DefaultText = "";
            this.txt_COD_TERAPIA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_COD_TERAPIA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_COD_TERAPIA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_COD_TERAPIA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_COD_TERAPIA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_COD_TERAPIA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_COD_TERAPIA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_COD_TERAPIA.Location = new System.Drawing.Point(154, 200);
            this.txt_COD_TERAPIA.Name = "txt_COD_TERAPIA";
            this.txt_COD_TERAPIA.PasswordChar = '\0';
            this.txt_COD_TERAPIA.PlaceholderText = "CODIGO TERAPIA";
            this.txt_COD_TERAPIA.SelectedText = "";
            this.txt_COD_TERAPIA.Size = new System.Drawing.Size(200, 36);
            this.txt_COD_TERAPIA.TabIndex = 58;
            // 
            // lbl_NOTA
            // 
            this.lbl_NOTA.AutoSize = true;
            this.lbl_NOTA.Location = new System.Drawing.Point(386, 16);
            this.lbl_NOTA.Name = "lbl_NOTA";
            this.lbl_NOTA.Size = new System.Drawing.Size(37, 13);
            this.lbl_NOTA.TabIndex = 61;
            this.lbl_NOTA.Text = "NOTA";
            // 
            // txt_NOTA
            // 
            this.txt_NOTA.AutoRoundedCorners = true;
            this.txt_NOTA.BorderRadius = 17;
            this.txt_NOTA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NOTA.DefaultText = "";
            this.txt_NOTA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_NOTA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_NOTA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NOTA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NOTA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NOTA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_NOTA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NOTA.Location = new System.Drawing.Point(516, 9);
            this.txt_NOTA.Name = "txt_NOTA";
            this.txt_NOTA.PasswordChar = '\0';
            this.txt_NOTA.PlaceholderText = "NOTA";
            this.txt_NOTA.SelectedText = "";
            this.txt_NOTA.Size = new System.Drawing.Size(200, 36);
            this.txt_NOTA.TabIndex = 60;
            // 
            // lbl_CED_CUIDADOR
            // 
            this.lbl_CED_CUIDADOR.AutoSize = true;
            this.lbl_CED_CUIDADOR.Location = new System.Drawing.Point(382, 72);
            this.lbl_CED_CUIDADOR.Name = "lbl_CED_CUIDADOR";
            this.lbl_CED_CUIDADOR.Size = new System.Drawing.Size(110, 13);
            this.lbl_CED_CUIDADOR.TabIndex = 63;
            this.lbl_CED_CUIDADOR.Text = "CEDULA CUIDADOR";
            // 
            // txt_CED_CUIDADOR
            // 
            this.txt_CED_CUIDADOR.AutoRoundedCorners = true;
            this.txt_CED_CUIDADOR.BorderRadius = 17;
            this.txt_CED_CUIDADOR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CED_CUIDADOR.DefaultText = "";
            this.txt_CED_CUIDADOR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_CED_CUIDADOR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_CED_CUIDADOR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CED_CUIDADOR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CED_CUIDADOR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CED_CUIDADOR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CED_CUIDADOR.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CED_CUIDADOR.Location = new System.Drawing.Point(516, 59);
            this.txt_CED_CUIDADOR.Name = "txt_CED_CUIDADOR";
            this.txt_CED_CUIDADOR.PasswordChar = '\0';
            this.txt_CED_CUIDADOR.PlaceholderText = "CEDULA CUIDADOR";
            this.txt_CED_CUIDADOR.SelectedText = "";
            this.txt_CED_CUIDADOR.Size = new System.Drawing.Size(200, 36);
            this.txt_CED_CUIDADOR.TabIndex = 62;
            // 
            // Frm_REGISTRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(863, 513);
            this.Controls.Add(this.lbl_CED_CUIDADOR);
            this.Controls.Add(this.txt_CED_CUIDADOR);
            this.Controls.Add(this.lbl_NOTA);
            this.Controls.Add(this.txt_NOTA);
            this.Controls.Add(this.lbl_COD_TERAPIA);
            this.Controls.Add(this.txt_COD_TERAPIA);
            this.Controls.Add(this.lbl_COD_MEDICAMENTO);
            this.Controls.Add(this.txt_COD_MEDICAMENTO);
            this.Controls.Add(this.lbl_ID_ENFERMEDAD);
            this.Controls.Add(this.txt_ID_ENFERMEDAD);
            this.Controls.Add(this.lbl_CONSECUTIVO);
            this.Controls.Add(this.txt_CONSECUTIVO);
            this.Controls.Add(this.lbl_Editar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.lbl_Eliminar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.lbl_Registrar);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.dgv_Registro);
            this.Controls.Add(this.lbl_FEC_REGISTRO);
            this.Controls.Add(this.lbl_COD_ESTADO);
            this.Controls.Add(this.lbl_ID_PARENTESCO);
            this.Controls.Add(this.lbl_CEDULA);
            this.Controls.Add(this.lbl_COD_USUARIO);
            this.Controls.Add(this.datipi_FEC_REGISTRO);
            this.Controls.Add(this.txt_COD_ESTADO);
            this.Controls.Add(this.txt_ID_PARENTESCO);
            this.Controls.Add(this.txt_CEDULA);
            this.Controls.Add(this.txt_COD_USUARIO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_REGISTRO";
            this.Text = "REGISTRO";
            this.Load += new System.EventHandler(this.Frm_REGISTRO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Registro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Editar;
        private Guna.UI2.WinForms.Guna2ImageButton btn_Editar;
        private System.Windows.Forms.Label lbl_Eliminar;
        private Guna.UI2.WinForms.Guna2ImageButton btn_Eliminar;
        private System.Windows.Forms.Label lbl_Registrar;
        private Guna.UI2.WinForms.Guna2ImageButton btn_Registrar;
        private System.Windows.Forms.DataGridView dgv_Registro;
        private System.Windows.Forms.Label lbl_FEC_REGISTRO;
        private System.Windows.Forms.Label lbl_COD_ESTADO;
        private System.Windows.Forms.Label lbl_ID_PARENTESCO;
        private System.Windows.Forms.Label lbl_CEDULA;
        private System.Windows.Forms.Label lbl_COD_USUARIO;
        private Guna.UI2.WinForms.Guna2DateTimePicker datipi_FEC_REGISTRO;
        private Guna.UI2.WinForms.Guna2TextBox txt_COD_ESTADO;
        private Guna.UI2.WinForms.Guna2TextBox txt_ID_PARENTESCO;
        private Guna.UI2.WinForms.Guna2TextBox txt_CEDULA;
        private Guna.UI2.WinForms.Guna2TextBox txt_COD_USUARIO;
        private System.Windows.Forms.Label lbl_CONSECUTIVO;
        private Guna.UI2.WinForms.Guna2TextBox txt_CONSECUTIVO;
        private System.Windows.Forms.Label lbl_ID_ENFERMEDAD;
        private Guna.UI2.WinForms.Guna2TextBox txt_ID_ENFERMEDAD;
        private System.Windows.Forms.Label lbl_COD_MEDICAMENTO;
        private Guna.UI2.WinForms.Guna2TextBox txt_COD_MEDICAMENTO;
        private System.Windows.Forms.Label lbl_COD_TERAPIA;
        private Guna.UI2.WinForms.Guna2TextBox txt_COD_TERAPIA;
        private System.Windows.Forms.Label lbl_NOTA;
        private Guna.UI2.WinForms.Guna2TextBox txt_NOTA;
        private System.Windows.Forms.Label lbl_CED_CUIDADOR;
        private Guna.UI2.WinForms.Guna2TextBox txt_CED_CUIDADOR;
    }
}
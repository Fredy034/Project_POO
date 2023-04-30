namespace PawsInn.Formularios
{
    partial class frmMascota
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMascota));
            this.cmbTipoMascota = new System.Windows.Forms.ComboBox();
            this.cmbRaza = new System.Windows.Forms.ComboBox();
            this.dtgVacuna = new System.Windows.Forms.DataGridView();
            this.pcbMascota = new System.Windows.Forms.PictureBox();
            this.tltFotoMascota = new System.Windows.Forms.ToolTip(this.components);
            this.dlgFotoMascota = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.Label();
            this.btnPrimero = new FontAwesome.Sharp.IconButton();
            this.btnAnterior = new FontAwesome.Sharp.IconButton();
            this.btnSiguiente = new FontAwesome.Sharp.IconButton();
            this.btnUltimo = new FontAwesome.Sharp.IconButton();
            this.tltBotones = new System.Windows.Forms.ToolTip(this.components);
            this.btnConsultar = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnIngresar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCondicion = new PawsInn.Componentes.Custom_TextBox();
            this.txtPeso = new PawsInn.Componentes.Custom_TextBox();
            this.txtEdad = new PawsInn.Componentes.Custom_TextBox();
            this.txtNombreM = new PawsInn.Componentes.Custom_TextBox();
            this.txtPropietario = new PawsInn.Componentes.Custom_TextBox();
            this.txtCedula = new PawsInn.Componentes.Custom_TextBox();
            this.custom_Button1 = new PawsInn.Componentes.Custom_Button();
            this.Elegir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVacuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMascota)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTipoMascota
            // 
            this.cmbTipoMascota.BackColor = System.Drawing.Color.LightGray;
            this.cmbTipoMascota.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbTipoMascota.Enabled = false;
            this.cmbTipoMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoMascota.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoMascota.FormattingEnabled = true;
            this.cmbTipoMascota.Location = new System.Drawing.Point(10, 485);
            this.cmbTipoMascota.Name = "cmbTipoMascota";
            this.cmbTipoMascota.Size = new System.Drawing.Size(564, 51);
            this.cmbTipoMascota.TabIndex = 4;
            this.cmbTipoMascota.SelectedIndexChanged += new System.EventHandler(this.cmbTipoMascota_SelectedIndexChanged);
            this.cmbTipoMascota.Leave += new System.EventHandler(this.cmbTipoMascota_Leave);
            // 
            // cmbRaza
            // 
            this.cmbRaza.BackColor = System.Drawing.Color.LightGray;
            this.cmbRaza.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbRaza.Enabled = false;
            this.cmbRaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRaza.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRaza.FormattingEnabled = true;
            this.cmbRaza.Location = new System.Drawing.Point(10, 536);
            this.cmbRaza.Name = "cmbRaza";
            this.cmbRaza.Size = new System.Drawing.Size(564, 51);
            this.cmbRaza.TabIndex = 5;
            // 
            // dtgVacuna
            // 
            this.dtgVacuna.AllowUserToAddRows = false;
            this.dtgVacuna.AllowUserToDeleteRows = false;
            this.dtgVacuna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtgVacuna.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtgVacuna.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgVacuna.ColumnHeadersHeight = 40;
            this.dtgVacuna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Elegir});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgVacuna.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgVacuna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgVacuna.Enabled = false;
            this.dtgVacuna.Location = new System.Drawing.Point(10, 587);
            this.dtgVacuna.Name = "dtgVacuna";
            this.dtgVacuna.RowHeadersVisible = false;
            this.dtgVacuna.RowHeadersWidth = 62;
            this.dtgVacuna.RowTemplate.Height = 28;
            this.dtgVacuna.Size = new System.Drawing.Size(564, 210);
            this.dtgVacuna.TabIndex = 6;
            // 
            // pcbMascota
            // 
            this.pcbMascota.Enabled = false;
            this.pcbMascota.Image = ((System.Drawing.Image)(resources.GetObject("pcbMascota.Image")));
            this.pcbMascota.Location = new System.Drawing.Point(621, 67);
            this.pcbMascota.Name = "pcbMascota";
            this.pcbMascota.Size = new System.Drawing.Size(534, 526);
            this.pcbMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMascota.TabIndex = 9;
            this.pcbMascota.TabStop = false;
            this.tltFotoMascota.SetToolTip(this.pcbMascota, "Doble clic para aregar una foto");
            this.pcbMascota.DoubleClick += new System.EventHandler(this.pcbMascota_DoubleClick);
            // 
            // tltFotoMascota
            // 
            this.tltFotoMascota.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tltFotoMascota.ToolTipTitle = "Foto de Mascota";
            // 
            // dlgFotoMascota
            // 
            this.dlgFotoMascota.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(616, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Foto de la Mascota";
            // 
            // txtRuta
            // 
            this.txtRuta.AutoSize = true;
            this.txtRuta.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(882, 35);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(0, 21);
            this.txtRuta.TabIndex = 11;
            this.txtRuta.Visible = false;
            // 
            // btnPrimero
            // 
            this.btnPrimero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnPrimero.FlatAppearance.BorderSize = 0;
            this.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimero.IconChar = FontAwesome.Sharp.IconChar.BackwardFast;
            this.btnPrimero.IconColor = System.Drawing.Color.White;
            this.btnPrimero.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrimero.IconSize = 50;
            this.btnPrimero.Location = new System.Drawing.Point(783, 621);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(50, 50);
            this.btnPrimero.TabIndex = 12;
            this.tltBotones.SetToolTip(this.btnPrimero, "Primero");
            this.btnPrimero.UseVisualStyleBackColor = false;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            this.btnAnterior.IconColor = System.Drawing.Color.White;
            this.btnAnterior.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnterior.IconSize = 50;
            this.btnAnterior.Location = new System.Drawing.Point(839, 621);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(50, 50);
            this.btnAnterior.TabIndex = 13;
            this.tltBotones.SetToolTip(this.btnAnterior, "Anterior");
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.IconChar = FontAwesome.Sharp.IconChar.ForwardStep;
            this.btnSiguiente.IconColor = System.Drawing.Color.White;
            this.btnSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSiguiente.IconSize = 50;
            this.btnSiguiente.Location = new System.Drawing.Point(895, 621);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(50, 50);
            this.btnSiguiente.TabIndex = 14;
            this.tltBotones.SetToolTip(this.btnSiguiente, "Siguiente");
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnUltimo.FlatAppearance.BorderSize = 0;
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo.IconChar = FontAwesome.Sharp.IconChar.FastForward;
            this.btnUltimo.IconColor = System.Drawing.Color.White;
            this.btnUltimo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUltimo.IconSize = 50;
            this.btnUltimo.Location = new System.Drawing.Point(951, 621);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(50, 50);
            this.btnUltimo.TabIndex = 15;
            this.tltBotones.SetToolTip(this.btnUltimo, "Último");
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnConsultar.IconColor = System.Drawing.Color.White;
            this.btnConsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultar.IconSize = 50;
            this.btnConsultar.Location = new System.Drawing.Point(727, 677);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(50, 50);
            this.btnConsultar.TabIndex = 16;
            this.tltBotones.SetToolTip(this.btnConsultar, "Consultar");
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnModificar.IconColor = System.Drawing.Color.White;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.IconSize = 50;
            this.btnModificar.Location = new System.Drawing.Point(783, 677);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(50, 50);
            this.btnModificar.TabIndex = 17;
            this.tltBotones.SetToolTip(this.btnModificar, "Modificar");
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnIngresar.IconColor = System.Drawing.Color.White;
            this.btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngresar.IconSize = 50;
            this.btnIngresar.Location = new System.Drawing.Point(839, 677);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(50, 50);
            this.btnIngresar.TabIndex = 18;
            this.tltBotones.SetToolTip(this.btnIngresar, "Ingresar");
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 50;
            this.btnEliminar.Location = new System.Drawing.Point(895, 677);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(50, 50);
            this.btnEliminar.TabIndex = 19;
            this.tltBotones.SetToolTip(this.btnEliminar, "Eliminar");
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 50;
            this.btnGuardar.Location = new System.Drawing.Point(951, 677);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 50);
            this.btnGuardar.TabIndex = 20;
            this.tltBotones.SetToolTip(this.btnGuardar, "Guardar");
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 50;
            this.btnSalir.Location = new System.Drawing.Point(1007, 677);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 50);
            this.btnSalir.TabIndex = 21;
            this.tltBotones.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgVacuna);
            this.panel1.Controls.Add(this.cmbRaza);
            this.panel1.Controls.Add(this.cmbTipoMascota);
            this.panel1.Controls.Add(this.txtCondicion);
            this.panel1.Controls.Add(this.txtPeso);
            this.panel1.Controls.Add(this.txtEdad);
            this.panel1.Controls.Add(this.txtNombreM);
            this.panel1.Controls.Add(this.txtPropietario);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(584, 807);
            this.panel1.TabIndex = 22;
            // 
            // txtCondicion
            // 
            this.txtCondicion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCondicion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.txtCondicion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtCondicion.BorderRadius = 0;
            this.txtCondicion.BorderSize = 2;
            this.txtCondicion.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCondicion.Enabled = false;
            this.txtCondicion.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondicion.ForeColor = System.Drawing.Color.Black;
            this.txtCondicion.Location = new System.Drawing.Point(10, 305);
            this.txtCondicion.Margin = new System.Windows.Forms.Padding(4);
            this.txtCondicion.Multiline = true;
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCondicion.PasswordChar = false;
            this.txtCondicion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCondicion.PlaceholderText = "Condicion de la Mascota";
            this.txtCondicion.Size = new System.Drawing.Size(564, 180);
            this.txtCondicion.TabIndex = 3;
            this.txtCondicion.Texts = "";
            this.txtCondicion.UnderlinedStyle = true;
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPeso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.txtPeso.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtPeso.BorderRadius = 0;
            this.txtPeso.BorderSize = 2;
            this.txtPeso.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPeso.Enabled = false;
            this.txtPeso.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.ForeColor = System.Drawing.Color.Black;
            this.txtPeso.Location = new System.Drawing.Point(10, 246);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeso.Multiline = false;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPeso.PasswordChar = false;
            this.txtPeso.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPeso.PlaceholderText = "Peso de la Mascota";
            this.txtPeso.Size = new System.Drawing.Size(564, 59);
            this.txtPeso.TabIndex = 2;
            this.txtPeso.Texts = "";
            this.txtPeso.UnderlinedStyle = true;
            this.txtPeso.Leave += new System.EventHandler(this.txtPeso_Leave);
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEdad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.txtEdad.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtEdad.BorderRadius = 0;
            this.txtEdad.BorderSize = 2;
            this.txtEdad.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEdad.Enabled = false;
            this.txtEdad.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.ForeColor = System.Drawing.Color.Black;
            this.txtEdad.Location = new System.Drawing.Point(10, 187);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdad.Multiline = false;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEdad.PasswordChar = false;
            this.txtEdad.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEdad.PlaceholderText = "Edad de la Mascota";
            this.txtEdad.Size = new System.Drawing.Size(564, 59);
            this.txtEdad.TabIndex = 1;
            this.txtEdad.Texts = "";
            this.txtEdad.UnderlinedStyle = true;
            this.txtEdad.Leave += new System.EventHandler(this.txtEdad_Leave);
            // 
            // txtNombreM
            // 
            this.txtNombreM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombreM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.txtNombreM.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtNombreM.BorderRadius = 0;
            this.txtNombreM.BorderSize = 2;
            this.txtNombreM.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNombreM.Enabled = false;
            this.txtNombreM.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreM.ForeColor = System.Drawing.Color.Black;
            this.txtNombreM.Location = new System.Drawing.Point(10, 128);
            this.txtNombreM.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreM.Multiline = false;
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombreM.PasswordChar = false;
            this.txtNombreM.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombreM.PlaceholderText = "Nombre de la Mascota";
            this.txtNombreM.Size = new System.Drawing.Size(564, 59);
            this.txtNombreM.TabIndex = 0;
            this.txtNombreM.Texts = "";
            this.txtNombreM.UnderlinedStyle = true;
            this.txtNombreM.Leave += new System.EventHandler(this.txtNombreM_Leave);
            // 
            // txtPropietario
            // 
            this.txtPropietario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPropietario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.txtPropietario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtPropietario.BorderRadius = 0;
            this.txtPropietario.BorderSize = 2;
            this.txtPropietario.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPropietario.Enabled = false;
            this.txtPropietario.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropietario.ForeColor = System.Drawing.Color.Black;
            this.txtPropietario.Location = new System.Drawing.Point(10, 69);
            this.txtPropietario.Margin = new System.Windows.Forms.Padding(4);
            this.txtPropietario.Multiline = false;
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPropietario.PasswordChar = false;
            this.txtPropietario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPropietario.PlaceholderText = "Propietario";
            this.txtPropietario.Size = new System.Drawing.Size(564, 59);
            this.txtPropietario.TabIndex = 7;
            this.txtPropietario.Texts = "";
            this.txtPropietario.UnderlinedStyle = true;
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCedula.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.txtCedula.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtCedula.BorderRadius = 0;
            this.txtCedula.BorderSize = 2;
            this.txtCedula.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCedula.Enabled = false;
            this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.ForeColor = System.Drawing.Color.Black;
            this.txtCedula.Location = new System.Drawing.Point(10, 10);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.Multiline = false;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCedula.PasswordChar = false;
            this.txtCedula.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCedula.PlaceholderText = "Cédula";
            this.txtCedula.Size = new System.Drawing.Size(564, 59);
            this.txtCedula.TabIndex = 8;
            this.txtCedula.Texts = "";
            this.txtCedula.UnderlinedStyle = true;
            this.txtCedula.Leave += new System.EventHandler(this.txtCedula_Leave);
            // 
            // custom_Button1
            // 
            this.custom_Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.custom_Button1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.custom_Button1.BorderColor = System.Drawing.Color.Red;
            this.custom_Button1.BorderRadius = 60;
            this.custom_Button1.BorderSize = 0;
            this.custom_Button1.FlatAppearance.BorderSize = 0;
            this.custom_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custom_Button1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custom_Button1.ForeColor = System.Drawing.Color.White;
            this.custom_Button1.Location = new System.Drawing.Point(621, 750);
            this.custom_Button1.Name = "custom_Button1";
            this.custom_Button1.Size = new System.Drawing.Size(534, 60);
            this.custom_Button1.TabIndex = 23;
            this.custom_Button1.Text = "Consultar Historial de la Mascota";
            this.custom_Button1.TextColor = System.Drawing.Color.White;
            this.custom_Button1.UseVisualStyleBackColor = false;
            // 
            // Elegir
            // 
            this.Elegir.HeaderText = "Elegir";
            this.Elegir.MinimumWidth = 8;
            this.Elegir.Name = "Elegir";
            this.Elegir.Visible = false;
            this.Elegir.Width = 55;
            // 
            // frmMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1182, 832);
            this.Controls.Add(this.custom_Button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbMascota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMascota";
            this.Text = "frmMascota";
            this.Load += new System.EventHandler(this.frmMascota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVacuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMascota)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.Custom_TextBox txtNombreM;
        private Componentes.Custom_TextBox txtEdad;
        private Componentes.Custom_TextBox txtPeso;
        private Componentes.Custom_TextBox txtCondicion;
        private System.Windows.Forms.ComboBox cmbTipoMascota;
        private System.Windows.Forms.ComboBox cmbRaza;
        private System.Windows.Forms.DataGridView dtgVacuna;
        private System.Windows.Forms.PictureBox pcbMascota;
        private System.Windows.Forms.ToolTip tltFotoMascota;
        private System.Windows.Forms.OpenFileDialog dlgFotoMascota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtRuta;
        private FontAwesome.Sharp.IconButton btnPrimero;
        private FontAwesome.Sharp.IconButton btnAnterior;
        private FontAwesome.Sharp.IconButton btnSiguiente;
        private FontAwesome.Sharp.IconButton btnUltimo;
        private System.Windows.Forms.ToolTip tltBotones;
        private FontAwesome.Sharp.IconButton btnConsultar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.Panel panel1;
        private Componentes.Custom_TextBox txtPropietario;
        private Componentes.Custom_TextBox txtCedula;
        private Componentes.Custom_Button custom_Button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Elegir;
    }
}
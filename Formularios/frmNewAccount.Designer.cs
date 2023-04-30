namespace PawsInn.Formularios
{
    partial class frmNewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewAccount));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.chbParametros = new System.Windows.Forms.CheckBox();
            this.chbMinuscula = new System.Windows.Forms.CheckBox();
            this.chbMayuscula = new System.Windows.Forms.CheckBox();
            this.chbNumero = new System.Windows.Forms.CheckBox();
            this.chbCaracter = new System.Windows.Forms.CheckBox();
            this.tltFotoPerfil = new System.Windows.Forms.ToolTip(this.components);
            this.pcbFotoPerfil = new PawsInn.Componentes.Custom_PictureBox();
            this.dlgFotoPerfil = new System.Windows.Forms.OpenFileDialog();
            this.lblCuenta = new System.Windows.Forms.LinkLabel();
            this.lblCancelar = new System.Windows.Forms.LinkLabel();
            this.custom_TextBox1 = new PawsInn.Componentes.Custom_TextBox();
            this.btnRegistrar = new PawsInn.Componentes.Custom_Button();
            this.txtPassword = new PawsInn.Componentes.Custom_TextBox();
            this.txtUsername = new PawsInn.Componentes.Custom_TextBox();
            this.txtCorreo = new PawsInn.Componentes.Custom_TextBox();
            this.txtTelefono = new PawsInn.Componentes.Custom_TextBox();
            this.txtDireccion = new PawsInn.Componentes.Custom_TextBox();
            this.txtNombre = new PawsInn.Componentes.Custom_TextBox();
            this.txtCedula = new PawsInn.Componentes.Custom_TextBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnMinimize);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 50);
            this.panel3.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnBack.IconColor = System.Drawing.Color.White;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.Location = new System.Drawing.Point(300, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.TabIndex = 99;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 50);
            this.label3.TabIndex = 12;
            this.label3.Text = "Crear Cuenta";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 50;
            this.btnMinimize.Location = new System.Drawing.Point(350, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.btnMinimize.Size = new System.Drawing.Size(50, 50);
            this.btnMinimize.TabIndex = 100;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 50;
            this.btnClose.Location = new System.Drawing.Point(400, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 101;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 105);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(105, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 105);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Haettenschweiler", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 43);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hotel de Mascotas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Haettenschweiler", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 62);
            this.label5.TabIndex = 2;
            this.label5.Text = "PAWS INN";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(105, 105);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // chbParametros
            // 
            this.chbParametros.AutoSize = true;
            this.chbParametros.Enabled = false;
            this.chbParametros.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbParametros.Location = new System.Drawing.Point(23, 676);
            this.chbParametros.Name = "chbParametros";
            this.chbParametros.Size = new System.Drawing.Size(242, 27);
            this.chbParametros.TabIndex = 19;
            this.chbParametros.Text = "Mínimo 8 parámetros";
            this.chbParametros.UseVisualStyleBackColor = true;
            // 
            // chbMinuscula
            // 
            this.chbMinuscula.AutoSize = true;
            this.chbMinuscula.Enabled = false;
            this.chbMinuscula.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMinuscula.Location = new System.Drawing.Point(23, 709);
            this.chbMinuscula.Name = "chbMinuscula";
            this.chbMinuscula.Size = new System.Drawing.Size(328, 27);
            this.chbMinuscula.TabIndex = 20;
            this.chbMinuscula.Text = "Al menos una letra mínuscula";
            this.chbMinuscula.UseVisualStyleBackColor = true;
            // 
            // chbMayuscula
            // 
            this.chbMayuscula.AutoSize = true;
            this.chbMayuscula.Enabled = false;
            this.chbMayuscula.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMayuscula.Location = new System.Drawing.Point(23, 742);
            this.chbMayuscula.Name = "chbMayuscula";
            this.chbMayuscula.Size = new System.Drawing.Size(336, 27);
            this.chbMayuscula.TabIndex = 21;
            this.chbMayuscula.Text = "Al menos una letra mayúscula";
            this.chbMayuscula.UseVisualStyleBackColor = true;
            // 
            // chbNumero
            // 
            this.chbNumero.AutoSize = true;
            this.chbNumero.Enabled = false;
            this.chbNumero.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbNumero.Location = new System.Drawing.Point(23, 775);
            this.chbNumero.Name = "chbNumero";
            this.chbNumero.Size = new System.Drawing.Size(238, 27);
            this.chbNumero.TabIndex = 22;
            this.chbNumero.Text = "Al menos un número";
            this.chbNumero.UseVisualStyleBackColor = true;
            // 
            // chbCaracter
            // 
            this.chbCaracter.AutoSize = true;
            this.chbCaracter.Enabled = false;
            this.chbCaracter.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCaracter.Location = new System.Drawing.Point(23, 808);
            this.chbCaracter.Name = "chbCaracter";
            this.chbCaracter.Size = new System.Drawing.Size(338, 27);
            this.chbCaracter.TabIndex = 23;
            this.chbCaracter.Text = "Al menos un carácter especial";
            this.chbCaracter.UseVisualStyleBackColor = true;
            // 
            // tltFotoPerfil
            // 
            this.tltFotoPerfil.AutoPopDelay = 5000;
            this.tltFotoPerfil.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tltFotoPerfil.ForeColor = System.Drawing.SystemColors.Info;
            this.tltFotoPerfil.InitialDelay = 200;
            this.tltFotoPerfil.ReshowDelay = 100;
            this.tltFotoPerfil.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tltFotoPerfil.ToolTipTitle = "Foto de Perfil";
            // 
            // pcbFotoPerfil
            // 
            this.pcbFotoPerfil.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pcbFotoPerfil.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pcbFotoPerfil.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.pcbFotoPerfil.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pcbFotoPerfil.BorderSize = 5;
            this.pcbFotoPerfil.GradientAngle = 50F;
            this.pcbFotoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("pcbFotoPerfil.Image")));
            this.pcbFotoPerfil.Location = new System.Drawing.Point(226, 161);
            this.pcbFotoPerfil.Name = "pcbFotoPerfil";
            this.pcbFotoPerfil.Size = new System.Drawing.Size(212, 212);
            this.pcbFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFotoPerfil.TabIndex = 25;
            this.pcbFotoPerfil.TabStop = false;
            this.tltFotoPerfil.SetToolTip(this.pcbFotoPerfil, "Doble Clic para Agregar");
            this.pcbFotoPerfil.DoubleClick += new System.EventHandler(this.pcbFotoPerfil_DoubleClick);
            // 
            // dlgFotoPerfil
            // 
            this.dlgFotoPerfil.FileName = "openFileDialog1";
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuenta.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblCuenta.Location = new System.Drawing.Point(21, 913);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(244, 23);
            this.lblCuenta.TabIndex = 29;
            this.lblCuenta.TabStop = true;
            this.lblCuenta.Text = "¿Ya tienes una cuenta?";
            this.lblCuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCuenta_LinkClicked);
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelar.LinkColor = System.Drawing.Color.IndianRed;
            this.lblCancelar.Location = new System.Drawing.Point(320, 913);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(103, 23);
            this.lblCancelar.TabIndex = 30;
            this.lblCancelar.TabStop = true;
            this.lblCancelar.Text = "Cancelar";
            this.lblCancelar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCancelar_LinkClicked);
            // 
            // custom_TextBox1
            // 
            this.custom_TextBox1.BackColor = System.Drawing.Color.White;
            this.custom_TextBox1.BorderColor = System.Drawing.Color.White;
            this.custom_TextBox1.BorderFocusColor = System.Drawing.Color.White;
            this.custom_TextBox1.BorderRadius = 0;
            this.custom_TextBox1.BorderSize = 2;
            this.custom_TextBox1.Enabled = false;
            this.custom_TextBox1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custom_TextBox1.ForeColor = System.Drawing.Color.Black;
            this.custom_TextBox1.Location = new System.Drawing.Point(24, 190);
            this.custom_TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.custom_TextBox1.Multiline = false;
            this.custom_TextBox1.Name = "custom_TextBox1";
            this.custom_TextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.custom_TextBox1.PasswordChar = false;
            this.custom_TextBox1.PlaceholderColor = System.Drawing.Color.Black;
            this.custom_TextBox1.PlaceholderText = "Foto de Perfíl";
            this.custom_TextBox1.Size = new System.Drawing.Size(180, 54);
            this.custom_TextBox1.TabIndex = 26;
            this.custom_TextBox1.Texts = "";
            this.custom_TextBox1.UnderlinedStyle = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRegistrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRegistrar.BorderColor = System.Drawing.Color.Red;
            this.btnRegistrar.BorderRadius = 50;
            this.btnRegistrar.BorderSize = 0;
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(23, 854);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(400, 56);
            this.btnRegistrar.TabIndex = 24;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextColor = System.Drawing.Color.White;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.txtPassword.BorderRadius = 0;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(23, 615);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.LightGray;
            this.txtPassword.PlaceholderText = "Contraseña";
            this.txtPassword.Size = new System.Drawing.Size(400, 54);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtUsername.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.txtUsername.BorderRadius = 0;
            this.txtUsername.BorderSize = 2;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(23, 305);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.LightGray;
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(201, 54);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCorreo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtCorreo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.txtCorreo.BorderRadius = 0;
            this.txtCorreo.BorderSize = 2;
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.Black;
            this.txtCorreo.Location = new System.Drawing.Point(23, 553);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Multiline = false;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCorreo.PasswordChar = false;
            this.txtCorreo.PlaceholderColor = System.Drawing.Color.LightGray;
            this.txtCorreo.PlaceholderText = "Correo Electrónico";
            this.txtCorreo.Size = new System.Drawing.Size(400, 54);
            this.txtCorreo.TabIndex = 6;
            this.txtCorreo.Texts = "";
            this.txtCorreo.UnderlinedStyle = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtTelefono.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.txtTelefono.BorderRadius = 0;
            this.txtTelefono.BorderSize = 2;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.Location = new System.Drawing.Point(23, 491);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.PlaceholderColor = System.Drawing.Color.LightGray;
            this.txtTelefono.PlaceholderText = "Teléfono";
            this.txtTelefono.Size = new System.Drawing.Size(400, 54);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.Texts = "";
            this.txtTelefono.UnderlinedStyle = true;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDireccion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtDireccion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.txtDireccion.BorderRadius = 0;
            this.txtDireccion.BorderSize = 2;
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.Location = new System.Drawing.Point(23, 429);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDireccion.PasswordChar = false;
            this.txtDireccion.PlaceholderColor = System.Drawing.Color.LightGray;
            this.txtDireccion.PlaceholderText = "Dirección";
            this.txtDireccion.Size = new System.Drawing.Size(400, 54);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.Texts = "";
            this.txtDireccion.UnderlinedStyle = true;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtNombre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.txtNombre.BorderRadius = 0;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(23, 367);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.LightGray;
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.Size = new System.Drawing.Size(400, 54);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlinedStyle = true;
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.White;
            this.txtCedula.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtCedula.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.txtCedula.BorderRadius = 0;
            this.txtCedula.BorderSize = 2;
            this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.ForeColor = System.Drawing.Color.Black;
            this.txtCedula.Location = new System.Drawing.Point(23, 243);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.Multiline = false;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCedula.PasswordChar = false;
            this.txtCedula.PlaceholderColor = System.Drawing.Color.LightGray;
            this.txtCedula.PlaceholderText = "Cédula";
            this.txtCedula.Size = new System.Drawing.Size(180, 54);
            this.txtCedula.TabIndex = 1;
            this.txtCedula.Texts = "";
            this.txtCedula.UnderlinedStyle = true;
            // 
            // frmNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 950);
            this.Controls.Add(this.lblCancelar);
            this.Controls.Add(this.lblCuenta);
            this.Controls.Add(this.custom_TextBox1);
            this.Controls.Add(this.pcbFotoPerfil);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.chbCaracter);
            this.Controls.Add(this.chbNumero);
            this.Controls.Add(this.chbMayuscula);
            this.Controls.Add(this.chbMinuscula);
            this.Controls.Add(this.chbParametros);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewAccount";
            this.Load += new System.EventHandler(this.frmNewAccount_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnBack;
        private Componentes.Custom_TextBox txtCedula;
        private Componentes.Custom_TextBox txtNombre;
        private Componentes.Custom_TextBox txtDireccion;
        private Componentes.Custom_TextBox txtTelefono;
        private Componentes.Custom_TextBox txtCorreo;
        private Componentes.Custom_TextBox txtUsername;
        private Componentes.Custom_TextBox txtPassword;
        private System.Windows.Forms.CheckBox chbParametros;
        private System.Windows.Forms.CheckBox chbMinuscula;
        private System.Windows.Forms.CheckBox chbMayuscula;
        private System.Windows.Forms.CheckBox chbNumero;
        private System.Windows.Forms.CheckBox chbCaracter;
        private Componentes.Custom_Button btnRegistrar;
        private Componentes.Custom_PictureBox pcbFotoPerfil;
        private Componentes.Custom_TextBox custom_TextBox1;
        private System.Windows.Forms.ToolTip tltFotoPerfil;
        private System.Windows.Forms.OpenFileDialog dlgFotoPerfil;
        private System.Windows.Forms.LinkLabel lblCuenta;
        private System.Windows.Forms.LinkLabel lblCancelar;
    }
}
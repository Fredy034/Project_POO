using FontAwesome.Sharp;
using PawsInn.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace PawsInn.Formularios
{
    public partial class frmMainMenu : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form formularioActivo = null;
        private Image imagenOriginal;
        cConexion cn = new cConexion();

        public frmMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 55);
            pnlControles.Controls.Add(leftBorderBtn);
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            Design();
            DisableButton();
            alignButtons();
            imagenOriginal = pcbPerfil.Image;
            pnlInfoUsuario.BringToFront();
            pcbPerfil.Image = Image.FromStream(ByteImage());
            lblCedula.Text = UserCache.Cedula;
            lblNombre.Text = UserCache.Nombre;
            lblTelefono.Text = UserCache.Telefono;
            lblCorreo.Text = UserCache.Correo;
            lblusuario.Text = UserCache.Usuario;
            lblDireccion.Text = UserCache.Direccion;
            if (UserCache.Cargo != "")
            {
                if (UserCache.Cargo == Cargos.Cliente)
                {
                    btnAdministrador.Visible = false;
                    btnProfesional.Visible = false;
                }
                if (UserCache.Cargo == Cargos.Profesional)
                {
                    btnAdministrador.Visible = false;
                }
                if (UserCache.Cargo == Cargos.Administrador)
                {
                    //Codes
                }
            }
        }

        private MemoryStream ByteImage()
        {
            try
            {
                byte[] img = UserCache.FotoPerfil;
                if (img == null)
                {
                    ImageConverter converter = new ImageConverter();
                    byte[] defaultImageBytes = (byte[])converter.ConvertTo(imagenOriginal, typeof(byte[]));
                    MemoryStream ms = new MemoryStream(defaultImageBytes);
                    return ms;
                }
                else
                {
                    MemoryStream ms = new MemoryStream(img);
                    return ms;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.LightGray;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.Transparent;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 255, 255);
            public static Color color2 = Color.FromArgb(249, 255, 234);
            public static Color color3 = Color.FromArgb(249, 118, 176);
            public static Color color4 = Color.FromArgb(253, 138, 114);
            public static Color color5 = Color.FromArgb(95, 77, 221);
            public static Color color6 = Color.FromArgb(249, 88, 155);
            public static Color color7 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(253, 119, 76);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                pcbHome.IconChar = currentBtn.IconChar;
                pcbHome.IconColor = color;
                lblHome.Text = currentBtn.Text;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(253, 119, 76);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void alignButtons()
        {
            btnAdministrador.TextAlign = ContentAlignment.MiddleLeft;
            btnAdministrador.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdministrador.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfesional.TextAlign = ContentAlignment.MiddleLeft;
            btnProfesional.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProfesional.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuario.ImageAlign = ContentAlignment.MiddleLeft;;
        }

        private void Design()
        {
            pnlAdministrador.Visible = false;
            pnlProfesional.Visible = false;
            pnlUsuario.Visible = false;
        }

        private void mostrarSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void ocultarSubmenu()
        {
            if (pnlAdministrador.Visible == true)
                pnlAdministrador.Visible = false;
            if (pnlProfesional.Visible == true)
                pnlProfesional.Visible = false;
            if (pnlUsuario.Visible == true)
                pnlUsuario.Visible = false;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que deseas cerrar la sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmSignIn frm = new frmSignIn();
                frm.Show();
                this.Close();
            }
        }

        public void abrirFormularioHijo(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formularioHijo);
            pnlContenedor.Tag = formularioHijo;
            formularioHijo.SendToBack();
            pcbLogo.Visible = false;
            formularioHijo.Show();
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlAdministrador);
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnProfesional_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlProfesional);
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlUsuario);
            ActivateButton(sender, RGBColors.color1);
        }

        private void pHome_Click(object sender, EventArgs e)
        {
            Reset();
            pcbLogo.Visible = true;
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            if (pnlInfoUsuario.Visible == true)
                pnlInfoUsuario.Visible = false;
            ocultarSubmenu();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            pcbHome.IconChar = IconChar.Home;
            pcbHome.IconColor = Color.White;
            lblHome.Text = "Home";
        }

        private void btnMascota_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmMascota());
            pcbHome.IconChar = IconChar.Paw;
            pcbHome.IconColor = Color.White;
            lblHome.Text = "Mascotas";
            ocultarSubmenu();
        }

        private void btnInforUsuario_Click(object sender, EventArgs e)
        {
            pnlInfoUsuario.Visible = !pnlInfoUsuario.Visible;
        }
    }
}

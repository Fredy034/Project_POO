using PawsInn.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PawsInn.Formularios;
using System.Data.Common;
using System.Globalization;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.Remoting.Contexts;

namespace PawsInn.Formularios
{
    public partial class frmNewAccount : Form
    {
        cConexion cn = new cConexion();
        private Image imagenOriginal;
        public frmNewAccount()
        {
            InitializeComponent();
        }

        private void frmNewAccount_Load(object sender, EventArgs e)
        {
            imagenOriginal = pcbFotoPerfil.Image;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmInicio frm = new frmInicio();
            frm.Show();
            this.Close();
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

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.LightGray;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.Transparent;
        }

        private bool SecuredPassword(string password)
        {
            chbCaracter.Checked = false; 
            chbMayuscula.Checked = false; 
            chbMinuscula.Checked = false; 
            chbNumero.Checked = false; 
            chbParametros.Checked = false;
            if (password.Length >= 8)
            {
                chbParametros.Checked = true;
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password, i))
                {
                    chbMayuscula.Checked = true;
                }
                else if (Char.IsLower(password, i))
                {
                    chbMinuscula.Checked = true;
                }
                else if (Char.IsDigit(password, i))
                {
                    chbNumero.Checked = true;
                }
                else
                {
                    chbCaracter.Checked = true;
                }
            }
            if (chbMayuscula.Checked && chbMinuscula.Checked && chbNumero.Checked && chbCaracter.Checked && chbParametros.Checked)
            {
                return true;
            }
            return false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (SecuredPassword(txtPassword.Texts))
                btnRegistrar.Enabled = true;
            else
                btnRegistrar.Enabled = false;
        }

        private void pcbFotoPerfil_DoubleClick(object sender, EventArgs e)
        {
            DialogResult r = dlgFotoPerfil.ShowDialog();
            if (r == DialogResult.OK)
            {
                using (Stream flujo = dlgFotoPerfil.OpenFile())
                {
                    Bitmap imagen = new Bitmap(flujo);
                    pcbFotoPerfil.Image = imagen;
                }
            }
        }

        private byte[] ConvertirImg(System.Drawing.Image picture)
        {
            MemoryStream ms = new MemoryStream();
            picture.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
            /*using (MemoryStream ms = new MemoryStream())
            {
                ImageFormat format = picture.RawFormat;
                if (format.Equals(ImageFormat.Jpeg))
                {
                    picture.Save(ms, ImageFormat.Jpeg);
                }
                else if (format.Equals(ImageFormat.Png))
                {
                    picture.Save(ms, ImageFormat.Png);
                }
                else if (format.Equals(ImageFormat.Bmp))
                {
                    picture.Save(ms, ImageFormat.Bmp);
                }
                else if (format.Equals(ImageFormat.Gif))
                {
                    picture.Save(ms, ImageFormat.Gif);
                }
                else if (format.Equals(ImageFormat.Icon))
                {
                    picture.Save(ms, ImageFormat.Icon);
                }
                else
                {
                    throw new ArgumentException("Formato de imagen no válido");
                }
                return ms.ToArray();
            }*/
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] image = ConvertirImg(pcbFotoPerfil.Image);

                SqlCommand check = new SqlCommand("SELECT * FROM tblUsuario WHERE Correo = @Correo OR Usuario = @Usuario", cn.AbrirConexion());
                check.Parameters.AddWithValue("Correo", txtCorreo.Texts);
                check.Parameters.AddWithValue("@Usuario", txtUsername.Texts);
                SqlDataAdapter da = new SqlDataAdapter(check);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.CerrarConexion();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("El usuario y/o correo electrónico que intentas almacenar, ya se encuentran registrados, verifica si ya tienes una cuenta, por el contrario, intenta nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //SqlCommand registro = new SqlCommand("INSERT INTO tblUsuario VALUES (@Cedula, @Nombre, @Direccion, @Telefono, @Correo, 2, NULL, @Usuario, @Password, NULL, @FotoP)", cn.AbrirConexion());
                    SqlCommand registro = new SqlCommand("SP_NuevoUsuario", cn.AbrirConexion());
                    registro.CommandType = CommandType.StoredProcedure;
                    registro.Parameters.AddWithValue("@Cedula", txtCedula.Texts);
                    registro.Parameters.AddWithValue("@Nombre", txtNombre.Texts);
                    registro.Parameters.AddWithValue("@Direccion", txtDireccion.Texts);
                    registro.Parameters.AddWithValue("@Telefono", txtTelefono.Texts);
                    registro.Parameters.AddWithValue("@Correo", txtCorreo.Texts);
                    registro.Parameters.AddWithValue("@IdCargo", 2);
                    registro.Parameters.AddWithValue("@Sueldo", 0);
                    registro.Parameters.AddWithValue("@User", txtUsername.Texts);
                    registro.Parameters.AddWithValue("@Pass", txtPassword.Texts);
                    registro.Parameters.AddWithValue("@FotoP", image);
                    registro.ExecuteNonQuery();
                    cn.CerrarConexion();
                    MessageBox.Show("El usuario: " + txtUsername.Texts + ", ha sido almacenado correctamente.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmSignIn frm = new frmSignIn();
                    frm.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblCancelar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clear();
        }

        private void lblCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("¿Ya tienes una cuenta en PawsInn?", "Iniciar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmSignIn frm = new frmSignIn();
                frm.Show();
                this.Close();
            }
        }

        private void clear()
        {
            txtCedula.Clear();
            txtCorreo.Clear();
            txtUsername.Clear();
            txtTelefono.Clear();
            txtPassword.Clear();
            txtDireccion.Clear();
            txtNombre.Clear();
            pcbFotoPerfil.Image = imagenOriginal;
        }
    }
}

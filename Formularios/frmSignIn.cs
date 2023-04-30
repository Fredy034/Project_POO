using PawsInn.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawsInn.Formularios
{
    public partial class frmSignIn : Form
    {
        cConexion cn = new cConexion();
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
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

        private void lblNoCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("¿Deseas crear una cuenta en PawsInn?", "Crear Cuenta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmNewAccount frm = new frmNewAccount();
                frm.Show();
                this.Close();
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Texts != "")
                {
                    if (txtPassword.Texts != "")
                    {
                        UserInfo user = new UserInfo();
                        var validLogin = user.LoginUser(txtUsername.Texts, txtPassword.Texts);
                        if (validLogin)
                        {
                            frmMainMenu frm = new frmMainMenu();
                            frm.Show();
                            this.Close();
                        }
                        else
                        {
                            lblErrorMessage.Text = "Incorrect username or password entered. \nPlease try again.";
                            lblErrorMessage.Visible = true;
                            pcbErrorMessage.Visible = true;
                            txtUsername.Clear();
                            txtPassword.Clear();
                        }
                    }
                    else
                    {
                        lblErrorMessage.Text = "Please enter a password";
                        lblErrorMessage.Visible = true;
                        pcbErrorMessage.Visible = true;
                    }
                }
                else
                {
                    lblErrorMessage.Text = "Please enter an username";
                    lblErrorMessage.Visible = true;
                    pcbErrorMessage.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == true)
                txtPassword.PasswordChar = false;
            else 
                txtPassword.PasswordChar = true;
        }

        private void btnViewPassword_MouseEnter(object sender, EventArgs e)
        {
            btnViewPassword.BackColor = Color.Transparent;
        }

        private void lblRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecoverPassword frm = new frmRecoverPassword();
            frm.ShowDialog();
        }
    }
}

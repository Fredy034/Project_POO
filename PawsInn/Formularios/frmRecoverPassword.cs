using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PawsInn.Clases;

namespace PawsInn.Formularios
{
    public partial class frmRecoverPassword : Form
    {
        public frmRecoverPassword()
        {
            InitializeComponent();
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            var user = new UserInfo();
            var result = user.recoverPassword(txtRecover.Texts);
            MessageBox.Show(result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

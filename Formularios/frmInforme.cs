using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawsInn.Formularios
{
    public partial class frmInforme : Form
    {
        public frmInforme()
        {
            InitializeComponent();
        }

        private void nuevoForm()
        {
            frmMascota frm = new frmMascota();
            frmMainMenu MainMenu = (frmMainMenu)this.ParentForm;
            MainMenu.abrirFormularioHijo(frm);
            this.Hide();
        }
    }
}

using PawsInn.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawsInn
{
    public partial class frmLoadingPage : Form
    {
        public frmLoadingPage()
        {
            InitializeComponent();
        }

        private void tmrFadeIn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.5;
            //circularPB.Value += 4;
            circularPB.Value += 10;
            circularPB.Text = circularPB.Value.ToString();
            if (circularPB.Value == 100)
            {
                frmInicio frm = new frmInicio();
                frm.Show();
                tmrFadeIn.Stop();
                this.Hide();
                //tmrFadeOut.Start();
            }
        }

        private void tmrFadeOut_Tick(object sender, EventArgs e)
        {
            /*this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                tmrFadeOut.Stop();
                this.Close();
            }*/
        }

        private void frmLoadingPage_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            circularPB.Value = 0;
            tmrFadeIn.Start();
        }
    }
}

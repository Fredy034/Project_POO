using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PawsInn.Clases;
using PawsInn.Formularios;

namespace PawsInn.Formularios
{
    public partial class frmMascota : Form
    {
        cConexion cn;
        SqlDataAdapter da;
        DataTable dt;
        int contador, i, boton;
        private Image imagenOriginal;
        private readonly Dictionary<string, string> razasMascota = new Dictionary<string, string>()
        {
            {"1", "Pastor Alemán"},
            {"2", "Labrador Retriever"},
            {"3", "Bulldog Inglés"},
            {"4", "Beagle"},
            {"5", "Boxer"},
            {"6", "Dálmata"},
            {"7", "Yorkshire Terrier"},
            {"8", "Rottweiler"},
            {"9", "Doberman"},
            {"10", "Husky Siberiano"},
            {"11", "Poodle"},
            {"12", "Bull Terrier"},
            {"13", "Bichón Frisé"},
            {"14", "Shih Tzu"},
            {"15", "Cavalier King Charles Spaniel"},
            {"16", "Golden Retriever"},
            {"17", "Chihuahua"},
            {"18", "Gran Danés"},
            {"19", "Schnauzer"},
            {"20", "Persa"},
            {"21", "Bengalí"},
            {"22", "Sphynx"},
            {"23", "Azul Ruso"},
            {"24", "Americano de Pelo Corto"},
            {"25", "Abisino"},
            {"26", "Maine Coon"},
            {"27", "Egipcio"},
            {"28", "Van Turco"},
            {"29", "Otro"},
            {"30", "Otro"}
        };
        private readonly Dictionary<string, string> razasMascotaInvertido = new Dictionary<string, string>()
        {
            {"Pastor Alemán", "1"},
            {"Labrador Retriever", "2"},
            {"Bulldog Inglés", "3"},
            {"Beagle", "4"},
            {"Boxer", "5"},
            {"Dálmata", "6"},
            {"Yorkshire Terrier", "7"},
            {"Rottweiler", "8"},
            {"Doberman", "9"},
            {"Husky Siberiano", "10"},
            {"Poodle", "11"},
            {"Bull Terrier", "12"},
            {"Bichón Frisé", "13"},
            {"Shih Tzu", "14"},
            {"Cavalier King Charles Spaniel", "15"},
            {"Golden Retriever", "16"},
            {"Chihuahua", "17"},
            {"Gran Danés", "18"},
            {"Schnauzer", "19"},
            {"Persa", "20"},
            {"Bengalí", "21"},
            {"Sphynx", "22"},
            {"Azul Ruso", "23"},
            {"Americano de Pelo Corto", "24"},
            {"Abisino", "25"},
            {"Maine Coon", "26"},
            {"Egipcio", "27"},
            {"Van Turco", "28"}
        };

        public frmMascota()
        {
            InitializeComponent();
            cn = new cConexion();
            i = 0;
            boton = 0;
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblMascota", cn.AbrirConexion());
            if (UserCache.Cargo != "")
            {
                if (UserCache.Cargo == Cargos.Cliente)
                {
                    cmd.CommandText += " WHERE Cedula = @Cedula";
                    cmd.Parameters.AddWithValue("@Cedula", UserCache.Cedula);
                    txtCedula.Visible = false;
                    txtPropietario.Visible = false;
                }
                if (UserCache.Cargo == Cargos.Profesional)
                {
                    //Codes
                }
                if (UserCache.Cargo == Cargos.Administrador)
                {
                    //Codes
                }
            }
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            cn.CerrarConexion();
        }

        private void frmMascota_Load(object sender, EventArgs e)
        {
            imagenOriginal = pcbMascota.Image;
            llenar(dt, i);
            llenarCombo();
        }

        private void habilita()
        {
            txtCedula.Enabled = true;
            txtNombreM.Enabled = true;
            txtEdad.Enabled = true;
            txtPeso.Enabled = true;
            txtCondicion.Enabled = true;
            cmbTipoMascota.Enabled = true;
            cmbRaza.Enabled = true;
            dtgVacuna.Enabled = true;
            pcbMascota.Enabled = true;
        }

        private void deshabilita()
        {
            txtCedula.Enabled = false;
            txtNombreM.Enabled = false;
            txtEdad.Enabled = false;
            txtPeso.Enabled = false;
            txtCondicion.Enabled = false;
            cmbTipoMascota.Enabled = false;
            cmbRaza.Enabled = false;
            dtgVacuna.Enabled = false;
            pcbMascota.Enabled = false;
        }

        private void limpiar()
        {
            txtCedula.Clear();
            txtPropietario.Clear();
            txtNombreM.Clear();
            txtEdad.Clear();
            txtPeso.Clear();
            txtCondicion.Clear();
            cmbTipoMascota.Text = string.Empty;
            cmbRaza.Text = string.Empty;
            dtgVacuna.DataSource = null;
            pcbMascota.Image = imagenOriginal;
        }

        private void pcbMascota_DoubleClick(object sender, EventArgs e)
        {
            DialogResult r = dlgFotoMascota.ShowDialog();
            if (r == DialogResult.OK)
            {
                txtRuta.Text = dlgFotoMascota.FileName;
                pcbMascota.Load(txtRuta.Text);
            }
        }

        private void cmbTipoMascota_Leave(object sender, EventArgs e)
        {

        }

        private void cmbTipoMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbRaza.Text = string.Empty;
                dtgVacuna.DataSource = null;
                SqlCommand razaM = new SqlCommand("SELECT * FROM tblRaza", cn.AbrirConexion());
                SqlCommand vacunaM = new SqlCommand("SELECT IdVacuna, DescripcionV 'Vacuna', IdTipo FROM tblVacuna", cn.AbrirConexion());
                switch (cmbTipoMascota.SelectedIndex)
                {
                    case 0:
                        razaM.CommandText += " WHERE IdTipo = 1";
                        vacunaM.CommandText += " WHERE IdTipo = 1";
                        break;
                    case 1:
                        razaM.CommandText += " WHERE IdTipo = 2";
                        vacunaM.CommandText += " WHERE IdTipo = 2";
                        break;
                    default:
                        // manejar caso no previsto
                        break;
                }
                SqlDataAdapter daRM = new SqlDataAdapter(razaM);
                DataTable dtRM = new DataTable();
                daRM.Fill(dtRM);
                cmbRaza.Items.Clear();
                for (int i = 0; i < dtRM.Rows.Count; i++)
                {
                    cmbRaza.Items.Add(dtRM.Rows[i][1]);
                }
                SqlDataAdapter daVM = new SqlDataAdapter(vacunaM);
                DataTable dtVM = new DataTable();
                daVM.Fill(dtVM);
                dtgVacuna.DataSource = dtVM;
                Elegir.Visible = true;
                dtgVacuna.Columns[1].Visible = false;
                dtgVacuna.Columns[3].Visible = false;
                foreach (DataGridViewColumn col in dtgVacuna.Columns)
                {
                    if (col.Name != "Elegir")
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                cn.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llenarCombo()
        {
            SqlCommand tipoM = new SqlCommand("SELECT * FROM tblTipo", cn.AbrirConexion());
            SqlDataAdapter daTM = new SqlDataAdapter(tipoM);
            DataTable dtTM = new DataTable();
            daTM.Fill(dtTM);
            for (int i = 0; i < dtTM.Rows.Count; i++)
            {
                cmbTipoMascota.Items.Add(dtTM.Rows[i][1]);
            }
            cn.CerrarConexion();
        }

        private void llenar(DataTable dt, int i)
        {
            try
            {
                if (UserCache.Cargo != Cargos.Cliente)
                {
                    txtCedula.Texts = dt.Rows[i][1].ToString();
                    SqlCommand prop = new SqlCommand("SELECT Nombre FROM tblUsuario WHERE Cedula = @Cedula", cn.AbrirConexion());
                    prop.Parameters.AddWithValue("@Cedula", dt.Rows[i][1].ToString());
                    SqlDataAdapter daProp = new SqlDataAdapter(prop);
                    DataTable dtProp = new DataTable();
                    daProp.Fill(dtProp);
                    txtPropietario.Texts = dtProp.Rows[0][0].ToString();
                    cn.CerrarConexion();
                }
                txtNombreM.Texts = dt.Rows[i][2].ToString();
                txtEdad.Texts = dt.Rows[i][3].ToString();
                txtPeso.Texts = dt.Rows[i][4].ToString();
                txtCondicion.Texts = dt.Rows[i][5].ToString();
                string TipoMascota = dt.Rows[i][6].ToString();
                Dictionary<string, string> tiposMascota = new Dictionary<string, string>()
                {
                    {"1", "Perro"},
                    {"2", "Gato"}
                };
                string tipoMascotaText;
                if (tiposMascota.TryGetValue(TipoMascota, out tipoMascotaText))
                {
                    cmbTipoMascota.Text = tipoMascotaText;
                }
                else
                {
                    cmbTipoMascota.Text = "";
                }
                string RazaMascota = dt.Rows[i][7].ToString();
                string razaMascotaText;
                if (razasMascota.TryGetValue(RazaMascota, out razaMascotaText))
                {
                    cmbRaza.Text = razaMascotaText;
                }
                else
                {
                    cmbRaza.Text = "";
                }

                SqlCommand command = new SqlCommand("SELECT V.DescripcionV 'Vacunas' FROM tblVacuna V JOIN tblMascota_Vacuna MV ON V.IdVacuna = MV.IdVacuna JOIN tblMascota M ON MV.IdMascota = M.IdMascota WHERE M.IdMascota = @IdMascota;", cn.AbrirConexion());
                command.Parameters.AddWithValue("@IdMascota", dt.Rows[0][0]);
                DataTable dtC = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dtC);
                dtgVacuna.DataSource = dtC;
                Elegir.Visible = true;
                dtgVacuna.Columns["Elegir"].DefaultCellStyle.NullValue = true;
                foreach (DataGridViewColumn col in dtgVacuna.Columns)
                {
                    if (col.Name != "Elegir")
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                txtRuta.Text = dt.Rows[i][10].ToString();
                if (dt.Rows[i][9] != null && dt.Rows[i][9] != DBNull.Value && dt.Rows[i][9] is byte[])
                {
                    byte[] imgBytes = (byte[])dt.Rows[i][9];
                    MemoryStream ms = new MemoryStream(imgBytes);
                    Image img = Image.FromStream(ms);
                    pcbMascota.Image = img;
                }
                else
                {
                    pcbMascota.Image = imagenOriginal;
                }

                contador = dt.Rows.Count;
                cn.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            i = 0;
            llenar(dt, i);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            i--;
            if (i == -1)
            {
                i = 0;
            }
            llenar(dt, i);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            i++;
            if (i == contador)
            {
                i = contador - 1;
            }
            llenar(dt, i);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            i = contador - 1;
            llenar(dt, i);
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtCedula.Texts != "")
                {
                    SqlCommand prop = new SqlCommand("SELECT Nombre FROM tblUsuario WHERE Cedula = @Cedula", cn.AbrirConexion());
                    prop.Parameters.AddWithValue("@Cedula", txtCedula.Texts);
                    SqlDataAdapter daProp = new SqlDataAdapter(prop);
                    DataTable dtProp = new DataTable();
                    daProp.Fill(dtProp);
                    cn.CerrarConexion();
                    if (dtProp.Rows.Count != 0)
                    {
                        txtPropietario.Texts = dtProp.Rows[0][0].ToString();
                        txtCedula.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("La cédula ingresada no se encuentra registrada, por favor verifique la información e intentelo nuevamente.", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El campo no puede estar vacío.", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombreM_Leave(object sender, EventArgs e)
        {
            try
            {
                if (UserCache.Cargo != "")
                {
                    if (UserCache.Cargo == Cargos.Cliente)
                    {
                        SqlCommand cmd1 = new SqlCommand("SELECT * FROM tblMascota WHERE NombreMascota = @NombreM", cn.AbrirConexion());
                        cmd1.Parameters.AddWithValue("@NombreM", txtNombreM.Texts);
                        SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);
                        cn.CerrarConexion();
                        i = 0;
                        switch (boton)
                        {
                            case 1:
                                if (dt1.Rows.Count == 0)
                                {
                                    MessageBox.Show("La mascota que intentas buscar no se encuentra almacenada, intentalo nuevamente.", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtNombreM.Clear();
                                    txtNombreM.Focus();
                                }
                                else
                                {
                                    llenar(dt1, i);
                                    deshabilita();
                                }
                                break;
                            case 2:
                                if (dt1.Rows.Count != 0)
                                {
                                    MessageBox.Show("La mascota que intentas agregar ya se encuentra registrada, intentalo nuevamente.", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    llenar(dt1, i);
                                }
                                break;
                            case 3:
                                if (dt1.Rows.Count == 0)
                                {
                                    MessageBox.Show("El registro no existe.");
                                    txtNombreM.Clear();
                                    txtNombreM.Focus();
                                }
                                else
                                    llenar(dt1, i);
                                break;
                            case 4:
                                if (dt1.Rows.Count == 0)
                                {
                                    MessageBox.Show("No existe el registro");
                                    txtNombreM.Clear();
                                    txtNombreM.Focus();
                                }
                                else
                                {
                                    llenar(dt1, i);
                                    if (MessageBox.Show("¿Esta seguro que desea borrar la habitacion?", "¡Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        SqlCommand cm = new SqlCommand("DELETE FROM tblHabitacion WHERE IdHabitacion = '" + txtNombreM.Texts + "'", cn.AbrirConexion());
                                        MessageBox.Show("Habitacion: " + txtNombreM.Texts + " eliminada exitosamente.", "Eliminar Habitacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cm.ExecuteNonQuery();
                                    }
                                }
                                break;
                        }
                    }
                    else
                    {
                        SqlCommand cmd1 = new SqlCommand("SELECT * FROM tblMascota WHERE NombreMascota = @NombreM AND Cedula = @Cedula", cn.AbrirConexion());
                        cmd1.Parameters.AddWithValue("@NombreM", txtNombreM.Texts);
                        cmd1.Parameters.AddWithValue("Cedula", txtCedula.Texts);
                        SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);
                        cn.CerrarConexion();
                        i = 0;
                        switch (boton)
                        {
                            case 1:
                                if (dt1.Rows.Count == 0)
                                {
                                    MessageBox.Show("El usuario no posee esa mascota, intentarlo nuevamente.", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtNombreM.Clear();
                                    txtNombreM.Focus();
                                }
                                else
                                {
                                    llenar(dt1, i);
                                    deshabilita();
                                }
                                break;
                            case 2:
                                if (dt1.Rows.Count != 0)
                                {
                                    MessageBox.Show("El usuario ya tiene esa mascota registrada,  intentarlo nuevamente.", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    llenar(dt1, i);
                                }
                                break;
                            case 3:
                                if (dt1.Rows.Count == 0)
                                {
                                    MessageBox.Show("El registro no existe.");
                                    txtNombreM.Clear();
                                    txtNombreM.Focus();
                                }
                                else
                                    llenar(dt1, i);
                                break;
                            case 4:
                                if (dt1.Rows.Count == 0)
                                {
                                    MessageBox.Show("No existe el registro");
                                    txtNombreM.Clear();
                                    txtNombreM.Focus();
                                }
                                else
                                {
                                    llenar(dt1, i);
                                    if (MessageBox.Show("¿Esta seguro que desea borrar la habitacion?", "¡Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        SqlCommand cm = new SqlCommand("DELETE FROM tblHabitacion WHERE IdHabitacion = '" + txtNombreM.Texts + "'", cn.AbrirConexion());
                                        MessageBox.Show("Habitacion: " + txtNombreM.Texts + " eliminada exitosamente.", "Eliminar Habitacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cm.ExecuteNonQuery();
                                    }
                                }
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEdad_Leave(object sender, EventArgs e)
        {
            string Edad = txtEdad.Texts;
            for (int i = 0; i < Edad.Length; i++)
            {
                if (!Char.IsDigit(Edad, i))
                {
                    MessageBox.Show("El campo únicamente acepta valore numéricos.", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void txtPeso_Leave(object sender, EventArgs e)
        {
            string Peso = txtPeso.Texts;
            if (!float.TryParse(Peso, out float result))
            {
                MessageBox.Show("El campo únicamente acepta valores numéricos.", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            boton = 1;
            limpiar();
            if (UserCache.Cargo != "")
            {
                if (UserCache.Cargo == Cargos.Cliente)
                {
                    txtNombreM.Enabled = true;
                    txtNombreM.Focus();
                }
                else
                {
                    txtCedula.Enabled = true;
                    txtNombreM.Enabled = true;
                    txtCedula.Focus();
                }
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            boton = 2;
            habilita();
            limpiar();
            if (UserCache.Cargo != "")
            {
                if (UserCache.Cargo == Cargos.Cliente)
                {
                    txtNombreM.Enabled = true;
                    txtNombreM.Focus();
                }
                else
                {
                    txtCedula.Enabled = true;
                    txtNombreM.Enabled = true;
                    txtCedula.Focus();
                }
            }
            btnGuardar.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            boton = 3;
            habilita();
            limpiar();
            if (UserCache.Cargo != "")
            {
                if (UserCache.Cargo == Cargos.Cliente)
                {
                    txtNombreM.Enabled = true;
                    txtNombreM.Focus();
                }
                else
                {
                    txtCedula.Enabled = true;
                    txtNombreM.Enabled = true;
                    txtCedula.Focus();
                }
            }
            btnGuardar.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            llenar(dt, i);
            deshabilita();
        }

    }
}

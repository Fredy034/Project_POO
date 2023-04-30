using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace PawsInn.Clases
{
    internal class cConexion
    {
        private static string CadenaConexion = @"Data Source=DESKTOP-65QG3G0\SQLEXPRESS; Initial Catalog=PawsInn; Integrated Security=True;Connect Timeout=30";
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);

        public SqlConnection AbrirConexion()
        {
            try
            {
                if (Conexion.State == ConnectionState.Closed)
                {
                    Conexion.Open();
                }
                return Conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + ", al intentar abrir la conexion");
                return null;
            }
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}

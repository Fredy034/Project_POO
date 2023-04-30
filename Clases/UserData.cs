using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PawsInn.Clases;

namespace PawsInn.Clases
{
    internal class UserData : ConnectionToSql
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT U.Cedula, U.Nombre, U.Direccion, U.Telefono, U.Correo, C.DescripcionC, U.Sueldo, U.Usuario, U.Contrasena, U.FotoP FROM tblUsuario U JOIN tblCargo C ON U.IdCargo = C.IdCargo WHERE U.Usuario = @User AND U.Contrasena = @Pass";
                    command.Parameters.AddWithValue("@User", user);
                    command.Parameters.AddWithValue("@Pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserCache.Cedula = reader.IsDBNull(0) ? "" : reader.GetString(0);
                            UserCache.Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1);
                            UserCache.Direccion = reader.IsDBNull(2) ? "" : reader.GetString(2);
                            UserCache.Telefono = reader.IsDBNull(3) ? "" : reader.GetString(3);
                            UserCache.Correo = reader.IsDBNull(4) ? "" : reader.GetString(4);
                            UserCache.Cargo = reader.IsDBNull(5) ? "" : reader.GetString(5);
                            UserCache.Sueldo = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);
                            UserCache.Usuario = reader.IsDBNull(7) ? "" : reader.GetString(7);
                            UserCache.Password = reader.IsDBNull(8) ? "" : reader.GetString(8);
                            if (!reader.IsDBNull(9))
                            {
                                UserCache.FotoPerfil = (byte[])reader["FotoP"];
                            }

                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tblUSuario WHERE Usuario = @User OR Correo = @Correo";
                    command.Parameters.AddWithValue("@User", userRequesting);
                    command.Parameters.AddWithValue("@Correo", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string UserName = reader.GetString(1);
                        string UserMail = reader.GetString(4);
                        string accountPassword = reader.GetString(8);
                        var mailService = new SystemSupportMail();
                        mailService.sendMail(
                            subject: "SYSTEM: Password recovery request",
                            body: "Hi Mr/Mss. " + UserName + ", \nYou requested to recover your password.\nYour current password is: " + accountPassword + "\nHowever, we recommend you to change your password as soon as possible.",
                            recipientMail: new List<string> { UserMail }
                            );
                        return "Hi Mr/Mss. " + UserName + ", \nYou requested to recover your password.\nPlease check your mail: " + UserMail;
                    }
                    else
                        return "Sorry, but you don't have an account with that mail or username. Check the fields.";
                }
            }
        }
    }
}

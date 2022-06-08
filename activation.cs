using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FirmaXML
{
    class activation
    {
        const string connectionString = "server=172.16.15.62; database=FirmaXML; user=firmador; password=F1rm4equisemeele$.;";
        private static bool Activated { get; set; }

        public static bool isActivated(string key)
        {
            using (MySqlConnection mysqlconn = new MySqlConnection(connectionString))
            {
                string checkForActivationQuery = "SELECT Activado FROM Clientes WHERE SerialKey = @key";
                MySqlCommand cmd = new MySqlCommand(checkForActivationQuery, mysqlconn);
                cmd.Parameters.AddWithValue("@key", key);
                mysqlconn.Open();
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if(result > 0)
                {
                    MessageBox.Show("El software ya ha sido activado");
                    return true;                                        
                }
                MessageBox.Show("El software aún no ha sido activado");
                return false;
            }
        }

        public static void crearRegistro(string nombreempresa, string rutempresa, string email)
        {
            using (MySqlConnection mysqlConn = new MySqlConnection(connectionString))
            {
                string newQuery = "INSERT INTO Clientes(NombreEmpresa, RutEmpresa, Email, SerialKey) " +
                "VALUES(@nombreempresa, @rutempresa, @email, CONCAT((floor(5 + RAND() * (9999))) , (floor(5 + RAND() * (9999))), (floor(5 + RAND() * (9999))), (floor(5 + RAND() * (9999))))";
                MySqlCommand cmd = new MySqlCommand(newQuery, mysqlConn);
                cmd.Parameters.AddWithValue("@nombreempresa", nombreempresa);
                cmd.Parameters.AddWithValue("@rutempresa", rutempresa);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@serialkey", "CONCAT((floor(5 + RAND() * (9999))), - , (floor(5 + RAND() * (9999))), - , (floor(5 + RAND() * (9999))), - , (floor(5 + RAND() * (9999))))");
                mysqlConn.Open();
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result > 0)
                {
                    MessageBox.Show("Usuario Creado");
                    Activated = true;
                }
                else
                {
                    MessageBox.Show("Usuario ya existe");
                    Activated = false;
                }
            }
        }

        public static void activarFirmador(string key)
        {
            if (!isActivated(key))
            {
                using (MySqlConnection mysqlConn = new MySqlConnection(connectionString))
                {
                    string checkForKeyQuery = "SELECT COUNT (*) FROM Clientes WHERE SerialKey = @key";
                    MySqlCommand cmd = new MySqlCommand(checkForKeyQuery, mysqlConn);
                    cmd.Parameters.AddWithValue("@key", key);
                    mysqlConn.Open();
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    if (result > 0)
                    {
                        updateActivation(key);
                        Activated = true;
                    }
                    else
                    {
                        MessageBox.Show("La clave es incorrecta");
                        Activated = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("El software ya ha sido activado");
                Activated = true;
            }
        }

        private static void updateActivation(string key)
        {
            using (MySqlConnection mysqlConn = new MySqlConnection(connectionString))
            {
                string updateQuery = "UPDATE Clientes SET Activado = 1 WHERE SerialKey = @key";
                MySqlCommand cmd = new MySqlCommand(updateQuery, mysqlConn);
                cmd.Parameters.AddWithValue("@key", key);
                mysqlConn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Activación completada");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Management;
using System.Collections;
using System.IO.IsolatedStorage;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FirmaXML
{
    class activation
    {
        const string connectionString = "server=172.16.23.15; database=FirmaXML; user=firmador; password=F1rm4equisemeele$.;";        
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
                if (result > 0)
                {                    
                    return true;                                        
                }                
                return false;
            }
        }

        public static void checkUsuario(string nombreempresa, string rutempresa, string email)
        {
            using (MySqlConnection mysqlConn = new MySqlConnection(connectionString))
            {
                try
                {
                    string checkForKeyQuery = "SELECT * FROM Clientes WHERE RutEmpresa = @rutempresa";
                    MySqlCommand cmd = new MySqlCommand(checkForKeyQuery, mysqlConn);
                    cmd.Parameters.AddWithValue("@rutempresa", rutempresa);
                    mysqlConn.Open();
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    if (result > 0)
                    {
                        MessageBox.Show("Usuario ya existe. Proceda a introducir licencia");
                        Activated = false;
                    }
                    else
                    {
                        crearUsuario(nombreempresa, rutempresa, email);
                    }
                    mysqlConn.Close();
                    //CONCAT((LPAD(FLOOR(RAND() * 10000), 4, '0')), ('-'), (LPAD(FLOOR(RAND() * 10000), 4, '0')), ('-'), (LPAD(FLOOR(RAND() * 10000), 4, '0')), ('-'), (LPAD(FLOOR(RAND() * 10000), 4, '0')))
                }
                catch
                {
                    MessageBox.Show("Error al verificar usuario. Volver a intentar");
                }
            }
        }

        public static void crearUsuario(string nombreempresa, string rutempresa, string email)
        {
            using (MySqlConnection mysqlConn = new MySqlConnection(connectionString))
            {
                try
                {
                    mysqlConn.Open();
                    string newQuery = "INSERT INTO Clientes (NombreEmpresa, RutEmpresa, Email) VALUES ( @nombreempresa, @rutempresa, @email )";
                    MySqlCommand cmd2 = new MySqlCommand(newQuery, mysqlConn);
                    cmd2.Parameters.AddWithValue("@nombreempresa", nombreempresa);
                    cmd2.Parameters.AddWithValue("@rutempresa", rutempresa);
                    cmd2.Parameters.AddWithValue("@email", email);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Usuario Creado");
                    Activated = false;
                    mysqlConn.Close();
                }
                catch
                {
                    MessageBox.Show("Error al crear usuario. Volver a intentar");
                }
                  
            }
        }

        public static void activarFirmador(string rutempresa, string key)
        {            
            using (MySqlConnection mysqlConn = new MySqlConnection(connectionString))
            {                
                string checkForKeyQuery = "SELECT * FROM Clientes WHERE RutEmpresa = @rutempresa AND SerialKey = @key";
                MySqlCommand cmd = new MySqlCommand(checkForKeyQuery, mysqlConn);
                cmd.Parameters.AddWithValue("@rutempresa", rutempresa);
                cmd.Parameters.AddWithValue("@key", key);
                mysqlConn.Open();
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result > 0)
                {
                    updateActivation(key);
                    using (IsolatedStorageFile isolatedStorageFile = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null))
                    {
                        using (IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream("setting.txt", System.IO.FileMode.CreateNew, isolatedStorageFile))
                        {
                            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(isolatedStorageFileStream))
                            {
                                sw.WriteLine(key);
                            }
                        }
                    }
                    Activated = true;
                }
                else
                {
                    MessageBox.Show("La clave es incorrecta");
                    Activated = false;
                }                                                
            }                                   
        }

        private static void updateActivation(string key)
        {
            try
            {
                using (MySqlConnection mysqlConn = new MySqlConnection(connectionString))
                {
                    string updateQuery = "UPDATE Clientes SET Activado = 1 WHERE SerialKey = @key";
                    MySqlCommand cmd = new MySqlCommand(updateQuery, mysqlConn);
                    cmd.Parameters.AddWithValue("@key", key);
                    mysqlConn.Open();
                    cmd.ExecuteNonQuery();
                    mysqlConn.Close();
                    closeForm();
                    MessageBox.Show("Activación completada");
                    string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "settings.txt");
                    StreamWriter sw = new StreamWriter(path);
                    sw.WriteLine(key);
                    sw.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error al activar aplicación. Volver a intentar");
            }
        }

        public static void closeForm()
        {
            FrmRegistro f = new FrmRegistro();
            f.Close();
        }
    }    
}

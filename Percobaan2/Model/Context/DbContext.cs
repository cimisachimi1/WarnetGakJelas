using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;

namespace Percobaan2.Model.Context
{
    public class DbContext : IDisposable
    {
        // deklarasi private variabel / field
        private MySqlConnection? _conn;

        // deklarasi property Conn (connection), untuk menyimpan objek koneksi
        public MySqlConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }

        // Method untuk melakukan koneksi ke database
        private MySqlConnection GetOpenConnection()
        {
            MySqlConnection conn = null; // deklarasi objek connection

            try // penggunaan blok try-catch untuk penanganan error
            {
                // deklarasi variabel connectionStringss
                string connectionString = "server=127.0.0.1; user=root; database=nangis; password=";


                conn = new MySqlConnection(connectionString); // buat objek connection
                
                conn.Open(); // buka koneksi ke database
                
            }
            // jika terjadi error di blok try, akan ditangani langsung oleh blok catch
            catch (Exception ex)
            {
                Console.WriteLine("Open Connection Error: {0}", ex.Message);
                MessageBox.Show(ex.Message);
            }

            return conn;
        }

        // Method to execute SQL script from file
        private void ExecuteSqlScript(MySqlConnection connection, string scriptFilePath)
        {
            try
            {
                string script = File.ReadAllText(scriptFilePath);

                MySqlCommand command = new MySqlCommand(script, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing SQL script: {0}", ex.Message);
            }
        }

        // Method ini digunakan untuk menghapus objek koneksi dari memory ketika sudah tidak digunakan
        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed) _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }

            GC.SuppressFinalize(this);
        }
    }
}

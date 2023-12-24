using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Percobaan2.Model.Entity;
using Percobaan2.Model.Context;

namespace Percobaan2.Model.Repository
{
    public class PelangganRepository
    {
        // deklarasi objek connection
        private MySqlConnection _conn;

        // constructor
        public PelangganRepository(DbContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }

        // constructor with connection parameter
        public PelangganRepository(MySqlConnection connection)
        {
            _conn = connection;
        }

        public List<Pelanggan> ReadAll()
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Pelanggan> list = new List<Pelanggan>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"SELECT ID_Pelanggan, Nama_Pelanggan, Alamat, Email, NomerHp 
                               FROM pelanggan 
                               ORDER BY Nama_Pelanggan";

                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Pelanggan akunPlnggn = new Pelanggan();
                            akunPlnggn.ID_Pelanggan = dtr["ID_Pelanggan"].ToString();
                            akunPlnggn.NamaPelanggan = dtr["NamaPelanggan"].ToString();
                            akunPlnggn.Alamat = dtr["Alamat"].ToString();
                            akunPlnggn.Email = dtr["Email"].ToString();
                            akunPlnggn.NomerHp = dtr["NomerHp"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(akunPlnggn);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return list;
        }

    }
}

using MySql.Data.MySqlClient;
using Percobaan2.Model.Context;
using Percobaan2.Model.Entity;
using System;
using System.Collections.Generic;

namespace Percobaan2.Model.Repository
{
    public class PelangganRepository
    {
        private MySqlConnection _conn;

        public PelangganRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public List<Pelanggan> ReadAll()
        {
            List<Pelanggan> pelangganList = new List<Pelanggan>();

            try
            {
                string sql = @"SELECT ID_Pelanggan, NamaPelanggan, Alamat, Email, NomerHp, Username, Password, SisaWaktu
                           FROM pelanggan 
                           ORDER BY NamaPelanggan";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Pelanggan pelanggan = new Pelanggan
                            {
                                ID_Pelanggan = dtr["ID_Pelanggan"].ToString(),
                                NamaPelanggan = dtr["NamaPelanggan"].ToString(),
                                Alamat = dtr["Alamat"].ToString(),
                                Email = dtr["Email"].ToString(),
                                NomerHp = dtr["NomerHp"].ToString(),
                                Username = dtr["Username"].ToString(),
                                Password = dtr["Password"].ToString(),
                                SisaWaktu = (TimeSpan)dtr["SisaWaktu"]
                            };

                            pelangganList.Add(pelanggan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ReadAllPelanggan error: {0}", ex.Message);
            }

            return pelangganList;
        }

        public int Create(Pelanggan pelanggan)
        {
            int result = 0;

            string sql = @"INSERT INTO pelanggan (ID_Pelanggan, NamaPelanggan, Alamat, Email, NomerHp, Username, Password)
                           VALUES (@ID_Pelanggan, @NamaPelanggan, @Alamat, @Email, @NomerHp, @Username, @Password)";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@ID_Pelanggan", pelanggan.ID_Pelanggan);
                cmd.Parameters.AddWithValue("@NamaPelanggan", pelanggan.NamaPelanggan);
                cmd.Parameters.AddWithValue("@Alamat", pelanggan.Alamat);
                cmd.Parameters.AddWithValue("@Email", pelanggan.Email);
                cmd.Parameters.AddWithValue("@NomerHp", pelanggan.NomerHp);
                cmd.Parameters.AddWithValue("@Username", pelanggan.Username);
                cmd.Parameters.AddWithValue("@Password", pelanggan.Password);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("CreatePelanggan error: {0}", ex.Message);
                }
            }

            return result;
        }
        public int Edit(Pelanggan pelanggan)
        {
            int result = 0;

            string sql = @"UPDATE pelanggan 
                   SET NamaPelanggan = @NamaPelanggan, 
                       Alamat = @Alamat, 
                       Email = @Email, 
                       NomerHp = @NomerHp, 
                       Username = @Username, 
                       Password = @Password, 
                       SisaWaktu = @SisaWaktu
                   WHERE ID_Pelanggan = @ID_Pelanggan";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@ID_Pelanggan", pelanggan.ID_Pelanggan);
                cmd.Parameters.AddWithValue("@NamaPelanggan", pelanggan.NamaPelanggan);
                cmd.Parameters.AddWithValue("@Alamat", pelanggan.Alamat);
                cmd.Parameters.AddWithValue("@Email", pelanggan.Email);
                cmd.Parameters.AddWithValue("@NomerHp", pelanggan.NomerHp);
                cmd.Parameters.AddWithValue("@Username", pelanggan.Username);
                cmd.Parameters.AddWithValue("@Password", pelanggan.Password);
                cmd.Parameters.AddWithValue("@SisaWaktu", pelanggan.SisaWaktu);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("EditPelanggan error: {0}", ex.Message);
                }
            }

            return result;
        }
    }
}

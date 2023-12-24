using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Percobaan2.Model.Entity;
using Percobaan2.Model.Context;

namespace Percobaan2.Model.Repository
{
    public class KomputerWarnetRepository
    {
        private MySqlConnection _conn;

        public KomputerWarnetRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(KomputerWarnet komputer)
        {
            int result = 0;

            string sql = @"INSERT INTO komputer_warnet (ID_Komputer, Ketersediaan, Jenis_Komputer)
                           VALUES (@ID_Komputer, @Ketersediaan, @Jenis_Komputer)";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@ID_Komputer", komputer.ID_Komputer);
                cmd.Parameters.AddWithValue("@Ketersediaan", komputer.Ketersediaan);
                cmd.Parameters.AddWithValue("@Jenis_Komputer", komputer.Jenis_Komputer);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Create error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Update(KomputerWarnet komputer)
        {
            int result = 0;

            string sql = @"UPDATE komputer_warnet 
                           SET Ketersediaan = @Ketersediaan, Jenis_Komputer = @Jenis_Komputer
                           WHERE ID_Komputer = @ID_Komputer";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Ketersediaan", komputer.Ketersediaan);
                cmd.Parameters.AddWithValue("@Jenis_Komputer", komputer.Jenis_Komputer);
                cmd.Parameters.AddWithValue("@ID_Komputer", komputer.ID_Komputer);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Update error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Delete(KomputerWarnet komputer)
        {
            int result = 0;

            string sql = @"DELETE FROM komputer_warnet
                           WHERE ID_Komputer = @ID_Komputer";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@ID_Komputer", komputer.ID_Komputer);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }

        public List<KomputerWarnet> ReadAll()
        {
            List<KomputerWarnet> list = new List<KomputerWarnet>();

            try
            {
                string sql = @"SELECT ID_Komputer, Ketersediaan, Jenis_Komputer 
                               FROM komputer_warnet 
                               ORDER BY Jenis_Komputer";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            KomputerWarnet komputer = new KomputerWarnet();
                            komputer.ID_Komputer = dtr["ID_Komputer"].ToString(); 
                            komputer.Ketersediaan = Convert.ToBoolean(dtr["Ketersediaan"]);
                            komputer.Jenis_Komputer = dtr["Jenis_Komputer"].ToString();

                            list.Add(komputer);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ReadAll error: {0}", ex.Message);
            }

            return list;
        }

        public List<KomputerWarnet> ReadByJenis(string jenis)
        {
            List<KomputerWarnet> list = new List<KomputerWarnet>();

            try
            {
                string sql = @"SELECT ID_Komputer, Ketersediaan, Jenis_Komputer 
                               FROM komputer_warnet 
                               WHERE Jenis_Komputer LIKE @Jenis
                               ORDER BY Jenis_Komputer";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@Jenis", "%" + jenis + "%");

                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            KomputerWarnet komputer = new KomputerWarnet();
                            komputer.ID_Komputer = dtr["ID_Komputer"].ToString();
                            komputer.Ketersediaan = Convert.ToBoolean(dtr["Ketersediaan"]);
                            komputer.Jenis_Komputer = dtr["Jenis_Komputer"].ToString();

                            list.Add(komputer);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ReadByJenis error: {0}", ex.Message);
            }

            return list;
        }

        public KomputerWarnet ReadByID(int ID_Komputer)
        {
            KomputerWarnet komputer = null;

            try
            {
                string sql = @"SELECT ID_Komputer, Ketersediaan, Jenis_Komputer 
                               FROM komputer_warnet 
                               WHERE ID_Komputer = @ID_Komputer";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Komputer", ID_Komputer);

                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        if (dtr.Read())
                        {
                            komputer = new KomputerWarnet();
                            komputer.ID_Komputer = dtr["ID_Komputer"].ToString();
                            komputer.Ketersediaan = Convert.ToBoolean(dtr["Ketersediaan"]);
                            komputer.Jenis_Komputer = dtr["Jenis_Komputer"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ReadByID error: {0}", ex.Message);
            }

            return komputer;
        }
    }
}

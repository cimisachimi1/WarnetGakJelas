using MySql.Data.MySqlClient;
using Percobaan2.Model.Context;
using Percobaan2.Model.Entity;
using System;
using System.Collections.Generic;

namespace Percobaan2.Model.Repository
{
    public class PaketRepository
    {
        private MySqlConnection _conn;

        public PaketRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public List<Paket> ReadAll()
        {
            List<Paket> paketList = new List<Paket>();

            try
            {
                string sql = @"SELECT ID_Paket, Nama, Menit, Harga, Jumlah
                               FROM paket 
                               ORDER BY ID_Paket";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Paket paket = new Paket
                            {
                                ID_Paket = dtr["ID_Paket"].ToString(),
                                Nama = dtr["Nama"].ToString(),
                                Menit = Convert.ToInt32(dtr["Menit"]),
                                Harga = Convert.ToInt32(dtr["Harga"]),
                                Jumlah = Convert.ToInt32(dtr["Jumlah"])
                            };

                            paketList.Add(paket);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ReadAllPaket error: {0}", ex.Message);
            }

            return paketList;
        }
    }
}

using MySql.Data.MySqlClient;
using Percobaan2.Model.Context;
using Percobaan2.Model.Entity;
using System;
using System.Collections.Generic;

namespace Percobaan2.Model.Repository
{
    public class TransaksiRepository
    {
        private MySqlConnection _conn;

        public TransaksiRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public List<Transaksi> ReadAll()
        {
            List<Transaksi> transaksiList = new List<Transaksi>();

            try
            {
                string sql = @"SELECT ID_Transaksi, ID_Pelanggan, TanggalTransaksi, WaktuTerpakai, Harga, ID_Operator
                           FROM transaksi 
                           ORDER BY TanggalTransaksi";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Transaksi transaksi = new Transaksi
                            {
                                ID_Transaksi = dtr["ID_Transaksi"].ToString(),
                                ID_Pelanggan = dtr["ID_Pelanggan"].ToString(),
                                TanggalTransaksi = (DateTime)dtr["TanggalTransaksi"],
                                WaktuTerpakai = (DateTime)dtr["WaktuTerpakai"],
                                Harga = (int)dtr["Harga"],
                                ID_Operator = dtr["ID_Operator"].ToString()
                            };

                            transaksiList.Add(transaksi);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ReadAllTransaksi error: {0}", ex.Message);
            }

            return transaksiList;
        }
        public int Create(Transaksi transaksi)
        {
            int result = 0;

            string sql = @"INSERT INTO transaksi (ID_Transaksi, ID_Pelanggan, TanggalTransaksi, WaktuTerpakai, Harga, ID_Operator)
                   VALUES (@ID_Transaksi, @ID_Pelanggan, @TanggalTransaksi, @WaktuTerpakai, @Harga, @ID_Operator)";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@ID_Transaksi", transaksi.ID_Transaksi);
                cmd.Parameters.AddWithValue("@ID_Pelanggan", transaksi.ID_Pelanggan);
                cmd.Parameters.AddWithValue("@TanggalTransaksi", transaksi.TanggalTransaksi);
                cmd.Parameters.AddWithValue("@WaktuTerpakai", transaksi.WaktuTerpakai);
                cmd.Parameters.AddWithValue("@Harga", transaksi.Harga);
                cmd.Parameters.AddWithValue("@ID_Operator", transaksi.ID_Operator);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("CreateTransaksi error: {0}", ex.Message);
                }
            }

            return result;
        }

    }
}

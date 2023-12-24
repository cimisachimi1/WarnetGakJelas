using MySql.Data.MySqlClient;
using Percobaan2.Model.Context;
using Percobaan2.Model.Entity;

namespace Percobaan2.Model.Repository
{
    public class OperatorRepository
    {
        private MySqlConnection _conn;

        public OperatorRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Operator operatorObject)
        {
            int result = 0;

            string sql = @"INSERT INTO operator (ID_Operator, Nama, Alamat, Umur, Mulai_Shift, Akhir_Shift, Username, Password)
                           VALUES (@ID_Operator, @Nama, @Alamat, @Umur, @Mulai_Shift, @Akhir_Shift, @Username, @Password)";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@ID_Operator", operatorObject.ID_Operator);
                cmd.Parameters.AddWithValue("@Nama", operatorObject.Nama);
                cmd.Parameters.AddWithValue("@Alamat", operatorObject.Alamat);
                cmd.Parameters.AddWithValue("@Umur", operatorObject.Umur);
                cmd.Parameters.AddWithValue("@Mulai_Shift", operatorObject.Mulai_Shift);
                cmd.Parameters.AddWithValue("@Akhir_Shift", operatorObject.Akhir_Shift);
                cmd.Parameters.AddWithValue("@Username", operatorObject.Username);
                cmd.Parameters.AddWithValue("@Password", operatorObject.Password);

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
        public List<Operator> ReadAll()
        {
            List<Operator> operators = new List<Operator>();

            try
            {
                string sql = @"SELECT ID_Operator, Nama, Alamat, Umur, Mulai_Shift, Akhir_Shift, Username, Password
                       FROM operator 
                       ORDER BY Nama";  // You can change the ORDER BY clause as per your requirement

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Operator operatorObject = new Operator
                            {
                                ID_Operator = dtr["ID_Operator"].ToString(),
                                Nama = dtr["Nama"].ToString(),
                                Alamat = dtr["Alamat"].ToString(),
                                Umur = Convert.ToInt32(dtr["Umur"]),
                                Mulai_Shift = Convert.ToDateTime(dtr["Mulai_Shift"]),
                                Akhir_Shift = Convert.ToDateTime(dtr["Akhir_Shift"]),
                                Username = dtr["Username"].ToString(),
                                Password = dtr["Password"].ToString()
                            };

                            operators.Add(operatorObject);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ReadAllOperators error: {0}", ex.Message);
            }

            return operators;
        }

    }
}

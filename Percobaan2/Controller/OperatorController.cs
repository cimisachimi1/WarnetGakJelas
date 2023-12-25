using Percobaan2.Model.Entity;
using Percobaan2.Model.Repository;
using Percobaan2.Model.Context;
using System.Collections.Generic;

namespace Percobaan2.Controller
{
    public class OperatorController
    {
        private OperatorRepository _repository;

        public List<Operator> ReadAll()
        {
            List<Operator> operators = new List<Operator>();

            using (DbContext context = new DbContext())
            {
                _repository = new OperatorRepository(context);
                operators = _repository.ReadAll();
            }

            return operators;
        }

        // You can add additional methods for Create, Edit, Delete, etc., as needed.
        // Example:

        public int CreateOperator(Operator operatorObject)
        {
            using (DbContext context = new DbContext())
            {
                _repository = new OperatorRepository(context);
                return _repository.Create(operatorObject);
            }
        }
        public bool IsValidOperator(string userName, string password)
        {
            // cek username yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Username harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            // cek password yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            bool isValidOperator = false;

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new OperatorRepository(context);

                // panggil method IsValidOperator class repository untuk memeriksa keberadaan operator
                isValidOperator = _repository.IsValidOperator(userName, password);
            }

            if (!isValidOperator)
            {
                MessageBox.Show("Username atau password operator salah !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }


    }
}

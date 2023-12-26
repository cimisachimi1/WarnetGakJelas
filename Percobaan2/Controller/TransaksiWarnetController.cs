using Percobaan2.Model.Entity;
using Percobaan2.Model.Repository;
using Percobaan2.Model.Context;
using System.Collections.Generic;

namespace Percobaan2.Controller
{
    public class TransaksiWarnetController
    {
        private TransaksiWarnetRepository _repository;

        public List<TransaksiWarnet> ReadAll()
        {
            List<TransaksiWarnet> transaksiWarnets = new List<TransaksiWarnet>();

            using (DbContext context = new DbContext())
            {
                _repository = new TransaksiWarnetRepository(context);
                transaksiWarnets = _repository.ReadAll();
            }

            return transaksiWarnets;
        }
        public int Create(TransaksiWarnet transaksi)
        {
            int result = 0;

            // Create a context using a using block
            using (DbContext context = new DbContext())
            {
                // Create a repository object
                _repository = new TransaksiWarnetRepository(context); // Assuming you have a TransaksiWarnetRepository class

                // Call the Create method of the repository to add data
                result = _repository.Create(transaksi);
            }

            // Display appropriate messages based on the result
            if (result > 0)
            {
                MessageBox.Show("Data transaksi berhasil disimpan !", "Informasi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data transaksi gagal disimpan !!!", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

    }

}



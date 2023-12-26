using Percobaan2.Model.Entity;
using Percobaan2.Model.Repository;
using Percobaan2.Model.Context;
using System.Collections.Generic;

namespace Percobaan2.Controller
{
    public class TransaksiController
    {
        private TransaksiRepository transaksirepository;

        public List<Transaksi> ReadAll()
        {
            List<Transaksi> transaksis = new List<Transaksi>();

            using (DbContext context = new DbContext())
            {
                transaksirepository = new TransaksiRepository(context);
                transaksis = transaksirepository.ReadAll();
            }

            return transaksis;
        }

        public int Create(Transaksi transaksi)
        {
            int result = 0;
            // Create a context using a using block
            using (DbContext context = new DbContext())
            {
                // Create a repository object
                transaksirepository = new TransaksiRepository(context); // Assuming you have a PelangganRepository class

                // Call the Create method of the repository to add data
                result = transaksirepository.Create(transaksi);
            }

            // Display appropriate messages based on the result
            if (result > 0)
            {
                MessageBox.Show("Data pelanggan berhasil disimpan !", "Informasi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data pelanggan gagal disimpan !!!", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }


    }
}

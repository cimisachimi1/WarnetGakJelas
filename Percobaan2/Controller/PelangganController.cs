using Percobaan2.Model.Entity;
using Percobaan2.Model.Repository;
using Percobaan2.Model.Context;
using System.Collections.Generic;

namespace Percobaan2.Controller
{
    public class PelangganController
    {
        private PelangganRepository _repository;

        public List<Pelanggan> ReadAll()
        {
            List<Pelanggan> pelanggans = new List<Pelanggan>();

            using (DbContext context = new DbContext())
            {
                _repository = new PelangganRepository(context);
                pelanggans = _repository.ReadAll();
            }

            return pelanggans;
        }

        // You can add additional methods for Create, Edit, Delete, etc., as needed.
        // Example:


        public int Create(Pelanggan pelanggan)
        {
            int result = 0;

            // Check if ID_Pelanggan is empty or null
            if (string.IsNullOrEmpty(pelanggan.ID_Pelanggan))
            {
                MessageBox.Show("ID Pelanggan harus diisi !!!", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // Check if NamaPelanggan is empty or null
            if (string.IsNullOrEmpty(pelanggan.NamaPelanggan))
            {
                MessageBox.Show("Nama Pelanggan harus diisi !!!", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // You can add similar checks for other properties if needed

            // Create a context using a using block
            using (DbContext context = new DbContext())
            {
                // Create a repository object
                _repository = new PelangganRepository(context); // Assuming you have a PelangganRepository class

                // Call the Create method of the repository to add data
                result = _repository.Create(pelanggan);
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


        public int Update(Pelanggan pelangganObject)
        {
            using (DbContext context = new DbContext())
            {
                _repository = new PelangganRepository(context);
                return _repository.Edit(pelangganObject);
            }
        }

    }
}

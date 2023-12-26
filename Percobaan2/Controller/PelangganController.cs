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
        public int Delete(Pelanggan pelanggan)
        {
            int result = 0;

            // Check if ID_Pelanggan is empty or null
            if (string.IsNullOrEmpty(pelanggan.ID_Pelanggan))
            {
                MessageBox.Show("ID Pelanggan harus dipilih untuk dihapus !!!", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // Create a context using a using block
            using (DbContext context = new DbContext())
            {
                // Create a repository object
                _repository = new PelangganRepository(context);

                // Call the Delete method of the repository to delete data
                result = _repository.Delete(pelanggan);
            }

            // Display appropriate messages based on the result
            if (result > 0)
            {
                MessageBox.Show("Data pelanggan berhasil dihapus !", "Informasi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data pelanggan gagal dihapus !!!", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        // You can add additional methods for Create, Edit, Delete, etc., as needed.
        // Example:
        public List<Pelanggan> ReadByNama(string nama)
        {
            // membuat objek collection
            List<Pelanggan> list = new List<Pelanggan>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PelangganRepository(context); // Assuming you have a PelangganRepository

                // panggil method ReadByNama yang ada di dalam class repository
                list = _repository.ReadByNama(nama);
            }

            return list;
        }


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


        public int Update(Pelanggan pelanggan)
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

            // Create a context using a using block
            using (DbContext context = new DbContext())
            {
                // Create a repository object
                _repository = new PelangganRepository(context); // Assuming you have a PelangganRepository class

                // Call the Create method of the repository to add data
                result = _repository.Update(pelanggan);
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

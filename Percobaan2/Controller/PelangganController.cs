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


        public int CreatePelanggan(Pelanggan pelangganObject)
        {
            using (DbContext context = new DbContext())
            {
                _repository = new PelangganRepository(context);
                return _repository.Create(pelangganObject);
            }
        }

        // Add other methods as needed for Pelanggan CRUD operations.
    }
}

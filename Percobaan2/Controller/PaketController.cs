using Percobaan2.Model.Entity;
using Percobaan2.Model.Repository;
using Percobaan2.Model.Context;
using System.Collections.Generic;

namespace Percobaan2.Controller
{
    public class PaketController
    {
        private PaketRepository _repository;

        public List<Paket> ReadAll()
        {
            List<Paket> pakets = new List<Paket>();

            using (DbContext context = new DbContext())
            {
                _repository = new PaketRepository(context);
                pakets = _repository.ReadAll();
            }

            return pakets;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Percobaan2.Model.Entity;
using Percobaan2.Model.Repository;
using Percobaan2.Model.Context;

namespace Percobaan2.Controller
{
    public class PelangganController
    {
        private PelangganRepository _repository;


        public List<Pelanggan> ReadAll()
        {
            List<Pelanggan> list = new List<Pelanggan>();

            using (DbContext context = new DbContext())
            {
                _repository = new PelangganRepository(context);
                list = _repository.ReadAll();
            }

            return list;
        }
    }
}

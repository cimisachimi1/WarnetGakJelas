using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Percobaan2.Model.Entity;
using Percobaan2.Model.Repository;
using Percobaan2.Model.Context;

namespace Percobaan2.Controller
{
    public class KomputerWarnetController
    {
        private KomputerWarnetRepository _repository;

        public List<KomputerWarnet> ReadAll()
        {
            List<KomputerWarnet> list = new List<KomputerWarnet>();

            using (DbContext context = new DbContext())
            {
                _repository = new KomputerWarnetRepository(context);
                list = _repository.ReadAll();
            }

            return list;
        }

        public KomputerWarnet ReadByID(int ID_Komputer)
        {
            KomputerWarnet komputer = null;

            using (DbContext context = new DbContext())
            {
                _repository = new KomputerWarnetRepository(context);
                komputer = _repository.ReadByID(ID_Komputer);
            }

            return komputer;
        }

        public List<KomputerWarnet> ReadByJenis(string jenis)
        {
            List<KomputerWarnet> list = new List<KomputerWarnet>();

            using (DbContext context = new DbContext())
            {
                _repository = new KomputerWarnetRepository(context);
                list = _repository.ReadByJenis(jenis);
            }

            return list;
        }




    }
}

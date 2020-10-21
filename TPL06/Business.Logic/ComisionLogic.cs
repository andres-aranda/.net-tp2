using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class ComisionLogic : BusinessLogic
    {
        public ComisionesAdapter ComisionData { get; set; }

        public ComisionLogic()
        {
            ComisionData = new ComisionesAdapter();
        }

        public List<Comision> GetAll()
        {
            return ComisionData.GetAll();
        }

        public Comision GetOne(int id)
        {
            return ComisionData.GetOne(id);
        }

        public void Save(Comision c)
        {
            ComisionData.Save(c);
        }

        public void Delete(int id)
        {
            ComisionData.Delete(id);
        }
        public List<Comision> GetByMateria(int idMateria)
        {
            return ComisionData.GetByMateria(idMateria);
        }
    }
}

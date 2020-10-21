using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class MateriaLogic : BusinessLogic
    {
        public MateriaAdapter MateriaData { get; set; }

        public MateriaLogic()
        {
            MateriaData = new MateriaAdapter();
        }

        public List<Materia> GetAll()
        {
            return MateriaData.GetAll();
        }
        
        public List<Materia> GetByPlan(int idPLan)
        {
            return MateriaData.GetByPlan(idPLan);
        }  
    

        public Materia GetOne(int id)
        {
            return MateriaData.GetOne(id);
        }

        public void Save(Materia m)
        {
            MateriaData.Save(m);
        }

        public void Delete(int id)
        {
            MateriaData.Delete(id);
        }
    }
}

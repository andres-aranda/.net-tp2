using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;


namespace Business.Logic
{
   public class ModuloLogic : BusinessLogic
    {
        public ModuloAdapter ModuloData { get; set; }

        public ModuloLogic()
        {
            ModuloData = new ModuloAdapter();
        }

        public List<Modulo> GetAll()
        {
            return ModuloData.GetAll();
        }

        public Modulo GetOne(int id)
        {
            return ModuloData.GetOne(id);
        }

        public void Save(Modulo u)
        {
            ModuloData.Save(u);
        }

        public void Delete(int id)
        {
            ModuloData.Delete(id);
        }
    }
}

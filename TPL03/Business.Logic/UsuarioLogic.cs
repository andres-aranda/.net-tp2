using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        public UsuarioLogic()
        {
            this.UsuarioData = UsuarioData;
        }
        public Data.Database.UsuarioAdapter UsuarioData
        {
            get => default;
            set
            {
              GetAll();
            }


        }
        public List<Usuario> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void GetOne()
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        public void Delete()
        {
            throw new System.NotImplementedException();
        }
    }
}

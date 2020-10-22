using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class PersonaLogic : BusinessLogic
    {
        public PersonaAdapter PersonaData { get; set; }

        public PersonaLogic()
        {
            PersonaData = new PersonaAdapter();
        }

        public List<Persona> GetAll()
        {
            return PersonaData.GetAll();
        }

        public Persona GetOne(int id)
        {
            return PersonaData.GetOne(id);
        }

        public void Save(Persona m)
        {
            PersonaData.Save(m);
        }

        public void Delete(int id)
        {
            PersonaData.Delete(id);
        }

        public List<Materia> GetMateriasPlan(int idPersona)
        {
            return PersonaData.GetMateriasPlan(idPersona);
        }
    }
}


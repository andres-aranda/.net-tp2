using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class CursoLogic : BusinessLogic
    {
        public CursoAdapter CursoData { get; set; }
        public InscripcionAdapter InscripcionData { get; set; }

        public List<Inscripcion> GetMateriasInscripciones(int id)
        {
            return CursoData.GetMateriasInscripciones(id);
        }
        public List<Inscripcion> GetMateriasInscripcionesDocente(int id)
        {
            return CursoData.GetMateriasInscripcionesDocente(id);
        }

        public List<Curso> GetCursosDocente(int id)
        {
            return CursoData.GetCursosDocente(id);
        }


        public CursoLogic()
        {
            CursoData = new CursoAdapter();
            InscripcionData = new InscripcionAdapter();
        }

        public List<Curso> GetAll()
        {
            return CursoData.GetAll();
        }

        public Curso GetOne(int id)
        {
            return CursoData.GetOne(id);
        }
        public Curso GetByComisionMateria(int idCom, int idMat )
        {
            return CursoData.GetByMateriaCom(idCom, idMat);
        }

        public void Save(Curso m)
        {
            CursoData.Save(m);
        }

        public void Delete(int id)
        {
            CursoData.Delete(id);
        }
        public List<Curso> GetByMateria(int id)
        {
            return CursoData.GetByMaterias(id);
        }

        public void Inscribir(int idAlumno, int idCurso)
        {
            InscripcionData.Inscribir(idAlumno, idCurso);
        }
    }
}

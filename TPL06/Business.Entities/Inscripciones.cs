using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Inscripcion : BusinessEntity
    {
        private int _IdInscripcion;
        private int _IdAlumno;
        private int _IdCurso;
        private string _Condicion;
        private int _Nota;
        private Curso _Curso;
        private Persona _Persona;

        public Persona Persona
        {
            get => _Persona;
            set => _Persona = value;
        } 
        public Curso Curso
        {
            get => _Curso;
            set => _Curso = value;
        }
 
        public int IdInscripcion
        {
            get => _IdInscripcion;
            set => _IdInscripcion = value;
        } 
        public int IdCurso
        {
            get => _IdCurso;
            set => _IdCurso = value;
        }
        public int IdAlumno
        {
            get => _IdAlumno;
            set => _IdAlumno = value;
        }

        public string Condicion
        {
            get => _Condicion;
            set => _Condicion = value;
        }

        public int Nota
        {
            get => _Nota;
            set => _Nota = value;
        }


    }
}
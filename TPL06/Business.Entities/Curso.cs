using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Curso : BusinessEntity
    {
        private int _AñoCalendario;
        private int _Cupo;
        private string _Descripcion;
        private Materia _Materia;
        private Comision _Comision;


        public Comision Comision
        {
            get => _Comision;
            set => _Comision = value;
        }
        public Materia Materia
        {
            get => _Materia;
            set => _Materia = value;
        }
        
        public int AñoCalendario
        {
            get => _AñoCalendario;
            set => _AñoCalendario = value;
        }

        public int Cupo
        {
            get => _Cupo;
            set => _Cupo = value;
        }

        public string Descripcion
        {
            get => _Descripcion;
            set => _Descripcion = value;
        }
    }
}
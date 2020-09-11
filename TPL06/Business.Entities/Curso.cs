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
        private int _IdComision;
        private int _IdMateria;
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
            get => default;
            set
            {
            }
        }

        public int Cupo
        {
            get => default;
            set
            {
            }
        }

        public string Descripcion
        {
            get => default;
            set
            {
            }
        }

        public int IdComision
        {
            get => default;
            set
            {
            }
        }

        public int IdMateria
        {
            get => default;
            set
            {
            }
        }
    }
}
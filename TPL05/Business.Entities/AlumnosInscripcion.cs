﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class AlumnosInscripcion : BusinessEntity
    {
        private String _Condicion;
        private int _Nota;
        private int _IdCurso;
        private int _IdAlumno;

        public string Condicion
        {
            get; set;
        }

        public int Nota
        {
            get; set;
        }

        public int IdCurso
        {
            get; set;
        }

        public int IdAlumno
        {
            get; set;
        }
    }
}
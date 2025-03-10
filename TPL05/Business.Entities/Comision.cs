﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Comision : BusinessEntity
    {
        private int _AñoEspecialidad;
        private string _Descripcion;
        private int _IdPlan;

        public int AñoEspecialidad
        {
            get => _AñoEspecialidad;
            set => _AñoEspecialidad = value;
        }

        public string Descripcion
        {
            get => _Descripcion;
            set => _Descripcion = value;
        }

        public int IdPlan
        {
            get => _IdPlan;
            set => _IdPlan = value;
        }
    }
}

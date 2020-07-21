using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace Business.Entities
{
    public class Materia : BusinessEntity
    {
        private string _Descripcion;
        private int _HsSemanales;
        private int _HsTotales;
        private int _IdPlan;

        public string Descripcion
        {
            get => _Descripcion;
            set => _Descripcion = value;
        }

        public int HsSemanales
        {
            get => _HsSemanales;
            set => _HsSemanales = value;
        }

        public int HsTotales
        {
            get => _HsTotales;
            set => _HsTotales = value;
        }

        public int IdPlan
        {
            get => _IdPlan;
            set => _IdPlan = value;
        }
    }
}
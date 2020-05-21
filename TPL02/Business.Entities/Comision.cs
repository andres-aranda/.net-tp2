using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    class Comision : BusinessEntity
    {
        private int _AñoEspecialidad;
        private string _Descripcion;
        private int _IdPlan;

        public int AñoEspecialidad
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

        public int IdPlan
        {
            get => default;
            set
            {
            }
        }
    }
}

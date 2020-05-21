using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class DocenteCurso : BusinessEntity
    {
        private TipoCargo _Cargo;
        private int _IdCurso;
        private int _IdDocente;

        public enum TipoCargo
        {
            Deleted,
            New,
            Modified,
            Unmodified
        }
        public TipoCargo Cargo
        {
            get => default;
            set
            {
            }
        }

        public int IdCurso
        {
            get => default;
            set
            {
            }
        }

        public int IdDocente
        {
            get => default;
            set
            {
            }
        }
    }
}
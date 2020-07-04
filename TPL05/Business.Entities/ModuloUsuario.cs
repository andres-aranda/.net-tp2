using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class ModuloUsuario : BusinessEntity
    {
        private int _IdModulo;
        private int _IdUsuario;
        private bool _PermiteAlta;
        private bool _PermiteBaja;
        private bool _PermiteModificacion;
        private bool _PermiteConsulta;

        public int IdModulo
        {
            get => default;
            set
            {
            }
        }

        public int IdUsuario
        {
            get => default;
            set
            {
            }
        }

        public bool PermiteAlta
        {
            get => default;
            set
            {
            }
        }

        public bool PermiteBaja
        {
            get => default;
            set
            {
            }
        }

        public bool PermiteConsulta
        {
            get => default;
            set
            {
            }
        }

        public bool PermiteModificacion
        {
            get => default;
            set
            {
            }
        }
    }
}
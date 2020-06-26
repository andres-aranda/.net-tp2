using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Usuario:BusinessEntity
    {
        private string _Apellido;
        private String _Nombre;
        private String _NombreUsuario;
        private String _Email;
        private string _Clave;
        private bool _Habilitado;

        public string Apellido
        {
            get => default;
            set
            {
            }
        }

        public string Clave
        {
            get => default;
            set
            {
            }
        }

        public String Email
        {
            get => default;
            set
            {
            }
        }

        public string Nombre
        {
            get => default;
            set
            {
            }
        }

        public string NombreUsuario
        {
            get => default;
            set
            {
            }
        }

        public bool Habilitado
        {
            get => default;
            set
            {
            }
        }
    }
}

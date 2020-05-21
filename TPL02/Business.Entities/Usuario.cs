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
        private System.Net.Mail.MailAddress _Email;
        private string _Clave;

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

        public System.Net.Mail.MailAddress Email
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
    }
}

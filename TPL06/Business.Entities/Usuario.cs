using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Business.Entities
{
    public class Usuario : BusinessEntity
    {
        private String _NombreUsuario;
        private string _Clave;
        private bool _Habilitado;
        private List<Modulo> modulo;
        private Persona _persona;

        public Persona Persona
        {
            get => _persona;
            set => _persona = value;
        }

        public string Clave
        {
            get { return _Clave; }
            set { _Clave = value; }
        }

        public string NombreUsuario
        {
            get { return _NombreUsuario; }
            set { _NombreUsuario = value; }
        }

        public bool Habilitado
        {
            get { return _Habilitado; }
            set { _Habilitado = value; }
        }

        public List<Modulo> Modulo
        {
            get => modulo;
            set => modulo = value;
        }

        public Usuario() { }
    }
}

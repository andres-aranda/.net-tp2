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
        public Usuario()
        {
            
        }
        private string _Apellido;
        private String _Nombre;
        private String _NombreUsuario;
        private String _Email;
        private string _Clave;
        private bool _Habilitado;

        protected SqlDataAdapter _daUsuarios;

        public SqlDataAdapter daUsuarios
        {
            get { return _daUsuarios; }
            set { _daUsuarios = value; }
        }

        protected SqlConnection _conn;

        public SqlConnection Conn
        {
            get { return _conn; }
            set { _conn = value; }
        }

        public DataTable GetAll()
        {
            DataTable dtUsuarios = new DataTable();
            this.daUsuarios.Fill(dtUsuarios);
            return dtUsuarios;
        }
        public void GuardarCambios(DataTable dtUsuarios)
        {
            this.daUsuarios.Update(dtUsuarios);
            dtUsuarios.AcceptChanges();
        }
        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        public string Clave
        {
            get { return _Clave; }
            set { _Clave = value; }
        }

        public String Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
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
    }
}

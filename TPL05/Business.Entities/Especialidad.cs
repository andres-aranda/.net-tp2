using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Business.Entities
{
    public class Especialidad : BusinessEntity
    {
        public Especialidad()
        {

        }
        private string _Descripcion;


        protected SqlDataAdapter _daEspecialidades;

        public SqlDataAdapter daEspecialidades
        {
            get { return _daEspecialidades; }
            set { _daEspecialidades = value; }
        }

        protected SqlConnection _conn;

        public SqlConnection Conn
        {
            get { return _conn; }
            set { _conn = value; }
        }

        public DataTable GetAll()
        {
            DataTable dtEspecialidades = new DataTable();
            this.daEspecialidades.Fill(dtEspecialidades);
            return dtEspecialidades;
        }
        public void GuardarCambios(DataTable dtEspecialidades)
        {
            this.daEspecialidades.Update(dtEspecialidades);
            dtEspecialidades.AcceptChanges();
        }
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
    }
}

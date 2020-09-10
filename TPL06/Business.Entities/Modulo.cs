using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Business.Entities
{
   public class Modulo : BusinessEntity
    {
        public Modulo()
        {

        }
        private string _Descripcion;

        protected SqlDataAdapter _daModulos;

        public SqlDataAdapter daModulos
        {
            get { return _daModulos; }
            set { _daModulos = value; }
        }

        protected SqlConnection _conn;

        public SqlConnection Conn
        {
            get { return _conn; }
            set { _conn = value; }
        }

        public DataTable GetAll()
        {
            DataTable dtModulos = new DataTable();
            this.daModulos.Fill(dtModulos);
            return dtModulos;
        }
        public void GuardarCambios(DataTable dtModulos)
        {
            this.daModulos.Update(dtModulos);
            dtModulos.AcceptChanges();
        }
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
    }
}

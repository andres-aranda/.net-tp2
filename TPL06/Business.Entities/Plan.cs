using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Business.Entities
{
    public class Plan : BusinessEntity
    {
        public Plan() 
        {

        }

        private string _Descripcion;
        private int _IdEspecialidad;
        private Especialidad _especialidad;
        protected SqlDataAdapter _daPlanes;

        public SqlDataAdapter daPlanes
        {
            get { return _daPlanes; }
            set { _daPlanes = value; }
        }

        protected SqlConnection _conn;

        public SqlConnection Conn
        {
            get { return _conn; }
            set { _conn = value; }
        }

        public DataTable GetAll()
        {
            DataTable dtPlanes = new DataTable();
            this.daPlanes.Fill(dtPlanes);
            return dtPlanes;
        }
        public void GuardarCambios(DataTable dtPlanes)
        {
            this.daPlanes.Update(dtPlanes);
            dtPlanes.AcceptChanges();
        }
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        public int IdEspecialidad
        {
            get { return _IdEspecialidad; }
            set { _IdEspecialidad = value; }
        }

        public Especialidad Especialidad { get => _especialidad; set => _especialidad = value; }
    }
}

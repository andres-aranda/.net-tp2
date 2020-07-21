using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Data.Database
{
    public class MateriaAdapter : Adapter
    {
        public List<Materia> GetAll()
        {
            List<Materia> materias = new List<Materia>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMaterias = new SqlCommand("SELECT * FROM materias", Sqlconn);
                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();
                while (drMaterias.Read())
                {
                    Materia m = new Materia();
                    m.Id = (int)drMaterias["id_materia"];
                    m.Descripcion = (string)drMaterias["desc_materia"];
                    m.HsSemanales = (int)drMaterias["hs_semanales"];
                    m.HsTotales = (int)drMaterias["hs_totales"];
                    m.IdPlan = (int)drMaterias["id_plan"];

                    materias.Add(m);
                }
                drMaterias.Close();
            }
            catch (Exception e)
            {
                Exception ex = new Exception("Error al recuperar la lista de materias", e);
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
            return materias;
        }
    }
}

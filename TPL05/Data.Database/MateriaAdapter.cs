using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Data.Database
{
    public class MateriaAdapter : Adapter
    {
        public void Insert(Materia m)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO materias (desc_materia, hs_semanales, hs_totales, id_plan)" +
                    " VALUES (@desc_materia, @hs_semanales, @hs_totales, @id_plan)" +
                    " SELECT @@identity", Sqlconn);

                cmd.Parameters.Add("@desc_materia", SqlDbType.VarChar, 50).Value = m.Descripcion;
                cmd.Parameters.Add("@hs_semanales", SqlDbType.Int).Value = m.HsSemanales;
                cmd.Parameters.Add("@hs_totales", SqlDbType.Int).Value = m.HsTotales;
                cmd.Parameters.Add("@id_plan", SqlDbType.Int).Value = m.IdPlan;
                m.Id = decimal.ToInt32((decimal)cmd.ExecuteScalar());
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Save(Materia m)
        {
            if (m.State == BusinessEntity.Estados.New)
            {
                this.Insert(m);
            }
            else if (m.State == BusinessEntity.Estados.Deleted)
            {
                this.Delete(m.Id);
            }
            else if (m.State == BusinessEntity.Estados.Modified)
            {
                this.Update(m);
            }
            m.State = BusinessEntity.Estados.Unmodified;
        }

        public void Update(Materia materia)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("UPDATE materias SET desc_materia = @desc_materia, hs_semanales = @hs_semanales," +
                    " hs_totales = @hs_totales, id_plan = @id_plan" +
                    " WHERE id_materia = @id", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = materia.Id;
                cmd.Parameters.Add("@desc_materia", SqlDbType.VarChar).Value = materia.Descripcion;
                cmd.Parameters.Add("@hs_semanales", SqlDbType.Int).Value = materia.HsSemanales;
                cmd.Parameters.Add("@hs_totales", SqlDbType.Int).Value = materia.HsTotales;
                cmd.Parameters.Add("@id_plan", SqlDbType.Int).Value = materia.IdPlan;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                CloseConnection();
            }
        }

        public Materia GetOne(int id)
        {
            Materia materia = new Materia();
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM materias WHERE id_materia = @id", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    materia.Id = (int)dr["id_materia"];
                    materia.Descripcion = (string)dr["desc_materia"];
                    materia.HsSemanales = (int)dr["hs_semanales"];
                    materia.HsTotales = (int)dr["hs_totales"];
                    materia.IdPlan = (int)dr["id_plan"];
                }
                dr.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                CloseConnection();
            }
            return materia;
        }

        public List<Materia> GetAll()
        {
            List<Materia> materias = new List<Materia>();
            try
            {
                OpenConnection();
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
                CloseConnection();
            }
            return materias;
        }

        public void Delete(int id)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("DELETE materias WHERE id_materia = @id", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}

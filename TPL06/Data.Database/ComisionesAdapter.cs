using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data;
using Academia.Data.Database;

namespace Data.Database
{
    public class ComisionesAdapter : Adapter
    {
        public List<Comision> GetAll()
        {
            List<Comision> comisiones = new List<Comision>();
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM comisiones", Sqlconn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Comision c = new Comision
                    {
                        Id = (int)dr["id_comision"],
                        DescripcionComision = (string)dr["desc_comision"],
                        AñoEspecialidad = (int)dr["anio_especialidad"],
                        IdPlan = (int)dr["id_plan"]
                    };
                    comisiones.Add(c);
                }

                dr.Close();
                CloseConnection();
            }
            catch (Exception e)
            {
                throw e;
            }
            return comisiones;
        }

        public Comision GetOne(int id)
        {
            Comision c = new Comision();
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM comisiones WHERE id_comision = @id", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c.Id = (int)dr["id_comision"];
                    c.DescripcionComision = (string)dr["desc_comision"];
                    c.AñoEspecialidad = (int)dr["anio_especialidad"];
                    c.IdPlan = (int)dr["id_plan"];
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                CloseConnection();
            }
            return c;
        }

        public void Delete(int id)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("DELETE comisiones WHERE id_comision = @id", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(Comision c)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("UPDATE comisiones SET desc_comision = @desc_comision," +
                    " anio_especialidad = @año, id_plan = @id_plan" +
                    " WHERE id_comision = @id", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = c.Id;
                cmd.Parameters.Add("@desc_comision", SqlDbType.VarChar).Value = c.DescripcionComision;
                cmd.Parameters.Add("@año", SqlDbType.Int).Value = c.AñoEspecialidad;
                cmd.Parameters.Add("@id_plan", SqlDbType.Int).Value = c.IdPlan;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Insert(Comision c)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO comisiones (desc_comision, anio_especialidad, id_plan)" +
                    " VALUES (@desc_comision, @año, @id_plan)" +
                    " SELECT @@identity", Sqlconn);
                cmd.Parameters.Add("@desc_comision", SqlDbType.VarChar).Value = c.DescripcionComision;
                cmd.Parameters.Add("@año", SqlDbType.Int).Value = c.AñoEspecialidad;
                cmd.Parameters.Add("@id_plan", SqlDbType.Int).Value = c.IdPlan;
                c.Id = decimal.ToInt32((decimal)cmd.ExecuteScalar());
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<Comision> GetByPlan(int idPlan)
        {
            List<Comision> comisiones = new List<Comision>();
            try
            {
                using (EntidadesTP2 db = new EntidadesTP2())
                {
                    List<comisiones> oComisiones = (from c in db.comisiones
                                                    where c.id_plan == idPlan
                                                    select c).ToList();
                    foreach (comisiones com in oComisiones)
                    {
                        Comision c = new Comision
                        {
                            Id = com.id_plan,
                            DescripcionComision = com.desc_comision,
                            AñoEspecialidad = com.anio_especialidad,
                            IdPlan = com.id_plan
                        };
                        comisiones.Add(c);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return comisiones;
        }

        public List<Comision> GetByMateria(int IdMateria)
        {
            List<Comision> comisiones = new List<Comision>();
            try
            {
                OpenConnection();
                SqlCommand cmdComisions = new SqlCommand("select * from materias mat " +
                "inner join cursos cur on cur.id_materia = mat.id_materia " +
                "inner join comisiones com on com.id_comision = cur.id_comision" +
                " WHERE mat.id_materia=@idMateria;"
                 , Sqlconn);
                cmdComisions.Parameters.Add("@idMateria", SqlDbType.Int).Value = IdMateria;
                SqlDataReader dr = cmdComisions.ExecuteReader();
                while (dr.Read())
                {
                    Comision c = new Comision
                    {
                        Id = (int)dr["id_comision"],
                        DescripcionComision = (string)dr["desc_comision"],
                        AñoEspecialidad = (int)dr["anio_especialidad"],
                        IdPlan = (int)dr["id_plan"]
                    };
                    comisiones.Add(c);
                }

                dr.Close();
                CloseConnection();
            }
            catch (Exception e)
            {
                throw e;
            }
            return comisiones;
        }
        public void Save(Comision c)
        {
            if (c.State == BusinessEntity.Estados.New)
            {
                this.Insert(c);
            }
            else if (c.State == BusinessEntity.Estados.Deleted)
            {
                this.Delete(c.Id);
            }
            else if (c.State == BusinessEntity.Estados.Modified)
            {
                this.Update(c);
            }
            c.State = BusinessEntity.Estados.Unmodified;
        }
    }
}

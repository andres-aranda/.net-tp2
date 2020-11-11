using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;
using Academia.Data.Database;
using System.Linq;

namespace Data.Database
{
    public  class PlanAdapter:Adapter
    {
        public List<Plan> GetAll()
        {
            List<Plan> planes = new List<Plan>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlanes = new SqlCommand("SELECT * FROM planes", Sqlconn);
                SqlDataReader drPlanes = cmdPlanes.ExecuteReader();
                while (drPlanes.Read())
                {
                    Plan mod = new Plan();
                    mod.Id = (int)drPlanes["id_plan"];
                    mod.Descripcion = (string)drPlanes["desc_plan"];
                    mod.IdEspecialidad = (int)drPlanes["id_especialidad"];

                    planes.Add(mod);
                }

                drPlanes.Close();
                this.CloseConnection();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al recuperar lista de planes", Ex);
                throw ExcepcionManejada;
            }

            return planes;
        }

        public Plan GetByIdMateria(int idMateria)
        {
            Plan p = new Plan();
            using (EntidadesTP2 db = new EntidadesTP2())
            {
                planes oPlan = (from pl in db.planes
                                join m in db.materias on pl.id_plan equals m.id_plan
                                where m.id_materia == idMateria
                                select pl).First();
                p.Id = oPlan.id_plan;
                p.Descripcion = oPlan.desc_plan;
            }
            return p;
        }

        public Plan GetOne(int Id)
        {
            Plan mod = new Plan();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlan = new SqlCommand("SELECT * FROM planes WHERE id_plan = @id", Sqlconn);
                cmdPlan.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                SqlDataReader drPlan = cmdPlan.ExecuteReader();
                if (drPlan.Read())
                {
                    mod.Id = (int)drPlan["id_plan"];
                    mod.Descripcion = (string)drPlan["desc_plan"];
                    mod.IdEspecialidad = (int)drPlan["id_especialidad"];
                }

                drPlan.Close();
                //this.CloseConnection();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al recuperar datos de planes", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return mod;
        }


        public void Delete(int Id)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE planes WHERE id_plan = @id", Sqlconn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                cmdDelete.ExecuteNonQuery();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Plan plan)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("UPDATE planes SET desc_plan = @desc_plan, id_especialidad = @id_especialidad " +
                    " WHERE id_plan = @id", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = plan.Id;
                cmd.Parameters.Add("@desc_plan", SqlDbType.VarChar, 50).Value = plan.Descripcion;
                cmd.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = plan.IdEspecialidad;
                cmd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al modificar plan", Ex);
                throw excepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Plan plan)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO planes (desc_plan, id_especialidad)" +
                    " VALUES (@desc_plan, @id_especialidad)" +
                    " SELECT @@identity", Sqlconn);

                cmd.Parameters.Add("@desc_plan", SqlDbType.VarChar, 50).Value = plan.Descripcion;
                cmd.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = plan.IdEspecialidad;
                plan.Id = decimal.ToInt32((decimal)cmd.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al modificar plan", Ex);
                throw excepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Plan plan)
        {
            if (plan.State == BusinessEntity.Estados.New)
            {
                this.Insert(plan);
            }
            else if (plan.State == BusinessEntity.Estados.Deleted)
            {
                this.Delete(plan.Id);
            }
            else if (plan.State == BusinessEntity.Estados.Modified)
            {
                this.Update(plan);
            }
            plan.State = BusinessEntity.Estados.Unmodified;
        }
    }
}

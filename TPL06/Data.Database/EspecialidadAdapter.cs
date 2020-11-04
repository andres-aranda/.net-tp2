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
   public  class EspecialidadAdapter:Adapter
    {

        public List<Especialidad> GetAll()
        {
            List<Especialidad> especialidades = new List<Especialidad>();
            using (EntidadesTP2 db = new EntidadesTP2())
            {
                foreach (var e in db.especialidades)
                {
                    Especialidad especialidad = new Especialidad
                    {
                        Id = e.id_especialidad,
                        Descripcion = e.desc_especialidad
                    };
                    especialidades.Add(especialidad);
                }
            }
            return especialidades;
        }

        public Especialidad GetOne(int Id)
        {
            Especialidad esp = new Especialidad();
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidad = new SqlCommand("SELECT * FROM especialidades WHERE id_especialidad = @id", Sqlconn);
                cmdEspecialidad.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                SqlDataReader drEspecialidad = cmdEspecialidad.ExecuteReader();
                if (drEspecialidad.Read())
                {
                    esp.Id = (int)drEspecialidad["id_especialidad"];
                    esp.Descripcion = (string)drEspecialidad["desc_especialidad"];
 
                }

                drEspecialidad.Close();
                //this.CloseConnection();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al recuperar datos de especialidades", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return esp;
        }

        public void Delete(int Id)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE especialidades WHERE id_especialidad = @id", Sqlconn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al eliminar espeialidad", Ex);
                throw excepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Especialidad especialidad)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("UPDATE especialidades SET desc_especialidad = @desc_especialidad "
                    + " WHERE id_especialidad = @id", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = especialidad.Id;
                cmd.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 50).Value = especialidad.Descripcion;
                cmd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al modificar especialidad", Ex);
                throw excepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Especialidad especialidad)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO especialidades (desc_especialidad)" +
                    " VALUES (@desc_especialidad)" +
                    " SELECT @@identity", Sqlconn);

                cmd.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 50).Value = especialidad.Descripcion;
                especialidad.Id = decimal.ToInt32((decimal)cmd.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al modificar especialidad", Ex);
                throw excepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Especialidad especialidad)
        {
            if (especialidad.State == BusinessEntity.Estados.New)
            {
                this.Insert(especialidad);
            }
            else if (especialidad.State == BusinessEntity.Estados.Deleted)
            {
                this.Delete(especialidad.Id);
            }
            else if (especialidad.State == BusinessEntity.Estados.Modified)
            {
                this.Update(especialidad);
            }
            especialidad.State = BusinessEntity.Estados.Unmodified;
        }

        public Especialidad GetByPlan(int id)
        {
            Especialidad especialidad = new Especialidad();
            using (EntidadesTP2 db = new EntidadesTP2())
            {
                especialidades esp = (from p in db.planes
                                      join e in db.especialidades on p.id_especialidad equals e.id_especialidad
                                      where p.id_plan == id
                                      select e).First();
                especialidad.Id = esp.id_especialidad;
                especialidad.Descripcion = esp.desc_especialidad;
            }
            return especialidad;
        }

    }
}

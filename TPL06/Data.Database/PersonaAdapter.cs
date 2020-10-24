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
    public class PersonaAdapter : Adapter
    {
        public void Insert(Persona m)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO personas (nombre, legajo, tipo_persona, id_plan)" +
                    " VALUES (@nombre, @legajo, @tipo_persona, @id_plan)" +
                    " SELECT @@identity", Sqlconn);

                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = m.Nombre;
                cmd.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = m.Apellido;
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = m.Email;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = m.Nombre;
                cmd.Parameters.Add("@legajo", SqlDbType.Int).Value = m.Legajo;
                cmd.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = m.TipoPersona;
                cmd.Parameters.Add("@id_plan", SqlDbType.Int).Value = m.IdPlan;
                cmd.Parameters.Add("@fecha_nac", SqlDbType.Int).Value = m.FechaDeNacimiento;
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

        public void Save(Persona m)
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

        public void Update(Persona persona)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("UPDATE personas SET nombre = @nombre, legajo = @legajo," +
                    " tipo_persona = @tipo_persona, id_plan = @id_plan" +
                    " WHERE id_persona = @id", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = persona.Id;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = persona.Nombre;
                cmd.Parameters.Add("@legajo", SqlDbType.Int).Value = persona.Legajo;
                cmd.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = persona.TipoPersona;
                cmd.Parameters.Add("@id_plan", SqlDbType.Int).Value = persona.IdPlan;
                cmd.Parameters.Add("@fecha_nac", SqlDbType.Int).Value = persona.FechaDeNacimiento;
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

        public Persona GetOne(int id)
        {
            Persona persona = new Persona();
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM personas WHERE id_persona = @id", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    persona.Id = (int)dr["id_persona"];
                    persona.Nombre = (string)dr["nombre"];
                    persona.Apellido = (string)dr["apellido"];
                    persona.Direccion = (string)dr["direccion"];
                    persona.Telefono = (string)dr["telefono"];
                    persona.Legajo = (int)dr["legajo"];
                    persona.IdPlan = (int)dr["id_plan"];
                    persona.FechaDeNacimiento = (DateTime)dr["fecha_nac"];
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
            return persona;
        }

        public List<Persona> GetAll()
        {
            List<Persona> personas = new List<Persona>();
            try
            {
                OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("SELECT * FROM personas", Sqlconn);
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();
                while (drPersonas.Read())
                {
                    Persona m = new Persona();
                    m.Id = (int)drPersonas["id_persona"];
                    m.Nombre = (string)drPersonas["nombre"];
                    m.Legajo = (int)drPersonas["legajo"];

                    m.IdPlan = (int)drPersonas["id_plan"];

                    personas.Add(m);
                }
                drPersonas.Close();
            }
            catch (Exception e)
            {
                Exception ex = new Exception("Error al recuperar la lista de personas", e);
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return personas;
        }

        public void Delete(int id)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("DELETE personas WHERE id_persona = @id", Sqlconn);
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

        public List<Materia> GetMateriasPlan(int idPersona)
        {
            List<Materia> materias = new List<Materia>();
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT m.* " +
                    "FROM personas per " +
                    "LEFT JOIN planes p ON per.id_plan = p.id_plan " +
                    "LEFT JOIN materias m ON p.id_plan = m.id_plan " +
                    "WHERE per.id_persona = @id_persona;", Sqlconn);
                cmd.Parameters.Add("@id_persona", SqlDbType.Int).Value = idPersona;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Materia m = new Materia
                    {
                        Id = (int)dr["id_materia"],
                        Descripcion = (string)dr["desc_materia"],
                        HsSemanales = (int)dr["hs_semanales"],
                        HsTotales = (int)dr["hs_totales"],
                        IdPlan = (int)dr["id_plan"]
                    };
                    materias.Add(m);
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
            return materias;
        }


    }
}

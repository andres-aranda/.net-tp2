using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Business.Entities;

namespace Data.Database
{
    public class InscripcionAdapter : Adapter
    {
        private CursoAdapter cur = new CursoAdapter();
        public void Insert(Inscripcion m)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO alumnos_inscripciones (condicion, id_alumno, id_curso, nota)" +
                    " VALUES (@condicion, @id_alumno, @id_curso, @nota)" +
                    " SELECT @@identity", Sqlconn);

                cmd.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = m.Condicion;
                cmd.Parameters.Add("@id_alumno", SqlDbType.Int).Value = m.IdAlumno;
                cmd.Parameters.Add("@id_curso", SqlDbType.Int).Value = m.IdCurso;
                cmd.Parameters.Add("@nota", SqlDbType.Int).Value = m.Nota;
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

        public void Save(Inscripcion m)
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

        public void Update(Inscripcion inscripcion)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("UPDATE alumnos_inscripciones SET condicion = @condicion, id_alumno = @id_alumno," +
                    " id_curso = @id_curso, nota = @nota" +
                    " WHERE id_inscripcion = @id", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = inscripcion.Id;
                cmd.Parameters.Add("@condicion", SqlDbType.VarChar).Value = inscripcion.Condicion;
                cmd.Parameters.Add("@id_alumno", SqlDbType.Int).Value = inscripcion.IdAlumno;
                cmd.Parameters.Add("@id_curso", SqlDbType.Int).Value = inscripcion.IdCurso;
                cmd.Parameters.Add("@nota", SqlDbType.Int).Value = inscripcion.Nota;
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

        public Inscripcion GetOne(int id)
        {
            Inscripcion inscripcion = new Inscripcion();
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM alumnos_inscripciones WHERE id_inscripcion = @id", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    inscripcion.Id = (int)dr["id_inscripcion"];
                    inscripcion.Condicion = (string)dr["condicion"];
                    inscripcion.IdAlumno = (int)dr["id_alumno"];
                    inscripcion.IdCurso = (int)dr["id_curso"];
                    inscripcion.Nota = (int)dr["nota"];
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
            return inscripcion;
        }

        public List<Inscripcion> GetAll()
        {
            List<Inscripcion> alumnos_inscripciones = new List<Inscripcion>();
            try
            {
                OpenConnection();
                SqlCommand cmdInscripcions = new SqlCommand("SELECT * FROM alumnos_inscripciones", Sqlconn);
                SqlDataReader drInscripcions = cmdInscripcions.ExecuteReader();
                while (drInscripcions.Read())
                {
                    Inscripcion m = new Inscripcion();
                    m.Id = (int)drInscripcions["id_inscripcion"];
                    m.Condicion = (string)drInscripcions["condicion"];
                    m.IdAlumno = (int)drInscripcions["id_alumno"];
                    m.IdCurso = (int)drInscripcions["id_curso"];
                    m.Nota = (int)drInscripcions["nota"];

                    alumnos_inscripciones.Add(m);
                }
                drInscripcions.Close();
            }
            catch (Exception e)
            {
                Exception ex = new Exception("Error al recuperar la lista de alumnos_inscripciones", e);
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return alumnos_inscripciones;
        }
  

        public void Delete(int id)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("DELETE alumnos_inscripciones WHERE id_inscripcion = @id", Sqlconn);
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

        public void Inscribir(int idAlumno, int idCurso)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO alumnos_inscripciones " +
                    "   (id_alumno, id_curso, condicion, nota) " +
                    "VALUES " +
                    "   (@id_alumno, @id_curso, 'Cursando', NULL)", Sqlconn);
                cmd.Parameters.Add("@id_alumno", SqlDbType.Int).Value = idAlumno;
                cmd.Parameters.Add("@id_curso", SqlDbType.Int).Value = idCurso;
                cmd.ExecuteScalar();
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

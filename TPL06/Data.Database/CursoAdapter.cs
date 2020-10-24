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
    public class CursoAdapter : Adapter
    {
        private MateriaAdapter mat = new MateriaAdapter();
        private ComisionesAdapter com = new ComisionesAdapter();
        public void Insert(Curso m)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO cursos (cupo, id_materia, id_comision, anio_calendario)" +
                    " VALUES (@cupo, @id_materia, @id_comision, @anio_calendario)" +
                    " SELECT @@identity", Sqlconn);

                cmd.Parameters.Add("@cupo", SqlDbType.Int).Value = m.Cupo;
                cmd.Parameters.Add("@id_materia", SqlDbType.Int).Value = m.IdMateria;
                cmd.Parameters.Add("@id_comision", SqlDbType.Int).Value = m.IdComision;
                cmd.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = m.AñoCalendario;
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

        public void Save(Curso m)
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

        public void Update(Curso curso)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("UPDATE cursos SET cupo = @cupo, id_materia = @id_materia," +
                    " id_comision = @id_comision, anio_calendario = @anio_calendario" +
                    " WHERE id_curso = @id", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = curso.Id;
                cmd.Parameters.Add("@cupo", SqlDbType.VarChar).Value = curso.Cupo;
                cmd.Parameters.Add("@id_materia", SqlDbType.Int).Value = curso.IdMateria;
                cmd.Parameters.Add("@id_comision", SqlDbType.Int).Value = curso.IdComision;
                cmd.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = curso.AñoCalendario;
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

        public Curso GetOne(int id)
        {
            Curso curso = new Curso();
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM cursos WHERE id_curso = @id", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    curso.Id = (int)dr["id_curso"];
                    curso.Cupo = (int)dr["cupo"];
                    curso.IdMateria = (int)dr["id_materia"];
                    curso.IdComision = (int)dr["id_comision"];
                    curso.AñoCalendario = (int)dr["anio_calendario"];
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
            return curso;
        }

        public Curso GetByMateriaCom(int idComision, int idMateria )
        {
            Curso curso = new Curso();
            MateriaAdapter matAdapt = new MateriaAdapter();
            ComisionesAdapter comAdapt = new ComisionesAdapter();
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM cursos WHERE id_materia = @idMateria and id_comision = @idComision", Sqlconn);
                cmd.Parameters.Add("@idMateria", SqlDbType.Int).Value = idMateria;
                cmd.Parameters.Add("@idMateria", SqlDbType.Int).Value = idComision;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    curso.Id = (int)dr["id_curso"];
                    curso.Cupo = (int)dr["cupo"];
                    curso.IdMateria = (int)dr["id_materia"];
                    curso.IdComision = (int)dr["id_comision"];
                    curso.AñoCalendario = (int)dr["anio_calendario"];

                    curso.Materia = matAdapt.GetOne((int)dr["id_materia"]);
                    curso.Comision = comAdapt.GetOne((int)dr["id_comision"]);
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
            return curso;
        }

        public List<Curso> GetAll()
        {
            List<Curso> cursos = new List<Curso>();
            try
            {
                OpenConnection();
                SqlCommand cmdCursos = new SqlCommand("SELECT * FROM cursos", Sqlconn);
                SqlDataReader drCursos = cmdCursos.ExecuteReader();
                while (drCursos.Read())
                {
                    Curso m = new Curso();
                    m.Id = (int)drCursos["id_curso"];
                    m.Cupo = (int)drCursos["cupo"];
                    m.IdMateria = (int)drCursos["id_materia"];
                    m.IdComision = (int)drCursos["id_comision"];
                    m.AñoCalendario = (int)drCursos["anio_calendario"];
                    if (m.IdMateria != 0){ m.Materia = mat.GetOne(m.IdMateria); }
                    if (m.IdComision != 0){  m.Comision = com.GetOne(m.IdComision);}              
                    cursos.Add(m);
                }
                drCursos.Close();
            }
            catch (Exception e)
            {
                Exception ex = new Exception("Error al recuperar la lista de cursos", e);
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return cursos;
        }   
        public List<Curso> GetByMaterias(int IdMateria)
        {
            List<Curso> cursos = new List<Curso>();
            try
            {
                OpenConnection();
                SqlCommand cmdCursos = new SqlCommand("SELECT * FROM cursos WHERE id_materia = @idMateria", Sqlconn);
                cmdCursos.Parameters.Add("@idMateria", SqlDbType.Int).Value = IdMateria;
                SqlDataReader drCursos = cmdCursos.ExecuteReader();
                while (drCursos.Read())
                {
                    Curso m = new Curso();
                    m.Id = (int)drCursos["id_curso"];
                    m.Cupo = (int)drCursos["cupo"];
                    m.IdMateria = (int)drCursos["id_materia"];
                    m.IdComision = (int)drCursos["id_comision"];
                    m.AñoCalendario = (int)drCursos["anio_calendario"];
                   m.Materia = mat.GetOne(m.IdMateria); 
                     m.Comision = com.GetOne(m.IdComision);              
                    cursos.Add(m);
                }
                drCursos.Close();
            }
            catch (Exception e)
            {
                Exception ex = new Exception("Error al recuperar la lista de cursos", e);
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return cursos;
        }

        public void Delete(int id)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("DELETE cursos WHERE id_curso = @id", Sqlconn);
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

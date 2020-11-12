using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academia.Data.Database;
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
                cmd.Parameters.Add("@id_materia", SqlDbType.Int).Value = m.Materia.Id;
                cmd.Parameters.Add("@id_comision", SqlDbType.Int).Value = m.Comision.Id;
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
                cmd.Parameters.Add("@id_materia", SqlDbType.Int).Value = curso.Materia.Id;
                cmd.Parameters.Add("@id_comision", SqlDbType.Int).Value = curso.Comision.Id;
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
                    curso.AñoCalendario = (int)dr["anio_calendario"];
                    curso.Materia = new Materia
                    {
                        Id = (int)dr["id_materia"]
                    };
                    curso.Comision = new Comision
                    {
                        Id = (int)dr["id_comision"]
                    };
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
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM cursos " +
                    "WHERE" +
                    "    id_materia = @idMateria AND " +
                    "    id_comision = @idComision AND " +
                    "    anio_calendario = @anio_calendario", Sqlconn);
                cmd.Parameters.Add("@idMateria", SqlDbType.Int).Value = idMateria;
                cmd.Parameters.Add("@idComision", SqlDbType.Int).Value = idComision;
                cmd.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = DateTime.Now.Year;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    curso.Id = (int)dr["id_curso"];
                    curso.Cupo = (int)dr["cupo"];
                    curso.AñoCalendario = (int)dr["anio_calendario"];
                    curso.Materia = matAdapt.GetOne((int)dr["id_materia"]);
                    curso.Comision = comAdapt.GetOne((int)dr["id_comision"]);
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
                    m.Materia = new Materia
                    {
                        Id = (int)drCursos["id_materia"]
                    };
                    m.Comision = new Comision
                    {
                        Id = (int)drCursos["id_comision"]
                    };
                    m.AñoCalendario = (int)drCursos["anio_calendario"];
                    if (m.Materia.Id != 0){ m.Materia = mat.GetOne(m.Materia.Id); }
                    if (m.Comision.Id != 0){  m.Comision = com.GetOne(m.Comision.Id);}              
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
                    m.Materia.Id = (int)drCursos["id_materia"];
                    m.Comision.Id = (int)drCursos["id_comision"];
                    m.AñoCalendario = (int)drCursos["anio_calendario"];
                    m.Materia = mat.GetOne(m.Materia.Id); 
                    m.Comision = com.GetOne(m.Comision.Id);              
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
        public List<Inscripcion> GetMateriasInscripcionesDocente(int idDocente)
        {
            List<Inscripcion> insc = new List<Inscripcion>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCurso = new SqlCommand(
                    "select DISTINCT id_inscripcion ,nombre, apellido, legajo, desc_materia, desc_comision, nota, anio_calendario from personas pe " +
                    "inner join alumnos_inscripciones alu_ins on alu_ins.id_alumno = pe.id_persona " +
                    " inner join cursos cur on cur.id_curso = alu_ins.id_curso " +
                    "inner join materias mat on mat.id_materia = cur.id_materia " +
                    " inner join comisiones com on com.id_comision = cur.id_comision " +
                    "inner join docentes_cursos doc_cur on doc_cur.id_curso=cur.id_curso "+
                    "WHERE id_docente = @id", Sqlconn);
                cmdCurso.Parameters.Add("@id", SqlDbType.Int).Value = idDocente;
                SqlDataReader drCurso = cmdCurso.ExecuteReader();
                while (drCurso.Read())
                {
                    Inscripcion ii = new Inscripcion();
                    ii.Id=(int)drCurso["id_inscripcion"];
                    ii.Curso = new Curso();
                    ii.Curso.Materia = new Materia();
                    ii.Curso.Comision = new Comision();
                    ii.Curso.Materia.Descripcion = (string)drCurso["desc_materia"];
                    ii.Curso.Comision.DescripcionComision = (string)drCurso["desc_comision"];
                    ii.Persona = new Persona();
                    ii.Persona.Nombre= (string)drCurso["nombre"];
                    ii.Persona.Apellido= (string)drCurso["apellido"];
                    ii.Persona.Legajo= (int)drCurso["legajo"];
                    ii.Nota = (int)drCurso["nota"];
                    ii.Curso.AñoCalendario = (int)drCurso["anio_calendario"];
                    insc.Add(ii);
                }
                drCurso.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar persona.", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return insc;

        }
        public List <Inscripcion> GetMateriasInscripciones(int id)
        {
            List<Inscripcion> insc = new List<Inscripcion>();
            try
            {                 
                this.OpenConnection();
                SqlCommand cmdCurso = new SqlCommand("    select desc_materia, desc_comision, nota, anio_calendario " +
                    "from personas pe " +
                    "inner join alumnos_inscripciones alu_ins on alu_ins.id_alumno = pe.id_persona" +
                    " inner join cursos cur on cur.id_curso = alu_ins.id_curso" +
                    " inner join materias mat on mat.id_materia = cur.id_materia " +
                    "inner join comisiones com on com.id_comision = cur.id_comision " +
                    "WHERE id_persona = @id;");
                cmdCurso.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drCurso = cmdCurso.ExecuteReader();
                while (drCurso.Read())
                {
                    Inscripcion ii = new Inscripcion();
                    ii.Curso = new Curso();
                    ii.Curso.Materia = new Materia();
                    ii.Curso.Comision = new Comision();
                    ii.Curso.Materia.Descripcion = (string)drCurso["desc_materia"];
                    ii.Curso.Comision.DescripcionComision = (string)drCurso["desc_comision"];
                    ii.Nota = (int)drCurso["nota"];
                    ii.Curso.AñoCalendario = (int)drCurso["anio_calendario"];
                    insc.Add(ii);
                }
                drCurso.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar persona.", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return insc;

        }
        public List<Curso> GetCursosDocente(int id)
        {
            List<Curso> curs = new List<Curso>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCurso = new SqlCommand("select desc_materia, desc_comision, anio_calendario " +
                    "from personas pe inner join docentes_cursos doc_cur on doc_cur.id_docente = pe.id_persona " +
                    "inner join cursos cur on cur.id_curso = doc_cur.id_curso " +
                    "inner join materias mat on mat.id_materia = cur.id_materia " +
                    "inner join comisiones com on com.id_comision = cur.id_comision where pe.id_persona = @id", Sqlconn);
                cmdCurso.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drCurso = cmdCurso.ExecuteReader();
                while (drCurso.Read())
                {
                    Curso curso= new Curso();                   
                    curso.Materia = new Materia();
                    curso.Comision = new Comision();
                    curso.Materia.Descripcion = (string)drCurso["desc_materia"];
                    curso.Comision.DescripcionComision = (string)drCurso["desc_comision"];
                    curso.AñoCalendario = (int)drCurso["anio_calendario"];
                    curs.Add(curso);
                }
                drCurso.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar persona.", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return curs;

        }
    }
}

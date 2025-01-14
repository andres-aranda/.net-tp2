using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;
using Academia.Data.Database;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Net.Mail;
using System.ComponentModel.Design;

// VER TRY CATCH para capas negocio y presentación.

namespace Data.Database
{
    public class UsuarioAdapter : Adapter
    {
        public List<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                OpenConnection();
                SqlCommand cmdUsuarios = new SqlCommand(
                    "SELECT u.*, p.apellido, p.nombre, p.email " +
                    "FROM usuarios u " +
                    "INNER JOIN personas p ON u.id_persona = p.id_persona", Sqlconn);
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
                while (drUsuarios.Read())
                {
                    Usuario usr = new Usuario();
                    usr.Id = (int)drUsuarios["id_usuario"];
                    usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usr.Persona = new Persona
                    {
                        Id = (int)drUsuarios["id_persona"],
                        Nombre = (string)drUsuarios["nombre"],
                        Apellido = (string)drUsuarios["apellido"],
                        Email = new MailAddress((string)drUsuarios["email"])
                    };

                    usuarios.Add(usr);
                }

                drUsuarios.Close();
                CloseConnection();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = 
                    new Exception("Error al recuperar lista de usuarios", Ex);
                throw ExcepcionManejada;
            }

            return usuarios;
        }

        public Usuario GetOne(int Id)
        {
            Usuario usr = new Usuario();
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuario = new SqlCommand(
                    "SELECT u.*, p.nombre, p.apellido, p.email , p.legajo " +
                    "FROM usuarios u " +
                    "INNER JOIN personas p ON p.id_persona = u.id_persona " +
                    "WHERE id_usuario = @id", Sqlconn);
                cmdUsuario.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                SqlDataReader drUsuario = cmdUsuario.ExecuteReader();
                if (drUsuario.Read())
                {
                    usr.Id = (int)drUsuario["id_usuario"];
                    usr.NombreUsuario = (string)drUsuario["nombre_usuario"];
                    usr.Clave = (string)drUsuario["clave"];
                    usr.Persona = new Persona
                    {
                        Id = (int)drUsuario["id_persona"],
                        Legajo = (int)drUsuario["legajo"],
                        Nombre = (string)drUsuario["nombre"],
                        Apellido = (string)drUsuario["apellido"],
                        Email = new MailAddress((string)drUsuario["email"])
                    };
                }

                drUsuario.Close();
                //this.CloseConnection();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al recuperar datos de usuarios", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return usr;
        }

        public Usuario GetOne(string nombreUsuario)
        {
            Usuario u;
            try
            {
                using (EntidadesTP2 db = new EntidadesTP2())
                {
                    var oUsuario = db.usuarios.Find(nombreUsuario);
                    var oPersona = db.personas.Find(oUsuario.id_persona);
                    u = new Usuario()
                    {
                        Id = oUsuario.id_usuario,
                        NombreUsuario = oUsuario.nombre_usuario,
                        Clave = oUsuario.clave,
                        Persona = new Persona
                        {
                            Nombre = oPersona.nombre,
                            Apellido = oPersona.apellido,
                            Email = new MailAddress(oPersona.email)
                        }
                    };
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return u;
        }

        public void Delete(int Id)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand(
                    "DELETE modulos_usuarios WHERE id_usuario = @id; " +
                    "DELETE usuarios WHERE id_usuario = @id", Sqlconn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                cmdDelete.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                
                throw new Exception("Error al eliminar usuario", Ex);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void DeleteModulo(string nombreUsuario, int idModulo)
        {
            try
            {
                using (EntidadesTP2 db = new EntidadesTP2())
                {
                    int id = (from u in db.usuarios
                             where u.nombre_usuario == nombreUsuario
                             select u.id_usuario).First();
                    db.modulos_usuarios.Remove((from mu in db.modulos_usuarios                                               
                                               where mu.id_usuario == id && mu.id_modulo == idModulo
                                               select mu).First());
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(Usuario usuario)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("UPDATE usuarios SET nombre_usuario = @nombre_usuario, clave = @clave " +
                    " WHERE id_usuario = @id; ", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = usuario.Id;
                cmd.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmd.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                cmd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al modificar usuario", Ex);
                throw excepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Usuario usuario)
        {
            try
            {
                using (EntidadesTP2 db = new EntidadesTP2())
                {
                    int idPersona = (from p in db.personas
                                     where p.legajo == usuario.Persona.Legajo
                                     select p.id_persona).First();

                    usuarios oUsuario = new usuarios
                    {
                        nombre_usuario = usuario.NombreUsuario,
                        clave = usuario.Clave,
                        id_persona = idPersona
                    };
                    db.usuarios.Add(oUsuario);
                    db.SaveChanges();
                }
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al modificar usuario", Ex);
                throw excepcionManejada;
            }
        }

        public void Save(Usuario usuario)
        {
            if (usuario.State == BusinessEntity.Estados.New)
            {
                this.Insert(usuario);
            }
            else if (usuario.State == BusinessEntity.Estados.Deleted)
            {
                this.Delete(usuario.Id);
            }
            else if (usuario.State == BusinessEntity.Estados.Modified)
            {
                this.Update(usuario);
            }
            usuario.State = BusinessEntity.Estados.Unmodified;
        }

        public Usuario Loguearse(string nombreUsuario, string password)
        {
            Usuario usuario = new Usuario();
            ModuloAdapter md = new ModuloAdapter();
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuario = new SqlCommand(
                    "SELECT u.*, p.nombre, p.apellido, p.email " +
                    "FROM usuarios u " +
                    "INNER JOIN personas p ON u.id_persona = p.id_persona " +
                    "WHERE nombre_usuario = @nombreUsuario AND clave = @password", Sqlconn);
                cmdUsuario.Parameters.Add("@nombreUsuario", SqlDbType.VarChar).Value = nombreUsuario;
                cmdUsuario.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                SqlDataReader drUsuario = cmdUsuario.ExecuteReader();
                if (drUsuario.Read())
                {
                    usuario.Id = (int)drUsuario["id_usuario"];
                    usuario.NombreUsuario = (string)drUsuario["nombre_usuario"];
                    usuario.Clave = (string)drUsuario["clave"];
                    usuario.Persona = new Persona
                    {
                        Id = (int)drUsuario["id_persona"],
                        Nombre = (string)drUsuario["nombre"],
                        Apellido = (string)drUsuario["apellido"],
                        Email = new MailAddress((string)drUsuario["email"])
                    };
                    usuario.Modulo = md.GetById(usuario.Id);
                }
                drUsuario.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al recuperar datos de usuarios", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            if (usuario.NombreUsuario == null)
            {
                return null;
            }
            return usuario;
        }

        public List<Modulo> GetModulos(Usuario u)
        {
            List<Modulo> modulos = new List<Modulo>();
            try
            {
                using (EntidadesTP2 db = new EntidadesTP2())
                {
                    var modulosUsuario = from m in db.modulos
                                         join mu in db.modulos_usuarios on m.id_modulo equals mu.id_modulo
                                         where mu.id_usuario == u.Id
                                         select m;
                    foreach (var m in modulosUsuario)
                    {
                        Modulo mod = new Modulo
                        {
                            Id = m.id_modulo,
                            Descripcion = m.desc_modulo
                        };
                        modulos.Add(mod);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return modulos;
        }

        public void AddModulo(string nombreUsuario, int idModulo)
        {
            try
            {
                using (EntidadesTP2 db = new EntidadesTP2())
                {
                    int idUsuario = (from u in db.usuarios
                              where u.nombre_usuario == nombreUsuario
                              select u.id_usuario).First();
                    modulos_usuarios mu = new modulos_usuarios
                    {
                        id_modulo = idModulo,
                        id_usuario = idUsuario
                    };
                    db.modulos_usuarios.Add(mu);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

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
                this.OpenConnection();
                SqlCommand cmdUsuarios = new SqlCommand("SELECT * FROM usuarios", Sqlconn);
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
                while (drUsuarios.Read())
                {
                    Usuario usr = new Usuario();
                    usr.Id = (int)drUsuarios["id_usuario"];
                    usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usr.Habilitado = (bool)drUsuarios["habilitado"];
                    usr.Nombre = (string)drUsuarios["nombre"];
                    usr.Apellido = (string)drUsuarios["apellido"];
                    usr.Email = (string)drUsuarios["email"];

                    usuarios.Add(usr);
                }

                drUsuarios.Close();
                this.CloseConnection();
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
                SqlCommand cmdUsuario = new SqlCommand("SELECT * FROM usuarios WHERE id_usuario = @id", Sqlconn);
                cmdUsuario.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                SqlDataReader drUsuario = cmdUsuario.ExecuteReader();
                if (drUsuario.Read())
                {
                    usr.Id = (int)drUsuario["id_usuario"];
                    usr.NombreUsuario = (string)drUsuario["nombre_usuario"];
                    usr.Clave = (string)drUsuario["clave"];
                    usr.Habilitado = (bool)drUsuario["habilitado"];
                    usr.Nombre = (string)drUsuario["nombre"];
                    usr.Apellido = (string)drUsuario["apellido"];
                    usr.Email = (string)drUsuario["email"];
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

        public void Delete(int Id)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE usuarios WHERE id_usuario = @id", Sqlconn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al eliminar usuario", Ex);
                throw excepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Usuario usuario)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("UPDATE usuarios SET nombre_usuario = @nombre_usuario, clave = @clave, "
                    + "habilitado = @habilitado, nombre = @nombre, apellido = @apellido, email = @email" +
                    " WHERE id_usuario = @id", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = usuario.Id;
                cmd.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmd.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                cmd.Parameters.Add("@habilitado", SqlDbType.VarChar, 50).Value = usuario.Habilitado;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario.Nombre;
                cmd.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuario.Apellido;
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.Email;
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
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO usuarios (nombre_usuario, clave, habilitado, nombre, apellido, email)" +
                    " VALUES (@nombre_usuario, @clave, @habilitado, @nombre, @apellido, @email)" +
                    " SELECT @@identity", Sqlconn);
                
                cmd.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmd.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                cmd.Parameters.Add("@habilitado", SqlDbType.VarChar, 50).Value = usuario.Habilitado;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario.Nombre;
                cmd.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuario.Apellido;
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.Email;
                usuario.Id = decimal.ToInt32((decimal)cmd.ExecuteScalar());
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

        public Usuario Loguearse(String nombreUsuario, String password)
        {
            Usuario usuario = new Usuario();
            ModuloAdapter md = new ModuloAdapter();
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuario = new SqlCommand("SELECT * FROM usuarios WHERE nombre_usuario = @nombreUsuario AND clave = @password", Sqlconn);
                cmdUsuario.Parameters.Add("@nombreUsuario", SqlDbType.VarChar).Value = nombreUsuario;
                cmdUsuario.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                SqlDataReader drUsuario = cmdUsuario.ExecuteReader();
                if (drUsuario.Read())
                {
                    usuario.Id = (int)drUsuario["id_usuario"];
                    usuario.NombreUsuario = (string)drUsuario["nombre_usuario"];
                    usuario.Clave = (string)drUsuario["clave"];
                    usuario.Habilitado = (bool)drUsuario["habilitado"];
                    usuario.Nombre = (string)drUsuario["nombre"];
                    usuario.Apellido = (string)drUsuario["apellido"];
                    usuario.Email = (string)drUsuario["email"];
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
    }
}

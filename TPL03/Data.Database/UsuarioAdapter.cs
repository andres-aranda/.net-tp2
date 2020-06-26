using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;

namespace Data.Database
{
    public class UsuarioAdapter:Adapter
    {
        #region DatosEnMemoria
        // Esta regi�n solo se usa en esta etapa donde los datos se mantienen en memoria.
        // Al modificar este proyecto para que acceda a la base de datos esta ser� eliminada
        private static List<Usuario> _Usuarios;

        private static List<Usuario> Usuarios
        {
            get
            {
                if (_Usuarios == null)
                {
                    _Usuarios = new List<Business.Entities.Usuario>();
                    Business.Entities.Usuario usr;
                    usr = new Business.Entities.Usuario();
                    usr.Id = 1;
                    usr.State = Business.Entities.BusinessEntity.Estados.Unmodified;
                    usr.Nombre = "Casimiro";
                    usr.Apellido = "Cegado";
                    usr.NombreUsuario = "casicegado";
                    usr.Clave = "miro";
                    usr.Email = "casimirocegado@gmail.com";
                    usr.Habilitado = true;
                    _Usuarios.Add(usr);

                    usr = new Business.Entities.Usuario();
                    usr.Id = 2;
                    usr.State = Business.Entities.BusinessEntity.Estados.Unmodified;
                    usr.Nombre = "Armando Esteban";
                    usr.Apellido = "Quito";
                    usr.NombreUsuario = "aequito";
                    usr.Clave = "carpintero";
                    usr.Email = "armandoquito@gmail.com";
                    usr.Habilitado = true;
                    _Usuarios.Add(usr);

                    usr = new Business.Entities.Usuario();
                    usr.Id = 3;
                    usr.State = Business.Entities.BusinessEntity.Estados.Unmodified;
                    usr.Nombre = "Alan";
                    usr.Apellido = "Brado";
                    usr.NombreUsuario = "alanbrado";
                    usr.Clave = "abrete sesamo";
                    usr.Email = "alanbrado@gmail.com";
                    usr.Habilitado = true;
                    _Usuarios.Add(usr);

                }
                return _Usuarios;
            }
        }
        #endregion

        public List<Usuario> GetAll()
        {
            return new List<Usuario>(Usuarios);
        }

        public Business.Entities.Usuario GetOne(int Id)
        {
            return Usuarios.Find(delegate(Usuario u) { return u.Id == Id; });
        }

        public void Delete(int Id)
        {
            Usuarios.Remove(this.GetOne(Id));
        }

        public void Save(Usuario usuario)
        {
            if (usuario.State == BusinessEntity.Estados.New)
            {
                int NextId = 0;
                foreach (Usuario usr in Usuarios)
                {
                    if (usr.Id > NextId)
                    {
                        NextId = usr.Id;
                    }
                }
                usuario.Id = NextId + 1;
                Usuarios.Add(usuario);
            }
            else if (usuario.State == BusinessEntity.Estados.Deleted)
            {
                this.Delete(usuario.Id);
            }
            else if (usuario.State == BusinessEntity.Estados.Modified)
            {
                Usuarios[Usuarios.FindIndex(delegate(Usuario u) { return u.Id == usuario.Id; })]=usuario;
            }
            usuario.State = BusinessEntity.Estados.Unmodified;            
        }
    }
}

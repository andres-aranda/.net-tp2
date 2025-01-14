﻿using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;


namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        public UsuarioAdapter UsuarioData  { get;  set;}

        public UsuarioLogic()
        {
            UsuarioData = new UsuarioAdapter();
        }

        public List<Usuario> GetAll()
        {
            return UsuarioData.GetAll();
        }

        public Usuario GetOne(int id)
        {
            return UsuarioData.GetOne(id);
        }

        public void Save(Usuario u)
        {
            UsuarioData.Save(u);
        }

        public void Delete(int id)
        {
            UsuarioData.Delete(id);
        }

        public Usuario Loguearse(String nombreUsuario, String password)
        {
            return UsuarioData.Loguearse(nombreUsuario, password);
        }
    }
}

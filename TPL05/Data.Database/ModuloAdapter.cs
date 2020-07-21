using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class ModuloAdapter:Adapter
    {

        public List<Modulo> GetAll()
        {
            List<Modulo> modulos = new List<Modulo>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdModulos = new SqlCommand("SELECT * FROM modulos", Sqlconn);
                SqlDataReader drModulos = cmdModulos.ExecuteReader();
                while (drModulos.Read())
                {
                    Modulo mod = new Modulo();
                    mod.Id = (int)drModulos["id_modulo"];
                    mod.Descripcion = (string)drModulos["desc_modulo"];
                    mod.Ejecuta = (string)drModulos["ejecuta"];
                   
                    modulos.Add(mod);
                }

                drModulos.Close();
                this.CloseConnection();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al recuperar lista de modulos", Ex);
                throw ExcepcionManejada;
            }

            return modulos;
        }

        public Modulo GetOne(int Id)
        {
            Modulo mod = new Modulo();
            try
            {
                this.OpenConnection();
                SqlCommand cmdModulo = new SqlCommand("SELECT * FROM modulos WHERE id_modulo = @id", Sqlconn);
                cmdModulo.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                SqlDataReader drModulo = cmdModulo.ExecuteReader();
                if (drModulo.Read())
                {
                    mod.Id = (int)drModulo["id_modulo"];
                    mod.Descripcion = (string)drModulo["desc_modulo"];
                    mod.Ejecuta = (string)drModulo["ejecuta"];
                }

                drModulo.Close();
                //this.CloseConnection();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al recuperar datos de modulos", Ex);
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
                SqlCommand cmdDelete = new SqlCommand("DELETE modulos WHERE id_modulo = @id", Sqlconn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al eliminar modulo", Ex);
                throw excepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Modulo modulo)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("UPDATE modulos SET desc_modulo = @desc_modulo, ejecuta = @ejecuta " +
                    " WHERE id_modulo = @id", Sqlconn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = modulo.Id;
                cmd.Parameters.Add("@desc_modulo", SqlDbType.VarChar, 50).Value = modulo.Descripcion;
                cmd.Parameters.Add("@ejecuta", SqlDbType.VarChar, 50).Value = modulo.Ejecuta;
                cmd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al modificar modulo", Ex);
                throw excepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Modulo modulo)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO modulos (desc_modulo, ejecuta)" +
                    " VALUES (@desc_modulo, @ejecuta)" +
                    " SELECT @@identity", Sqlconn);

                cmd.Parameters.Add("@desc_modulo", SqlDbType.VarChar, 50).Value = modulo.Descripcion;
                cmd.Parameters.Add("@ejecuta", SqlDbType.VarChar, 50).Value = modulo.Ejecuta;
                modulo.Id = decimal.ToInt32((decimal)cmd.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception excepcionManejada = new Exception("Error al modificar modulo", Ex);
                throw excepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Modulo modulo)
        {
            if (modulo.State == BusinessEntity.Estados.New)
            {
                this.Insert(modulo);
            }
            else if (modulo.State == BusinessEntity.Estados.Deleted)
            {
                this.Delete(modulo.Id);
            }
            else if (modulo.State == BusinessEntity.Estados.Modified)
            {
                this.Update(modulo);
            }
            modulo.State = BusinessEntity.Estados.Unmodified;
        }

    }
}

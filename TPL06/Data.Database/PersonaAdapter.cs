using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Academia.Data.Database;
using System.Net.Mail;


namespace Data.Database
{
    public class PersonaAdapter : Adapter
    {
        public void Insert(Persona p)
        {
            try
            {
                using (EntidadesTP2 db = new EntidadesTP2())
                {
                    personas oPersona = new personas()
                    {
                        nombre = p.Nombre,
                        apellido = p.Apellido,
                        direccion = p.Direccion,
                        telefono = p.Telefono,
                        legajo = p.Legajo,
                        id_plan = p.IdPlan,
                        fecha_nac = p.FechaDeNacimiento
                    };
                    db.personas.Add(oPersona);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Persona GetByLegajo(int legajo)
        {
            Persona persona = new Persona();
            try
            {
                using (EntidadesTP2 db = new EntidadesTP2())
                {
                    personas oPersona = (from p in db.personas
                                         where p.legajo == legajo
                                         select p).First();
                    persona.Id = oPersona.id_persona;
                    persona.Apellido = oPersona.apellido;
                    persona.Nombre = oPersona.nombre;
                    persona.Direccion = oPersona.direccion;
                    persona.Telefono = oPersona.telefono;
                    persona.Legajo = (int)oPersona.legajo;
                    persona.FechaDeNacimiento = oPersona.fecha_nac;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return persona;
        }

        public void Update(Persona p)
        {
            try
            {
                using (EntidadesTP2 db = new EntidadesTP2())
                {
                    personas oPersona = db.personas.Find(p.Id);
                    oPersona.nombre = p.Nombre;
                    oPersona.apellido = p.Apellido;
                    oPersona.direccion = p.Direccion;
                    oPersona.telefono = p.Telefono;
                    oPersona.legajo = p.Legajo;
                    oPersona.id_plan = p.IdPlan;
                    oPersona.fecha_nac = p.FechaDeNacimiento;

                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Persona GetOne(int id)
        {
            Persona persona = new Persona();
            try
            {
                using (EntidadesTP2 db = new EntidadesTP2())
                {
                    personas p = db.personas.Find(id);
                    persona.Id = p.id_persona;
                    persona.Nombre = p.nombre;
                    persona.Apellido = p.apellido;
                    persona.Direccion = p.direccion;
                    persona.Email = new MailAddress(p.email);
                    persona.Telefono = p.telefono;
                    persona.FechaDeNacimiento = p.fecha_nac;
                    persona.Legajo = (int)p.legajo;
                    persona.IdPlan = p.id_plan;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return persona;
        }

        public List<Persona> GetAll()
        {
            List<Persona> personas = new List<Persona>();
            using (EntidadesTP2 e = new EntidadesTP2())
            {
                
                foreach (var oPersona in e.personas)
                {
                    Persona per = new Persona
                    {
                        Id = oPersona.id_persona,
                        Nombre = oPersona.nombre,
                        Apellido = oPersona.apellido,
                        Direccion = oPersona.direccion,
                        Email = new MailAddress(oPersona.email),
                        Telefono = oPersona.telefono,
                        FechaDeNacimiento = oPersona.fecha_nac,
                        Legajo = (int)oPersona.legajo,
                        IdPlan = oPersona.id_plan
                    };
                    personas.Add(per);
                }
            }
            return personas;
        }

        public void Delete(int id)
        {
            try
            {
                using (EntidadesTP2 db = new EntidadesTP2())
                {
                    var persona = new personas { id_persona = id };
                    db.personas.Attach(persona);
                    db.personas.Remove(persona);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Materia> GetMateriasPlan(int idPersona)
        {
            List<Materia> materias = new List<Materia>();
            try
            {
                using (EntidadesTP2 db = new EntidadesTP2())
                {
                    var materiasPlan = from per in db.personas
                                       join p in db.planes on per.id_plan equals p.id_plan
                                       join m in db.materias on p.id_plan equals m.id_plan
                                       where per.id_persona == idPersona
                                       select m;
                    foreach (var m in materiasPlan)
                    {
                        materias.Add(new Materia()
                        {
                            Id = m.id_materia,
                            Descripcion = m.desc_materia,
                            HsSemanales = m.hs_semanales,
                            HsTotales = m.hs_totales,
                            IdPlan = m.id_plan
                        });
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return materias;
        }
        public void Save(Persona p)
        {
            if (p.State == BusinessEntity.Estados.New)
            {
                this.Insert(p);
            }
            else if (p.State == BusinessEntity.Estados.Deleted)
            {
                this.Delete(p.Id);
            }
            else if (p.State == BusinessEntity.Estados.Modified)
            {
                this.Update(p);
            }
            p.State = BusinessEntity.Estados.Unmodified;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Persona : BusinessEntity
    {
        private string _Apellido;
        private string _Direccion;
        private System.Net.Mail.MailAddress _Email;
        private DateTime _FechaNacimiento;
        private int _IdPlan;
        private int _Legajo;
        private string _Nombre;
        private string _Telefono;
        private Business.Entities.Persona.TiposPersonas _TipoPersona;

        public enum TiposPersonas
        {
            Deleted,
            New,
            Modified,
            Unmodified
        }
        public string Apellido
        {
            get => default;
            set
            {
            }
        }

        public string Direccion
        {
            get => default;
            set
            {
            }
        }

        public System.Net.Mail.MailAddress Email
        {
            get => default;
            set
            {
            }
        }

        public DateTime FechaDeNacimiento
        {
            get => default;
            set
            {
            }
        }

        public int IdPlan
        {
            get => default;
            set
            {
            }
        }

        public int Legajo
        {
            get => default;
            set
            {
            }
        }

        public string Nombre
        {
            get => default;
            set
            {
            }
        }

        public string Telefono
        {
            get => default;
            set
            {
            }
        }

        public TiposPersonas TipoPersona
        {
            get => default;
            set
            {
            }
        }
    }
}
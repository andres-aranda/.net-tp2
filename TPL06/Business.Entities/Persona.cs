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
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public System.Net.Mail.MailAddress Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public DateTime FechaDeNacimiento
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; }
        }

        public int IdPlan
        {
            get { return _IdPlan; }
            set { _IdPlan = value; }
        }

        public int Legajo
        {
            get { return _Legajo; }
            set { _Legajo = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        public TiposPersonas TipoPersona
        {
            get { return _TipoPersona; }
            set { _TipoPersona = value; }
        }
    }
}
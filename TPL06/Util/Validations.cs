using Academia.Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Util
{
    public class Validations
    {
        public static bool IsValidInscripcion(int IdPersona, int IdCurso)
        {
            try
            {
                using (EntidadesTP2 db = new EntidadesTP2())
                {
                    var v = (alumnos_inscripciones)db.alumnos_inscripciones.Where(x => x.id_alumno == IdPersona && x.id_curso == IdCurso).First();
                }
                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }
        public static bool IsClaveValida(string a , string b)
        {
            return a == b;
        }
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool UsernameExists(string nombreUsuario)
        {
            try
            {
                using (EntidadesTP2 db = new EntidadesTP2())
                {
                    usuarios u = db.usuarios.Where(x => x.nombre_usuario == nombreUsuario).First();
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public static bool IsLegajoUnico(int Legajo)
        {
            try
            {
                using (EntidadesTP2 db = new EntidadesTP2())
                {
                    var v = (personas)db.personas.Where(x => x.legajo == Legajo).First();
                }
            }
            catch
            {
                return true;
            }
            return false;
        }

        
        // Devuelve un saludo distinto dependiendo de la hora del día
        public static string Greeting()
        {
            TimeSpan now = DateTime.Now.TimeOfDay;
            if (now >= TimeSpan.Parse("05:00") && now < TimeSpan.Parse("13:00"))
            {
                return "Buenos días, ";
            }
            else if (now >= TimeSpan.Parse("13:00") && now < TimeSpan.Parse("18:00"))
            {
                return "Buenas tardes, ";
            }
            else
            {
                return "Buenas noches, ";
            }
        }

        public static bool IsValidNota(int nota, string condicion)
        {
            if (nota < 0 || nota > 10)
                return false;
            if (nota < 5 && condicion == "Regular")
                return false;
            if (nota < 6 && condicion == "Aprobada")
                return false;
            if (nota > 6 && condicion == "Libre")
                return false;
            return true;
        }
    }
}

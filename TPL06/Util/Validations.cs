using Academia.Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Util
{
    public class Validations
    {
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
    }
}

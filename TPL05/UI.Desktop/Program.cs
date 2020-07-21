using System;
using System.Windows.Forms;

namespace Academia.UI.Desktop
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuABMC());
        }
    }
}

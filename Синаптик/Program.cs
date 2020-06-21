using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Синаптик
{
    static class Program
    {
        public static SinaptikEntities Sinaptik = new SinaptikEntities();
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAvtoriz());
        }
    }
}

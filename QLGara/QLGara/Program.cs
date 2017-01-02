using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGara
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //Application.Run(new FormUsersList());
            //Application.Run(new FormProfile());
            //Application.Run(new FormUsersList());
            //Application.Run(new FormUsersList());
            //Application.Run(new FormUsersList());
            //Application.Run(new FormUsersList());
        }
    }
}

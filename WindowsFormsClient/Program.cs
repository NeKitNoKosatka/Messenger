using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsClient
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new RegistrationForm());
            //AuthorizationForm authorizationForm = new AuthorizationForm();

            Application.Run(new AuthorizationForm());
            //Application.Run(new MainForm());
            //Application.Run(new Form1());

        }

    }
}

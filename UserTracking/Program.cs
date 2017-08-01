using System;
using System.Windows.Forms;

namespace UserTracking
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new usertracking());
                /*Application.Run(new Views.SplashScreen.SplashScreen());*/
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }
    }
}

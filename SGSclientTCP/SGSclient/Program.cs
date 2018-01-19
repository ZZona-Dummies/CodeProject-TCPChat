using System;
using System.Windows.Forms;

namespace SGSclient
{
    static class Program
    {
        public static SClient client;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            

            LoginForm loginForm = new LoginForm();

            Application.Run(loginForm);
            if (loginForm.DialogResult == DialogResult.OK)
            {
                SGSClient sgsClientForm = new SGSClient();
                //sgsClientForm.clientSocket = loginForm.clientSocket; //Aqui le pasaba la referencia...
                //sgsClientForm.strName = loginForm.strName;

                sgsClientForm.ShowDialog();
            }

        }
    }
}
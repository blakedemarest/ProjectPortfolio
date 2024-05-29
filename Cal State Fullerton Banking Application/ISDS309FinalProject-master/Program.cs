using static ISDS309FinalProject.Form1_LoginFrm;

namespace ISDS309FinalProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //I needed to adjust this so that FinalizeReceipt doesn't activate as many times as there are windows open, I googled how to do this.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            Application.Run(new Form1_LoginFrm());
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            TransactionLogger.FinalizeReceipt(); // Handles final receipt writing here
        }
    }
}
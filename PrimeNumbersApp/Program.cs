using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumbersApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += ApplicationOnThreadException;

            AppDomain.CurrentDomain.UnhandledException += CurrentDomainUnhandledException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        private static void CurrentDomainUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            String errorMessage = String.Format("Sorry, something went wrong. \r\n" +
                 "\r\n Please report error" +
                  "\n\r" + ((Exception) e.ExceptionObject).Message);
            Console.WriteLine($"Error {0} {1}", DateTimeOffset.Now,e.ExceptionObject);
            MessageBox.Show(errorMessage, "Unexpected Error Occurred");
        }

        private static void ApplicationOnThreadException(object sender, ThreadExceptionEventArgs e)
        {
            String errorMessage = String.Format("Sorry, something went wrong. \r\n" +
                "\r\n Please report error"+
                "\n\r" + (e.Exception.Message));
            Console.WriteLine($"Error {0} {1}",DateTimeOffset.Now, e.Exception);
            MessageBox.Show(errorMessage,"Unexpected Error Occurred");
        }
    }
}

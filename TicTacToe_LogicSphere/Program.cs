using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_LogicSphere
{
    internal static class Program
    {
        public static ApplicationContext AppContext { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Here we use the window depending on the context (whether it is main menu's window or game's)
            AppContext = new ApplicationContext(new frmMainMenu());
            Application.Run(AppContext);
        }

        // This function allows changing between forms (between windows)
        public static void SwitchMainForm(Form newForm)
        {
            var oldMainForm = AppContext.MainForm;
            AppContext.MainForm = newForm;

            // The question mark here means that if the oldMainForm is not null its' Close() method will be executed
            oldMainForm?.Close();
            newForm.Show();
        }
    }
}

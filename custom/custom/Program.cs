using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using dataAccess;

namespace view
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DB.deleteAllExceptAdmin();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new view.PanelLogin());
        }
    }
}

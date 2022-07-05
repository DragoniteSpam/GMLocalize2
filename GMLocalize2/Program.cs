using System;
using System.Windows.Forms;

namespace GMLocalize2 {
    static class Program {
        public static ProgramWindow window = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            window = new ProgramWindow();
            Application.Run(window);
        }
    }
}

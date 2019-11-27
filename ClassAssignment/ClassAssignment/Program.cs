using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAssignment
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// CAB 201- CLASS ASSIGNMENT
        /// ARIK INTENAM MIR, student id- n9637567
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InitialGuiForm());
        }
    }
}

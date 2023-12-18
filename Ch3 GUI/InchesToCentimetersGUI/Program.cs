using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
   Author: Maria Esteban
   Date Modified: Sept 12 2023
   Description: allows the user to input a measurement in inches, click a Button, and output the value in centimeters.
*/

namespace InchesToCentimetersGUI
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
            Application.Run(new Form1());
        }
    }
}

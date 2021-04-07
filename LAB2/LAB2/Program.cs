//Grading ID: R8206
//Lab #: 2
//Due Date: Jan 2, 2020
//CIS 199 Section: 01
//Description: This program calculates 15,18 and 20 percent tips from a input dollar amount from the user.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
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
            Application.Run(new TipCalculator());




        }
    }
}

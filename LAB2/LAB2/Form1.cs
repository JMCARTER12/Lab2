//Grading ID: R8206
//Lab #: 2
//Due Date: Jan 2, 2020
//CIS 199 Section: 01
//Description: This program calculates 15,18 and 20 percent tips from a input dollar amount from the user.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{
    public partial class TipCalculator : Form
    {
        public TipCalculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonfortipcalculation_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtBoxPrice_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TiprateLowOutput_Click(object sender, EventArgs e)
        {

        }

        private void TiprateMediumOutput_Click(object sender, EventArgs e)
        {
            
        }

        private void TiprateHighOutput_Click(object sender, EventArgs e)
        {


        }


        // This is where the Event Handler starts
        private void TiprateCalculation_Click(object sender, EventArgs e)

        {
            double price; 

            price = double.Parse(TxtBoxPrice.Text); // Converting user input price

            const double Tiprate1 = 0.15; // 15%
            const double Tiprate2 = 0.18; // 18%
            const double Tiprate3 = 0.20; // 20%

            double Output1 = price * Tiprate1; // user submitted dollar amount * 15%
            double Output2 = price * Tiprate2; // user submitted dollar amount * 18%
            double Output3 = price * Tiprate3; // user submitted dollar amount * 20%

            TiprateLowOutput.Text=(Output1.ToString("C")); // These show the output of the tiprates
            TiprateMediumOutput.Text=(Output2.ToString("C")); 
            TiprateHighOutput.Text=(Output3.ToString("C"));

        }
    }
}

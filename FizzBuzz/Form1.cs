using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            calc = new FizzBuzzCalc();
        }

        FizzBuzzCalc calc;

        

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int numParse;

            NumberValidationLabel.Hide();

            if ( int.TryParse(Number.Text, out numParse) )
            {
                try
                {
                    calc.PerformFIZZBUZZCalculation(numParse);
                }
                catch(Exception f)
                {
                    NumberValidationLabel.Text = "Calculation Failed!";
                    NumberValidationLabel.Show();
                    return;
                }

                ResultViewTextBox.Lines = calc.lastCalculated;

                NumOfFIZZ.Text = calc.numOfFIZZ.ToString();
                NumOfBUZZ.Text = calc.numOfBUZZ.ToString();
                LastCalc.Text = calc.numToCalc.ToString();
            }
            else
            {
                NumberValidationLabel.Text = "Please enter a valid, non-negative integer!";
                NumberValidationLabel.Show();
            }
        }
    }
}

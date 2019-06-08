using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Started on 01/23/2019
//Added CE and C buttons on 01/25/2019
//Created CE and C funtions, as well as fixed the function for the equal button on 01/30/2019

namespace Calculator
{
    public partial class Form1 : Form
    {
        // Variable initialization
        // Input
        string input = string.Empty;
        // First operand (as an empty string, will be added to and converted later)
        string oper1 = string.Empty;
        // Second operand (ditto)
        string oper2 = string.Empty;
        // Operation char
        char operation;
        // Result (as a double)
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();

        }

        // ***********************Begin buttons for numbers***********************
        private void btn_0_Click(object sender, EventArgs e)
        {
            //This part ensures that the calcText box is empty, adds a value to the input variable, and then
            //adds it to the calcText textbox. Rinse and repeat for each of the buttons for the numbers
            this.calcText.Text = "";
            input += "0";
            this.calcText.Text += input;
        }

        // each button will take the text, add a specified number, and use the input variable to add it into the calcText box. This
        // is a repitition of the above code for each button
        private void btn_1_Click(object sender, EventArgs e)
        {
            this.calcText.Text = "";
            input += "1";
            this.calcText.Text += input;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            this.calcText.Text = "";
            input += "2";
            this.calcText.Text += input;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            this.calcText.Text = "";
            input += "3";
            this.calcText.Text += input;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            this.calcText.Text = "";
            input += "4";
            this.calcText.Text += input;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            this.calcText.Text = "";
            input += "5";
            this.calcText.Text += input;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            this.calcText.Text = "";
            input += "6";
            this.calcText.Text += input;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.calcText.Text = "";
            input += "7";
            this.calcText.Text += input;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            this.calcText.Text = "";
            input += "8";
            this.calcText.Text += input;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            this.calcText.Text = "";
            input += "9";
            this.calcText.Text += input;
        }
        // ***********************End number buttons***********************

        // ***********************Begin operator (and decimal point) buttons***********************
        private void btn_dec_Click(object sender, EventArgs e)
        {
            //Once we get to the decimal point, we then ensure that there an empty calcText, then we use a CHAR for the input
            //variable, and then add it into the text box. 
            this.calcText.Text = "";
            input += ".";
            this.calcText.Text += input;
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            //Operators are a little different. The operand variables are assigned a value of input, and the operation
            //variable is assigned the corresponding value (in this case, division), and the input value is cleared.

            oper1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            oper1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            oper1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            oper1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            //Create new variables for the values of the operands
            double firstNumber;
            double secondNumber;
            oper2 = input;

            //Reference the values wanted to a double, from the strings initialized in the constructor
            double.TryParse(oper1, out firstNumber);
            double.TryParse(oper2, out secondNumber);

            if (operation == '+')
            {
                result = firstNumber + secondNumber;
                calcText.Text = result.ToString();
            } else if (operation == '-')
            {
                result = firstNumber - secondNumber;
                calcText.Text = result.ToString();
            } else if (operation == '/')
            {
                result = firstNumber / secondNumber;
                calcText.Text = result.ToString();
            } else if (operation == '*')
            {
                result = firstNumber * secondNumber;
                calcText.Text = result.ToString();
            }
        }

        //Clears current input 
        private void btn_ce_Click(object sender, EventArgs e)
        {
            this.calcText.Text = "";
            this.input = string.Empty;
        }

        //Clears all of the inputs ever given. 
        private void btn_clr_Click(object sender, EventArgs e)
        {
            this.calcText.Text = "";
            this.input = string.Empty;
            this.oper1 = string.Empty;
            this.oper2 = string.Empty;

        }

        // The codeblock below represents the code that it takes to make a number onscreen negative (or positive)
        private void btn_sign_Click(object sender, EventArgs e)
        {
            double sign = Convert.ToDouble(input);
            sign = sign * -1;
            input = Convert.ToString(sign);
            this.calcText.Text = input;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            int back = input.Length;
            string newinput = input.Remove(back - 1, 1);
            input = newinput;
            this.calcText.Text = input;

            if (back == 0) {
                this.calcText.Text = input + 0;
                //TODO FIX THIS ERROR
            } 
        }
        // ***********************End operator buttons***********************
    }
}

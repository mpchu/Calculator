using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    //calculator class with event handlers
    public partial class Calculator : Form
    {
        string input = string.Empty;      //stores user input
        string operand1 = string.Empty;   //stores first operand
        string operand2 = string.Empty;   //stores second operand
        char operation;                   //operation being performed
        double result = 0.0;              //calculated result

        public Calculator()
        {
            InitializeComponent();
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void One_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            if (!input.Contains("."))
            {
                input += ".";
            }
            this.textBox1.Text += input;
        }

        private void DivisionSign_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void MultiplicationSign_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void SubtractionSign_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void AdditionSign_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void EqualSign_Click(object sender, EventArgs e)
        {
            operand2 = input;
            input = "";
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            switch (operation)
            {
                case '^':
                    result = Math.Pow(num1, num2);
                    textBox1.Text = result.ToString();
                    break;
                case '/':
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                    break;
                case '*':
                    result = num1 * num2;
                    textBox1.Text = result.ToString();
                    break;
                case '-':
                    result = num1 - num2;
                    textBox1.Text = result.ToString();
                    break;
                case '+':
                    result = num1 + num2;
                    textBox1.Text = result.ToString();
                    break;
            }

            input = result.ToString();
            operand2 = string.Empty;
            operation = '\0';
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        //clears calculator of any operand or operation data
        private void Clear_Click(object sender, EventArgs e)
        {
            operand1 = string.Empty;
            operand2 = string.Empty;
            input = string.Empty;
            operation = '\0';
            result = 0.0;
            this.textBox1.Text = "";
        }

        private void Exponent_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '^';
            input = string.Empty;
        }
    }
}

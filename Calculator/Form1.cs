using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public enum Operators { Add, Sub, Multi, Div }
    public partial class Form1 : Form
    {
        public double result = 0;
        public bool isNewNum = true;
        public Operators Opt = Operators.Add;

        public Form1()
        {
            InitializeComponent();
        }

        private void Number(string num)
        {
            if (isNewNum)
            {
                textBox1.Text = num;
                isNewNum = false;
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = num;
            }
            else
            {
                textBox1.Text = textBox1.Text + num;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            Number(numButton.Text);

        }

        private void NumPlus_Click(object sender, EventArgs e)
        {
            if (isNewNum == false)
            {
                double num = double.Parse(textBox1.Text);
                if (Opt == Operators.Add)
                    result = result + num;
                else if (Opt == Operators.Sub)
                    result = result - num;
                else if (Opt == Operators.Multi)
                    result = result * num;
                else if (Opt == Operators.Div)
                    result = result / num;

                textBox1.Text = result.ToString();
                isNewNum = true;
            }
            
            Button optButton = (Button)sender;
            if (optButton.Text == "+")
                Opt = Operators.Add;
            else if (optButton.Text == "-")
                Opt = Operators.Sub;
            else if (optButton.Text == "*")
                Opt = Operators.Multi;
            else if (optButton.Text == "/")
                Opt = Operators.Div;
        }

        private void NumClear_Click(object sender, EventArgs e)
        {
            result = 0;
            isNewNum = true;
            Opt = Operators.Add;

            textBox1.Text = "0";
        }
    }
}

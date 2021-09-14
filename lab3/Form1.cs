using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a1 = 0, a2 = 0, b1 = 0, b2 = 0;
            bool correct = true;
            if (textBox1.Text != "") a1 = Convert.ToDouble(textBox1.Text);
            if (textBox2.Text != "") a2 = Convert.ToDouble(textBox2.Text);
            if (textBox3.Text != "") b1 = Convert.ToDouble(textBox3.Text);
            if (textBox4.Text != "") b2 = Convert.ToDouble(textBox4.Text);
            label6.Text = "a1 = " + a1.ToString();
            MyComplex a = new MyComplex(a1, a2);
            MyComplex b = new MyComplex(b1, b2);
            string oper = comboBox1.Text;
            MyComplex c = new MyComplex();
            if(oper == "+") c = a + b;
            else if (oper == "-") c = a - b;
            else if (oper == "*") c = a * b;
            else
            {
                label6.Text = "Uncorret operator";
                correct = false;
            }
            if(correct)label6.Text = c.print();

        }
    }
}

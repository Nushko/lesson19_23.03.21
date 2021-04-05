using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson19_23._03._21
{
    public partial class Form1 : Form
    {
        double num1 = 0, num2 = 0, num3 = 0;
        char oper = ' ';
        public Form1()
        {
            InitializeComponent();
        }

        private void num_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (textBox1.Text == "0")
                textBox1.Text = "";

            textBox1.Text += button.Text;

            if (button.Text == ",")
            {
                if (!textBox1.Text.Contains(","))
                    textBox1.Text += ",";
            }
        }
        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            if (num1 == 0)
                num1 = double.Parse(textBox1.Text);

            textBox1.Text = "0";
            oper = button.Text[0];

            if (button.Text[0] == '×')
                oper = '*';

            if (button.Text[0] == '÷')
                oper = '/';

            label1.Text = $"{num1} {oper}";
        }

        private void clear_click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void clearAll_click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            num1 = 0;
            num2 = 0;
            oper = ' ';
            label1.Text = "";
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" && textBox1.Text != "")
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);

            if (textBox1.Text == "")
                textBox1.Text = "0";
        }

        private void btnToPow2_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox1.Text = (num1 * num1).ToString();
        }

        private void btn1_overX_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox1.Text = (1.0 / num1).ToString();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox1.Text = (Math.Sqrt(num1)).ToString();
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            if (num1 != 0)
            {
                num1 = num1 * (-1);
                textBox1.Text = num1.ToString();
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (oper != ' ')
            {
                num2 = double.Parse(textBox1.Text);
                num3 = (num1 / 100) * num2;
                textBox1.Text = oper switch
                {
                    '+' => (num1 + num3).ToString(),
                    '-' => (num1 - num3).ToString(),
                    '*' => (num1 * num3).ToString(),
                    '/' => (num1 / num3).ToString(),
                    _ => default
                };
                num1 = 0;
                num2 = 0;
                oper = ' ';
                label1.Text = "";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (oper != ' ')
            {
                num2 = double.Parse(textBox1.Text);
                textBox1.Text = oper switch
                {
                    '+' => (num1 + num2).ToString(),
                    '-' => (num1 - num2).ToString(),
                    '*' => (num1 * num2).ToString(),
                    '/' => (num1 / num2).ToString(),
                    _ => default
                };
                num1 = 0;
                num2 = 0;
                oper = ' ';
                label1.Text = "";
            }
        }

    }
}

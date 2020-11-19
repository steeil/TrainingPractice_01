using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngiCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 1)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('+') || textBox1.Text.Contains('-') || textBox1.Text.Contains('*') || textBox1.Text.Contains('/') || textBox1.Text.Contains('^') || textBox1.Text.Contains('%') || textBox1.Text.Contains('√') || textBox1.Text == "") { }
            else
            {
                textBox1.Text = textBox1.Text + "+";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('+') || textBox1.Text.Contains('-') || textBox1.Text.Contains('*') || textBox1.Text.Contains('/') || textBox1.Text.Contains('^') || textBox1.Text.Contains('%') || textBox1.Text.Contains('√') || textBox1.Text == "") { }
            else
            {
                textBox1.Text = textBox1.Text + "-";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('+') || textBox1.Text.Contains('-') || textBox1.Text.Contains('*') || textBox1.Text.Contains('/') || textBox1.Text.Contains('^') || textBox1.Text.Contains('%') || textBox1.Text.Contains('√') || textBox1.Text == "") { }
            else
            {
                textBox1.Text = textBox1.Text + "/";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('+') || textBox1.Text.Contains('-') || textBox1.Text.Contains('*') || textBox1.Text.Contains('/') || textBox1.Text.Contains('^') || textBox1.Text.Contains('%') || textBox1.Text.Contains('√') || textBox1.Text == "") { }
            else
            {
                textBox1.Text = textBox1.Text + "*";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('+') || textBox1.Text.Contains('-') || textBox1.Text.Contains('*') || textBox1.Text.Contains('/') || textBox1.Text.Contains('^') || textBox1.Text.Contains('%') || textBox1.Text.Contains('√') || textBox1.Text == "") { }
            else
            {
                textBox1.Text = textBox1.Text + "%";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('+') || textBox1.Text.Contains('-') || textBox1.Text.Contains('*') || textBox1.Text.Contains('/') || textBox1.Text.Contains('^') || textBox1.Text.Contains('%') || textBox1.Text.Contains('√') || textBox1.Text == "") { }
            else
            {
                textBox1.Text = textBox1.Text + "^";
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('+') || textBox1.Text.Contains('-') || textBox1.Text.Contains('*') || textBox1.Text.Contains('/') || textBox1.Text.Contains('^') || textBox1.Text.Contains('%') || textBox1.Text.Contains('√') || textBox1.Text == "") { }
            else
            {
                textBox1.Text = textBox1.Text + "√";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('+') || textBox1.Text.Contains('-') || textBox1.Text.Contains('*') || textBox1.Text.Contains('/') || textBox1.Text.Contains('^') || textBox1.Text.Contains('%') || textBox1.Text.Contains('√') || textBox1.Text == "") { }
            else
            {
                textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox1.Text)));
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('+') || textBox1.Text.Contains('-') || textBox1.Text.Contains('*') || textBox1.Text.Contains('/') || textBox1.Text.Contains('^') || textBox1.Text.Contains('%') || textBox1.Text.Contains('√') || textBox1.Text == "") { }
            else
            {
                textBox1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textBox1.Text),1.0/3.0));
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('+') || textBox1.Text.Contains('-') || textBox1.Text.Contains('*') || textBox1.Text.Contains('/') || textBox1.Text.Contains('^') || textBox1.Text.Contains('%') || textBox1.Text.Contains('√') || textBox1.Text == "") { }
            else
            {
                textBox1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textBox1.Text),2));
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('+') || textBox1.Text.Contains('-') || textBox1.Text.Contains('*') || textBox1.Text.Contains('/') || textBox1.Text.Contains('^') || textBox1.Text.Contains('%') || textBox1.Text.Contains('√') || textBox1.Text == "") { }
            else
            {
                textBox1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textBox1.Text), 3));
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('+') || textBox1.Text.Contains('-') || textBox1.Text.Contains('*') || textBox1.Text.Contains('/') || textBox1.Text.Contains('^') || textBox1.Text.Contains('%') || textBox1.Text.Contains('√') || textBox1.Text == "") { }
            else
            {
                int a = 1;
                for (int i=2;i<=Convert.ToInt32(textBox1.Text);i++)
                {
                    a *= i;
                }
                textBox1.Text = Convert.ToString(a);
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('+') || textBox1.Text.Contains('-') || textBox1.Text.Contains('*') || textBox1.Text.Contains('/') || textBox1.Text.Contains('^') || textBox1.Text.Contains('%') || textBox1.Text.Contains('√') || textBox1.Text == "") { }
            else
            {
                textBox1.Text = Convert.ToString(Math.Log10(Convert.ToDouble(textBox1.Text)));
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('+') || textBox1.Text.Contains('-') || textBox1.Text.Contains('*') || textBox1.Text.Contains('/') || textBox1.Text.Contains('^') || textBox1.Text.Contains('%') || textBox1.Text.Contains('√') || textBox1.Text == "") { }
            else
            {
                textBox1.Text = Convert.ToString(Math.Sin((Convert.ToDouble(textBox1.Text)/180D)*Math.PI));
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('+') || textBox1.Text.Contains('-') || textBox1.Text.Contains('*') || textBox1.Text.Contains('/') || textBox1.Text.Contains('^') || textBox1.Text.Contains('%') || textBox1.Text.Contains('√') || textBox1.Text == "") { }
            else
            {
                textBox1.Text = Convert.ToString(Math.Cos((Convert.ToDouble(textBox1.Text)/180D)*Math.PI));
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('+') || textBox1.Text.Contains('-') || textBox1.Text.Contains('*') || textBox1.Text.Contains('/') || textBox1.Text.Contains('^') || textBox1.Text.Contains('%') || textBox1.Text.Contains('√') || textBox1.Text == "") { }
            else
            {
                textBox1.Text = Convert.ToString(Math.Tan((Convert.ToDouble(textBox1.Text)/180D)*Math.PI));
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('+') || textBox1.Text.Contains('-') || textBox1.Text.Contains('*') || textBox1.Text.Contains('/') || textBox1.Text.Contains('^') || textBox1.Text.Contains('%') || textBox1.Text.Contains('√') || textBox1.Text == "") { }
            else
            {
                textBox1.Text = Convert.ToString(1/Convert.ToDouble(textBox1.Text));
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                if (textBox1.Text.Contains('+') || textBox1.Text.Contains('-') || textBox1.Text.Contains('*') || textBox1.Text.Contains('/') || textBox1.Text.Contains('^') || textBox1.Text.Contains('%') || textBox1.Text.Contains('√') || textBox1.Text == "") 
                {
                    char l=' ';
                    if (textBox1.Text.Contains('+'))
                    {
                        l = '+';
                    }
                    if (textBox1.Text.Contains('-'))
                    {
                        l = '-';
                    }
                    if (textBox1.Text.Contains('*'))
                    {
                        l = '*';
                    }
                    if (textBox1.Text.Contains('/'))
                    {
                        l = '/';
                    }
                    if (textBox1.Text.Contains('^'))
                    {
                        l = '^';
                    }
                    if (textBox1.Text.Contains('%'))
                    {
                        l = '%';
                    }
                    if (textBox1.Text.Contains('√'))
                    {
                        l = '√';
                    }
                    int k = textBox1.Text.IndexOf(l);
                    int s= textBox1.Text.Length;
                    for (int i = s; i > k + 1; i--)
                    {
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                    }
                }
                else
                {
                    int s = textBox1.Text.Length;
                    for (int i = s; i >=1; i--)
                    {
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                    }
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('+') || textBox1.Text.Contains('-') || textBox1.Text.Contains('*') || textBox1.Text.Contains('/') || textBox1.Text.Contains('^') || textBox1.Text.Contains('%') || textBox1.Text.Contains('√') || textBox1.Text == "")
            {
                string c1 = "";
                string c2 = "";
                int i = 0;
                int j = 0;
                if (textBox1.Text.Contains('+'))
                {
                    foreach (char c in textBox1.Text)
                    {
                        i++;
                        if (c == '+')
                        {
                            break;
                        }
                        c1 = c1 + c;
                    }
                    foreach (char c in textBox1.Text)
                    {
                        j++;
                        if (j > i)
                        {
                            c2 = c2 + c;
                        }
                    }
                    textBox1.Text = Convert.ToString(Convert.ToDouble(c1)+Convert.ToDouble(c2));
                }
                if (textBox1.Text.Contains('-'))
                {
                    foreach (char c in textBox1.Text)
                    {
                        i++;
                        if (c == '-')
                        {
                            break;
                        }
                        c1 = c1 + c;
                    }
                    foreach (char c in textBox1.Text)
                    {
                        j++;
                        if (j > i)
                        {
                            c2 = c2 + c;
                        }
                    }
                    textBox1.Text = Convert.ToString(Convert.ToDouble(c1) - Convert.ToDouble(c2));
                }
                if (textBox1.Text.Contains('*'))
                {
                    foreach (char c in textBox1.Text)
                    {
                        i++;
                        if (c == '*')
                        {
                            break;
                        }
                        c1 = c1 + c;
                    }
                    foreach (char c in textBox1.Text)
                    {
                        j++;
                        if (j > i)
                        {
                            c2 = c2 + c;
                        }
                    }
                    textBox1.Text = Convert.ToString(Convert.ToDouble(c1) * Convert.ToDouble(c2));
                }
                if (textBox1.Text.Contains('/'))
                {
                    foreach (char c in textBox1.Text)
                    {
                        i++;
                        if (c == '/')
                        {
                            break;
                        }
                        c1 = c1 + c;
                    }
                    foreach (char c in textBox1.Text)
                    {
                        j++;
                        if (j > i)
                        {
                            c2 = c2 + c;
                        }
                    }
                    textBox1.Text = Convert.ToString(Convert.ToDouble(c1) / Convert.ToDouble(c2));
                }
                if (textBox1.Text.Contains('^'))
                {
                    foreach (char c in textBox1.Text)
                    {
                        i++;
                        if (c == '^')
                        {
                            break;
                        }
                        c1 = c1 + c;
                    }
                    foreach (char c in textBox1.Text)
                    {
                        j++;
                        if (j > i)
                        {
                            c2 = c2 + c;
                        }
                    }
                    textBox1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(c1),Convert.ToDouble(c2)));
                }
                if (textBox1.Text.Contains('%'))
                {
                    foreach (char c in textBox1.Text)
                    {
                        i++;
                        if (c == '%')
                        {
                            break;
                        }
                        c1 = c1 + c;
                    }
                    foreach (char c in textBox1.Text)
                    {
                        j++;
                        if (j > i)
                        {
                            c2 = c2 + c;
                        }
                    }
                    textBox1.Text = Convert.ToString(Convert.ToDouble(c2) / Convert.ToDouble(c1) * 100);
                }
                if (textBox1.Text.Contains('√'))
                {
                    foreach (char c in textBox1.Text)
                    {
                        i++;
                        if (c == '√')
                        {
                            break;
                        }
                        c1 = c1 + c;
                    }
                    foreach (char c in textBox1.Text)
                    {
                        j++;
                        if (j > i)
                        {
                            c2 = c2 + c;
                        }
                    }
                    textBox1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(c1),1.0 / Convert.ToDouble(c2)));
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+Convert.ToString(Math.PI);
        }
    }
}

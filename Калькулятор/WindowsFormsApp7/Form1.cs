using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool id = false;
        bool pr_id = false;
        double res = 0;
        char z = ' ';

        public void pr(string w)
        {
            if (pr_id == true)
            {
                if (id == false) textBox1.Text += w;
                else
                {
                    res = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = w; id = false;
                }
            }

            else {
                if (textBox1.Text == "0.") 

                    textBox1.Clear();
                    if (id == false) textBox1.Text += w;
                    else
                    {
                        res = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = w; id = false;
                    }

                
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            pr(button1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            z = '+';
            id = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pr(button5.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length!=0)
            pr(button16.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            switch (z)
            {

                case '+': textBox1.Text = Convert.ToString(res+Convert.ToDouble(textBox1.Text));break;
                case '-': textBox1.Text = Convert.ToString(res - Convert.ToDouble(textBox1.Text)); break;
                case '/': textBox1.Text = Convert.ToString(res / Convert.ToDouble(textBox1.Text)); break;
                case '*': textBox1.Text = Convert.ToString(res * Convert.ToDouble(textBox1.Text)); break;
            }
        }

        private void button15_Click(object sender, EventArgs e)

        {
            pr_id = true;
            if (textBox1.Text.IndexOf('.')==-1)
            pr(button15.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            z = '-';
            id = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(-1*Convert.ToDouble(textBox1.Text));
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) >= 0)
                textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox1.Text)));
            else textBox1.Text = "ERROR";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Sin(Convert.ToDouble(textBox1.Text)*Math.PI/180));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pr(button8.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pr(button4.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pr(button9.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pr(button6.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pr(button3.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pr(button7.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pr(button2.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            z = '/';
            id = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            z = '*';
            id = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Cos(Convert.ToDouble(textBox1.Text) * Math.PI / 180));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Tan(Convert.ToDouble(textBox1.Text) * Math.PI / 180));
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Ceiling(Convert.ToDouble(textBox1.Text) * Math.PI / 180));
        }

        private void button24_Click(object sender, EventArgs e)
        {

            textBox1.Text = Convert.ToString(Math.Exp(Convert.ToDouble(textBox1.Text) * Math.PI / 180));
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Asin(Convert.ToDouble(textBox1.Text) * Math.PI / 180));
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Acos(Convert.ToDouble(textBox1.Text) * Math.PI / 180));
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Atan(Convert.ToDouble(textBox1.Text) * Math.PI / 180));
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Atan(Convert.ToDouble(textBox1.Text) * Math.PI / 180));
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Abs(Convert.ToDouble(textBox1.Text) * Math.PI / 180));
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Floor(Convert.ToDouble(textBox1.Text)));
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Ceiling(Convert.ToDouble(textBox1.Text)));
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Round(Convert.ToDouble(textBox1.Text)));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkMt
{
    public partial class Form1 : Form
    {
        public double mnoz;
        public double x;
        public double raport;
        public double nadavek;
        public double metrycist;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") mnoz = Convert.ToDouble(textBox1.Text);
            if (textBox2.Text != "") x = Convert.ToDouble(textBox2.Text);
            if (textBox4.Text != "") raport = Convert.ToDouble(textBox4.Text);
            if (textBox5.Text != "") nadavek = Convert.ToDouble(textBox5.Text);

            if (mnoz > 0 && x > 0 && raport > 0 && nadavek > 0)
            {
                metrycist = (mnoz / x) * (raport / 1000);
                label6.Text = Convert.ToString("K tisku: " + Math.Ceiling(metrycist + nadavek) + " (" + Math.Ceiling(metrycist) + ")");
                label7.Text = Convert.ToString("Etiket celkem: " + Math.Ceiling((metrycist + nadavek) / (raport / 1000)) * x);
            }
             
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
    }
}

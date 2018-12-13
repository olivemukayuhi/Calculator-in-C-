using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = Convert.ToDouble(textBox1.Text);
            var b = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (a + b).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var a = Convert.ToDouble(textBox1.Text);
            var b = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (a - b).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = Convert.ToDouble(textBox1.Text);
            var b = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (a / b).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var a = Convert.ToDouble(textBox1.Text);
            var b = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (a * b).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("please enter your number" + textBox1.Text);
            if (textBox1.Text == "")
            {
                MessageBox.Show("wrong calculation"+textBox1.Text);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SILAEV_PRACT_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox4.Text == "")
            {
                MessageBox.Show("Field is empty");
            }
            else
            {
                textBox1.Clear();
                textBox1.Text = textBox4.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Field is empty");
            }
            else
            {
                textBox1.Clear();
                textBox1.Text = textBox3.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Field is empty");
            }
            else
            {
                textBox1.Clear();
                textBox1.Text = textBox2.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Some fields is empty");
            }
            else
            {
                textBox1.Clear();
                textBox1.Text = textBox4.Text + " " + textBox3.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Some fields is empty");
            }
            else
            {
                textBox1.Clear();
                textBox1.Text = textBox4.Text + " " + textBox2.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Some fields is empty");
            }
            else
            {
                textBox1.Clear();
                textBox1.Text = textBox3.Text + " " + textBox2.Text;
            }
        }
    }
}

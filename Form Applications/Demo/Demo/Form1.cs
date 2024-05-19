using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //  Random randy = new Random();
            label1.Text = textBox1.Text;
            int fontsize = Convert.ToInt32(textBox1.Text);
           // Font myotherfont = new Font()
            Font myfont = new Font("Arial", fontsize, FontStyle.Italic);
            label1.Font = myfont;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
            label1.Text = textBox1.Text;
            button1.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                this.BackColor = Color.Blue;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "red")
            {
                this.BackColor = Color.Red;
            }
            
        }
    }
}

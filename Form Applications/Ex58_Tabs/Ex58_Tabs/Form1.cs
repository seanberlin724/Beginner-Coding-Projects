using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/******************Block Comment***********************
 * Sean Berlin            Per.9              5-15-18
 * This is a program that shows the basics of
 * the c# program
 * 
 * Create a program called EX58_TABS with a form with several controls including the TAB object.
 *  The TAB object will have at least 3 tabs each having a different look and different objects.
 *   Write code that does "something interesting." 
Use your imagination! Make it fun.(your choice)
 * 
 * *****************************/
namespace Ex58_Tabs
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Green")
            {
                this.BackColor = Color.Green;
                tabPage1.BackColor = Color.Green;
                button1.BackColor = Color.Green;
            }
            if (comboBox1.Text == "Blue")
            {
                this.BackColor = Color.Blue;
                tabPage1.BackColor = Color.Blue;
                button1.BackColor = Color.Blue;
            }
            if (comboBox1.Text == "Black")
            {
                this.BackColor = Color.Black;
                tabPage1.BackColor = Color.Black;
                button1.BackColor = Color.Black;
            }

        }
        float fontSize = 26f;
        private void button2_Click(object sender, EventArgs e)
        {
            fontSize++;
            Font myfont = new Font("Arial", fontSize, FontStyle.Italic);
            label1.Font = myfont;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fontSize--;
            Font myfont = new Font("Arial", fontSize, FontStyle.Italic);
            label1.Font = myfont;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // if (textBox1.Text == "313")
           // {
                //Application.Exit();
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
            if (label3.Text == "313")
            {
                Application.Exit();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label7.Left += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label5.Left += 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label6.Left += 5;
        }
    }
}

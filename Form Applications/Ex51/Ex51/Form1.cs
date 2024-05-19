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
 * Sean Berlin              Per.9            4-29-19
 * This is a program that shows the basics of
 * the c# program
 * Create a program called EX51 with a form that has a button a label and a textbox. 
 * Write code for the button such that on button click the user entered text in the
 *  textbox appears as the text for the label. Remember to comment!!! 
 * and the you project should not be called Form1
 * 
 * 
 * *****************************/
namespace Ex51
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
            label1.Text = textBox1.Text;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //this.Text = textBox1.Text;
            //label1.Text = textBox1.Text;
           // button1.Text = textBox1.Text;
        }
    }
}

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
 * Sean Berlin                          9-12-18
 * This is a program that shows the basics of
 * the c# program
 * Create a program called EX56_Sizes with a form with 4 buttons and a label. 
 * Write code to change the default size to a starting size of 500 by 500. 
 * Also have the form's starting position in the center of the screen. 
 * Your form will also include 4 buttons each with "on button click" code that 
 * will relocate the forms position/location. (upper right, upper left, bottom right, 
 * bottom left). Finally when changing position change the text to something new, 
 * helpful and meaningful that you learned about #C this year.
 * 
 * 
 * *****************************/
namespace Ex56_Sizes
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
            //bottom right
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            label1.Text = "I learned that #C can be used to perform formulas by utilizing methods.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //bottom left
            
            this.Left = Screen.PrimaryScreen.WorkingArea.Width -  1375;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            
            label1.Text = "I learned that #C can be used to create images or display images imported from the internet.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //top right
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - 730;
            label1.Text = "I learned that #C can utilize conditions and loops to find various types of numbers such as factorials and prime factors.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //top left
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - 1375;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - 730;
            label1.Text = "I learned all variables declared in #C must be declared using a data type";
        }
    }
}

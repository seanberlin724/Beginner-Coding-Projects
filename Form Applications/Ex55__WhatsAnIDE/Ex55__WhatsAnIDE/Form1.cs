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
 * Create a program called EX55_WhatIsAnIDE with a form that has 2 buttons and a label.
 *  The label will have a brief description of an IDE. 
 *  Write code for one button to enlarge the size of the form. 
 * The other button will have code to close the form.
 * 
 * 
 * *****************************/
namespace Ex55__WhatsAnIDE
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
        float fontSize = 26f;
        private void button1_Click(object sender, EventArgs e)
        {
            fontSize++;
            Font myfont = new Font("Arial", fontSize, FontStyle.Italic);
            label1.Font = myfont;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

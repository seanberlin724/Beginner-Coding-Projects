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
 * Sean Berlin             Per.9             4-25-19
 * This is a program that shows the basics of
 * the c# program
 * Create a program called EX50(Yea just EX50) with one form that has two buttons and a label.
 *  Write code for both button click events.
 *   Each event handler or method should change the text properties of the label to 
 *   a set string you create. 
 * Remember to comment your code.
 * 
 * 
 * *****************************/
namespace Ex50
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
        float fontSize = 8.25f;
        private void button2_Click(object sender, EventArgs e)
        {
            fontSize++;
            Font myfont = new Font("Arial", fontSize, FontStyle.Italic);
            label1.Font = myfont;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Changed";
        }
    }
}

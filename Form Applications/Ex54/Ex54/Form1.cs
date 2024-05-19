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
 * Create a program called EX54 with a form that has 6 buttons and 1 label. 
 * Create meaningful text for the label that describes a few of you favorite ToolBox objects. 
 * Each button will change one of the following properties: font, 
 * text(add a few more Toolbox objects), background color and font color, 
 * size and one to reset the label back to its original properties. Edit the tab order
 *  so that it follows a logical sequence from top left to bottom right.
 * 
 * 
 * *****************************/
namespace Ex54
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
        float fontSize = 18f;
        private void button2_Click(object sender, EventArgs e)
        {
             fontSize = 18;
            Font myfont = new Font("Algerian", fontSize, FontStyle.Regular);
            label1.Font = myfont;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Color myColor = new Color();
            //label1.Text = myColor;
            this.label1.ForeColor = Color.Tomato;
            //label1.Text
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label1.BackColor = Color.Blue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "The text has been changed";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fontSize++;
            Font myfont = new Font("Arial", fontSize, FontStyle.Regular);
            label1.Font = myfont;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.label1.ForeColor = DefaultForeColor;
            fontSize = 18;
            Font myfont = new Font("Arial", fontSize, FontStyle.Regular);
            label1.Font = myfont;
            this.label1.BackColor = DefaultBackColor;
            label1.BackColor = DefaultBackColor;
            label1.Text = "The ComboBox allows for creativity by giving a drop down menu of an inputed list. The button allows properties to change when clicked on.";
            

        }
    }
}

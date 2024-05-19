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
 * Create a program called EX52 with a form that has a button, combobox and a label.
 *  Make the combobox such that there are 5 possible names that could be selected.
 *   Write code for the button such that on button click the
 *  combobox text appears as a label text.
 * 
 * 
 * *****************************/
namespace Ex52
{
    public partial class Ex52 : Form
    {
        public Ex52()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = comboBox1.Text;
        }
    }
}

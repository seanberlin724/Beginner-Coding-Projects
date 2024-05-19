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
 * Sean Berlin              Per. 9            6-13-19
 * This is a program that shows the basics of
 * the c# program
 * Create a picture box on a form 2. 
 * Create a series of pictures that vary slightly from each other. 
 * 3. Create a command button or buttons to start and stop the timer.
 *  4. Write code in the timer event to load the display the picture series.
 *  5. Program a way to cleanly exit the program. 
 * 
 * 
 * *****************************/
namespace Ex63_FlipBook
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
            timer1.Enabled = true;
           
        }
        int x = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Slide" +x +".jpg");
            x++;
            if (x>6)
            {
                x = 1;
            }
        }
    }
}

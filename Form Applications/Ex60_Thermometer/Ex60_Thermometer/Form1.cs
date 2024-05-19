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
 * Sean Berlin              Per.9            5-29-18
 * This is a program that shows the basics of
 * the c# program
 * 
 * 
 * 
 * *****************************/
namespace Ex60_Thermometer
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //double fahrenheight = 0;
           //int fahrenheight = Convert.ToInt32(Console.ReadLine());
            //double centigrade = (fahrenheight - 32) * (5 / 9); 
            //textBox2.Text = "" + centigrade.ToString();
         
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

            // fahrenheightt = "";
            //textBox1.Text = fahrenheightt;
            //fahrenheightt = 
            
            
            
            //double fahrenheight = 0;
            double fahrenheight = -vScrollBar1.Value;
            textBox1.Text = "" + fahrenheight.ToString("0.##");
          
           double centigrade = (fahrenheight - 32) * (5.0 / 9.0);
            textBox2.Text = "" + centigrade.ToString("0.##");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

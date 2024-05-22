using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_Maze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            moveToStart();
            
        }
        private void moveToStart()
        {
            Cursor.Position = PointToScreen(label1.Location);

        }

        

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You win!!!");
            Application.Exit();
           
        }

        private void moveToStart(object sender, EventArgs e)
        {
            Cursor.Position = PointToScreen(label1.Location);
            timer1.Enabled = false;
            label11.Top = 27;
            label13.Left = 540;
            label41.Top = 53;
            label44.Top = 53;
            label47.Left = 446;
            label50.Left = 446;
        }
        private void moveToButton(object sender, EventArgs e)
        {
            Cursor.Position = PointToScreen(button2.Location);
            
        }
        private void moveToButton4(object sender, EventArgs e)
        {
            Cursor.Position = PointToScreen(button4.Location);

        }
        private void moveToButton3(object sender, EventArgs e)
        {

            Cursor.Position = PointToScreen(button3.Location);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label11.Top += 5;
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        int x = 5;
        int y = -5;
        int b = 5;
        int c = -5;
        int m = 5;
        int n = -5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label13.Left -= 7;
            
            if (label14.Top == 170)
            {
                x = 5;
            }
            if(label14.Top == 235)
            {

                x = -5; ;
            }
            if (label17.Top == 170)
            {
                y = 5;

            }
            if (label17.Top == 235)
            {
                y = -5;

            }
            if (label16.Top ==170)
            {
                b = 5;
            }
            if(label16.Top == 235)
            {
                b = -5;
            }
            if (label15.Top == 170)
            {
                c = 5;
            }
            if(label15.Top==235)
            {
                c = -5;
            }
            label14.Top += x;
            label17.Top += y;
            label16.Top += b;
            label15.Top += c;
            if(label28.Left==10)
            {
                m = +1;
            }
            if (label28.Left ==30)
            {
                m = -1;
            }
            if (label37.Left ==30)
            {
                n = 10;
            }
            if (label37.Left ==120)
            {
                n = -10;
            }
            label28.Left += m;
            label37.Left += n;
        }

        
        int a = 5;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label22.Top == 15)
            {
                a = 5;

            }
            if (label22.Top == 95)
            {
                a = -5;

            }
            label22.Top += a;
        }

        private void label23_MouseEnter(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            label27.Top += 5;
        }

       private void button4_Click(object sender, EventArgs e)
        {
            label41.Top += 2;
            label44.Top += -2;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            label47.Left += 2;
            label50.Left += -2;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}

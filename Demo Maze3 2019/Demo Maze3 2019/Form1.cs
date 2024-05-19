using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Maze3_2019
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
            button1.Height += 15;
            button1.Width += 15;
            button1.Top -= 8;
            button1.Left -= 8;
            button1.Location = new Point(100, 100);
        }
        
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Top++;
            button1.Left++;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Size = new Size(100, 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show(monthCalendar1.TodayDate.ToString());
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > 95)
            {
                progressBar1.Value = 0;
            }
            progressBar1.Value += 5;
        }
    }
}

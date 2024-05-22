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
 * 
 *  Many games depend on the roll of a pair of dice. 
 *  The object of this program is to simulate the roll of dice. 
 *  The program will display dice images showing the value of dice values. 
 *  The project assumes standard six sided dice but can be expanded to other sizes if desired. 
PROJECT 

 * 
 * *****************************/
namespace Ex62_DiceDisplay
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
            Application.Exit();
        }
        //Image diceOnePic = Image.FromFile("path here");
        //Image diceTwoPic = Image.FromFile("path here");
        //Image diceThreePic = Image.FromFile("path here");
        //Image diceFourPic = Image.FromFile("path here");
        //Image diceFivePic = Image.FromFile("path here");
        //Image diceSixPic = Image.FromFile("path here");
        public static Random rnd1 = new Random();
        private void button2_Click(object sender, EventArgs e)
        {
            int diceOne = rnd1.Next(1, 7);
            int diceTwo = rnd1.Next(1, 7);
            pictureBox1.Image = Image.FromFile("Dice " + diceOne + ".png");
            pictureBox2.Image = Image.FromFile("Dice " + diceTwo + ".png");
        }
    }
}

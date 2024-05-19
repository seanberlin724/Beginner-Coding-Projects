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
 * Create a program called EX57_MessyCalculator. Recreate your calculator, 
 * but this time place the controls in random positions on the form
 * (or leave them in their default positions if you double click to add) 
 * and ONLY change the text and position of the buttons by writing code.
 *  Don't use the properties window.
 * 
 * 
 * *****************************/
namespace Ex57_MessyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "1";
            button1.Size = new Size (34,34);
            button1.Location = new Point(89, 173);
            button1.ForeColor = Color.Blue;

            button2.Text = "2";
            button2.Size = new Size(34, 34);
            button2.Location = new Point(128, 173);
            button2.ForeColor = Color.Blue;

            button3.Text = "3";
            button3.Size = new Size(34, 34);
            button3.Location = new Point(170, 173);
            button3.ForeColor = Color.Blue;

            button4.Text = "4";
            button4.Size = new Size(34, 34);
            button4.Location = new Point(91, 133);
            button4.ForeColor = Color.Blue;

            button5.Text = "5";
            button5.Size = new Size(34, 34);
            button5.Location = new Point(127, 133);
            button5.ForeColor = Color.Blue;

            button6.Text = "6";
            button6.Size = new Size(34, 34);
            button6.Location = new Point(170, 133);
            button6.ForeColor = Color.Blue;

            button7.Text = "7";
            button7.Size = new Size(34, 34);
            button7.Location = new Point(91, 93);
            button7.ForeColor = Color.Blue;

            button8.Text = "8";
            button8.Size = new Size(34, 34);
            button8.Location = new Point(127, 93);
            button8.ForeColor = Color.Blue;

            button9.Text = "9";
            button9.Size = new Size(34, 34);
            button9.Location = new Point(170, 93);
            button9.ForeColor = Color.Blue;

            button10.Text = "M+";
            button10.Size = new Size(34, 34);
            button10.Location = new Point(40, 213);
            button10.ForeColor = Color.Red;

            button11.Text = "MS";
            button11.Size = new Size(34, 34);
            button11.Location = new Point(40, 173);
            button11.ForeColor = Color.Red;

            button12.Text = "MR";
            button12.Size = new Size(34, 34);
            button12.Location = new Point(40, 133);
            button12.ForeColor = Color.Red;

            button13.Text = "MC";
            button13.Size = new Size(34, 34);
            button13.Location = new Point(40, 91);
            button13.ForeColor = Color.Red;

            button14.Text = "/";
            button14.Size = new Size(34, 34);
            button14.Location = new Point(210, 93);
            button14.ForeColor = Color.Red;

            button15.Text = "*";
            button15.Size = new Size(34, 34);
            button15.Location = new Point(210, 133);
            button15.ForeColor = Color.Red;

            button16.Text = "-";
            button16.Size = new Size(34, 34);
            button16.Location = new Point(210, 175);
            button16.ForeColor = Color.Red;

            button17.Text = "+";
            button17.Size = new Size(34, 34);
            button17.Location = new Point(210, 215);
            button17.ForeColor = Color.Red;

            button18.Text = "=";
            button18.Size = new Size(34, 34);
            button18.Location = new Point(249, 215);
            button18.ForeColor = Color.Red;

            button19.Text = "Backspace";
            button19.Size = new Size(72, 25);
            button19.Location = new Point(40, 62);
            button19.ForeColor = Color.Red;

            button20.Text = "CE";
            button20.Size = new Size(81, 25);
            button20.Location = new Point(114, 62);
            button20.ForeColor = Color.Red;

            button21.Text = "C";
            button21.Size = new Size(81, 25);
            button21.Location = new Point(202, 62);
            button21.ForeColor = Color.Red;

            button22.Text = "0";
            button22.Size = new Size(34, 34);
            button22.Location = new Point(88, 213);
            button22.ForeColor = Color.Blue;

            button23.Text = "+/-";
            button23.Size = new Size(34, 34);
            button23.Location = new Point(130, 213);
            button23.ForeColor = Color.Blue;

            button24.Text = ".";
            button24.Size = new Size(34, 34);
            button24.Location = new Point(171, 213);
            button24.ForeColor = Color.Blue;

            button25.Text = "";
            button25.Size = new Size(32, 33);
            button25.Location = new Point(2, 64);
            button25.ForeColor = Color.Red;

            button26.Text = "SQRT";
            button26.Size = new Size(34, 34);
            button26.Location = new Point(250, 93);
            button26.ForeColor = Color.Blue;

            button27.Text = "%";
            button27.Size = new Size(34, 34);
            button27.Location = new Point(249, 133);
            button27.ForeColor = Color.Blue;

            button28.Text = "1/X";
            button28.Size = new Size(34, 34);
            button28.Location = new Point(250, 175);
            button28.ForeColor = Color.Red;

            label1.Text = "Edit";
            label1.Size = new Size(25,13);
            label1.Location = new Point(9,9);
            label1.ForeColor = Color.Black;

            label2.Text = "View";
            label2.Size = new Size(25, 13);
            label2.Location = new Point(46, 9);
            label2.ForeColor = Color.Black;

            label3.Text = "Help";
            label3.Size = new Size(29, 13);
            label3.Location = new Point(88, 10);
            label3.ForeColor = Color.Black;

            textBox1.Size = new Size(280, 20);
            textBox1.Location = new Point(2,26);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

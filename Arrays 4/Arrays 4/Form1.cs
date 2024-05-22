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
 * Sean Berlin             Per.2            11-21-19
 * Create a windows application that will take a word entered in a textbox and have it
 *  displayed in a label reversed. The program should include function that YOU created called
 *   makeReverse(). 
 * makeReverse() will return the reverse of its single string argument.
 *  For example, if the argument is "I love CS2" it should return "2SC evol I".
Extra challange: In some way indicate if the statement entered is a palindrome. A palindrome is a word, phrase, number, or other sequence of characters which reads the same backward as forward, such as madam or amanaplanpanama.
 * 
 * 
 * *****************************
 */
namespace Arrays_4
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = textBox1.Text;
            label1.Text = makeReverse(temp);
        }
        private string makeReverse(string word)
        {
            char[] cArray = word.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
            //string temp = "sean";
            //char[] reverse = word.ToCharArray();
            //Array.Reverse(reverse);
            //return temp;
            ////return new string(reverse);
        }
    }
}

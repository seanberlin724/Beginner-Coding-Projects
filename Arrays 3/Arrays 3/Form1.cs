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
 * Sean Berlin             Per.2             9-9-19
 * 
 * Create a windows application that will take a string entered in a textbox and
 *  have it displayed in a label all uppercase. This program should include a function that
 *   YOU CREATE called makeUppercase() not the one that MicroSoft has created. makeUppercase()
 *    should have a string argument and return a string all in uppercase letters. 
 *    Hint: You may need to use .ToCharArray() and the number 32 with a char cast. EXTRA CHALLENGE:
 *  Make another function called LowerCase().
 * 
 * 
 * *****************************
 */
namespace Arrays_3
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

        private void textBox1_TextChanged(object sender, EventArgs e)//collects inputed word
        {
            // char word = Convert.ToChar(Console.ReadLine());
            //string[] word = new string[1];
            //char [] 

            //string word = Convert.ToChar(Console.ReadLine());
            //char[]  = ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = textBox1.Text;
            label3.Text = makeUpper(temp);

            

        }


        private string makeUpper(string word)   // "Monkey"
        {
            string temp = "";
            char[] letters = word.ToCharArray();    //  {'M','o','n','k','e','y'}
            for (int i = 0; i < letters.Length; i++)
            {
                if ((int)letters[i] >= 97 && (int) letters [i] <= 122)//between 97 and 122
                {
                    temp += (char)((int)letters[i] - 32);
                }
                else
                {
                    temp += (char)((int) letters [i]);
                }
                //temp += (char)((int)letters[i] - 32);
            }
            return temp;
        }
        private string makeLower(string otherWord)
        {
            string lower = "";
            char[] otherLetters = otherWord.ToCharArray();
            for (int i = 0; i < otherLetters.Length; i++)
            {
                if ((int)otherLetters[i] >= 65 && (int)otherLetters[i] <= 90)//between 97 and 122
                {
                    lower += (char)((int)otherLetters[i] + 32);
                }
                else
                {
                    lower += (char)((int)otherLetters[i]);
                }
            }
            return lower;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string lower = textBox2.Text;
            label4.Text = makeLower(lower);
        }
    }
}

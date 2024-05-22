using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
/******************Block Comment***********************
 * Sean Berlin             Per.2             9-9-19
 * This is a 
 * Write a function that will load an integer array with random numbers from 1 to 10. 
 * Create a form that has a button that when clicked will show 10 consecutive message boxes 
 * displaying the content of each index (in order) of the array. In other words have the numbers 
 * 1 to 10 appear one at a time in message boxes.
    Recall: MessageBox.Show(put string here)
 * 
 * 
 * 
 * 
 * *****************************
 */
namespace Arrays1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Random rnd1 = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            //int[] randomNumbers = new int[10];//0-9
            //Random myRandy = new Random();
            //for (int i = 0; i < randomNumbers.Length; i++)
            //{
            //    randomNumbers[i] = myRandy.Next(1, 11);
            //}
            
        }
        private int[] loadArray(int x)//will load up an integer array of random numbers form 1-10
        {
            Random randy = new Random();
            int[] temp = new int[x];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = randy.Next(1, 11); //doesnt include last number
            }
            return temp;
        }
        //public static int[] fillIntArray(int amt) //return entire collection of ints
        //{
        //    Random myRandy = new Random();
        //    int[] temp = new int[amt];
        //    for (int i = 0; i < temp.Length; i++)
        //    {
        //        temp[i] = myRandy.Next(1, 100);
        //    }
        //    return temp;


        //}

        private void button1_Click(object sender, EventArgs e)
        {
            int[] x = loadArray(10);
            for (int i = 0; i < x.Length; i++)
            {
                MessageBox.Show(x[i].ToString()); //message box needs to display string
            }
            
        }
    }
}

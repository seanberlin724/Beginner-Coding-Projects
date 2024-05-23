using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Towers_of_Hanoi
{
    class Peg
    {
        //instance variables
        private int height, xPos, yPos;
        private int[] rings;


        //constructor
        public Peg(int height, int xPos, int yPos)
        {
            this.height = height;
            this.xPos = xPos;
            this.yPos = yPos;
            rings = new int[0];
        }


        //draws peg and correct number of rings at proper location
        public void draw()
        {
            //Console.WriteLine("-----------");
            string bottomOfPeg = "-------------";
            Console.SetCursorPosition(xPos, yPos); //over x and down y
            Console.WriteLine(bottomOfPeg);

            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(xPos + bottomOfPeg.Length / 2, yPos - 1 - i);
                Console.Write("|");
            }

            //prints rings
            for (int z = 0; z < rings.Length; z++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(xPos + bottomOfPeg.Length / 2 + 1, yPos - 1 - z);
                Console.Write(makeStars(rings[z]));
                //prints on right side of peg
                ////int lengthOfRing = rings[z];
                ////makeStars(lengthOfRing);
                //lengthOfRing--;
                // Console.Write(rings[z]);


                //prints on left side of peg
                Console.SetCursorPosition(xPos - 1 - rings[z] + bottomOfPeg.Length / 2 + 1, yPos - 1 - z);
                Console.Write(makeStars(rings[z]));
                //makeStars(lengthOfRing);


                //determine size of top ring
                int sizeOfTopRing = determineSizeOfTopRing();
                Console.ForegroundColor = ConsoleColor.White;
            }

        }

        //add ring(adds value to rings array)
        public void addRing(int ringSize)
        {
            Array.Resize<int>(ref rings, rings.Length + 1); //adds 1 to the number of elements in rings array

            rings[rings.Length - 1] = ringSize;
        }

        //remove ring(remove value off of a peg)
        public int removeRing()
        {
            int temp = 999;
            if (rings.Length >= 1)
            {
                temp = rings[rings.Length - 1];
                Array.Resize<int>(ref rings, rings.Length - 1);
                return temp;
            }
            return temp;

            //needs to be edited later
        }

        public string makeStars(int size) //prints on one of the peg(only doing half)
        {
            //Console.ForegroundColor = ConsoleColor.Green;
            string temp = "";
            for (int i = 0; i < size; i++)
            {

                temp += "*";
            }
            return temp;
        }

        public int determineSizeOfTopRing()
        {
            if (rings.Length > 0)
            {
                return rings[rings.Length - 1];
            }
            else
            {
                return 999;
            }

            //Don't think I need all that
            //int size = 0;
            //if (rings[rings.Length] ==3)
            //{
            //    size = 1;
            //}
            //else if (rings[rings.Length] < 3)
            //{

            //}
            //else if (rings[rings.Length] < 2)
            //{

            //}
            ////rings[rings.Length];
            //return size;
        }
        public int getNumberOfRings()
        {
            return rings.Length;
        }
    }
}

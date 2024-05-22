using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Die_Class
{
    //instance variables
    class Die
    {
        private int numberOfSides, currentSide;
        Random myRandy;
        //obstructor
        public Die(Random newRandy)
        {
            numberOfSides = 6;
            currentSide = 1;
            myRandy = newRandy;
        }

        public Die(int numberOfSides, Random newRandy)
        {
            this.numberOfSides = numberOfSides;
            currentSide = 1;
            myRandy = newRandy;
        }
        public int roll()
        {
            currentSide = myRandy.Next(1, numberOfSides + 1);
            return currentSide;
        }
        public int CurrentSide
        {
            get { return currentSide; }
        }
    }   
}

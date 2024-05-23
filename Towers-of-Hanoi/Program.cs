/******************Block Comment***********************
 * Sean Berlin
 * Program Description:
 * This program simulates the Towers of Hanoi game. The game consists of three pegs and a number of rings of different sizes
 * which can be stacked onto any peg. The objective of the game is to move the entire stack to another peg, obeying the following rules:
 * 1. Only one ring can be moved at a time.
 * 2. A ring can only be moved if it is the uppermost ring on one of the pegs.
 * 3. No ring may be placed on top of a smaller ring.
 * 
 * Implementation Details:
 * - The program initializes the game with a specified number of rings on the first peg.
 * - The user can then input moves to transfer the rings from one peg to another until all rings are moved to the third peg.
 * - Invalid moves are rejected, and the user is prompted to make a valid move.
 * - The program displays the game board after each move.
 * - The game ends when all rings are successfully transferred to the third peg.
 * - The program calculates and displays the number of moves made by the user.
 * 
 * Important Notes:
 * - The program includes methods for initializing the game, drawing the game board, and validating moves.
 * - Each peg is represented by an instance of the Peg class.
 * - Rings are added and removed from pegs using the addRing() and removeRing() methods of the Peg class.
 * - User input for moves is validated to ensure legality according to the rules of the game.
 * - The program tracks the number of moves made by the user and displays the final count at the end of the game.
 * 
 * 
 * *****************************
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Towers_of_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 80;
            Console.Title = "Towers of Hannoi";
            //Console.Write("How many rings 1 to 4: ");
            // int numberOfRings = Convert.ToInt32(Console.ReadLine());

            //create 3 peg objects
            Peg peg1 = new Peg(7, 10, 10);
            Peg peg2 = new Peg(7, 30, 10);
            Peg peg3 = new Peg(7, 50, 10);

            int numOfRings = 3;
            peg1.addRing(5);
            peg1.addRing(3);
            peg1.addRing(1);
            Console.Clear();
            drawBoard(peg1, peg2, peg3);
            //Console.ReadLine();
            int movesCount = 0;
            //int startingRings = peg1.determineSizeOfTopRing();
            double startingRings = peg1.getNumberOfRings();
            double leastPossibleMoves = Math.Pow(2, startingRings) - 1;
            int ringsOnThirdPeg = 1;

            //peg1.startingRingsCounter() != peg3.startingRingsCounter()
            //peg1.startingRingsCounter() != ringsOnThirdPeg
            //startingRings != peg3.determineSizeOfTopRing() + startingRings
            while (peg3.getNumberOfRings() != numOfRings)
            {
                movesCount++;
                int from = Question("from");
                int to = Question("to");
                if (from == 1 && peg1.determineSizeOfTopRing() < peg2.determineSizeOfTopRing() && to == 2)
                {
                    peg2.addRing(peg1.removeRing());
                    //drawBoard(peg1, peg2, peg3);
                }
                else if (from == 1 && peg1.determineSizeOfTopRing() < peg3.determineSizeOfTopRing() && to == 3)
                {
                    peg3.addRing(peg1.removeRing());
                    //drawBoard(peg1, peg2, peg3);
                }
                else if (from == 2 && peg2.determineSizeOfTopRing() < peg1.determineSizeOfTopRing() && to == 1)
                {
                    peg1.addRing(peg2.removeRing());
                    //drawBoard(peg1, peg2, peg3);
                }
                else if (from == 2 && peg2.determineSizeOfTopRing() < peg3.determineSizeOfTopRing() && to == 3)
                {
                    peg3.addRing(peg2.removeRing());
                    //drawBoard(peg1, peg2, peg3);
                }
                else if (from == 3 && peg3.determineSizeOfTopRing() < peg1.determineSizeOfTopRing() && to == 1)
                {
                    peg1.addRing(peg3.removeRing());
                    //drawBoard(peg1, peg2, peg3);
                }
                else if (from == 3 && peg3.determineSizeOfTopRing() < peg2.determineSizeOfTopRing() && to == 2)
                {
                    peg2.addRing(peg3.removeRing());
                    //drawBoard(peg1, peg2, peg3);
                }
                else
                {

                    Console.SetCursorPosition(15, 10);
                    Console.WriteLine("------Invalid Move hit any key to continue-----");
                    Console.ReadKey();
                }
                //ringsOnThirdPeg = peg3.determineSizeOfTopRing();
                drawBoard(peg1, peg2, peg3);

            }
            Console.SetCursorPosition(3, 20);
            Console.WriteLine("You WON!!! You completed Towers of Hannoi in " + movesCount + " moves.");
            Console.WriteLine("A perfect score is " + leastPossibleMoves + " moves");
            // Console.ReadKey();
            //// peg2.addRing(peg1.removeRing());
            // Console.Clear();
            // peg1.draw();
            // peg2.draw();
            // peg3.draw();

            //Game Logic
            //Set up board

            // Console.WriteLine("How many rings do you want to play with?3-6:");
            int numberOfRings = Convert.ToInt32(Console.ReadLine());
            int value = numberOfRings * 2 - 1;
            for (int i = 0; i < numberOfRings; i++)
            {
                peg1.addRing(value);
                value -= 2;
            }

            //Gameplay in a loop until user wins
            while (true)
            {
                Console.WriteLine("What peg do you want to go from?");
                int goFrom = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What peg do you want to go to?");
                int goTo = Convert.ToInt32(Console.ReadLine());
                if (true)
                {

                }

                Console.ReadLine();
            }
        }

        public static int Question(string word)
        {
            Console.SetCursorPosition(5, 12);
            Console.Write("Where do you want to move " + word + ":\t ");
            int temp = Convert.ToInt32(Console.ReadLine());
            return temp;
        }

        public static void drawBoard(Peg peg1, Peg peg2, Peg peg3)
        {
            Console.Clear();
            peg1.draw();
            peg2.draw();
            peg3.draw();
        }
        //Rules method to prevent a bigger ring from going on to a smaller ring
        //public static void legalMoveChecker(int from, int to, Peg peg1, Peg peg2, Peg peg3)
        //{
        //    if ()//if size of top ring from "from" is less than size of top ring to "to" then DO the move
        //    {

        //        Console.WriteLine("Your move was legal");
        //    }
        //    else if (true)//if size of top ring from "from" is greater than size of top ring to "to" then DO NOT do the move
        //    {

        //        Console.WriteLine("Your move was illegal. A bigger ring cannot be placed on smaller ring");
        //    }

        //}
    }
}

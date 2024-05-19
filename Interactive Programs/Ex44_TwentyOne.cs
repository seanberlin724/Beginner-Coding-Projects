/******************Block Comment***********************
 * Sean Berlin
 * Create an application(form or console) called EX44_TwentyOne. 
 *  Write code to simulate a simplified version of the game "21." 
 *   A deck of cards numbered 1 to 10 is used and any number can be repeated. 
 *  The computer starts by asking you (the user) how many cards you want. 
 *  It then deals you the cards,  which are randomly picked,
 *  and deals itself three randomly picked cards.  
 *  If both scores are over 21, or if both are equal but under 21,
 *   the game is declared a draw.  
 *   Otherwise, the winner is the one with the highest score equal to or less than 21.
 *  If one score is over 21,  but the other is 21 or less,
 *  the player with 21 or less is declared the winner.
 *  Write the program so that the game can be played as often
 *   as desired with the winner of the game winning one point.
 *  At the end of the games display the total winning
 *   for you and the computer and the number of draws.   
 *   The program output for console app should look similar to:

		How many cards do you want?    3
			You:  8  5  1
			Computer:  8  3  3
			I have 14 and you have 14 so we draw.
			Would you like to play again? ( Y/N )?  

		How many cards do you want?  2
			You:  7  2
			Computer:  8  7  4
			I have 19 and you have 9 so I win.
			Would you like to play again?  ( Y/N )?  Y

How many cards do you want?  3
			You:  8  7  4
			Computer:  2  7  1
			I have 10 and you have 19 so you win.
			Would you like to play again?  ( Y/N )?  N

Overall Game Results			
Computer wins = 1
Your wins = 1
Draws = 1	

Extra: You may wish to add some type of coin system so you can make wagers.
 * *****************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX44_TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int wins = 0;
            int draws = 0;
            int losses = 0;
            string again = "";
            string numberOfCards = "";
            do
            {
                int card0 = cardFinder(); int card1 = cardFinder(); int card2 = cardFinder();
                int card3 = cardFinder(); int card4 = cardFinder(); int card5 = cardFinder();
                int card6 = cardFinder(); int card7 = cardFinder(); int card8 = cardFinder();
                // Console.WriteLine(" {0}\t{1}\t{2}", card0, card1, card2);
                Console.WriteLine("How many cards do you want");
                numberOfCards = Console.ReadLine();
                int ComputerTotal = ComputerTotalFinder(card0, card1, card2);
                int YouTotal2 = YouTotal2Finder(card4, card5);
                int YouTotal3 = YouTotal3Finder(card4, card5, card6);
                int YouTotal4 = YouTotal4Finder(card4, card5, card6, card7);
                if (numberOfCards == "2")
                {
                    Console.WriteLine("Computer: {0} {1} {2}", card0, card1, card2);
                    Console.WriteLine("You: {0} {1}", card4, card5);
                    Console.WriteLine("I have {0} and you have {1}", ComputerTotal, YouTotal2);
                    if (ComputerTotal < 21 && YouTotal2 < 21)
                    {
                        if (ComputerTotal == YouTotal2)
                        {
                            Console.WriteLine("It is a draw");
                            draws++;
                        }
                        if (ComputerTotal > YouTotal2)
                        {
                            Console.WriteLine("You lose");
                            losses++;
                        }
                        if (ComputerTotal < YouTotal2)
                        {
                            Console.WriteLine("You win");
                            wins++;
                        }

                    }
                    if (ComputerTotal > 21 && YouTotal2 < 21)
                    {
                        Console.WriteLine("The computer went over 21, so you win");
                        wins++;
                    }
                    if (ComputerTotal > 21 && YouTotal2 > 21)
                    {
                        Console.WriteLine("Both the computer and you went over 21, so it is a draw");
                        draws++;
                    }
                    if (ComputerTotal < 21 && YouTotal2 > 21)
                    {
                        Console.WriteLine("You went over 21, so you loose");
                        losses++;
                    }
                }
                if (numberOfCards == "3")
                {
                    Console.WriteLine("Computer: {0} {1} {2}", card0, card1, card2);
                    Console.WriteLine("You: {0} {1} {2}", card4, card5, card6);
                    Console.WriteLine("I have {0} and you have {1}", ComputerTotal, YouTotal3);
                    if (ComputerTotal < 21 && YouTotal3 < 21)
                    {
                        if (ComputerTotal == YouTotal3)
                        {
                            Console.WriteLine("It is a draw");
                            draws++;
                        }
                        if (ComputerTotal > YouTotal3)
                        {
                            Console.WriteLine("You lose");
                            losses++;
                        }
                        if (ComputerTotal < YouTotal3)
                        {
                            Console.WriteLine("You win");
                            wins++;
                        }
                    }
                    if (ComputerTotal > 21 && YouTotal3 < 21)
                    {
                        Console.WriteLine("The computer went over 21, so you win");
                        wins++;
                    }

                    if (ComputerTotal > 21 && YouTotal3 > 21)
                    {
                        Console.WriteLine("Both the computer and you went over 21, so it is a draw");
                        draws++;
                    }
                    if (ComputerTotal < 21 && YouTotal3 > 21)
                    {
                        Console.WriteLine("You went over 21, so you loose");
                        losses++;
                    }
                }
                if (numberOfCards == "4")
                {
                    Console.WriteLine("Computer: {0} {1} {2}", card0, card1, card2);
                    Console.WriteLine("You: {0} {1} {2} {3}", card4, card5, card6, card7);
                    Console.WriteLine("I have {0} and you have {1}", ComputerTotal, YouTotal4);
                    if (ComputerTotal < 21 && YouTotal4 < 21)
                    {
                        if (ComputerTotal == YouTotal4)
                        {
                            Console.WriteLine("It is a draw");
                            draws++;
                        }
                        if (ComputerTotal > YouTotal4)
                        {
                            Console.WriteLine("You lose");
                            losses++;
                        }
                        if (ComputerTotal < YouTotal4)
                        {
                            Console.WriteLine("You win");
                            wins++;
                        }
                    }
                    if (ComputerTotal > 21 && YouTotal4 < 21)
                    {
                        Console.WriteLine("The computer went over 21, so you win");
                        wins++;
                    }
                    if (ComputerTotal > 21 && YouTotal4 > 21)
                    {
                        Console.WriteLine("Both the computer and you went over 21, so it is a draw");
                        draws++;
                    }
                    if (ComputerTotal < 21 && YouTotal4 > 21)
                    {
                        Console.WriteLine("You went over 21, so you loose");
                        losses++;
                    }
                }
                Console.WriteLine("Do you want to play another round");
                again = Console.ReadLine();
            } while (again.ToLower() == "yes");
            Console.WriteLine(" You won {0} games, lost {1} games, and drawn {2} games", wins, losses, draws);
            Console.ReadLine();
        }
        public static Random rnd1 = new Random();
        public static int cardFinder()
        {
            int card1 = rnd1.Next(1, 11);
            return card1;
        }
        public static int ComputerTotalFinder(int card0, int card1, int card2)
        {
            return card0 + card1 + card2;
        }
        public static int YouTotal2Finder(int card4, int card5)
        {
            return card4 + card5;
        }
        public static int YouTotal3Finder(int card4, int card5, int card6)
        {
            return card4 + card5 + card6;
        }
        public static int YouTotal4Finder(int card4, int card5, int card6, int card7)
        {
            return card4 + card5 + card6 + card7;
        }
    }
}

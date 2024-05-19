/***************************************************
 * Sean Berlin
 * This is the demo for conditonal statements
 * L4_MakingDecisions.cs 
 ****************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_MakingDecisions
{
    class Program
    {
        static void Main(string[] args)
        {

            //        /*// If 

            //                  if(condition) the condition will be a true or false
            //                  {
            //                        do some stuff
            //                  }

            //*/
            //        Console.WriteLine("if statement example:");
            //        //                                  x=11;
            //        int x = 11;
            //        if (x == 10)
            //        //if (false)
            //        //if (true)
            //        {

            //            Console.WriteLine("The number is 10");

            //        }
            //        /*          Operator                    Meaning
            //         *          = =                         equal to its not!!! = because 11 does not equal 10
            //         *          <                           less than
            //         *          <=                          less than or equal to
            //         *          >                           greater than
            //         *          >=                          greater than or equal to
            //         *          !=                          not equal
            //         *                  Make sure you know the difference between
            //         *                  == and =
            //         */


            //        Console.Write("pleae enter a temperature:");
            //        double temp = Convert.ToDouble(Console.ReadLine());
            //        if (temp < 40)
            //        {
            //            Console.WriteLine("Wear a coat");
            //        }

            //        Console.WriteLine("Have a nice day");



            //        Console.ReadLine();
            //        Console.WriteLine(" *********if and else *********");
            //        /*
            //         *      if (condition)
            //         *      {
            //         *          do stuff
            //         *      }
            //         *      else
            //         *      {
            //         *          do this stuff
            //         *      }
            //         * 
            //         */

            //        Console.Write("please enter a temperature:");
            //        temp = Convert.ToDouble(Console.ReadLine());
            //        if (temp < 40)
            //        {

            //            Console.WriteLine("Wear a coat");
            //            //statements
            //        }
            //        else
            //        {

            //            Console.WriteLine("Dont wear a coat");



            //        }
            //        Console.WriteLine("and dont forget to have a nice day");
            //        Console.WriteLine("************else if******************");



            //        Console.ReadLine();

            //        Console.Write("please enter a temperature:");
            //        temp = Convert.ToDouble(Console.ReadLine());
            //        if (temp > 100)
            //        {
            //            Console.WriteLine("stay inside its too hot!!");
            //        }
            //        else if (temp > 30 && temp < 99)
            //        {
            //            Console.WriteLine("Go out and play");
            //        }
            //        else if (temp > 20 && temp <= 30)
            //        {
            //            Console.WriteLine("do something else");
            //        }
            //        else
            //        {

            //            Console.WriteLine("wear a coat");

            //        }


            //        Console.ReadLine();

            //        Console.ReadLine();
            //        Console.WriteLine("  nested ifs  ");
            //        int votes1 = 100;
            //        int votes2 = 200;

            //        if (votes1 != votes2)
            //        {
            //            if (votes1 > votes2) //remember to indent
            //            {
            //                Console.WriteLine("Candidate 1 wins");
            //            }
            //            else
            //            {
            //                Console.WriteLine("candidate 2 wins");

            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Its a tie");

            //        }
            ////        Console.ReadLine();
            //    }
            Console.WriteLine("what was the score of your test");
            double x = Convert.ToDouble(Console.ReadLine());
            if (x <= 100 & x >= 90)
            {
                Console.WriteLine("You got an A");
            }
            if (x < 90 & x >= 80)
            {

                Console.WriteLine("You got a B");
            }
            if (x < 80 & x >= 70)
            {
                Console.WriteLine("You got a C");
            }
            if (x < 70 & x >= 60)
            {
                Console.WriteLine("You got a D");
            }
            if (x < 60)
            {
                Console.WriteLine("You got a F");
            }
            Console.ReadLine();
            //We used the and statement above
            //recall its && for "AND"
            //THE "OR" operator is ||
            string name = Console.ReadLine();
            Console.Write("please enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (name == "sean" || name = "Berlin")
            {
                Console.WriteLine("You are Sean Berlin");
            }
            else if (name = "berlin" && age <100)
            {
                Console.WriteLine("Your age is under 100 and you are Sean Berlin");
            }
            if (name == "Joe" || (age < 100 && age > 50))
            {
                Console.WriteLine("something else");
            }
        }
    }
}

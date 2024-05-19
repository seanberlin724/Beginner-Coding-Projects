/******************Block Comment***********************
 * Sean Berlin                          9-12-18
 * (2 Days)Create a program called EX26_Discriminant. 
 * Remember your comments and use appropriate variable names and methods where appropriate. 
 * In mathematics, the quantity b^2 - 4 a c is called the "discriminant", where f(x)=Ax^2+Bx +C. 
 * Visit the links below if you are unfamiliar with the discriminant. 
 * Your task is to write a program that asks the user for values of A, B and C, and displays
 * No real roots if the discriminant is negative, 
 * One Root if the discriminant is zero, and Two Roots if the discriminant is positive. 
 * (If you are having trouble with the algebra concepts of the discriminant please ask.)
 * Example of what your output should look like:
 * f(x) = Ax^2 + Bx + C
 * To calculate the discriminant please enter the
 * A value:2
 * B value:-3
 * C value:4
 * The Discriminant is -23 that number is negative therefore the polynomial f(x) = 2x^2-3x+4 has No Real Roots.
 * *****************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex26_Discriminant
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro("Discriminant Evaluater", "This program will calculate the discriminat \nand determine the roots of a quadratic function", ConsoleColor.Green, 70);
            Console.WriteLine("f(x) = Ax^2 + Bx + c");
            int AValue = ACollector();
            int BValue = BCollector();
            int CValue = CCollector();
            int Discriminate = CalculateDiscriminate(AValue, BValue,CValue);
            if (Discriminate < 0)
            {
                //Console.WriteLine("There are no real roots");
                Console.WriteLine("The discrimant is {0} that number is less than zero \ntherefore the polynomial f(x) = {1}x^2-{2}x+{3} has no real roots", Discriminate, AValue, BValue, CValue);
                Console.ReadLine();
            }
            if (Discriminate == 0)
            {
                Console.WriteLine("The discrimant is {0} that number is zero \ntherefore the polynomial f(x) = {1}x^2-{2}x+{3} has only real one root",Discriminate,AValue,BValue,CValue);
                Console.ReadLine();
            }
            if (Discriminate > 0)
            {
                //Console.WriteLine("There are two real roots");
                Console.WriteLine("The discrimant is {0} that number is greater than zero \ntherefore the polynomial f(x) = {1}x^2-{2}x+{3} has two real roots", Discriminate, AValue, BValue, CValue);
                Console.ReadLine();
            }
            Console.WriteLine("The discriminant is {0}",Discriminate);
            ending();
        }
        public static void Intro(string title, string discription, ConsoleColor myColor, int myWidth)
        {
            Console.Title = title;
            Console.BackgroundColor = myColor;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WindowWidth = myWidth;
            Console.WindowHeight = 15;
            Console.Clear();
            Console.WriteLine("This is the Greatest Into ever!!");
            Console.WriteLine(discription);
        }
        public static int ACollector()
        {
            Console.Write("To calculate the discriminant please enter the \nA Value:");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
        public static int BCollector()
        {
            Console.Write("B Value:");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
        public static int CCollector()
        {
            Console.Write("C Value:");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
        public static int CalculateDiscriminate(int AValue, int BValue, int CValue)
        {
            return (BValue * BValue) - (4 * (AValue * CValue));
        }
        public static void ending()
        {
            Console.SetCursorPosition(15, 10);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("<---- Hit Enter to Quit! ---->");
            Console.ReadLine();
        }
    }
}

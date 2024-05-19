/******************Block Comment***********************
* Sean Berlin
* Create a Console Application OR Windows Application called Ex37_PrimeNumber.
* I recommend creating a isItPrime(int n) method that takes an
* integer argument and returns a bool. 
* The user should be able to test several integers. Write code that asks the 
* user for a non-negative integer and then displays a message indicating 
* if it is prime or not.  A prime number
* is an integer that has no factors other than one and itself. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex37_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            bool prime = true;//it is prime
            string tester = "no";
            do
            {
                Console.WriteLine("Enter a number to see if it is prime");
                int n = Convert.ToInt32(Console.ReadLine());
                if (prime == false)
                {
                    Console.WriteLine(n + "" + "is not a prime number");
                }
                if (prime == true)
                {
                    Console.WriteLine(n + "" + "is a prime number");
                }
                Console.WriteLine("Do you want to find another prime number?");
                tester = Console.ReadLine();
            } while (tester.ToLower() == "yes");
            Console.WriteLine("Have a nice day");
            Console.ReadLine();
        }
        private static bool isPrime(int n)
        {
            if (n == 2)
            { 
                return true;     
            }
            if (n % 2 == 0) //if it is even then it is NOT prime
            {
                return false;
            }
            for (int i = 3; i * i <= n; i += 2) //i*i checks only the square root of the number. i += 2 makes it odd. ultimately checks if the square of any odd number is divisible by any odd number. if not divisible then it is prime. Example is 21. 21 is divisble by 7 therefore it is NOT prime. 
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }        
    }
}


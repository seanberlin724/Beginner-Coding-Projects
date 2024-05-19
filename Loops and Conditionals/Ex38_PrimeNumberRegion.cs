/******************Block Comment***********************
 * Sean Berlin
 * Create an application called looping  Ex38_PrimeRegion. 
 * Reuse the method isItPrime(int n) from Ex37_PrimeNumber to help display the number 
 * of primes found between two numbers entered by the user.
 * *****************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex38_PrimeNumberRegion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter starting number:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ending number:");
            int o = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = n; n <= o; i++)
            {
                if (isPrime(n) ==true)
                {

                    count++;
                }
                n++;
            }
            Console.WriteLine("The number of prime numbers is " +count);
            Console.ReadLine();
        }
        private static bool isPrime(int n)
        {  
            if (n == 2)
            {
                return true;
            }
            if (n % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i * i <= n; i += 2)
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

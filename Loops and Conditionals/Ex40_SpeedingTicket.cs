/******************Block Comment***********************
 * Sean Berlin
 * Create an application called Ex39_SpeedingTicket: 
 * Your program should implement several methods to help produce the proper 
 * fine for a speeding ticket. As always use proper variable names and comment your code. 
 * You may make your program a form or a console application.
 * *****************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex39_SpeedingTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            int speedLimit = speedLimitCollector();
            int ticketedSpeed = ticketedSpeedCollector();
            int overSpeedLimit = overSpeedLimitCalculator(speedLimit, ticketedSpeed);
            int classification = classificationCollector();
            int initialFee = 75;
            int overSpeedLimitFine = overSpeedLimitFineCalculator(overSpeedLimit);              //after the difference of speeds is divided by 5
            double speedFeed = speedFeedCalculator(overSpeedLimitFine, initialFee);
            double fine = 0;
            double extraFreshmen = freshmenFines(overSpeedLimit);
            double extraSophmore = sophmoreFines(overSpeedLimit);
            double extraJunior = juniorFines(overSpeedLimit);
            double extraSenior = seniorFines(overSpeedLimit);
            if (classification == 1)
            {
                fine = speedFeed + extraFreshmen;
            }
            if (classification == 2)
            {
                fine = speedFeed + extraSophmore;
            }
            if (classification == 3)
            {
                fine = speedFeed + extraJunior;
            }
            if (classification == 4)
            {
                fine = speedFeed + extraSenior;
            }
            Console.WriteLine("Your total fine will be {0:c}", fine);
            Console.ReadLine();
        }
        public static int speedLimitCollector()
        {
            Console.WriteLine("Enter speed limit:");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
        public static int ticketedSpeedCollector()
        {
            Console.WriteLine("Enter ticketed speed");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
        public static int overSpeedLimitCalculator(int speedLimit, int ticketedSpeed)
        {
            return ticketedSpeed - speedLimit;
        }
        public static int classificationCollector()
        {
            Console.WriteLine("Enter classification: \nFreshmen (enter 1) \nSophmore (enter 2) \nJunior (enter 3) \nSenior (enter 4)");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
        public static int overSpeedLimitFineCalculator(int overSpeedLimit)
        {
            return overSpeedLimit / 5;
        }
        public static double speedFeedCalculator(int overSpeedLimitFine, int initialFee)
        {
            return (87.5 * overSpeedLimitFine) + initialFee;
        }
        public static double seniorFines(double overSpeedLimit)
        {
            double extraSenior;
            if (overSpeedLimit < 20)
            {
                extraSenior = 50;
            }
            else
            {
                extraSenior = 200;
            }
            return extraSenior;
        }
        public static double juniorFines(double overSpeedLimit)
        {
            double extraJunior;
            if (overSpeedLimit >= 20)
            {
                extraJunior = 100;
            }
            else
            {
                extraJunior = 0;
            }
            return extraJunior;
        }
        public static double sophmoreFines(double overSpeedLimit)
        {
            double extraSophmore;
            if (overSpeedLimit < 20)
            {
                extraSophmore = -50;
            }
            else
            {
                extraSophmore = 100;
            }
            return extraSophmore;
        }
        public static double freshmenFines(double overSpeedLimit)
        {
            double extraFreshmen;
            if (overSpeedLimit < 20)
            {
                extraFreshmen = -50;
            }
            else
            {
                extraFreshmen = 100;
            }
            return extraFreshmen;
        }
    }
}

/******************Block Comment***********************
 * Sean Berlin
 * Chapter 3 Notes  10.5.18
 *      
 * Goals
 * Declare memory locations for data
 * Use predefined data types
 * Use integral data types
 * Use floating-point types
 * Learn about the decimal data type
 * Declare Boolean variables
 * Declare and manipulate strings
 * Work with constants 
 * Write assignment statements using arithmetic operators
 * Learn about the order of operations
 * Learn special formatting rules for currency
 * Work through a programming example that illustrates the chapter’s concepts
 * *****************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace L2_VariablesAndOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            // Identifiers - used to name memory locations, methods and classes
            //      Rules
            //          Combination of alphabetic characters (a-z and A-Z), numeric digits (0-9), and the underscore 
            //          First character in the name may not be numeric
            //          No embedded spaces – concatenate(append) words together
            //          Keywords cannot be used
            //          Use the case of the character to your advantage
            //          Be descriptive with meaningful names
            // 
            //          PascalCase
            //          thisIsAnExampleOfCamelCase
            //   


            //          Syntax for variables
            //          All variables must be declared before using them
            //          Declaring the variable and Initializing 
            //          Data Types
            //          byte,sbyte,short,ushort,int,uint,long,ulong,
            //          decimal,double,float,
            //          char,
            //          string
            //          bool    true or false

            int myFirstInt; // declare the variable myFirstInt
            myFirstInt = 144;  // initializing myFirstInt to 144
            int mySecondInt = 4;
            int sum = myFirstInt + mySecondInt; // sum = 148

            int temp1 = 1000000;
            long myLong = 100000000; //myLong holds more

            //  type identifier;

            // declaring and initializing
            // type identifier = expression;
            // int & long (numbers without decimals)
            int shoeSize, theAge, theWeight;
            theAge = 33;
            theWeight = 165;

            // char (one single character  'in single quotes')
            char myChar = '☺';
            char myLetterGrade = 'A';

            //  string (one or more characters together "in quotes")
            string myFirstName = "Apple";
            string myAddress = "123 School Lane\nNewtown Pa 18940"; // use same escape keys as before

            Console.WriteLine("My first name is " + myFirstName + ".");
            Console.WriteLine("My adress is  " + myAddress);
            Console.WriteLine("Nice job" + myFirstName +
                "i see that you have" +
                myLetterGrade +
                " and that your shoe size is" + ".");
  
            Console.Clear();

            Console.WriteLine("What is your name? ");
            string FName = Console.ReadLine();
            Console.Title = FName;
            Console.WriteLine("Nice to meet you" + FName + ".");
            Console.ReadLine();

            // Console.Write("What is your first name?");
            // string FName = Console.ReadLine();
            //Console.WriteLine("Hello " + FName + " how are you today?");

            //  decimal & double (numbers with decimals)
            double myDouble = 123.343; //decimal used for money
            decimal myDeci = 123.456m; //put suffix at end with decimal
            float myFloat = 345.3465f; //use f for float

            double myAvergae = (myDouble + myDouble + myFloat) /3;
            Console.WriteLine("The ave is " + myAvergae);
            // int Pen = 237; make new int called dol - int dol = Pen/100; answer is 2 since integer divided by integer is integer
            // int Q = Pen%100/25; answer is 1
            // int d = Pen%100 %25/10


            ///  Arithmetic Operations
            ///  +, - , *, / , % Mod Mod will give the remainder
            ///  (PEMDAS)

            int pen = 578;
            int Q = pen % 100 / 25; //1q
            Console.WriteLine(Q + "quarter in" + pen + " pennies");

            int z = 10;
            z = z + 1; // z has 11 in it after this line
            //z is 11
            z++;
            // z is 12
            z *= 10;
            // z is 120
            z /= 2; // z is 60
            z %= 3; //answer is 0
            // z = z + 1;
            // Incrementing and Decrementing Operations
            //  z++   z= z+1 (this is a shortcut)
            //  z--   z=z-1
            //  z+=5  z = z+5
            // z = z + 5       z += 5

            // z++;   // add 1 after its used
            // ++z;       // add 1 before its used
            /////////////////  This can be a bit tricky !!!!  ///////
            //                 10 + 12
            // z = 12 this prints 22
            //                12  - 10
            // z = 10 this prints 2
            z = 10;
            Console.WriteLine(--z + ++z - --z); //should be 10

            //////////////  CW formating

            //  formatting to 2 decimal places
            double d1 = 123.34534545;
            double d2 = 747.23452;
            Console.WriteLine("The first number is {0:f2} and the second number is {1:f3}",d1,d2);

            //  formatting with money
            Console.WriteLine("The first number is {0:c2} and the second number is {1:c3}", d1, d2);

            //  formatting with %
            Console.WriteLine("The first number is {0:p2} and the second number is {1:p3}", d1, d2);

            //  formatting with strings
            //  example fill in the variables
            string direction = "left";
            string topic2 = "Johnny";
            string fName = "Johnny";
            string verb = "run";
            string topic1 = "CS";
            Console.WriteLine("\n\n\n");
            Console.WriteLine("");
            Console.ReadLine();             
        }
    }
}



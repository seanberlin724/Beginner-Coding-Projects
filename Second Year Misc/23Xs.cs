/******************Block Comment***********************
 * Sean Berlin
 * Program Description: Write a program to print the numbers
 *  1 to 23 in an X shape on the printer as shown below so the two rows
 *   intersect at "12." 
 *   Required statements: output, loop control 
 * 
 *      1                       23
 *      2                     22 
 *       3                   21  
 *        4                 20   
 *         5               19    
 *          6             18     
 *           7           17      
 *            8         16       
 *             9       15        
 *              10    14         
 *               11  13          
 *                12             
 *               11  13          
 *              10    14         
 *             9       15        
 *            8         16       
 *           7           17      
 *          6             18     
 *         5               19    
 *        4                 20   
 *       3                   21  
 *      2                     22 
 *     1                       23
 * 
 * *****************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23Xs__Problem_168h_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLeft = 1;
            int rowLeft = 1;

            int numRight = 23;
            int rowRight = 1;

            // Printing the left side of the X shape
            do
            {
                Console.SetCursorPosition(rowLeft - 1, rowLeft - 1);  // Adjusting for 0-based index
                Console.Write(numLeft);
                numLeft++;
                rowLeft++;
            } while (numLeft <= 12);

            // Printing the right side of the X shape
            do
            {
                Console.SetCursorPosition(23 - rowRight, rowRight - 1);  // Adjusting for 0-based index
                Console.Write(numRight);
                numRight--;
                rowRight++;
            } while (numRight >= 12);

            // Printing the middle intersection (12)
            Console.SetCursorPosition(11, 11);  // The intersection at (12, 12) in 0-based index
            Console.Write(12);

            Console.ReadLine();
        }
    }
}

/******************Block Comment***********************
 * Sean Berlin
 * Create a class representing a student. The Student() class will include
 *  at least these 11 characteristics: first and last name, student ID,
 *   overall GPA, gender, year classification as a string(freshman, sophomore, junior, senior),
 *    Math grade, Science grade, English grade, History grade, and major.
 *     Write at least two constructors create at least one class method that calculates the GPA.
 *      Include properties for each of the data items(instance variables). 
 *      Provide a method in the student class to compute and return the overall GPA.
 *       Scores should have no digits to the right of the decimal. 
 *       Have your main program/client instantiate the student object with
 *        information provided by the user. Do not allow the ID to be changed
 *         after the object has been constructed. Override the toString method
 *          of the Student class to display the student
 *  object in a pleasing manner that includes subject scores and GPA.
 * *****************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Student_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = getName();
            int studentId = getStudentId();
            string gender = getGender();
            string yearClassification = getYearClassification();
            double mathGrade = getMathGrade();
            double scienceGrade = getScienceGrade();
            double englishGrade = getEnglishGrade();
            double historyGrade = getHistoryGrade();
            double majorGrade = getMajorGrade();   
            //studenttt ne = new st
            Console.ReadLine();
        }
        public static string getName()
        {
            Console.WriteLine("First and last naem: ");
            string name = Convert.ToString(Console.ReadLine());
            return name;
        }
        public static string getGender()
        {
            Console.WriteLine("Gender: ");
            string gender = Convert.ToString(Console.ReadLine());
            return gender;
        }
        public static int getStudentId()
        {
            Console.WriteLine("Student Id: ");
            int studentId = Convert.ToInt32(Console.ReadLine());
            return studentId;
        }
        public static string getYearClassification()
        {
            Console.WriteLine("Year classification: ");
            string yearClassification = Convert.ToString(Console.ReadLine());
            return yearClassification;
        }
        public static double getMathGrade()
        {
            Console.WriteLine("Math Grade: ");
            double mathGrade = Convert.ToDouble(Console.ReadLine());
            return mathGrade;
        }
        public static double getScienceGrade()
        {
            Console.WriteLine("Science Grade: ");
            double scienceGrade = Convert.ToDouble(Console.ReadLine());
            return scienceGrade;
        }
        public static double getEnglishGrade()
        {
            Console.WriteLine("English Grade: ");
            double englishGrade = Convert.ToDouble(Console.ReadLine());
            return englishGrade;
        }
        public static double getHistoryGrade()
        {
            Console.WriteLine("History Grade: ");
            double historyGrade = Convert.ToDouble(Console.ReadLine());
            return historyGrade;
        }
        public static double getMajorGrade()
        {
            Console.WriteLine("Major Grade: ");
            double majorGrade = Convert.ToDouble(Console.ReadLine());
            return majorGrade;
        }
    }
}

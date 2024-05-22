using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Class_try_2
{
    class Student
    {
        //instance variables
        private string name;
        private int studentID;
        private double overallGPA; //calculate
        private string gender;
        private string yearClassification;
        private double mathGrade;
        private double scienceGrade;
        private double englishGrade;
        private double historyGrade;
        //private string major;
        private double majorGrade;

        //default constructor
        public Student()
        {
            name = "Sean Berlin";
            studentID = 472179;
            overallGPA = 4;
            gender = "male";
            yearClassification = "senior";
            mathGrade = 90;
            scienceGrade = 80;
            englishGrade = 70;
            historyGrade = 60;
            majorGrade = 50;
        }

        public Student(string name, int studentID, string gender, string yearClassification, double mathGrade, double scienceGrade, double englishGrade, double historyGrade, double majorGrade)
        {
            this.name = name;
            this.studentID = studentID;
            this.gender = gender;
            this.yearClassification = yearClassification;
            this.mathGrade = mathGrade;
            this.scienceGrade = scienceGrade;
            this.englishGrade = englishGrade;
            this.historyGrade = historyGrade;
            this.majorGrade = majorGrade;
        }

        public void gpaCalculator(double mathGrade, double scienceGrade, double englishGrade, double historyGrade, double majorGrade, double overallGPA)
        {
            string mathLetterGrade;
            if (mathGrade < 60)
            {
                mathGrade = 0;
            }
            else if (mathGrade >= 60 && mathGrade <= 69)
            {
                mathGrade = 1;
            }
            else if (mathGrade >= 70 && mathGrade <= 79)
            {
                mathGrade = 2;
            }
            else if (mathGrade >= 80 && mathGrade <= 89)
            {
                mathGrade = 3;
            }
            else if (mathGrade >= 90)
            {
                mathGrade = 4;
            }

            string scienceLetterGrade;
            if (scienceGrade < 60)
            {
                scienceGrade = 0;
            }
            else if (scienceGrade >= 60 && scienceGrade <= 69)
            {
                scienceGrade = 1;
            }
            else if (scienceGrade >= 70 && scienceGrade <= 79)
            {
                scienceGrade = 2;
            }
            else if (scienceGrade >= 80 && scienceGrade <= 89)
            {
                scienceGrade = 3;
            }
            else if (scienceGrade >= 90)
            {
                scienceGrade = 4;
            }

            string enlgishLetterGrade;
            if (englishGrade < 60)
            {
                englishGrade = 0;
            }
            else if (englishGrade >= 60 && englishGrade <= 69)
            {
                englishGrade = 1;
            }
            else if (englishGrade >= 70 && englishGrade <= 79)
            {
                englishGrade = 2;
            }
            else if (englishGrade >= 80 && englishGrade <= 89)
            {
                englishGrade = 3;
            }
            else if (englishGrade >= 90)
            {
                englishGrade = 4;
            }

            string historyLetterGrade;
            if (historyGrade < 60)
            {
                historyGrade = 0;
            }
            else if (historyGrade >= 60 && historyGrade <= 69)
            {
                historyGrade = 1;
            }
            else if (historyGrade >= 70 && historyGrade <= 79)
            {
                historyGrade = 2;
            }
            else if (historyGrade >= 80 && historyGrade <= 89)
            {
                historyGrade = 3;
            }
            else if (historyGrade >= 90)
            {
                historyGrade = 4;
            }

            string majorLetterGrade;
            if (majorGrade < 60)
            {
                majorGrade = 0;
            }
            else if (majorGrade >= 60 && majorGrade <= 69)
            {
                majorGrade = 1;
            }
            else if (majorGrade >= 70 && majorGrade <= 79)
            {
                majorGrade = 2;
            }
            else if (majorGrade >= 80 && majorGrade <= 89)
            {
                majorGrade = 3;
            }
            else if (majorGrade >= 90)
            {
                majorGrade = 4;
            }
            overallGPA = (mathGrade + scienceGrade + englishGrade + historyGrade + majorGrade) / 5;
        }

        public override string ToString()
        {
            return "Name:\t" + name +
                    "\nStudentID:\t" + studentID.ToString() +
                    "\nGender:\t" + gender +
                    "\nYear Classification:\t" + yearClassification.ToString() +
                    "\nMath Grade:\t" + mathGrade.ToString() +
                    "\nScience Grade:\t" + scienceGrade.ToString() +
                    "\nEnglish Grade:\t" + englishGrade.ToString() +
                    "\nHistory Grade:\t" + historyGrade.ToString() +
                    "\nMajor Grade:\t" + majorGrade.ToString() +
                    "\nCalculated GPA: \t" + overallGPA.ToString();
        }
    }
}

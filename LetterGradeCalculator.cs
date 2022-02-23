*
 * Programmer: Maria Vasquez
 * Date: Winter 2022
 * Purpose: This program uses methods to calculate equations for average grade & letter equivalent
 */

using System;
using static System.Console;

namespace WeightedAverageCalc
{
    class WAC
    {
        static void Main(string[] args)
        {
            // constant weights are defined here
            const float ASSIGNMENTS_PERCENTAGE = 0.2f;
            const float MIDTERM_EXAM_PERCENTAGE = 0.3f;
            const float QUIZ_PERCENTAGE = 0.1f;
            const float FINAL_EXAM_PERCENTAGE = 0.3f;

            // variables for storing the grades of a student
            float assignments;
            float midtermExam;
            float quiz1;
            float quiz2;
            float finalExam;

            float weightedExams = 0;
            float totalWeightedAverage = 0;

            Title = "CSIS1175 - Assignment 3 - By Maria Vasquez";

            DisplayBanner("Total Weighted Average Calculator\n");

            // if () do lines 46 to 75
            // The user enters the grades, the program gets them and stores them in the corresponding variable
            assignments = GetUserInput("Assignments");
            midtermExam = GetUserInput("Midterm Exam");
            quiz1 = GetUserInput("Quiz1");
            quiz2 = GetUserInput("Quiz2");
            finalExam = GetUserInput("Final Exam");


            // Total Weighted Average is sum of products of grades and their weight
            totalWeightedAverage += WeightedGrade(assignments, ASSIGNMENTS_PERCENTAGE);
            totalWeightedAverage += WeightedGrade(midtermExam, MIDTERM_EXAM_PERCENTAGE);
            totalWeightedAverage += WeightedGrade((quiz1 + quiz2), QUIZ_PERCENTAGE);
            totalWeightedAverage += WeightedGrade(finalExam, FINAL_EXAM_PERCENTAGE);

            DisplayTableRow("Assessment", "Percentage", "Your Grade");
            DisplayTableRow("--------------", " -----------", "----------");

            DisplayTableRow("Assignments", ASSIGNMENTS_PERCENTAGE, assignments);
            DisplayTableRow("MidTerm Exam", MIDTERM_EXAM_PERCENTAGE, midtermExam);
            DisplayTableRow("Quiz1", QUIZ_PERCENTAGE, quiz1);
            DisplayTableRow("Quiz2", QUIZ_PERCENTAGE, quiz2);
            DisplayTableRow("Final Exam", FINAL_EXAM_PERCENTAGE, finalExam);

            WriteLine("----------------------------------------");

            // change the following line of code such that the Floor value of totalWeightedAverage is displayed on Console
            DisplayTableRow("Weighted Total", 1, (float)Math.Floor(totalWeightedAverage));

            WriteLine("\n");

            weightedExams += WeightedGrade(midtermExam, MIDTERM_EXAM_PERCENTAGE);
            weightedExams += WeightedGrade((quiz1 + quiz2), QUIZ_PERCENTAGE);
            weightedExams += WeightedGrade(finalExam, FINAL_EXAM_PERCENTAGE);
            weightedExams /= 0.8f;

            // change the following line of code such that the Ceiling value of weightedExams is displayed on Console
            WriteLine("The Weighted Average Total on Exams (Midterm, Quizzes, Final exam) is {0:F2}", Math.Ceiling(weightedExams));
            WriteLine("If WAT-on-Exams is less than 50, the student fails the course.");

            ReadKey();
        }

        //  your method definitions are written here (out of Main method). A method cannot be defined inside another method
        static void DisplayBanner(string banner)
        {
            WriteLine(banner);
        }

        static bool GetUserInput(string textMessage, byte min, byte max, out float userInputValue)
        {
            // 2 outputs: value user entered and bool true or false if value is valid

            bool validInput;
            string userInput;
            float userValue;


            Write($"Enter a value between {max} and {min}: ");
            userInput = ReadLine();
            float.TryParse(userInput, out userValue);

            if(userValue < min || userValue > max)
            {
                Write($"The number is NOT valid, please select a number between {min} and {max}"); //check for exact message
                userValue = 0;
                return !validInput; 
            }
            else if (userValue < min && userValue > max)
            {
                Write($"Check executable file for correct message here, value ... {min} and {max}");
                userValue = 0;
                return false;
            }
            else
            {
                userValue = userInputValue;
                return true;
            }
          

            /*string userInput;
            float studentGrade;

            WriteLine($"Enter grade for {gradeName}");
            userInput = ReadLine();
            studentGrade = float.Parse(userInput);
            return studentGrade;
            */
        }

        // new letter ABCD... method! 

        static void DisplayTableRow(string name, string percentage, string grade)
        {
            WriteLine("{0,14}{1,13:P0} {2,-15}", name, percentage, grade);
        }

        static void DisplayTableRow(string name, float percentage, float grade)
        {
            WriteLine("{0,14}{1,13:P0} {2,-15}", name, percentage, grade);
        }

        static float WeightedGrade(float grade, float weight)
        {
            float weightCalc = grade * weight;
            return weightCalc;
        }

    }

}

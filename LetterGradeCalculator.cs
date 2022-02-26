// Purpose: This program uses methods to calculate weigthed grade & letter equivalent
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


            Title = "CSIS1175 - Assignment 4 - By Maria Vasquez";

            DisplayBanner("\\****************************************\\\n" + "\\\t\t\t\t\t \\\n" + "\\  \"Total Weigthed Average Calculator\"   \\\n" + "\\\t\t\t\t\t \\\n" + "\\****************************************\\\n\n");

            // The user enters the grades, the program gets them and stores them in the corresponding variable, checks if numbers are valid

            if (GetUserInput("Assignments", 0, 100, out assignments) == true)
                if (GetUserInput("Midterm Exam", 0, 100, out midtermExam) == true)
                    if (GetUserInput("Quiz1", 0, 100, out quiz1) == true)
                        if (GetUserInput("Quiz2", 0, 100, out quiz2) == true)
                            if (GetUserInput("Final Exam", 0, 100, out finalExam) == true)
                            {
                                // Total Weighted Average is sum of products of grades and their weight
                                totalWeightedAverage += WeightedGrade(assignments, ASSIGNMENTS_PERCENTAGE);
                                totalWeightedAverage += WeightedGrade(midtermExam, MIDTERM_EXAM_PERCENTAGE);
                                totalWeightedAverage += WeightedGrade((quiz1 + quiz2), QUIZ_PERCENTAGE);
                                totalWeightedAverage += WeightedGrade(finalExam, FINAL_EXAM_PERCENTAGE);

                                DisplayTableRow("\n    Assessment", "Percentage",  "Your Grade");
                                DisplayTableRow("--------------", " -----------", "----------");

                                DisplayTableRow("Assignments", ASSIGNMENTS_PERCENTAGE, assignments, LetterGrade(assignments));
                                DisplayTableRow("MidTerm Exam", MIDTERM_EXAM_PERCENTAGE, midtermExam, LetterGrade(midtermExam));
                                DisplayTableRow("Quiz1", QUIZ_PERCENTAGE, quiz1, LetterGrade(quiz1));
                                DisplayTableRow("Quiz2", QUIZ_PERCENTAGE, quiz2, LetterGrade(quiz2));
                                DisplayTableRow("Final Exam", FINAL_EXAM_PERCENTAGE, finalExam, LetterGrade(finalExam));

                                WriteLine("---------------------------------------");

                                DisplayTableRow("Weighted Total", 1, (float)Math.Floor(totalWeightedAverage), LetterGrade(totalWeightedAverage));

                                WriteLine("\n");

                                weightedExams += WeightedGrade(midtermExam, MIDTERM_EXAM_PERCENTAGE);
                                weightedExams += WeightedGrade((quiz1 + quiz2), QUIZ_PERCENTAGE);
                                weightedExams += WeightedGrade(finalExam, FINAL_EXAM_PERCENTAGE);
                                weightedExams /= 0.8f;

                                WriteLine("The Weighted Average Total on Exams (Midterm, Quizzes, Final exam) is {0:F2}", Math.Ceiling(weightedExams) + $" ({LetterGrade(weightedExams)})");
                                if (weightedExams >= 50)
                                {
                                    WriteLine("The student PASSES the course");
                                }
                                else
                                {
                                    WriteLine("The student FAILS the course.");
                                }

                            }

            Write("\nPress a key to quit...");

            ReadKey();
        }

        // Display text
        static void DisplayBanner(string banner)
        {
            WriteLine(banner);
        }

        // Check if user input is a number & between min and max range
        static bool GetUserInput(string textMessage, byte min, byte max, out float userInputValue)
        {

            string userInput;
            float userValue;
            bool isNumber;


            Write($"Enter a value for {textMessage}: ");
            userInput = ReadLine();
            isNumber = float.TryParse(userInput, out userValue);

            if (!isNumber)
            {
                WriteLine($"The value of the {textMessage} must be a number");
                userInputValue = 0;
                return false;
            }
            else if (userValue < min || userValue > max)
            {
                WriteLine($"The value must be between {min} and {max}");
                userInputValue = 0;
                return false;
            }
            else
            {
                userInputValue = userValue;
                return true;
            }

        }

        // Convert number grade to letter equivalent
        static string LetterGrade(float gradeNumber)
        {
            
            string letterGrade;

            if (gradeNumber >= 95)
            {
                letterGrade = "A+";
            }
            else if (gradeNumber >= 90)
            {
                letterGrade = "A";
            }
            else if (gradeNumber >= 85)
            {
                letterGrade = "A-";
            }
            else if (gradeNumber >= 80)
            {
                letterGrade = "B+";
            }
            else if (gradeNumber >= 75)
            {
                letterGrade = "B";
            }
            else if (gradeNumber >= 70)
            {
                letterGrade = "B-";
            }
            else if (gradeNumber >= 65)
            {
                letterGrade = "C+";
            }
            else if (gradeNumber >= 60)
            {
                letterGrade = "C";
            }
            else if (gradeNumber >= 55)
            {
                letterGrade = "C-";
            }
            else if (gradeNumber >= 50)
            {
                letterGrade = "P";
            }
            else
            {
                letterGrade = "F";
            }
            return letterGrade; 
        }


        // Display 3-string titles
        static void DisplayTableRow(string name, string percentage, string grade)
        {
            WriteLine("{0,14} {1,12:P0}  {2,-14}", name, percentage, grade);
        }

        //Display rows of grades
        static void DisplayTableRow(string name, float percentage, float grade, string letterGrade)
        {
            WriteLine("{0,14}{1,13:P0} {2,6:F2}  {3,-1}", name, percentage, grade, letterGrade);
        }

        // Calculate weighted average grade
        static float WeightedGrade(float grade, float weight)
        {
            float weightCalc = grade * weight;
            return weightCalc;
        }

    }
}

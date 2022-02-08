// Purpose: Calculate the weigthed average and WAT-on-Exams, from a student's grades. Printing a nice chart with the grades, percentages and results.

using static System.Console;

namespace WeigthedAverage
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Constants
            const float ASSIGNMENTS_PERCENTAGE = 0.2f;
            const float MIDTERM_PERCENTAGE = 0.3f;
            const float QUIZZES_PERCENTAGE = 0.2f;
            const float FINAL_PERCENTAGE = 0.3f;

            // Variables 
            float totalWeigthedAverage;
            float weigthedExams;

            float assignments = 100f;
            float midterm = 55f;
            float quiz1 = 45.5f;
            float quiz2 = 100f;
            float final = 65.8f;
            

            // Equations
            totalWeigthedAverage = (assignments * ASSIGNMENTS_PERCENTAGE + midterm * MIDTERM_PERCENTAGE + ((quiz1 + quiz2) / 2) * QUIZZES_PERCENTAGE + final * FINAL_PERCENTAGE) /
                    (ASSIGNMENTS_PERCENTAGE + MIDTERM_PERCENTAGE + QUIZZES_PERCENTAGE + FINAL_PERCENTAGE);

            weigthedExams = (midterm * MIDTERM_PERCENTAGE + ((quiz1 + quiz2) / 2) * QUIZZES_PERCENTAGE + final * FINAL_PERCENTAGE) / (MIDTERM_PERCENTAGE + QUIZZES_PERCENTAGE + FINAL_PERCENTAGE);


            Write("\\****************************************\\\n");
            Write("\\\t\t\t\t\t \\\n");
            Write("\\  \"Total Weigthed Average Calculator\"   \\\n");
            Write("\\\t\t\t\t\t \\\n");
            Write("\\****************************************\\\n\n");

            WriteLine("{0,14} {1,13}  {2,-15}", "Assessment", "Percentage", "Your Grade");
            WriteLine("{0,14} {1,13}  {2,-15}", "--------------", "----------", "----------");
            WriteLine("{0,14} {1,13:P0}  {2,-15}", "Assignments", ASSIGNMENTS_PERCENTAGE, assignments);
            WriteLine("{0,14} {1,13:P0}  {2,-15}", "Midterm", MIDTERM_PERCENTAGE, midterm);
            WriteLine("{0,14} {1,13:P0}  {2,-15}", "Quiz 1", (QUIZZES_PERCENTAGE / 2), quiz1);
            WriteLine("{0,14} {1,13:P0}  {2,-15}", "Quiz 2", (QUIZZES_PERCENTAGE / 2), quiz2);
            WriteLine("{0,14} {1,13:P0}  {2,-15}", "Final Exam", FINAL_PERCENTAGE, final);
            WriteLine("{0,40}", "----------------------------------------");
            WriteLine("{0,14} {1,13:P0}  {2,-15}", "Weigthed Total", 1, string.Format("{0:F2}", totalWeigthedAverage));


            Write("\n\nThe Weigthed Average Total (Wat) on Exams (Midterms, Quizzes, Final Exam) is " + string.Format("{0:F2}", weigthedExams) + "\n");
            Write("If WAT-on-Exams is less than 50, the student fails the course.\n");

            ReadKey();
        }

    }

}

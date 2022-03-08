// Purpose: Print letters selected by user with "*" and " " from a list of allowed characters "EHLNTXZ"

using System;
using static System.Console;

namespace Assignment5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const string ALLOWED_CHARS = "EHLNTXZ";
            string inputString;
            int inputDimension;

            GetUserString(ALLOWED_CHARS, out inputString);
 
            inputDimension = GetUserInput("Enter an odd number greater than 2 for the dimension of the shape: ");
   
            //Go through all the characters of user input string
            for (int i = 0; i < inputString.Length; i++)
            {
                // Switch-Case that checks every character within the input and calls it to print
                switch (inputString[i])
                {
                    case 'X':
                        DrawX(inputDimension);    
                        break;
                    case 'E':
                        DrawE(inputDimension);
                        break;
                    case 'L':
                        DrawL(inputDimension);
                        break;
                    case 'N':
                        DrawN(inputDimension);
                        break;
                    case 'T':
                        DrawT(inputDimension);
                        break;
                    case 'Z':
                        DrawZ(inputDimension);
                        break;
                    case 'H':
                        DrawH(inputDimension);
                        break;
                    default:
                        break;
                }

            }

            Write("Press key to quit...");
            ReadKey();
        }

        static string GetUserString(string allowedChars, out string userString)
        {
            //do-while loop to validate the user input and the loop keeps repeating until all characters entered by the user are the letters (characters) in the accepted English letters
            string userWord;
            string invalidCharacters;

            do
            {
                invalidCharacters = "";
                Write("Enter a string, including only the following characters ( EHLNTXZ ) : ");
                userWord = ReadLine();
 
                for (int i = 0; i < userWord.Length; i++)
                    if (allowedChars.IndexOf(char.ToUpper(userWord[i])) == -1)
                    {
                        invalidCharacters += userWord[i];
                    }              
                if(invalidCharacters.Length > 0)
                {
                    WriteLine($"{invalidCharacters} is not accepted, only EHLNTXZ characters are accepted! Re-enter your characters: ");
                }

            } while (invalidCharacters.Length > 0);


            //the method returns the string that the user has entered
            userString = userWord.ToUpper();
            return userString;
        }
        
        // get the dimension of the block letter from the user. Must be odd number greater or = to 3
        static int GetUserInput(string sentence)
        {

            int userInput;

            do
            {
                Write(sentence);
                userInput = Convert.ToInt32(ReadLine());
                if (userInput < 3)
                {
                    WriteLine("Must be greater than 3!");
                }
                else if (userInput % 2 == 0)
                {
                    WriteLine($"{userInput} is not odd!");
                }

            } while (userInput < 3 || userInput % 2 == 0);

            return userInput;

        }
        
        // Print each of these leters X, E, L , N, T, Z, H
        private static void DrawX(int dimension)
        {
            WriteLine();
            for (int row = 1; row <= dimension; row++)
            {
                for (int col = 1; col <= dimension; col++)
                {
                    if (col == row || row + col - 1 == dimension)
                    {
                        Write("*");
                    }
                    else
                    {
                        Write(" ");
                    }
                }
                WriteLine();
            }
            WriteLine();
        }

        private static void DrawE(int dimension)
        {
            WriteLine();
            for (int row = 1; row <= dimension; row++)
            {
                for (int col = 1; col <= dimension; col++)
                {
                    if (col == 1 || row == 1 || row == dimension || row == Math.Ceiling((double)dimension / 2))
                    {
                        Write("*");
                    }
                    else
                    {
                        Write(" ");
                    }
                }
                WriteLine();
            }
            WriteLine();
        }

        private static void DrawL(int dimension)
        {
            WriteLine();
            for (int row = 1; row <= dimension; row++)
            {
                for (int col = 1; col <= dimension; col++)
                {
                    if (col == 1 || row == dimension)
                    {
                        Write("*");
                    }
                    else
                    {
                        Write(" ");
                    }
                }
                WriteLine();
            }
            WriteLine();
        }

        private static void DrawN(int dimension)
        {
            WriteLine();
            for (int row = 1; row <= dimension; row++)
            {
                for (int col = 1; col <= dimension; col++)
                {
                    if (col == 1 || col == dimension || col == row)
                    {
                        Write("*");
                    }
                    else
                    {
                        Write(" ");
                    }
                }
                WriteLine();
            }
            WriteLine();
        }

        private static void DrawT(int dimension)
        {
            WriteLine();
            for (int row = 1; row <= dimension; row++)
            {
                for (int col = 1; col <= dimension; col++)
                {
                    if (row == 1 || col == Math.Ceiling((double)dimension / 2))
                    {
                        Write("*");
                    }
                    else
                    {
                        Write(" ");
                    }
                }
                WriteLine();
            }
            WriteLine();
        }

        private static void DrawZ(int dimension)
        {
            WriteLine();
            for (int row = 1; row <= dimension; row++)
            {
                for (int col = 1; col <= dimension; col++)
                {
                    if (row == 1 || row == dimension || row + col - 1 == dimension)
                    {
                        Write("*");
                    }
                    else
                    {
                        Write(" ");
                    }
                }
                WriteLine();
            }
            WriteLine();
        }

        private static void DrawH(int dimension)
        {
            WriteLine();
            for (int row = 1; row <= dimension; row++)
            {
                for (int col = 1; col <= dimension; col++)
                {
                    if (col == 1 || col == dimension || row == Math.Ceiling((double)dimension / 2))
                    {
                        Write("*");
                    }
                    else
                    {
                        Write(" ");
                    }
                }
                WriteLine();
            }
            WriteLine();
        }

    }
}

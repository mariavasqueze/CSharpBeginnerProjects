// Program to give true or false questions to the user, and calculate how many they get right. 
// From codeacademy C# course

using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      string[] questions = {"Roses can only be red", "PI has 31.4 trillion decimals", "Lyon is France's capital city", "There are 3 primary colors: red, yellow, and blue"};

      bool[] answers = {false, true, false, true};
      bool[] responses = new bool[questions.Length];
      if(responses.Length != answers.Length)
      {
        Console.WriteLine("Be careful arrays are not the same length");
      }

      int askingIndex = 0;
      foreach(string question in questions)
      {
        string input; 
        bool isBool;
        bool inputBool;

        Console.WriteLine(question);
        Console.WriteLine("True or false? ");
        input = Console.ReadLine();
          //Convert user input to boolean value
        isBool = Boolean.TryParse(input, out inputBool);

        while(!isBool)
        {
            Console.WriteLine("Please respond with 'true' or 'false'.");
            input = Console.ReadLine();
            isBool = Boolean.TryParse(input, out inputBool);
        }

        responses[askingIndex] = inputBool;
        askingIndex++; 
      }

      //compare responses to answers array and count correct ones
      int scoringIndex = 0; //to loop through responses
      int score = 0; //to count correct ones

      foreach(bool answer in answers)
      {
        bool response = responses[scoringIndex];
        Console.Write(scoringIndex + 1 + ".");
        Console.WriteLine($"Input: {response} | Answer: {answer}");

        if (response == answer)
        {
          score++;
        }
        scoringIndex++;
      }

      Console.WriteLine($"You got {scoringIndex} out of 5 correct!");

    } 
  }
}



// Codeacademy exercise to create a password checker. It increases score if the password meets requirements (at least one lower and uppercase letters, special character, a number, and min 8 chars length. 

using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
        int minLength = 8;
        string uppercase = "ABCDEFGHIJKLMNOPQRSTUVXXYZ";
        string lowercase = "abcdefghijklmnopqrstuvwxyz";
        string digits = "0123456789";
        string specialChars = ".[!@#$%^&*?_~-£()]/";

        Console.WriteLine("Enter a password: ");
        string userPassword = Console.ReadLine();
        int score = 0;

        if(userPassword.Length >= minLength)
        {
          score++;
        }
        if (Tools.Contains(userPassword, uppercase))
        {
          score++;
        }
        if(Tools.Contains(userPassword, lowercase))
        {
          score++;
        }
        if(Tools.Contains(userPassword, digits))
        {
          score++;
        }
        if(Tools.Contains(userPassword, specialChars))
        {
          score++;
        }
        if(userPassword == "password" || userPassword == "1234")
        {
          score = 0;
        }
        Console.WriteLine(score);

        switch(score)
        {
          case 5:
          Console.WriteLine("Password is extremely strong");
          break;

          case 4:
          Console.WriteLine("Password is extremely strong");
          break;

          case 3: 
          Console.WriteLine("Password is strong");
          break;

          case 2:
          Console.WriteLine("Password is medium");
          break;

          case 1:
          Console.WriteLine("Password is weak");
          break;

          default:
          Console.WriteLine("The password doesn't meet any of the standards");
          break;
        }
    }
    

  }
}

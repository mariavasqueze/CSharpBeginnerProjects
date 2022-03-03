// Simple project from codeacademy, it takes a message and encrypts it by adding 3 places to the letter so A becomes D... is to practice loops 

using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      string userMessage;

      Console.WriteLine("Enter a message to encrypt: ");
      userMessage = Console.ReadLine();
      
      //Convert captured string to an array of characters
      char[] secretMessage = userMessage.ToCharArray();

      char[] encryptedMessage = new char[secretMessage.Length];

      for(int i = 0; i < secretMessage.Length; i++)
      {
        char letter = secretMessage[i];
        int letterPosition = Array.IndexOf(alphabet, letter);
        int newLetterPosition = (letterPosition + 3) % 26;
        char letterEncoded = alphabet[newLetterPosition];

        encryptedMessage[i] = letterEncoded;

      }
      // Convert to string and print encrypted
      string messageString = String.Join(" ", encryptedMessage);
      Console.WriteLine(messageString);
    }
  }
}

using System;
using static System.Console;
class CountVowels
{
   static void Main()
   {
      string in_phrase = "";
            int vowelCount = 0;
            char checkLetter = '\0';

            Write("Enter Phrase: ");
            in_phrase = ReadLine();

            for (int i = 0; i < in_phrase.Length; ++i)
            {
                checkLetter = char.ToUpper(in_phrase[i]);
                switch(checkLetter)
                {
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        vowelCount++;
                        break;
                }
            }
            WriteLine("Vowels :" + vowelCount);

   }
}

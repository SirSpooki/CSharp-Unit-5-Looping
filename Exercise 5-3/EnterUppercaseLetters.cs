using System;
using static System.Console;
class EnterUppercaseLetters
{
   static void Main()
   {
     char user;
     //string US;
     char QUIT = '!';
     WriteLine("Enter an uppercase letter: ");
     user = Convert.ToChar(ReadLine());
     
     if (char.IsUpper(user))
     {
       WriteLine("OK");
       while(user != QUIT)
       {
          WriteLine("Enter an uppercase letter or ! to quit: ");
          user = Convert.ToChar(ReadLine());

          if (char.IsUpper(user))
            {
              WriteLine("OK");
            }
          else if (char.IsLower(user))
            {
              WriteLine("Sorry - that was not an uppercase letter.");
            }
       }
    }
    else if (char.IsLower(user))
      {
        WriteLine("Sorry - that was not an uppercase letter.");
      }
   }
}

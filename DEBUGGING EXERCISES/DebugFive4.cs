/*
The program requires the user to guess the number of days it takes to make X amount of money when doubling the value every day. 
The starting value is $0.01. 
The program indicates if the guess is too high, or too low. 
*/
using System;
using static System.Console;
using System.Globalization;
class DebugFive4
{
   static void Main()
   {
      const double LIMIT = 1000000.00;
      const double START = 0.01;
      string inputString;
      double total;
      int howMany;
      int count;
      Write("How many days do you think ");
      WriteLine("it will take you to reach");
      Write("{0} starting with {1}", LIMIT.ToString("C", CultureInfo.GetCultureInfo("en-US")), START.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("and doubling it every day?");
      inputString = ReadLine();
      howMany = Convert.ToInt32(inputString);
      count = 0;
      total = START;
      while(total < LIMIT)
      {
         total = total * 2;
         count += 1;
      } 
      if(howMany >= count)
        {
         WriteLine("Your guess was too high.");
        }
      else if(howMany <= count)
        {
           WriteLine("Your guess was too low.");
        }
        else
        {
           WriteLine("Your guess was correct.");
        }
      WriteLine("It takes {0} days to reach {1}", count, LIMIT.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("when you double {0} every day", START.ToString("C", CultureInfo.GetCultureInfo("en-US")));
   }
}

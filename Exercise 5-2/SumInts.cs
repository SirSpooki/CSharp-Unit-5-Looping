using System;
using static System.Console;
class SumInts
{
   static void Main()
   {
     int sum = 0;
     int num;
     const int QUIT = 999;
     string user;

     WriteLine($"ENTER NUMBERS TO ADD");
     user = ReadLine();
     num = Convert.ToInt32(user);

     while (num != QUIT)
     {
       sum += num;
       WriteLine("ENTER NUMBERS TO ADD (ENTER {QUIT} TO END)");
       user = ReadLine();
       num = Convert.ToInt32(user);
     }
       WriteLine($"Sum of Numbers Is: {sum}");
   }
}

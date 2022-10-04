using System;
using static System.Console;
class SumFiveints
{
   static void Main()
   {
    int x, n;
    int sum = 0;
    for (x = 1; x <= 5; ++x)
    {
      WriteLine("Enter an integer");
      n = Convert.ToInt32(ReadLine());
      sum += n;
    }
    WriteLine(sum);
   }
}

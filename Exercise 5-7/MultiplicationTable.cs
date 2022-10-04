using System;
using static System.Console;
class MultiplicationTable
{
   static void Main()
   {      
            int entry = 0;
            Write("Enter number:");
            entry = int.Parse(ReadLine());
            for (int i = 1; i <= 10; ++i)
            {
                WriteLine("{0,3} x {1,2} = {2}",i,entry,i*entry);
            }
   }
}

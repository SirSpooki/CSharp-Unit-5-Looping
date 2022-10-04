using System;
using static System.Console;
class DailyTemps
{
   static void Main()
   {
    const int QUIT = 999;
    double temp;
    string user;
    double total = 0;
    double count = 0;

    WriteLine("Enter Temperature (Valid temperatures range from -20 to 130)");
    user = ReadLine();
    temp = Convert.ToDouble(user);
    
   
    if ((temp <= 130)&(temp >= -20))
      {
         ++count;
        total += temp;
          while(temp != QUIT)
            {
              WriteLine("Enter Temperature (Valid temperatures range from -20 to 130)");
              user = ReadLine();
              temp = Convert.ToDouble(user);

              if ((temp <= 130) & (temp >= -20))
                {
                  total += temp;
                  ++count;
                }
              else if ((temp > 130)||(temp < -20))
                {
                  if (temp == 999)
                    {
                      double avg = total/count;
                      WriteLine($"Number of temperatures entered: {count}");
                      WriteLine($"Average of temperatures entered: {avg}");
                    }
                  else
                    {
                      WriteLine("Valid temperatures range from -20 to 130. Please reenter temperature.");
                    }                
                } 

            }
      }
    else if ((temp > 130)||(temp < -20))
      {
        WriteLine("Valid temperatures range from -20 to 130. Please reenter temperature.");

        while(temp != QUIT)
            {
              WriteLine("Enter Temperature (Valid temperatures range from -20 to 130)");
              user = ReadLine();
              temp = Convert.ToDouble(user);

              if ((temp <= 130) & (temp >= -20))
                {
                  total += temp;
                  ++count;
                }
              else if ((temp > 130)||(temp < -20))
                {
                  if (temp == 999)
                    {
                      double avg = total/count;
                      WriteLine($"Number of temperatures entered: {count}");
                      WriteLine($"Average of temperatures entered: {avg}");
                    }
                  else
                    {
                      WriteLine("Valid temperatures range from -20 to 130. Please reenter temperature.");
                    }                
                } 
      }
      }
   
}
}

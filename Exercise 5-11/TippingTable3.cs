using System;
using static System.Console;
using System.Globalization;
class TippingTable3
{
   static void Main()
   {
     double dinnerPrice = 10.00;
            double tipRate;
            double tip;
            double lowRate = 0.10;
            double maxRate = 0.25;
            double maxDinner = 100.00;
            const double TIPSTEP = 0.05;
            const double DINNERSTEP = 10.00;

            WriteLine("(0.10 = 10%)");
            Write("lowest tip rate:");
            lowRate = double.Parse(ReadLine());
            Write("max tip rate:");
            maxRate = double.Parse(ReadLine());
            Write("min dinner price:");
            dinnerPrice = double.Parse(ReadLine());
            Write("max dinner price:");
            maxDinner = double.Parse(ReadLine());

            Write("   Price");
            for (tipRate = lowRate; tipRate <= maxRate; tipRate += TIPSTEP)
                Write("{0,8}", tipRate.ToString("F"));
            tipRate = lowRate;
            WriteLine();
            WriteLine("----------------------------------------");
            while(dinnerPrice <= maxDinner)
            {
                Write("{0, 8}", dinnerPrice.ToString("C"));
                while(tipRate <= maxRate)
                {
                    tip = dinnerPrice * tipRate;
                    Write("{0,8}", tip.ToString("F"));
                    tipRate += TIPSTEP;
                }
                dinnerPrice += DINNERSTEP;
                tipRate = lowRate;
                WriteLine();
            }

            WriteLine("--End--");
        }
    }

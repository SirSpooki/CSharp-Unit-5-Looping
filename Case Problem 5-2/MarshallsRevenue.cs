using System;
using static System.Console;
using System.Globalization;
class MarshallsRevenue
{
   enum months 
  {
    JANUARY = 1, FEBRUARY, MARCH, APRIL, MAY, JUNE, JULY, AUGUST,
    SEPTEMBER, OCTOBER, NOVEMBER, DECEMBER
  }
   static void Main()
   {
     int month, extMuralSched, intMuralSched;
     const double EXTERIOR_COST = 750;
     const double EXTERIOR_DISC = 699;
     const double INTERIOR_COST = 500;
     const double INTERIOR_DISC = 450;

     WriteLine("Enter the month");
     month = Convert.ToInt32(ReadLine());
        if (month > 12 || month < 0)
            {
              WriteLine("INVALID INPUT -- Enter the month (1-12)");
              month = Convert.ToInt32(ReadLine());
            }
     WriteLine("Enter number of interior murals scheduled");
     intMuralSched = Convert.ToInt32(ReadLine());
        if (intMuralSched > 30 || intMuralSched < 0)
            {
              WriteLine(" INVALID INPUT -- Enter number of interior murals scheduled (0-30)");
              intMuralSched = Convert.ToInt32(ReadLine());
            }
     WriteLine("Enter number of exterior murals scheduled");
     extMuralSched = Convert.ToInt32(ReadLine()); 
     if (extMuralSched > 30 || extMuralSched < 0)
            {
              WriteLine(" INVALID INPUT -- Enter number of interior exterior scheduled (0-30)");
              extMuralSched = Convert.ToInt32(ReadLine());
            }

     double interiorMath = intMuralSched * INTERIOR_COST;
     double discInteriorMath = intMuralSched * INTERIOR_DISC;
     double exteriorMath = extMuralSched * EXTERIOR_COST;
     double discExteriorMath = extMuralSched * EXTERIOR_DISC;


     switch((months) month)
     {
       case months.DECEMBER:
       case months.JANUARY:
       case months.FEBRUARY:
          if (extMuralSched>0)
            {
              extMuralSched = 0;
            }

          bool isMoreCold = intMuralSched > extMuralSched;
          double disableExtMath = extMuralSched * EXTERIOR_COST;
          double WeatherRev = interiorMath + disableExtMath;
          

          WriteLine("{0} interior murals are scheduled for a total of {1}", intMuralSched, interiorMath.ToString("C", CultureInfo.GetCultureInfo("en-US")));
          WriteLine("{0} exterior murals are scheduled for a total of {1}", extMuralSched,disableExtMath.ToString("C", CultureInfo.GetCultureInfo("en-US")));
          WriteLine("Total revenue expected is {0}", WeatherRev.ToString("C", CultureInfo.GetCultureInfo("en-US")));
          WriteLine($"It is {isMoreCold} that there are more interior murals scheduled than exterior ones.");
          break;

       case months.APRIL:
       case months.MAY:
       case months.SEPTEMBER:
       case months.OCTOBER:
       
          double revDiscExt = interiorMath + discExteriorMath;
          bool isMoreDiscExt = intMuralSched > extMuralSched;
          WriteLine("{0} interior murals are scheduled for a total of {1}", intMuralSched, interiorMath.ToString("C", CultureInfo.GetCultureInfo("en-US")));
          WriteLine("{0} exterior murals are scheduled for a total of {1}", extMuralSched, discExteriorMath.ToString("C", CultureInfo.GetCultureInfo("en-US")));
          WriteLine("Total revenue expected is {0}", revDiscExt.ToString("C", CultureInfo.GetCultureInfo("en-US")));
          WriteLine($"It is {isMoreDiscExt} that there are more interior murals scheduled than exterior ones.");
          break;

       case months.JULY:
       case months.AUGUST:

          double revDiscInt = exteriorMath + discInteriorMath;
          bool isMoreDiscInt = intMuralSched > extMuralSched;
          WriteLine("{0} interior murals are scheduled for a total of {1}", intMuralSched, discInteriorMath.ToString("C", CultureInfo.GetCultureInfo("en-US")));
          WriteLine("{0} exterior murals are scheduled for a total of {1}", extMuralSched, exteriorMath.ToString("C", CultureInfo.GetCultureInfo("en-US")));
          WriteLine("Total revenue expected is {0}", revDiscInt.ToString("C", CultureInfo.GetCultureInfo("en-US")));
          WriteLine($"It is {isMoreDiscInt} that there are more interior murals scheduled than exterior ones.");
          break;
          
       default:

          double rev = exteriorMath + interiorMath;
          bool isMore = intMuralSched > extMuralSched;
          WriteLine("{0} interior murals are scheduled for a total 500 of {1}", intMuralSched, interiorMath.ToString("C", CultureInfo.GetCultureInfo("en-US")));
          WriteLine("{0} exterior murals are scheduled for a total 6750 of {1}", extMuralSched, exteriorMath.ToString("C", CultureInfo.GetCultureInfo("en-US")));
          WriteLine("Total revenue expected is {0}", rev.ToString("C", CultureInfo.GetCultureInfo("en-US")));
          WriteLine($"It is {isMore} that there are more interior murals scheduled than exterior ones.");
          break;   
     }
     


   }
   }


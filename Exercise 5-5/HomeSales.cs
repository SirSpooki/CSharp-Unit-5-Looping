using System;
using static System.Console;
using System.Globalization;
class HomeSales
{
   static void Main()
   {
     int Danielle = 0;
     int Edward = 0;
     int Francis = 0; 
     int total = 0;
     const string QUIT = "Z";
     const string QUITLOWER = "z";
     string user;
     WriteLine("Enter a salesperson initial (D,E, or F): ");
     user = ReadLine();

     if (user == "d" || user == "D")
          {
            WriteLine("Enter amount of sale");
            Danielle += Convert.ToInt32(ReadLine());
          }
    else if (user == "e" || user == "E")
          {
            WriteLine("Enter amount of sale");
            Edward += Convert.ToInt32(ReadLine());
          }
    else if (user == "f" || user == "F")
          {
            WriteLine("Enter amount of sale");
            Francis += Convert.ToInt32(ReadLine());
          }
    else
      {
      WriteLine("Sorry - invalid salesperson");
      }
    
     
     while (user != QUIT && user != QUITLOWER)
      {
        WriteLine("Enter next salesperson initial or Z to quit: ");
        user = ReadLine();

        if (user == "d" || user == "D")
          {
            WriteLine("Enter amount of sale");
            Danielle += Convert.ToInt32(ReadLine());
          }
        if (user == "e" || user == "E")
          {
            WriteLine("Enter amount of sale");
            Edward += Convert.ToInt32(ReadLine());
          }
        if (user == "f" || user == "F")
          {
            WriteLine("Enter amount of sale");
            Francis += Convert.ToInt32(ReadLine());
          }
      }
      total = Danielle + Edward + Francis;
      WriteLine("Danielle sold      {0}",Danielle.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Edward sold      {0}",Edward.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Francis sold      {0}",Francis.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Total sales were     {0}",total.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      if (Danielle > Edward && Danielle > Francis)
        {
          WriteLine("Danielle sold the most");
        }
      else if (Edward > Danielle && Edward > Francis)
        {
          WriteLine("Edward sold the most");
        }
      else if (Francis > Danielle && Francis > Edward)
        {
          WriteLine("Francis sold the most");
        }
      else
        {
          WriteLine("There was a tie");
        }

   }
}

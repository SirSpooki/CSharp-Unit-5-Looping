using System;
using static System.Console;
class WebAddress
{
   static void Main()
   {
        string in_name = "";
            string noSpaces = "";
            Write("Business name:");
            in_name = ReadLine();
            //strip spaces
            for (int i = 0; i < in_name.Length; ++i)
            {
                if (in_name[i] != ' ')
                    noSpaces += in_name[i];
            }
            WriteLine("www.{0}.com",noSpaces);

            WriteLine("--End--");
   }
}

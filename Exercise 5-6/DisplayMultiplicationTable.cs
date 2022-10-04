using static System.Console;
class DisplayMultiplicationTable
{
   static void Main()
   {
     int value = 10;

        Write("    ");
        for (int x = 1; x <= value; ++x)
            Write("{0, 4}", x);

        WriteLine();
        WriteLine("_____________________________________________");

        for (int row = 1; row <= value; ++row)
        {
            Write("{0, 4}", row);
            for (int column = 1; column <= value; ++column)
            {
                Write("{0, 4}", row * column);
            }
            WriteLine();
        }
        ReadLine();
   }
}

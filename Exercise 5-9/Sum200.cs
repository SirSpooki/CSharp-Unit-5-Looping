using static System.Console;
class Sum200
{
   static void Main()
   {

            int itr = 0;
            int sum = 0;
            while (itr <= 200)
            {
                sum += itr;
                if (itr >= 100)
                    WriteLine(sum);
                ++itr;
            }
   }
}

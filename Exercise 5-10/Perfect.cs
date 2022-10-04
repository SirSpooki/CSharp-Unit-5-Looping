using static System.Console;
class Perfect
{
   static void Main()
   {
    int i, num, sum;
       WriteLine("The perfect numbers between 1 and 1000 are");
       num = 1;
       while (num <= 10000) {
           sum = 0;
           for (i = 1; i < num; i++)
               if (num % i == 0)
                   sum += i;
           if (sum == num)
               WriteLine(num + " ");
           num++;
       }
   }
}


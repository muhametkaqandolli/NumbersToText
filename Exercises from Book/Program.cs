using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_from_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int n;
             int sum = 0;
             int sum1= 1;
             int sum2= 1;

             for (int i=1; i<=10; i++)
             {

                 Console.WriteLine(sum2);
                 sum = sum2 + sum1;
                 sum2 = sum1;
                 sum1 = sum;

             }
             Console.WriteLine("the sum is :" + sum); */

            int a,b, i;
            string result = "";
            Console.Write("Write a number between 1-999: ");
            a = Convert.ToInt32(Console.ReadLine());

            string[] units = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixten", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] hundreds = { };

            if (a>0 && a<20)
            {
                i = a;
                result =  units[i - 1];
                Console.WriteLine("The number you wrote is: " + result);
            } else if (a>19 && a<100)
            {
                
                i = a / 10;
                a = a % 10;
                result = tens[i - 1] + " " + units[a-1];
                Console.WriteLine("The number you wrote is: " + result);
            } else if (a>99 && a<1000)
            {
                i = a / 100;
                b = (a % 100) / 10;
                a = a % 10;

                result = units[i-1] + " hundred and " + tens[b-1] + " " + units[a - 1];

                Console.WriteLine("The number you wrote is: " + result);
            }



            Console.ReadKey();

        }

  
          
         
    }
}

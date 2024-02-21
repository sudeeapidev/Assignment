using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPractise
{
    class reverseWhile
    {
        static void Main(string[] args)
        {
            int r = 0;
            int rev = 0;
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int number = num;
            while (num > 0)
            {
                r = num % 10;
                rev = (rev*10) + r;
                num = num / 10;
            }

            Console.WriteLine("The reverse of the number is " +rev);
        }
    }
}

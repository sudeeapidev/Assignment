using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPractise
{
    class reverseFor
    {
        static void Main(string[] args)
        {
            int r = 0;
            int rev = 0;
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int number = num;
            for (; num > 0; num = num / 10)
            {
                r = num % 10;
                rev = (rev * 10) + r;
            }

                Console.WriteLine("The reverse of the number is " +rev);
        }
    }
}

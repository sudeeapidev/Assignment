using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPractise
{
    class ArmstrongFor
    {
        static void Main(string[] args)
        {
            int r = 0;
            int res = 0;
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int number = num;
            for (; num > 0; num = num / 10)
            {
                r = num % 10;
                res = res + (r * r * r);
            }

            if (res == number)
            {

                Console.WriteLine("The number is armstrong number");

            }
            else
            { 
                Console.WriteLine("The number is not an armstrong number");

            }
        }

    }
}



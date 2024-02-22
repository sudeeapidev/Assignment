using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPractise
{
    class sumOfDigitsWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int r = 0;
            int res = 0;
            while(num>0)
            {
                r = num % 10;
                res = res + r;
                num = num/ 10;
            }
            Console.WriteLine("The sum of digits are: " +res);
        }
    }
}

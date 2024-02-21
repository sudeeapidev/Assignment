using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPractise
{
    class sumOfDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num=int.Parse(Console.ReadLine());
            int r = 0;
            int res = 0;
            for(;num>0;num=num/10)
            {
                r = num % 10;
                res = res + r;
                
            }

            Console.WriteLine("The sum of the digits are " + res);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPractise
{
    class armstrongWhile
    {
        static void Main(string[] args)
        {
            int r = 0;
            int res = 0;
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int number = num;
            while(num > 0) 
            {
                r = num % 10;
                res = res + (r*r*r);
                num = num / 10;
            }

            if(number==res)
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

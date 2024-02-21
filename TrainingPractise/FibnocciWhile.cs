using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPractise
{
    class FibnocciWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements to print");
            int number = int.Parse(Console.ReadLine());
            int number1 = 0;
            int number2 = 1;
            int result=0;
            int i=1;
            
            Console.Write(number1 + " " + number2);
            while (i < number)
            {
                result = number1 + number2;
                if (result >= number)
                {
                    i = number;
                }
                else
                {
                    Console.Write(" " + result);
                    number1 = number2;
                    number2 = result;
                    i++;

                }
            }


        }
    }
}

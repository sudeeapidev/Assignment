using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPractise
{
     class Fibnacci
    {
        static void Main(string[] args)
        {
            int number1 = 0;
            int number2 = 1;
            int result;
            Console.WriteLine("Enter number of elements to print");
            int number=int.Parse(Console.ReadLine());
            Console.Write(number1 +" " +number2);
            for(int i=2;i<number;i++)
            {
                result = number1 + number2;
                if (result>=number)
                {
                    i = number;
                }
                else
                {
                    Console.Write(" " + result);
                    number1 = number2;
                    number2 = result;
                }

            }
        }
      
    }
}

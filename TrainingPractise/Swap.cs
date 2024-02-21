using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPractise
{
    class Swap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a-b;
            Console.WriteLine("The numbers after swapping are " + a + " and " + b);


        }
    }
}

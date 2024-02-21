using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPractise
{
     class Palindromewhile
    {
        static void Main(string[] args)
        {
            int i, r;
            int result = 0;
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            int number1 = number;
            while(number > 0)
            {
                r = number % 10;
                result = (result * 10) + r;
                number = number / 10;
            }

            if (result == number1)
            {
                Console.WriteLine("The number " + number1 + " is Palindrome");
            }
            else
            {
                Console.WriteLine("The number " + number1 + " is not a Palindrome");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPractise
{
    class PrimeFor
    {
        static void Main(string[] args)
        {
            int c=0;
            Console.WriteLine("Enter the start number");
            int startNumber=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end number");
            int endNumber=int.Parse(Console.ReadLine());
            Console.WriteLine("The prime numbers between " +startNumber + " and " +endNumber + " are ");
            for(int i=startNumber  ;i<endNumber;i++) 
            {
                c = 0;
                for (int j = 1; j < endNumber; j++)
                {
                    if (i % j == 0)
                    {
                        c++;
                    }
                }
                if (c == 2)
                {
                    Console.WriteLine(i);
                }


            }    
        }
    }
}

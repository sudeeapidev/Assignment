using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPractise
{
    class Primewhile
    {
        static void Main(string[] args)
        {
            {
                int c = 0;
                Console.WriteLine("Enter the startnumber");
                int startnum = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the endnumber");
                int endnum = int.Parse(Console.ReadLine());
                var i = startnum;
                Console.WriteLine("The prime numbers between " + startnum + " and " + endnum + " are");
                while (i < endnum)
                {
                    var j = 1;
                    while (j < endnum)
                    {
                        if (i % j == 0)
                        {
                            c++;

                        }
                        j++;
                    }
                    if (c == 2)
                    {
                        Console.Write(i + ",");
                    }
                    c = 0;
                    i++;
                }

            }
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPractise
{
    internal class test
    {
        static void Main(string[] args)
        {
            int  i,j, ctr, startnumber, endnumber;

           
           

            Console.Write("Input starting number of range: ");
            startnumber = Convert.ToInt32(Console.ReadLine());  

            Console.Write("Input ending number of range : ");
            endnumber = Convert.ToInt32(Console.ReadLine());  

            Console.Write("The prime numbers between {0} and {1} are : \n", startnumber, endnumber); 

            
            for (i = startnumber; i <= endnumber; i++)
            {
                ctr = 0;  

                
                for (j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        ctr++; 
                        break;  
                    }
                }

                
                if (ctr == 0 && i != 1)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.Write("\n");  
        }
    }
}
    


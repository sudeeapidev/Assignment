using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPractise
{
    class MaxArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements");
            int num=int.Parse(Console.ReadLine());
            int[] arr=new int[num];
            

            Console.WriteLine("Enter the elements");
            for(int i=0; i<num; i++)
            {
                int numi=int.Parse(Console.ReadLine());
                arr[i] = numi;
            }
            Console.WriteLine("The elements of the array are");
            foreach(int i in arr) 
            {
                Console.WriteLine(i);
            }

            //Max elements of the array
            int max = 0;
            for(int i=0; i<num;i++) 
            {
                if (arr[i]>max)
                {
                    max= arr[i];
                }
            }
            Console.WriteLine("The max element is " + max);
            //Console.WriteLine("The max element is " + arr.Max());
        }
    }
}

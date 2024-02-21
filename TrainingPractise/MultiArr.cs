using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPractise
{
    class MultiArr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int[,] arr = new int[x, y];
            Console.WriteLine("Enter elements of the array");
            //Console.WriteLine(arr.Length);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                   // Console.WriteLine(arr[i,j]);
                }
            }
            Console.WriteLine("The elements of the array are :");
            foreach(int a in arr)
            {
                
                Console.WriteLine(a);
            }
        }

    }
}

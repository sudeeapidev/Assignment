using System.ComponentModel.Design;

namespace TrainingPractise
{
    class Greater
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 numbers");
            int a =Convert.ToInt32(Console.ReadLine());
            int b =Convert.ToInt32(Console.ReadLine());
            int c =Convert.ToInt32(Console.ReadLine());
            int d =Convert.ToInt32(Console.ReadLine());
            int e =Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c && a > d && a > e)

            {
                Console.WriteLine("Highest number is" + a);
                //Console.WriteLine("The lowest number is " + a);
            }

            else if (b > a && b > c && b > d && b > e)
                {
                Console.WriteLine("Highest number is" + b);
                //Console.WriteLine("The lowest number is" + b);
                }
            else if (c > a && c > b && c > d && c > e)
            {
                Console.WriteLine("Highest number is" + c);
               
            }
            else if (d > a && d > b && d > c && d > e)
            {
                Console.WriteLine("Highest number is" + d);
                
            }
          
            else 
                Console.WriteLine("Highest number is "+ e);

           if(a<b && a<c && a<d && a<e )
            {
                Console.WriteLine("The smallest number is " + a);

            }
           else if(b<a && b<c && b<d && b<e )
            {
                Console.WriteLine("The smallest number is " + b);
            }
           else if(c<a && c<b &&c<d && c<e)
            {
                Console.WriteLine("The smallest number is " + c);
            }
            else if (d < a && d < b && d < e && d < c)
            {
                Console.WriteLine("The smallest number is " + d);
            }
           else
            {
                Console.WriteLine("The smallest number is " + e);
            }


        }
    }
}

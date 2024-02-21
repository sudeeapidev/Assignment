using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPractise
{
    class Product
    {
        static void Main(string[] args)
        {
            int oneplus = 45000;
            int iphone = 130000;
            int xbox = 35000;
            int PS = 28000;
            int smartWatch = 16000;
            int cartAmount = 0;
        First:
            Console.WriteLine("Select Products :");
            Console.WriteLine("1. Oneplus Mobile    - " +oneplus );
            Console.WriteLine("2. IPhone 15 Max Pro - "+iphone);
            Console.WriteLine("3. XBox 360         - " +xbox);
            Console.WriteLine("4. PS 4              - " +PS);
            Console.WriteLine("5. Smart Watch       - " +smartWatch);
            int  input = Convert.ToInt32(Console.ReadLine());
            
            switch(input)
            {
                case 1:
                    cartAmount = cartAmount + oneplus ;
                    break;
                case 2:
                    cartAmount = cartAmount + iphone;
                    break;
                case 3:
                    cartAmount = cartAmount + xbox;
                    break;
                case 4:
                    cartAmount = cartAmount + PS;
                    break;
                case 5:
                    cartAmount = cartAmount + smartWatch;
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    goto First;
                
             }



            Console.WriteLine("Do you want to continue shopping? (yes/no) ");
            String response = Console.ReadLine();
            if (response.ToLower() == "yes")
            {
                goto First;
            }
            else if (response.ToLower() =="no")
                {
                Console.WriteLine("Thanks for shopping with us...! Total cart value is: "+cartAmount);
                }
            else
            {
                Console.WriteLine("Invalid response");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallProjects
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int result;
            string ans;

            Console.WriteLine("Welcome");
            Console.WriteLine("enter the 1st number :");

            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the 2nd number :");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("choose an operation");
            Console.WriteLine("Enter a for addition, s for substraction, m for multiplication, d for division ");

            ans = Console.ReadLine();

            if(ans == "a")
            {
                result = x + y;
            }
            else if (ans == "s") {
                result = y - x;
            }
            else if (ans == "m")
            {
                result = x * y;
            }
            else
             {
                result = y / x;
            }
            Console.WriteLine("the answer is :" + result);
            Console.WriteLine("thank you ");
            Console.ReadKey();
        }
    }
}

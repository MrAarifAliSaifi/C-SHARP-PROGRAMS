using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = 1;

            Console.WriteLine("PLEASE ENTER THE NO TO FIND OUT THE FACTORIAL:");  //taking input from the usr
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=n;i>0;i--)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("THE FACTORIAL OF THE GIVEN NUMBER IS:"+factorial);
            Console.ReadLine();

        }
    }
}

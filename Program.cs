using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindromNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int test = 0;
            Console.WriteLine("PLEASE ENTER THE NO TO BE CHECKED");     //taking input from the user 
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            while (n > 0)
            {
                int remainder = n % 10;
                test = test * 10 + remainder;   //to avoid overwrite condition
                n = n /10;
            }
            if (test == temp)
            {
                Console.WriteLine("YES THE ENTERED NO IS PALINDROM");
            }
            else
                Console.WriteLine("NO IS NOT PALINDROM");
                Console.ReadLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;AA

namespace duplicateNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 1,2,3,4,4,5,6,3,4,8,4,8,3,5,7,23,6,5,6};
            int size = ar.Length;Console.WriteLine("THE DUPLICATE ELEMENTS ARE");

            for (int i = 0; i <size; i++)
            {
                for (int j = i+1; j <size; j++)
                {
                    if(ar[i]==ar[j])
                     Console.Write(" "+ar[j]);
                    
                }
               
            }
            Console.ReadLine();
        }
    }
}

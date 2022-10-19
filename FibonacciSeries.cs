using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public static void Check()
        {
            int a = 0;
            int b = 1;
            int c, i, number;
            Console.Write("Enter the number of elements : ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + " " + b + " ");
            for(i = 0; i < number; i++)
            {
                c = a + b;
                Console.WriteLine(c + " ");
                a = b;
                b = c;
            }
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public static void Check()
        {
            Console.Write("Enter a Number : ");
            int sum = 0;
            int i = 1;
            int n = Convert.ToInt32(Console.ReadLine());

            while(i <= n/2)
            {
                if(n % i == 0)
                {
                    sum = sum + i;
                }
                i++;
            }
            if(sum == n)
            {
                Console.WriteLine(n + " is a Perfect Number");
            }
            else
            {
                Console.WriteLine(n + " is not a Perfect Number");
            }

        }
    }
}

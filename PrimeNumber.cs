using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public static void Check()
        {
            Console.Write("Enter a Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 2; i < num/2; i++)
            {
                if(num % i == 0)
                {
                    Console.WriteLine(num + " is not Prime Number");
                    break;
                }
                else
                {
                    Console.WriteLine(num + " is Prime Number");
                    break;
                }
            }
        }
    }
}

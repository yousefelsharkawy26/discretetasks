using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long num, rem, i, sum = 0;
            long n1, n2;
            Console.Write("Enter your First Number : ");
            n1 = long.Parse(Console.ReadLine());
            Console.Write("Enter your Second Number : ");
            n2 = long.Parse(Console.ReadLine());
            for (num = n1; num <= n2;num++)
            {
                for (i = 1; i <= (num/2);i++)
                {
                    rem = num % i;
                    if (rem == 0)
                    {
                        sum = sum + i;
                    }
                }
                if (num == sum)
                    Console.WriteLine("Number {0} is Perfect Number in Range ", num);
                sum = 0;

            }
            Console.ReadLine();
        }
    }
}

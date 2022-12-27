using System;
using System.Runtime.InteropServices;

namespace primenumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sec, i, n1, n2;

            Console.Write("Enter the frist Number : ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second Number : ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 == 1)
                n1++;
            num = n1;
            Console.WriteLine("Prime in given range is : ");
            while (num <= n2)
            {
                sec = 0;
                for (i = 2; num > i; i++)
                {
                    if (num % i == 0)
                    {
                        sec = 1;
                        break;
                    }
                }
                if (sec == 0)
                    Console.WriteLine(num);
                num++;
                

            }
            Console.ReadLine();
        }
    }
}

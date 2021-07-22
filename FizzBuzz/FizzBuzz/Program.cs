using System;
using System.Threading;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fizz Buzz In C# 1-100 By ISFR");
            Thread.Sleep(3000);
            
            for (int i = 1; i <= 100; i++) //sets up fizzbuzz
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            Console.ReadLine();
        }
    }
}

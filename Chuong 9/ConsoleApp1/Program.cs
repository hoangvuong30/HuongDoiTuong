using System;
using test;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Job job1 = new Job("Paint a house", 10, 100);
            Job job2 = new Job("Dog walking", 1, 10);

            Console.WriteLine(job1);
            Console.WriteLine();
            Console.WriteLine(job2);
            Console.WriteLine();
            Console.WriteLine(job1+job2);
            Console.ReadLine();
        }
    }
}

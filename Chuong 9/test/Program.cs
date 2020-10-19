using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Job Tiec = new Job("Lam Tiec",8,30000);
            Job AnhSang = new Job("Anh sang san khau", 2, 40000);

            Console.WriteLine(Tiec);
            Console.WriteLine();
            Console.WriteLine(AnhSang);
            Console.WriteLine();

            Console.WriteLine("Overload + Opertor");
            Console.WriteLine(Tiec+AnhSang);
            Console.ReadLine();

        }
    }
}

using System;

namespace FractionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction ps1 = new Fraction(2,1,4);
            Fraction ps2 = new Fraction(1,3,5);
            Console.WriteLine("Phan so ban dau: "+ps1);
            //ps1.Reduce();
            //Console.WriteLine("Phan so da rut gon: "+ps1);
            
            Console.WriteLine("Phan so dau: "+ps2);
            //ps2.Reduce();
            //Console.WriteLine("Phan so rut gon: "+ps2);
            Console.WriteLine(ps1+ps2);
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FractionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            Fraction ps1 = new Fraction(0,1,2);
            Fraction ps2 = new Fraction(2, 0, 3);
      
            
            
            //Console.WriteLine("Nhap so nguyen: ");
            //a.WholeNumber = Convert.ToInt16(Console.ReadLine());
            //if (a.WholeNumber == 0)
            //{
            //    new Fraction(a.Numerator, a.Denominator);
            //}
            //if (a.Numerator == 0)
            //{
            //    new Fraction(a.WholeNumber,' ');
            //}
            Console.WriteLine("Phan so 1 ban dau: "+ps1);
            ps1.Reduce();
            
            Console.WriteLine("Phan so 1 da rut gon: "+ps1);

            Console.WriteLine("\nPhan so 2 ban dau: " + ps2);
            ps2.Reduce();
            
            Console.WriteLine("Phan so 2 da rut gon: "+ps2);
            //Console.WriteLine(ps1 + ps2);
            Console.Read();
        }
    }
}
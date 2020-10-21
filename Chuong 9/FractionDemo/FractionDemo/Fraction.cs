using System;
using System.Collections.Generic;
using System.Text;

namespace FractionDemo
{
    public class Fraction
    {
        private int _denominator = 1;
        private int WholeNumber1;
        public int WholeNumber { set; get; }
        public int Numerator { set; get; }
        public int Denominator
        {
            set
            {
                if (value == 0) throw new Exception("The denominator can't be zero");
                else _denominator = value;
            }
            get { return _denominator; }
        }
        public Fraction()
        {
            Denominator = 1;
            WholeNumber = 0;
            Numerator = 0;
        }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
            WholeNumber = 0;
        }

        public Fraction(int wholenumber, int numerator, int denominator)
        {
            WholeNumber = wholenumber;
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fraction(int WholeNumber1)
        {
            // TODO: Complete member initialization
            this.WholeNumber1 = WholeNumber1;
        }
        public void Reduce()
        {
            if (WholeNumber == 0)
            {

                int ucln = UCLN(Numerator, Denominator);
                Numerator /= ucln;
                Denominator /= ucln;
            }
            else
            {

            }
        }

        public override string ToString()
        {
            if (WholeNumber == 0)
                return string.Format("{0}/{1}", Numerator, Denominator);
            else if (Numerator == 0)
                return WholeNumber.ToString();
            return string.Format("{0} {1}/{2}", WholeNumber, Numerator, Denominator);
        }
        private static void QuyDong(Fraction a, Fraction b)
        {
            int d = BCNN(a.Denominator, b.Denominator);
            a.Numerator *= (d / a.Denominator);
            b.Numerator *= (d / b.Denominator);
            a.Denominator = b.Denominator = d;
        }
        public Fraction ChuyenHonSoThanhPhanSo()
        {
            return new Fraction(WholeNumber * Denominator + Numerator, Denominator);
        }
        public Fraction ChuyenPhanSoThanhHonSo()
        {
            return new Fraction(Numerator / Denominator, Numerator % Denominator, Denominator);
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            Fraction _a = a.ChuyenHonSoThanhPhanSo();
            Fraction _b = b.ChuyenHonSoThanhPhanSo();
            QuyDong(_a, _b);
            return new Fraction(_a.Numerator + _b.Numerator, _a.Denominator);
        }
        public void RutGon(Fraction a, Fraction b)
        {
            if (WholeNumber == 0)
            {
                new Fraction(Numerator, Denominator);

            }
            if (Numerator == 0)
            {
                new Fraction(WholeNumber);
            }
        }






        private static int BCNN(int a, int b)
        {
            return Math.Abs((a * b) / UCLN(a, b));
        }

        private static int UCLN(int a, int b)
        {
            int r;
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b > 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return Math.Abs(a);
        }



        internal void RutGon()
        {
            throw new NotImplementedException();
        }
    }
}

#define CLASS_FRACTION
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Fraction
{
    class Fraction
    {

        int denominator;
        public int Integer { get; set; }
        public int Numerator { get; set; }

        public int Denominator
        {
            get { return denominator; }
            set { if (value < 0) value = 1; this.denominator = value; }
        }

        public Fraction(int integer)
        {
            Integer = integer;
            Numerator = 0;
            denominator = 1;
            Console.WriteLine($"Constructor : \t{GetHashCode()}");
        }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
            Console.WriteLine($"2Constructor : \t{GetHashCode()}");
        }

        public Fraction(int integer = 0, int numerator = 0, int denominator = 1) : this(numerator, denominator)
        {
            Integer = integer;
            //Numerator = numerator;
            //Denominator = denominator;
            Console.WriteLine("Construtor:\t" + GetHashCode());
        }
        public Fraction(Fraction other)
        {
            if (this.Equals(other)) Console.WriteLine("You want to copy an object to itself");
            this.Integer = other.Integer;
            this.Numerator = other.Numerator;
            this.Denominator = other.Denominator;
            Console.WriteLine("CopyConstructor:\t" + GetHashCode());
        }
        ~Fraction()
        {
            Console.WriteLine("Destrutor:\t" + GetHashCode());
        }

        //				Operators:
        public static Fraction operator *(Fraction left_operand, Fraction right_operand)
        {
            Fraction left = new Fraction(left_operand);
            Fraction right = new Fraction(right_operand);
            left.ToImproper();
            right.ToImproper();
            return new Fraction(left.Numerator * right.Numerator, left.Denominator * right.Denominator).ToProper();
        }
        //---------------------------------------------------------------------------
        public static bool operator ==(Fraction left_operand, Fraction right_operand)
        {
            Fraction left = new Fraction(left_operand);
            Fraction right = new Fraction(right_operand);
            left.ToImproper();
            right.ToImproper();
            return left.Numerator * right.Denominator == right.Numerator * left.Denominator;
        }
        public static bool operator !=(Fraction left, Fraction right)
        {
            return !(left == right);
        }
        //				 Methods:
        public Fraction ToImproper()
        {
            Numerator += Integer * Denominator;
            Integer = 0;
            return this;
        }
        public Fraction ToProper()
        {
            Integer += Numerator / Denominator;
            Numerator %= Denominator;
            return this;
        }
        public void Print()
        {
            //Console.Write($"{Integer}({Numerator}/{Denominator})");
            if (Integer != 0) Console.Write(Integer);
            if (Numerator != 0)
            {
                if (Integer != 0) Console.Write("(");
                Console.Write($"{Numerator}/{Denominator}");
                if (Integer != 0) Console.Write(")");
            }
            else if (Integer == 0) Console.Write(0);
            Console.WriteLine();
        }
        public override string ToString()
        {
            string fraction = "";
            if (Integer != 0) fraction += Integer;
            if (Numerator != 0)
            {
                if (Integer != 0) fraction += "(";
                fraction += $"{Numerator}/{Denominator}";
                if (Integer != 0) fraction += ")";
            }
            else if (Integer == 0) fraction = "0";
            return fraction;
        }

#if CLASS_FRACTION

        //private double numerator;
        //private double denominator;

        //public Fraction(double numerator, double denominator)
        //{
        //    if (denominator == 0)
        //    {
        //        throw new ArgumentException(" Zero cannot be Denominator.");
        //    }

        //    this.numerator = numerator;
        //    this.denominator = denominator;
        //    Reduce();
        //    Console.WriteLine($"2args Constructor :\t{GetHashCode()}");
        //}

        //private void Reduce()
        //{
        //    double gcd = FindGCD(Math.Abs(numerator), Math.Abs(denominator));
        //    numerator /= gcd;
        //    denominator /= gcd;

        //    if (denominator < 0)
        //    {
        //        numerator = -numerator;
        //        denominator = -denominator;
        //    }
        //}

        //private double FindGCD(double a, double b)
        //{
        //    while (b != 0)
        //    {
        //        double temp = b;
        //        b = a % b;
        //        a = temp;
        //    }
        //    return a;
        //}

        //public override string ToString()
        //{
        //    if (denominator == 1)
        //    {
        //        return numerator.ToString();
        //    }
        //    return $"{numerator}/{denominator}";
        //}

        //public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        //{
        //    double resultNumerator = fraction1.numerator * fraction2.denominator + fraction2.numerator * fraction1.denominator;
        //    double resultDenominator = fraction1.denominator * fraction2.denominator;
        //    return new Fraction(resultNumerator, resultDenominator);
        //}

        //public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        //{
        //    double resultNumerator = fraction1.numerator * fraction2.denominator - fraction2.numerator * fraction1.denominator;
        //    double resultDenominator = fraction1.denominator * fraction2.denominator;
        //    return new Fraction(resultNumerator, resultDenominator);
        //}

        //public static Fraction operator *(Fraction fraction1, Fraction fraction2)
        //{
        //    double resultNumerator = fraction1.numerator * fraction2.numerator;
        //    double resultDenominator = fraction1.denominator * fraction2.denominator;
        //    return new Fraction(resultNumerator, resultDenominator);
        //}

        //public static Fraction operator /(Fraction fraction1, Fraction fraction2)
        //{
        //    if (fraction2.numerator == 0)
        //    {
        //        throw new DivideByZeroException("Division of zero not allow.");
        //    }

        //    double resultNumerator = fraction1.numerator * fraction2.denominator;
        //    double resultDenominator = fraction1.denominator * fraction2.numerator;
        //    return new Fraction(resultNumerator, resultDenominator);
        //}  
#endif
    }
}

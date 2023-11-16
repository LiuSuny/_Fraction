using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Fraction
{
    class Fraction
    {
        private double numerator;
        private double denominator;

        public Fraction(double numerator, double denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException(" Zero cannot be Denominator.");
            }

            this.numerator = numerator;
            this.denominator = denominator;
            Reduce();
            Console.WriteLine($"2args Constructor :\t{GetHashCode()}");
        }

        private void Reduce()
        {
            double gcd = FindGCD(Math.Abs(numerator), Math.Abs(denominator));
            numerator /= gcd;
            denominator /= gcd;

            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }
        }

        private double FindGCD(double a, double b)
        {
            while (b != 0)
            {
                double temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override string ToString()
        {
            if (denominator == 1)
            {
                return numerator.ToString();
            }
            return $"{numerator}/{denominator}";
        }

        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            double resultNumerator = fraction1.numerator * fraction2.denominator + fraction2.numerator * fraction1.denominator;
            double resultDenominator = fraction1.denominator * fraction2.denominator;
            return new Fraction(resultNumerator, resultDenominator);
        }

        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            double resultNumerator = fraction1.numerator * fraction2.denominator - fraction2.numerator * fraction1.denominator;
            double resultDenominator = fraction1.denominator * fraction2.denominator;
            return new Fraction(resultNumerator, resultDenominator);
        }

        public static Fraction operator *(Fraction fraction1, Fraction fraction2)
        {
            double resultNumerator = fraction1.numerator * fraction2.numerator;
            double resultDenominator = fraction1.denominator * fraction2.denominator;
            return new Fraction(resultNumerator, resultDenominator);
        }

        public static Fraction operator /(Fraction fraction1, Fraction fraction2)
        {
            if (fraction2.numerator == 0)
            {
                throw new DivideByZeroException("Division of zero not allow.");
            }

            double resultNumerator = fraction1.numerator * fraction2.denominator;
            double resultDenominator = fraction1.denominator * fraction2.numerator;
            return new Fraction(resultNumerator, resultDenominator);
        }
    }
}

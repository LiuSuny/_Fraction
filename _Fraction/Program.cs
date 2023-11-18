//#define FIRST_FRACTION
#define CONSTRUCTORS_CHECK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Fraction
{
    class Program
    {
        static void Main(string[] args)
        {

#if CONSTRUCTORS_CHECK
            Fraction A = new Fraction(); //Default constructor
            A.Print();
            Console.WriteLine(A);
            Console.WriteLine(A.GetType());

            Fraction B = new Fraction(5);
            B.Print();
            Console.WriteLine(B);

            Fraction C = new Fraction(1, 2);
            C.Print();
            Console.WriteLine(C);

            Fraction D = new Fraction(2, 3, 4);
            D.Print();
            Console.WriteLine(D);
#endif
            //Fraction A = new Fraction(2, 3, 4);
            //Fraction B = new Fraction(3, 4, 5);
            //Fraction C = new Fraction(A * B);

            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Console.WriteLine(C);

            ////Fraction D = new Fraction(A);
            //////Fraction D = A;
            ////Console.WriteLine(A.Equals(D));
            ////A = new Fraction(A);

            //Console.WriteLine(new Fraction(1, 2) != new Fraction(5, 10));


#if FIRST_FRACTION
            //Fraction f1 = new Fraction(4, 5);
            //Fraction f2 = new Fraction(3, 7);
            //Console.WriteLine(f1.subtraction(f2));


            Fraction f1 = new Fraction(2, 3);
            Fraction f2 = new Fraction(1, 2);
            Fraction f3 = new Fraction(5, 1);

            // Example of the operation
            Fraction addition = f1 + f2;
            Fraction subtraction = f1 - f2;
            Fraction multiply = f1 * f2;
            Fraction division = f1 / f2;

            // Вывод результатов
            Console.WriteLine($"Fraction1: {f1}");
            Console.WriteLine($"Fraction2: {f2}");
            Console.WriteLine($"Fraction3: {f3}");
            Console.WriteLine($"Addition: {addition}");
            Console.WriteLine($"Subtraction: {subtraction}");
            Console.WriteLine($"Multiply: {multiply}");
            Console.WriteLine($"Division: {division}");
#endif 

        }
    }
}

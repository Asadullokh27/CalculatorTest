using System;

namespace CalculatorTest
{
    public class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("0 ga bo'lib bo'lmaydi!");
            }
            return a / b;
        }

        public static double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public static double SquareRoot(double a)
        {
            if (a < 0)
            {
                throw new ArgumentException("0 dan kichik sonni kvadrat ildizini hisoblab bolmaydi!");
            }
            return Math.Sqrt(a);
        }

        public static double Modulus(double a, double b)
        {
            return a % b;
        }

        public static double Perimeter(double length, double width)
        {
            //Perimetrini ham hisoblasa boladi
            return 2 * (length + width);
        }

        public static double Area(double length, double width)
        {
            //Yuzasini ham hisoblasa boladi
            return length * width;
        }
    }
}

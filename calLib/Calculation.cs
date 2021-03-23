using System;

namespace calLib
{
    internal class Calculation
    {
        internal double Square(double num1)
        {
            return num1 * num1;
        }

        internal double Cube(double num)
        {
            return num * num * num;
        }

        internal double SquareRoot(double num1)
        {
            return 0.5 * num1;
        }
    }
}
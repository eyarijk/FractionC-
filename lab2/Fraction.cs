using System;

namespace lab2
{
    public class Fraction
    {
        private double numerator;
        private double denominator;

        public Fraction(double numerator, double denominator)
        {
            if (denominator == 0)
            {
                throw new Exception("Denominator must be <> 0");
            }

            this.numerator = numerator;
            this.denominator = denominator;
        }

        public double GetNumerator()
        {
            return this.numerator;
        }

        public double GetDenominator()
        {
            return this.denominator;
        }

        public double GetSum()
        {
            return this.numerator + this.denominator;
        }

        public double GetSubtraction()
        {
            return this.numerator - this.denominator;
        }

        public double GetDivision()
        {
            return this.numerator / this.denominator;
        }

        public double GetMultiplication()
        {
            return this.numerator * this.denominator;
        }
    }
}

using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Fraction fraction = new Fraction(10, 2);

            Console.WriteLine("Sum = " + fraction.GetSum());
            Console.WriteLine("Division = " + fraction.GetDivision());
            Console.WriteLine("Multiplication = " + fraction.GetMultiplication());
            Console.WriteLine("Subtraction = " + fraction.GetSubtraction());
        }
    }
}

using System;

namespace Learning03
{
    public class Fraction
    {
        // Private attributes for numerator and denominator
        private int _numerator;
        private int _denominator;

        // Constructor that initializes the number to 1/1
        public Fraction()
        {
            _numerator = 1;
            _denominator = 1;
        }

        // Constructor that has one parameter for the numerator, denominator is 1
        public Fraction(int numerator)
        {
            _numerator = numerator;
            _denominator = 1;
        }

        // Constructor that has two parameters for the numerator and denominator
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }
            _numerator = numerator;
            _denominator = denominator;
        }

        // Getters and setters for numerator
        public int GetNumerator()
        {
            return _numerator;
        }

        public void SetNumerator(int numerator)
        {
            _numerator = numerator;
        }

        // Getters and setters for denominator
        public int GetDenominator()
        {
            return _denominator;
        }

        public void SetDenominator(int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }
            _denominator = denominator;
        }

        // Method to return the fraction as a string in the form "numerator/denominator"
        public string GetFractionString()
        {
            return $"{_numerator}/{_denominator}";
        }

        // Method to return the decimal value of the fraction
        public double GetDecimalValue()
        {
            return (double)_numerator / _denominator;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create fractions using all three constructors
            Fraction fraction1 = new Fraction(); // 1/1
            Fraction fraction2 = new Fraction(6); // 6/1
            Fraction fraction3 = new Fraction(3, 4); // 3/4
            Fraction fraction4 = new Fraction(1, 3); // 1/3

            // Display the fractions and their decimal values
            Console.WriteLine(fraction1.GetFractionString());
            Console.WriteLine(fraction1.GetDecimalValue());

            Console.WriteLine(fraction2.GetFractionString());
            Console.WriteLine(fraction2.GetDecimalValue());

            Console.WriteLine(fraction3.GetFractionString());
            Console.WriteLine(fraction3.GetDecimalValue());

            Console.WriteLine(fraction4.GetFractionString());
            Console.WriteLine(fraction4.GetDecimalValue());

            // Test getters and setters
            fraction1.SetNumerator(2);
            fraction1.SetDenominator(3);
            Console.WriteLine(fraction1.GetFractionString()); // Should be 2/3
            Console.WriteLine(fraction1.GetDecimalValue()); // Should be 0.6666...

            fraction2.SetDenominator(2);
            Console.WriteLine(fraction2.GetFractionString()); // Should be 6/2
            Console.WriteLine(fraction2.GetDecimalValue()); // Should be 3.0
        }
    }
}

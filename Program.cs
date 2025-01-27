using System;

namespace Wk2Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Temperature Converter\n");

            // Input: Fahrenheit temperature
            Console.Write("Enter the temperature: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            // Conversion formula: Celsius = 5/9 * (Fahrenheit - 32)
            double celsius = 5.0 / 9.0 * (fahrenheit - 32);

            // Output the result
            Console.WriteLine($"\n{fahrenheit:F2} F is equivalent to {celsius:F2} C");

            Console.ReadKey();
        }
    }
}

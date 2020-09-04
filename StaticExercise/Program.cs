using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            var celsius = TempConverter.FahrenheitToCelsius(72);
            Console.WriteLine($"{celsius} degrees");
            var fahrenheit = TempConverter.CelsiusToFahrenheit(32);
            Console.WriteLine($"{fahrenheit} Degrees");
        
        }

    }
}

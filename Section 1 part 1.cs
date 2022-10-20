using System;

namespace Section_1_part_1
{
    internal static class TemperatureComparison
    {
        public static void Main(string[] args)
        {
            Console.Out.WriteLine("Please input Celsius Temperature in format '123,123'");
            var celsiusTemperature = decimal.Parse(Console.In.ReadLine());
            Console.Out.WriteLine("Please input Fahrenheit Temperature in format '123,123'");
            var fahrenheitTemperature = decimal.Parse(Console.In.ReadLine());
            var celsiusTemperatureConverted = TemperatureConversion(celsiusTemperature, true);
            var fahrenheitTemperatureConverted = TemperatureConversion(fahrenheitTemperature, false);

            if (celsiusTemperature > fahrenheitTemperatureConverted)
            {
                var tempDifferenceС = celsiusTemperature - fahrenheitTemperatureConverted;
                var tempDifferenceF = celsiusTemperatureConverted - fahrenheitTemperature;

                Console.Out.WriteLine(
                    $"{celsiusTemperature}C is bigger then {fahrenheitTemperature}F by {tempDifferenceС}C" +
                    $" and {tempDifferenceF}F");
            }

            else if (celsiusTemperature < fahrenheitTemperatureConverted)
            {
                var tempDifferenceС = fahrenheitTemperatureConverted - celsiusTemperature;
                var tempDifferenceF = fahrenheitTemperature - celsiusTemperatureConverted;
                Console.Out.WriteLine(
                    $"{fahrenheitTemperature}F is bigger then {celsiusTemperature}C by {tempDifferenceС}C" +
                    $" and {tempDifferenceF}F");
            }
            else
            {
                Console.Out.WriteLine($"{celsiusTemperature}C is equal to {fahrenheitTemperature}F");
            }

            decimal TemperatureConversion(decimal temperature, bool isFromCelsius)
            {
                switch (isFromCelsius)
                {
                    case true:
                        return temperature * (decimal)1.8 + 32;
                    case false:
                        return (temperature - 32) * 5 / 9;
                }
            }
        }
    }
}
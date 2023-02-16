namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelcius(68);
            var fahrenheit = TempConverter.CelciusToFahrenheit(20);
            Console.WriteLine($"Celcius: {celcius}");
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~");
            Console.WriteLine();
            Console.WriteLine($"Fahrenheit: {fahrenheit}");
        }
    }
}

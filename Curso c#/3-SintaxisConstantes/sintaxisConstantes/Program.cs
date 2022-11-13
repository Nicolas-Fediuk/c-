using System.Runtime.CompilerServices;

namespace sintaxisConstantes
{
    class Program
    {
        static void Main()
        {
            const double PI = 3.1416;

            Console.WriteLine("Ingrese el radio");

            double radio = double.Parse(Console.ReadLine());

            double area = Math.Pow(radio, 2)*PI;

            Console.WriteLine($"Calculo: {area}");  

        }
    }
}
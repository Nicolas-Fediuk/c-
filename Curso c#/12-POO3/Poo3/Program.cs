namespace Poo3
{
    class Program
    {
        static void Main()
        {
            ///realizarTarea();

            //calses anonimas

            var miVarible = new { Nombre = "Nico", Apelllido = "fediuk"};

            Console.WriteLine(miVarible.Nombre);
        }

        static void realizarTarea()
        {
            // sirve para ver donde dejamos o dejo el trabajo para continuar o que continue
            // TODO: 

            Punto origen = new Punto();

            Punto destino = new Punto(12,34);

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"la distancia entre los puntos es: {distancia}");

            Console.WriteLine($"Contador de objetos creados: {Punto.ContadorObj()}");
        }
    }
}

namespace if1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese su edad: ");
            int edad = Convert.ToInt16(Console.ReadLine());

            if (verificarEdad(edad))
                Console.WriteLine("pase");
            else
                Console.WriteLine("no pase");

            // genera numeros randon a partir del intervalo pasado 
            Random numero = new Random();
            int numeroAleatorio = numero.Next(0,100);
        }

        static bool verificarEdad(int edad)
        {
            if (edad < 18)
                return false;
            else
                return true;
        }
    }
}
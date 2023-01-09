namespace linq1
{
    class Program
    {
        static void Main()
        {
            // Enumerable y queryable con las clases que usa linq

            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Numeros pares");

            /*List<int> NumerosPares = new List<int>();

            foreach(var n in numeros)
            {
                if(n % 2 == 0)
                {
                    NumerosPares.Add(n);
                }
            }*/

            IEnumerable<int> NumerosPares = from numero in numeros where numero % 2 == 0 select numero;

            foreach(var i in NumerosPares)
            {
                Console.WriteLine(i);
            }
        }
    }
}

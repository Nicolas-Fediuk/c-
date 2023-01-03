namespace delegadosPredicados
{
    class Program
    {
        static void Main()
        {
            //Son delegados que devuelven true o false 
            //Son muy utilizados para filtrar valores comprobando si una condicion es cierta par un valor dado

            List<int> numeros = new List<int>();

            numeros.AddRange(new int[] { 1, 2, 3,4,5,6,7,8,9,10 });

            //declaracion del delegado predicado

            Predicate<int> predicado = new Predicate<int>(Pares); 

            List<int> numPares = numeros.FindAll(predicado);

            foreach(var par in numPares)
            {
                Console.WriteLine(par);
            }
        }

        static bool Pares(int num)
        {
            if (num % 2 == 0) return true;
            return false;
        }
    }

    
}
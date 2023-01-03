namespace colecciones3
{

    class Program
    {
        static void Main()
        {
            //crear queue
            Queue<int> numeros = new Queue<int>();

            foreach(int numero in new int[5] { 2, 3, 4, 5, 7 })
            {
                numeros.Enqueue(numero);
            }

            //agregar nueros al queue
            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            //eliminar elementos del queue
            numeros.Dequeue();

            //elimina el primer numero que se inserto, osea el 2
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

        }

    }
    
}



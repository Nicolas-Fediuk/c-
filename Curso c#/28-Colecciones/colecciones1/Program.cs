namespace colecciones1
{
    class Program
    {
        static void Main()
        {
            List<int> numeros = new List<int>();

            //numeros.Add(1);

            //numeros.Add(2);

            //numeros.Add(3);

            //for(int i = 0; i < numeros.Count; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}

            int elem;

            Console.WriteLine("Ingrese un numero");

            elem = Convert.ToInt32(Console.ReadLine());

            while (elem != 0)
            {
                
                numeros.Add(elem);

                Console.WriteLine("Ingrese un numero");
                elem = Convert.ToInt32(Console.ReadLine());

            }

            //me saca el ultimo numero
            numeros.RemoveAt(numeros.Count-1);

            foreach(int num in numeros)
            {
                Console.WriteLine(num);
            }
        }
    }
}

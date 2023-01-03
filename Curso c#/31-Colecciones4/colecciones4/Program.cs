namespace colecciones4
{
    class Program
    {
        static void Main()
        {
            //Stack<int> numeros = new Stack<int>();

            //foreach (int numero in new int[5] { 2, 3, 4, 5, 7 })
            //{
            //    numeros.Push(numero);
            //}

            ////agregar nueros al queue
            //foreach (int numero in numeros)
            //{
            //    Console.WriteLine(numero);
            //}

            ////eliminar elementos del queue
            // numeros.Pop();

            ////elimina el ultimo numero que se inserto, osea el 7
            //foreach (int numero in numeros)
            //{
            //    Console.WriteLine(numero);
            //}



            //dictionary
            Dictionary<string, int> edades = new Dictionary<string, int>();

            //agregar elementos
            edades.Add("nicolas", 24);

            edades["tefi"] = 23;

            //recorrer elementos 
            foreach(KeyValuePair<string,int> persona in edades)
            {
                Console.WriteLine("Nombre: "+persona.Key + " Edad: "+persona.Value);
            }


        }
    }
}

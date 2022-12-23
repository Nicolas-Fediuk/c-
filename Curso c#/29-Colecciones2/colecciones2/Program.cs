namespace colecciones2
{
    class Program
    {
        static void Main()
        {
            //likeList se usa para cuando tenemos que modificar, eliminar o dar alta los elementos a diferencia de list

            LinkedList<int> list = new LinkedList<int>();   


            foreach(int numero in new int[] { 1, 2, 3, 4, 5 })
            {
                list.AddFirst(numero);
            }

            //foreach(int numero in list)
            //{
            //    Console.WriteLine(numero);
            //}

            //para eliminar un elemento 
            list.Remove(3);

            //para ver el resultado
            for(LinkedListNode<int> nodo = list.First; nodo!=null; nodo = nodo.Next)
            {
                int numero = nodo.Value;

                Console.WriteLine(numero);
            }
        }
    }
}

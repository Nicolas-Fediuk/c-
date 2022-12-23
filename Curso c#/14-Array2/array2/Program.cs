using System.Text;

namespace array2
{
    class Program
    {
        static void Main()
        {
            //int[] numeros = new int[4];
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    numeros[i] = i;
            //}
            //ProcesoDatos(numeros);

            //foreach(int i in numeros)
            //{
            //    Console.WriteLine(i);
            //}

            int[] arrayElementos = leerDatos();

            foreach(int e in arrayElementos)
            {
                Console.WriteLine(e);
            }
        }

        static void ProcesoDatos(int[] datos)
        {
            //para ver los datos 

            //foreach (int dato in datos)
            //{
            //    Console.WriteLine(dato);
            //}

            //

            //for(int i = 0; i < datos.Length; i++)
            //{
            //    datos[i] += 10;
            //}

            
        }

        static int[] leerDatos()
        {
            Console.WriteLine("Ingrese la cantidad de elementos");

            int respuesta = Convert.ToInt16(Console.ReadLine());

            int[] datos = new int[respuesta];

            for (int i = 0; i < datos.Length; i++)
            {
                Console.WriteLine($"Introduce el valor en la posicion {i}");

                datos[i] = Convert.ToInt16(Console.ReadLine());
            }
            return datos;
        }

    }
}

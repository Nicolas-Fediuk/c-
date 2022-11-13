using System.Diagnostics.CodeAnalysis;

namespace metodos1
{
    class Program
    {
        static void Main()
        {
            hola(1,2);

            Console.WriteLine(suma(1, 2));
        }

        //asi cuando solo tiene una linea de codigo
        //el numero de abajo "1 referencia" es las catidades de veces que se llama al metodo
        static void hola(int n1,int n2) => Console.WriteLine($"hola: {n1+n2}");

        //cuando el parametro tiene una asignacion es porque es parametro es opcional, siempre al final
        static int suma(int n1, int n2, int n3 = 0)
        {
            return n1 + n2 + n3;
        }

        //sobrecarga de paraetros es cuando dos metodo tienen en mismo nombre
        //pero distintas cantidades de parametros o de distinto tipo


        
    }
}
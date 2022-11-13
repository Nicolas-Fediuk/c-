namespace excepciones2
{
    class Program
    {
        static void Main()
        {

            int numero1 = 0;
            int numero2 = 0;

            try
            {
                numero1 = Convert.ToInt16(Console.ReadLine());
                numero2 = Convert.ToInt16(Console.ReadLine());
            }

            //traeme toda las excepciones cuando el tipo de excepcion sea diferente de FormatException (cuando el tipo de dato ingresado no coincide con el tipo de la variable)
            catch (Exception ex) when (ex.GetType() != typeof(FormatException))
            {
                numero1 = 0;
                numero2 = 0;
                Console.WriteLine($"Error: {ex.Message}");
            }

            //con el filtro de arriba podemos dar un trato especial a las excepciones, como este
            catch(FormatException ex)
            {
                Console.WriteLine($"ingrese un numero por favor");
                numero1 = 0;
                numero2 = 0;
            }

            int resultado = numero1 + numero2;


            Console.WriteLine($"Resultado: {resultado}");

            int numero3 = int.MaxValue;
            //me muestra el numero maximo que puede tomar el tipo de varible 
            Console.WriteLine(numero3);

            //si hay una excepcion de desbordamiento que no siga ejecutnado el programa
            // solo con int y long funciona
            checked
            {
                //le sumo 20 al numero maximo
                int numero4 = numero3 + 20;
                Console.WriteLine(numero4);
            }
            // o int numero4 = checked(numero3 + 20);

            //o para no verificar int numero4 = unchecked(numero3 + 20);


        }
    }
}
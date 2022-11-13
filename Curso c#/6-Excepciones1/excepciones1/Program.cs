namespace excepciones1
{
    class Program
    {
        static void Main()
        {
            /* Las excepciones son errores en tiempo de ejcuccion del programa que escapan al control del
             programador.
            Ej: Conexiones a BBDD interrumpidas, etc. Es como saltarnos el error y seguir adelante, o mostrarlo*/
            // ty = intenta
            // catch = captura
            int numero1 = 0;
            int numero2 = 0;

            try
            {
                //que intente ejecutar ese te codigo
                //codigo que se intenta
                numero1 = Convert.ToInt16(Console.ReadLine());
                numero2 = Convert.ToInt16(Console.ReadLine());
            }
            catch (Exception ex)
            {
                // si no que ejecute este y muestre el error
                // codigo que se ejecuta si hay excepcion
                numero1 = 0;
                numero2 = 0;
                Console.WriteLine($"Error: {ex.Message}");
            }

            int resultado = numero1 + numero2;


            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}

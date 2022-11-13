namespace excepciones3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("ingrese un numero del mes");
            int mes = Convert.ToInt16(Console.ReadLine());

            try
            {
                Console.WriteLine(nombreDelMes(mes));
            }
            catch(Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
            }
            
            Console.WriteLine("Aqui continuariaa la ejecucion del programa");
        }

        public static string nombreDelMes(int mes)
        {
            switch(mes){
                case 1: return "enero";
                case 2: return "febrero";
                case 3: return "marzo";
                case 4: return "abril";
                case 5: return "mayo";
                case 6: return "junio";
                case 7: return "julio";
                case 8: return "agosto";
                case 9: return "septiembre";
                case 10: return "octubre";
                case 11: return "noviembre";
                case 12: return "diciembre";

                //thorow = lanzar 
                //se pueden generar excepciones cuando se desee 
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}

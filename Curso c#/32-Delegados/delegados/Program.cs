namespace delegados
{
    class Program
    {
        static void Main()
        {
            //Delegados: Son funciones que delegan tareas en otras funciones. Es una referencia a un metodo 

            //Se utilizan para llamar evento

            ObjetoDelegado del = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);

            del("Hola bienvenido");

            del = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);

            del("chau hasta luego");
        }

        //definicion del delegado 

        delegate void ObjetoDelegado(string mensaje);

    }

    class MensajeBienvenida
    {
        public static void SaludoBienvenida(string mensaje)
        {
            Console.WriteLine("Mensaje: "+mensaje);
        }
    }

    class MensajeDespedida
    {
        public static void SaludoDespedida(string mensaje)
        {
            Console.WriteLine("Mensaje "+mensaje);
        }
    }
}
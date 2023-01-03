namespace predicadicadosDelegadosEjemplo2
{
    class Program
    {
        static void Main()
        {
            List<Personas> gentes = new List<Personas>();

            Personas p1 = new Personas();
            p1.Nombre = "nicolas";
            p1.Edad = 24;

            Personas p2 = new Personas();
            p2.Nombre = "andrea";
            p2.Edad = 50;

            Personas p3 = new Personas();
            p3.Nombre = "sergio";
            p3.Edad = 52;

            gentes.AddRange(new Personas[] { p1, p2, p3 });

            Predicate<Personas> predicado = new Predicate<Personas>(DarNico);

            bool existe = gentes.Exists(predicado);

            if(existe)
            {
                Console.WriteLine("Existe");
            }
        }

        static bool DarNico(Personas persona)
        {
            if(persona.Nombre == "nicolas") return true;
            return false;
        }
    }

    class Personas
    {
        private int edad;
        private string nombre;

        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}

namespace lambda
{
    class Program
    {
        static void Main()
        {
            //lambda son funciones anonima
            //sirven para ejecutar funciones que no necesitan ser nombradas 
            //se usan en delegados sencillos y en linkq


            //List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //List<int> numerosPares = numeros.FindAll(i => i % 2 == 0);

            //numerosPares.ForEach(numerosPares => { Console.WriteLine("numero par: "); Console.WriteLine(numerosPares); });


            Personas p1 = new Personas();
            p1.Nombre = "Nicolas";
            p1.Edad = 34;

            Personas p2 = new Personas();
            p2.Nombre = "Andrea";
            p2.Edad = 52;

            ComparaPersona comprarEdad = (persona1,persona2) => persona1 == persona2;

            Console.WriteLine(comprarEdad(p1.Edad, p2.Edad));


        }

        public delegate bool ComparaPersona(int edad1, int edad2);
    }

    class Personas
    {
        private int edad;

        private string nombre;

        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }

}

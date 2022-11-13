namespace array1
{
    class Program
    {
        static void Main()
        {
            int[] edades;

            edades = new int[4];

            for(int i=0; i < edades.Length; i++)
            {
                edades[i] = i;
                Console.WriteLine(edades[i]);
            }

            int[] edades2 = { 12, 23, 45, 56 };

            foreach(int e in edades2)
            {
                Console.WriteLine(e);
            }

            //array implicito
            var nombres = new[] {"nico","fediuk"};

            //array de objetos
            Empleados[] arrayEmpleados = new Empleados[2];

            arrayEmpleados[0] = new Empleados("nicoas", 12);

            //array de tipo o clases anonimas
            var personas = new[] {
                new {Nombre = "nicolas", edad = 23},
                new {Nombre = "andrea", edad = 45}
            };
        }
    }

    class Empleados
    {
        private string nombre;
        private int edad;
        public Empleados(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
    }
} 

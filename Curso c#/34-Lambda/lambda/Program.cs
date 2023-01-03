namespace lambda
{
    class Program
    {
        static void Main()
        {
            //lambda son funciones anonima
            //sirven para ejecutar funciones que no necesitan ser nombradas 
            //se usan en delegados sencillos y en linkq


            //uso del delegado

            Omatematica om = new Omatematica(num => num*num);

            SumaMatematica om2 = new SumaMatematica((num1,num2) => num1+num2);

            Console.WriteLine(om(4));

            Console.WriteLine(om2(2,2));


        }

        public delegate int Omatematica(int num);

        public delegate int SumaMatematica(int num1, int num2);

        //public static int cuadrado(int num)
        //{
        //    return num * num;
        //}

        //public static int suma(int num1, int num2)
        //{
        //    return num1 + num2; 
        //}
    }

    class Personas
    {
        private int edad;

        private string nombre;

        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }

}
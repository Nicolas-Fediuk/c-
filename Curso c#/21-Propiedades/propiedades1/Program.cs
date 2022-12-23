namespace propiedades1
{
    class Program
    {
        static void Main()
        {
            Empleado em = new Empleado("nico");

            em.SALARIO = 1200;

            Console.WriteLine($"El salario es de: {em.SALARIO}");
        }
    }

    class Empleado
    {
        private string nombreEmpleado;
        private double salario;

        //Creacion de propiedad: Se usan en ocaciones especiales para modificar valores de los atributos mas facil, condiciones
        // y obtenter valores 

        //public double SALARIO
        //{
        //    get { return this.salario; }
        //    set { this.salario = evaluarSalario(value); }
        //}

        //expresion body, de manera mas resumida que la de arriba

        public double SALARIO
        {
            //puede ser de solo lectura (solo get), o solo escritura (solo set), si se decea 
            get => this.salario;

            set => this.salario = evaluarSalario(value);
        }
        public Empleado(string nombreEmpleado)
        {
            this.nombreEmpleado = nombreEmpleado;
        }

        //public void SetSalario(double salario)
        //{
        //    if(salario < 0)
        //    {
        //        Console.WriteLine("El salario no puede ser menor a 0");
        //        this.salario = 0;
        //    }
        //    else
        //    {
        //        this.salario = salario; 
        //    }
        //}

        //public double GetSalario()
        //{
        //    return salario;
        //}

        private double evaluarSalario(double salario)
        {
            if (salario < 0) return 0;
            else return salario;
        }






    }
}
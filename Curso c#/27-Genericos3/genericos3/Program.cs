namespace genericos3
{
    class Program
    {
        static void Main()
        {
            AlmacenEmpleados<Director> empDirec = new AlmacenEmpleados<Director>(3);

            empDirec.Agregar(new Director(200));

            empDirec.Agregar(new Director(300));

            empDirec.Agregar(new Director(400));


            AlmacenEmpleados<Director> empSec = new AlmacenEmpleados<Director>(3);

            empSec.Agregar(new Director(200));

            empSec.Agregar(new Director(300));

            empSec.Agregar(new Director(400));

            //error porque la clase estudiante no hereda la interfaz 
            //AlmacenEmpleados<Estudiante> empEs = new AlmacenEmpleados<Estudiante>(3);
        }
    }

    //clase generica que solo puede utilizar objetos que implementen la interfaz de empleado 
    class AlmacenEmpleados<T> where T : Iempleado
    {
        private int i = 0;

        private T[] datosEmpleados;

        public AlmacenEmpleados(int z)
        {
            datosEmpleados = new T[z];
        }

        public void Agregar(T obj)
        {
            datosEmpleados[i] = obj;


            i++;
        }

        public T getEmpledo(int i)
        {
            return datosEmpleados[i];
        }
    } 

    class Director : Iempleado
    {
        private double salario;
        public Director(int salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario;
        }

    }

    class Secretaria : Iempleado
    {
        private double salario;
        public Secretaria(int salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario;
        }
    }

    class Electricista : Iempleado
    {
        private double salario;
        public Electricista(int salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario;
        }
    }

    class Estudiante
    {
        private double edad;

        public Estudiante(double edad)
        {
            this.edad = edad;
        }
        
        public double getEdad()
        {
            return edad;
        }
    }
}

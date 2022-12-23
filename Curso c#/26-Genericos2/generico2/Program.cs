namespace generico2
{
    class Program
    {
        static void Main()
        {

            AlmacenObjetos<Empleado> a = new AlmacenObjetos<Empleado>(5);

            //a.agregar("nico");

            //a.agregar("tefi");

            //a.agregar("andre");

            //a.agregar("ser");

            //Console.WriteLine(a.getElemento(2));


            a.agregar(new Empleado(200));


            Empleado salario = a.getElemento(4);

            Console.WriteLine(salario.getSalario());
        }
    }

    //CLASES QUE TRABAJA CON CUALQUIER TIPO DE DATO 
    class AlmacenObjetos <T>
    {

        private T[] datoElementos;

        private int i = 0;
        public AlmacenObjetos(int z)
        {

            datoElementos = new T[z];
        }

        //AGREGAR CUALQUIER TIPO DE DATO
        public void agregar( T obj)
        {

            datoElementos[i] = obj;

            i++;
        }

        //DEVUELVE CUALQUIER TIPO DE DATO
        public T  getElemento(int i)
        {
            return datoElementos[i];
        }
    }

    class Empleado
    {
        private double salario;

        public Empleado(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario;
        }
    }
}
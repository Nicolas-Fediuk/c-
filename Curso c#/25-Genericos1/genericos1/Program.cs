namespace genericos1
{
    class Program
    {
        static void Main()
        {
            //creo una instancia y se asigno 5 el tamaño del vector
            AlmacenObjetos a = new AlmacenObjetos(5);

            a.agregar("nico");

            a.agregar("tefi");

            a.agregar("andre");

            a.agregar("ser");

            //muestro andre
            Console.WriteLine(a.getElemento(2));

            //agregar un dato de tipo emmplado con el salario de 200
            a.agregar(new Empleado(200));

            //guardo en una variable el return del dato de tipo empleado 
            Empleado salario = (Empleado)a.getElemento(4);

            //muestro el salario 
            Console.WriteLine(salario.getSalario());
        }
    }

    class AlmacenObjetos
    {
        //creo una variable de tipo objeto vector
        private Object[] datoElementos;

        private int i = 0;
        public AlmacenObjetos(int z)
        {
            //creo un constructor para pasarle por parametro el tamaño del vector
            datoElementos = new Object[z];
        }

        public void agregar(object obj)
        {
            //aca en la posicion de i le agrego lo que quiera
            datoElementos[i] = obj;

            //sumo uno a i para que se vayan guardando los datos
            i++;
        }

        public Object getElemento(int i)
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
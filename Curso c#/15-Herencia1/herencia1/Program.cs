using System.Runtime;

namespace herencia1
{
    class Program
    {
        //El polimorfimos es la capacidad que tiene POO de comportarse de diferentes formas, o tener 
        //direferentes formas dependiendo del contexto. El metodo de una clase, se puede cambiar en 
        // un metodo de una subclase (con el mismo nombre)
        //Poli = muchas
        //Morfismo = formas
        //encapsulamiento= las variables solo pueden ser usadas en la propia clase 
        static void Main()
        {
            Caballo c = new Caballo("juan");

            Humano h = new Humano("nico");

            Gorila g = new Gorila("hechita");

            //h.getNombre();

            // un humano es siempre un mamifero, y un mamifero no siempre es un humano 
            Mamiferos m2 = new Humano("Leo");

            //arreglo
            Mamiferos[] m3 = new Mamiferos[3];

            m3[0] = h;

            m3[1] = g;

            m3[2] = c;

            //m3[0].getNombre();
            
            for(int i = 0; i < m3.Length; i++)
            {
                m3[i].pensar();
            }
            c.pensar();
        }               
    }

    //superclase
    class Mamiferos
    {
        private string nombreSerVivo;

        public Mamiferos(string nombre)
        {
            nombreSerVivo = nombre;
        }
        public void respirar()
        {
            Console.WriteLine("respiro");
        }

        //vitual indica que todas las subclases de Mamifero (humano caballo,etc), pueden modificar este metodo
        //para que se adapte a cada clase 
        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento basico");
        }
        public void cuidarCriar()
        {
            Console.WriteLine("cuido a mis crias");
        }

        //protected = este metodo solo puede ser accesible desde esta clase, y de las clases heredaras 
        protected void getNombre()
        {
            Console.WriteLine("Nombre del ser vivo: " + nombreSerVivo);
        }
    }

    //hereda los metodos de mamifero
    class Caballo : Mamiferos
    {

        //usar el constructor de la clase padre
        public Caballo(string nombreCaballo):base(nombreCaballo)
        {
            
        }
        public void galopar()
        {
            Console.WriteLine("galopo");
        }
    }

    class Humano : Mamiferos
    {

        public Humano(string nobreHummano) : base(nobreHummano)
        {

        }


        //la clase mamifero ya tiene un metodo pensar igual a este, estonces con el new adelante le decimmos
        //que oculte el metodo de la clase principal e usa este metodo de la clase humano

        //new public void pensar()
        //{
        //    Console.WriteLine("Pienso");
        //}

        //para modificar el metodo pensar de la clase mamifero qie tiene virtual 
        public override void pensar()
        {
            Console.WriteLine("Pienso");
        }
    }

    class Gorila : Mamiferos
    {

        public Gorila(string nombreGorila) : base(nombreGorila)
        {

        }

        public override void pensar()
        {
            Console.WriteLine("pensamiento instintivo avanzado");
        }
        public void trepar()
        {
            Console.WriteLine("Trepo");
        }
    }
}
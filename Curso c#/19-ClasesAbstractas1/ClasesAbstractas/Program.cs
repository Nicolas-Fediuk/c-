namespace ClasesAbstractas
{
    class Program
    {
        static void Main()
        {
            Reptil r = new Reptil("carlo");
            r.respirar();
            r.getNombre();

            Humano h = new Humano("nik");
            h.respirar();
            h.getNombre();
        }

        interface IMamiferosTerrestres
        {
            int NumeroPatas();

        }
        interface IAnimalesDeportes
        {
            string TipoDeporte();
            bool esOlimpico();
        }
        interface IsaltosConPata
        {
            int NumeroPatas();
        }

        //esta clase sera la principal 
        //en las clases abtrasctas podes desarrollaar metodos y pasarlos a las subclases, las intefaces no
        //
        abstract class Animales
        {
            public void respirar()
            {
                Console.WriteLine("respiro");
            }

            //es como una interfaz, para que los metodos puedan modificarla a sus necesidades 
            public abstract void getNombre();
        }

        class Reptil : Animales
        {
            private string nombreReptil;


            public Reptil(string nombreReptil)
            {
                this.nombreReptil = nombreReptil;
            }

            public override void getNombre()
            {
                Console.WriteLine("Soy una lagartija y me llamo: "+ nombreReptil);
            }
        }
        class Mamiferos : Animales
        {
            private string nombreSerVivo;

            public Mamiferos(string nombre)
            {
                nombreSerVivo = nombre;
            }

            public virtual void pensar()
            {
                Console.WriteLine("Pensamiento basico");
            }
            public void cuidarCriar()
            {
                Console.WriteLine("cuido a mis crias");
            }

            //para usar y desarrollamos el metodo de la clase principal
            public override void getNombre()
            {
                Console.WriteLine("Nombre del maminefero es: " + nombreSerVivo);
            }
        }

        class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesDeportes, IsaltosConPata
        {

            public Caballo(string nombreCaballo) : base(nombreCaballo)
            {

            }
            public void galopar()
            {
                Console.WriteLine("galopo");
            }

            int IMamiferosTerrestres.NumeroPatas()
            {
                return 4;
            }
            int IsaltosConPata.NumeroPatas()
            {
                return 2;
            }
            public string TipoDeporte()
            {
                return "Carreras";
            }
            public bool esOlimpico()
            {
                return false;
            }
        }

        class Humano : Mamiferos
        {

            public Humano(string nobreHummano) : base(nobreHummano)
            {

            }

            public override void pensar()
            {
                Console.WriteLine("Pienso");
            }
        }

        class Gorila : Mamiferos, IMamiferosTerrestres
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

            public int NumeroPatas()
            {
                return 2;
            }
        }

        class Ballena : Mamiferos
        {
            public Ballena(string nombreBallena) : base(nombreBallena)
            {

            }

            public void nadar()
            {
                Console.WriteLine("Nado");
            }

        }
    }
}
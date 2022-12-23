namespace interfaces1
{
    class Program
    {
        static void Main()
        {
            Ballena ballena = new Ballena("lola");
            ballena.nadar();

            Caballo caballo = new Caballo("pepo");
            IMamiferosTerrestres Icaballo = caballo;
            IsaltosConPata IsaltoCaballo = caballo;
            Console.WriteLine("Cantidad de patas del caballo: "+Icaballo.NumeroPatas());
            Console.WriteLine("Y salta con el numero de patas: " + IsaltoCaballo.NumeroPatas());
        }
        //podemos ahcer que una clase herede de una interfaz 
        //las interfaces son parecidos a las clases, tienen las declaracion de un metodo sin completar 
        //defienen las directrices o comprotamiento que deben de seguir las clases o que heredan de esa interfaz 
        //es como un plantilla que indica el diseño de la herencia y el comportamiento que van a heredar las clases 


        //aca se tiene que crear un metodo en mamiferos para ingresar el numero de patas, pero las ballenas no tiene patas,
        //entonces se crea una interfaz
        //en las interfaces no se puede definir vearibles, constructores, destructores, ni modificadores de acceso
        interface IMamiferosTerrestres
        {
            //metodo
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

            public virtual void pensar()
            {
                Console.WriteLine("Pensamiento basico");
            }
            public void cuidarCriar()
            {
                Console.WriteLine("cuido a mis crias");
            }
            public void getNombre()
            {
                Console.WriteLine("Nombre del ser vivo: " + nombreSerVivo);
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

            //la interfaz permite que la clase genere el metodo a su manera 
            //obligas a la clase que tenga este metodo 

            //para cuando hay dos intefaces con el mismo nombre del metodo 
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

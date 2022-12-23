namespace ClasesSelladas
{
    class Program
    {

        static void Main()
        {

        }
        

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

            //los metodos sellados no se pueden sobreescribir o heredar de las subclases 
            sealed public override void pensar()
            {
                Console.WriteLine("Pienso");
            }
        }

        class Adolecente : Humano
        {
            public Adolecente(string nombreAdolecente) : base(nombreAdolecente)
            {

            }

            public override void pensar()
            {
                Console.WriteLine("no puedo pensar");
            }
        }

        //una clase sellada es aquella que no se podra heredar nada de esta 
        sealed class Gorila : Mamiferos, IMamiferosTerrestres
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

        class Chimpace : Gorila
        {
            public Chimpace(string nombreChimpace) : base(nombreChimpace)
            {

            }
            


        }

    }
}

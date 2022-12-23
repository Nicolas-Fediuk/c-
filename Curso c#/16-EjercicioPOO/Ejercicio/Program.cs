namespace Ejercicio
{
    class Program
    {
        static void Main()
        {
            Avion avion = new Avion();
            avion.Conducir();
        }

        class Vehiculo
        {
            public void ArrancarMotor()
            {
                Console.WriteLine("ENcender el motor");
            }

            public void PararMotor()
            {
                Console.WriteLine("Apagar el motor");
            }

            public virtual void Conducir()
            {
                string forma = "Por el agua";
                Console.WriteLine($"Conducir: {forma}");
            }
        }

        class Avion : Vehiculo
        {
            public void Tecnicaura()
            {
                Console.WriteLine("Aprender a volar, 7 años");
            }

            public override void Conducir()
            {
                string andar = "Por el aire";
                Console.WriteLine($"Pilotar: {andar}");
            }


        }

        class Coche : Vehiculo
        {

        }
    }
}

namespace poo1
{
    class Program
    {
        static void Main()
        {
            //modularizacion = separar el programa complejo en modulos
            //Emcapsulamiento = las clases o modules se bloquean para que otra no pueda ver su funcionamiento interno
            //Herencia = se heredan las propiedade
            //polimorfismo

            //Public = PascalCase
            //Private = camelCase

            //c = objeto
            circulo c = new circulo();
            double total = c.calculoArea(5);
            //Console.WriteLine(total);

            ConversorEuroDola conversor = new ConversorEuroDola();

            conversor.CambiarValor(4);

            Console.WriteLine(conversor.Convierte(50));


        }
    }

    class circulo
    {
        //Propiedades 
        private const double PI = 3.1416;

        //Metodos
        public double calculoArea(int radio)
        {
            return PI * radio * radio;
        }
    }

    class ConversorEuroDola{

       private double euro = 1.50;

        public double Convierte(double cantidad)
        {
            return cantidad * euro;
        }

        public void CambiarValor(double valor)
        {
            euro = valor;
        }
    }
}
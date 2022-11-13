using System.Runtime.CompilerServices;

namespace poo2
{
    class Program
    {
        static void Main()
        {
            coche c = new coche();

            //Console.WriteLine(c.GetRuedas());

            coche c2 = new coche(5,345,23,true,"si");

            //Console.WriteLine(c2.GetRuedas());

            coche c3 = new coche();
            c3.setExtras(true, "honda");
            Console.WriteLine(c3.getExtra());
        }

        
    }


    //partial =  sirve para partir una clase en 2, pero es como tener todo en una sola
    partial class coche
    {
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;

        public coche()
        {
            ruedas = 4;
            ancho = 0.800;
            largo = 2300.5;
            tapiceria = "tela";
        }

        public coche(int ruedas, double largo, double ancho, bool climatizador, string tapiceria)
        {
            this.ruedas = ruedas;
            this.largo = largo;
            this.ancho = ancho;
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }

    }

    partial class coche
    {
        public string GetMostrarDatos()
        {
            return "Informacion del coche\nRuedas: " + ruedas.ToString() + " Largo: " + largo.ToString() + " Ancho: " + ancho.ToString();
        }

        //los set dan valor y no devuelve valor, solo dar
        public void setExtras(bool climatizador, string tapizaria)
        {
            //this = cuando quiero hacer referencia a un campo de clase para direfenciar de un parametro
            this.climatizador = climatizador;
            this.tapiceria = tapizaria;
        }
        public string getExtra()
        {
            return "Extras del coche: \n" + "Tapizeria: " + tapiceria + " Climatizacion: " + climatizador;
        }
    }
}

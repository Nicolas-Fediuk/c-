namespace Emun
{
   // enum Estaciones { Otoño, Invierno, Primavera, Verano}

    enum Bonus { bajo=500, normal=1000, bueno=1500, alto=3000};
    class Program
    {
        static void Main()
        {
            //los emun son conjunto de nombres constantes

            //sintaxis: enum NombreDeEnumeracion {nombre1,nombre2,nombre3...}

            //sirve para representar y manejar valores fijos (constantes) 

            //Estaciones alergia = Estaciones.Primavera;

            //Console.WriteLine(alergia);

            /**********************************/

            //Bonus Nico = Bonus.alto;

            //int salarioBase = 1000;

            //double valor = (double)Nico + salarioBase;

            //Console.WriteLine(valor);

            /**********************************/

            Empleado em = new Empleado(Bonus.alto, 1000);

            Console.WriteLine("Salario: " + em.getSalario());
        }

        class Empleado
        {
            private double salario, bonus;
            public Empleado(Bonus bonus, double salario)
            {
                this.salario = salario;
                this.bonus = (double)bonus;
            }

            public double getSalario()
            {
                return salario + bonus;
            }
        }
    }
}

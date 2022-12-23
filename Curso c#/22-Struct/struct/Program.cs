namespace structs
{
    class Program
    {
        static void Main()
        {
            Empleado em = new Empleado(2000, 10);

            em.CambiarSalario(em, 100);

            Console.Write(em);
        }
    }
    //struct utiliza la memoria Stack y class la heap

    //stack es mas rapido, y lo que se alamacena es temporal, la heap es todo al reves 

    // las struct no permite la declacion de constructores, ni heredar 

    // se usan para trabajar con grandes datos en la memoria, ya que es mas rapido 

    //public struct Empleado
    public class Empleado
    {
        public double salarioBase, comision;

        public Empleado(double salarioBase, double comision)
        {
            this.salarioBase = salarioBase;
            this.comision = comision;
        }

        public override string ToString()
        {
            return String.Format($"Salario: {this.salarioBase}, Comision: {this.comision}");
        }

        public void CambiarSalario(Empleado em, double incremento)
        {
            em.salarioBase += incremento;

            em.comision += incremento;
        }
    }

}

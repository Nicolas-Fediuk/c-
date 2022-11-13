using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo3
{
    internal class Punto
    {
        private int x;
        private int y;
        //static: algo que no cambia
        private static int contadorDeObjetos = 0;
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;

            contadorDeObjetos++;
        }

        public Punto()
        {
            this.x = 0;
            this.y = 0;

            contadorDeObjetos++;
        }

        public static int ContadorObj()
        {
            return contadorDeObjetos;
        }

        public double DistanciaHasta(Punto p)
        {
            int xDif = this.x - p.x;

            int yDif = this.y - p.y;

            double total = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));

            return total;
        }
    }
}

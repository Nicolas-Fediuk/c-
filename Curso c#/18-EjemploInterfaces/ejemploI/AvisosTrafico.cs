using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploI
{
    internal class AvisosTrafico : IAvisos
    {
        private string remitente;
        private string mensaje;
        private string fecha;

        public AvisosTrafico()
        {
            remitente = "DGT";
            mensaje = "multa";
            fecha = "";
        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }
        public void MostrarAviso()
        {
            Console.WriteLine($"Mensaje: {mensaje}, Remitente: {remitente}, fecha: {fecha}");
        }

        public string GetFecha()
        {
            return fecha;
        }
    }
}

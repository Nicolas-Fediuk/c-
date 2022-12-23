using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploI
{
    //se desarrolla la interfaz para metodos que va a usar si o si 
    internal interface IAvisos
    {
        void MostrarAviso();

        string GetFecha();
    }
}

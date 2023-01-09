﻿namespace linq2
{
    class Program
    {
        static void Main()
        {
            ControlEmpresaEmpleados cee = new ControlEmpresaEmpleados();
            cee.getCeo();
        }
    }

    class ControlEmpresaEmpleados
    {
        List<Empresa> ListaEmpresa;
        List<Empleado> ListaEmpleado;

        public ControlEmpresaEmpleados()
        {
            ListaEmpresa = new List<Empresa>();
            ListaEmpleado = new List<Empleado>();

            ListaEmpresa.Add(new Empresa { nroEmpresa = 1, nombreEmpresa = "google" });
            ListaEmpresa.Add(new Empresa { nroEmpresa = 2, nombreEmpresa = "microsoft" });

            ListaEmpleado.Add(new Empleado { nroEmpleado = 1, nombreEmpleado = "nicolas", cargo = "CEO", salario = 123, idEmpresa = 1 });
            ListaEmpleado.Add(new Empleado { nroEmpleado = 2, nombreEmpleado = "ana", cargo = "CEO", salario = 12, idEmpresa = 1 });
            ListaEmpleado.Add(new Empleado { nroEmpleado = 3, nombreEmpleado = "leo", cargo = "co-CEO", salario = 1234, idEmpresa = 2 });
            ListaEmpleado.Add(new Empleado { nroEmpleado = 4, nombreEmpleado = "dani", cargo = "co-CEO", salario = 127, idEmpresa = 2 });
        }

        public void getCeo()
        {
            IEnumerable<Empleado> ceos = from empleado in ListaEmpleado where empleado.cargo == "CEO" select empleado;

            foreach(Empleado i in ceos)
            {
                i.getEmpleado();
            }
        }
    }
    class Empresa
    {
        public int nroEmpresa { set; get; }
        public string nombreEmpresa { set; get; }

       
        public string getEmpresa()
        {
            return "Numero: "+nroEmpresa+" Nombre: "+nombreEmpresa;
        }
    }

    class Empleado
    {
        public int nroEmpleado { set; get; }
        public string nombreEmpleado { set; get; }
        public string cargo { set; get; }
        public double salario { set; get; }

        public int idEmpresa { get; set; }

        public void getEmpleado()
        {
            Console .WriteLine(nroEmpleado + nombreEmpleado+ cargo+ salario+ idEmpresa);
        }
    }

    
}
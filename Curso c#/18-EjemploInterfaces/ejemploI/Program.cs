namespace ejemploI
{
    class Program
    {
        static void Main()
        {
            AvisosTrafico at = new AvisosTrafico();

            at.MostrarAviso();

            AvisosTrafico at2 = new AvisosTrafico("Carlos","multa loca","22/07/1999");

            at2.MostrarAviso();
        }
    }
}

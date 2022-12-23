namespace destructores
{
    class Program
    {
        static void Main()
        {
            ManejoArchivos m = new ManejoArchivos();

            m.mensaje();
        }

        //el destructior se usa para limpiar la memoria como por ejemplo: conexioes a base de datos, cerrar arhivos, etc 
        class ManejoArchivos
        {
            StreamReader archivo = null;

            int contador = 0;

            string linea;

            public ManejoArchivos()
            {
                archivo = new StreamReader(@"C:\Users\nfediuk\Desktop\pruebaDes.txt");

                while((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);

                    contador++;
                }
            }

            public void mensaje()
            {
                Console.WriteLine("hay lineas: "+contador);
            }

            ~ManejoArchivos() { 
                archivo.Close();
            }
        }
    }

    

}

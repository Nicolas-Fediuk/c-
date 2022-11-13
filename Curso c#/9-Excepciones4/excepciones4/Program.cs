namespace excepciones4
{
    class Program
    {
        static void Main()
        {
            //finally: se ejecuta por mas que pase por un try o un catch
            System.IO.StreamReader archivo = null;

            try
            {
                string linea;
                int contaador = 0;

                string path = @"C:\Users\nfediuk\Desktop\c#.txt";

                archivo = new System.IO.StreamReader(path);

                while((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);

                    contaador++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
            }
            finally
            {
                if(archivo != null) archivo.Close();
                
                Console.WriteLine("fichero cerrado");    
            }
        }
    }
}

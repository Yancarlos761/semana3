using System;

namespace grados_radianes
{
    class Program
    {
        static void Main(string[] args)
        {
            string l;
            Double n, y;
            Console.WriteLine("grados o radianes?");
            l = Console.ReadLine();
                Console.WriteLine("Ingrese cantidad");
                n = Double.Parse(Console.ReadLine());
            if (l == "grados") 
            {
                y = ((Double)n * 0.0175);
                    Console.WriteLine("Cantidad en grados convertida a radianes: " + y);
            }

            else { 
                y = ((Double)n * 57.296);
                Console.WriteLine("Cantidad radianes conertida a grados: " + y);
            }
        }
    }
}

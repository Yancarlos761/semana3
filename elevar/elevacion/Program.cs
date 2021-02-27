using System;

namespace elevacion
{
    class Program
    {
        static int potenciaRecursiva(int b, int exponente)
        {
            if (exponente == 0)
                return 1;
            else
                return b * potenciaRecursiva(b, exponente - 1);
        }
        static void Main(string[] args)
        {
            int b, exponente;
            Console.WriteLine("ingrese la base: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el exponente: ");
            exponente = int.Parse(Console.ReadLine());

            Console.WriteLine("La potencia es de: " + potenciaRecursiva(b, exponente));
            Console.ReadKey();
        }
    }
}

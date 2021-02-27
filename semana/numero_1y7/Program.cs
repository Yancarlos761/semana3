using System;

namespace dias_de_la_semana
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("elija un numero de 1 a 7");
            n = int.Parse(Console.ReadLine());
            if(n==1)
            {
                Console.Write("LUNES");
            }

            if (n == 2)
            {
                Console.Write("MARTES");
            }
            if (n == 3)
            {
                Console.Write("MIERCOLES");
            }

            if (n == 4)
            {
                Console.Write("JUEVES");
            }
            if (n == 5)
            {
                Console.Write("VIERNES");
            }

            if (n == 6)
            {
                Console.Write("SABADO");
            }
            if (n == 7)
            {
                Console.Write("DOMINGO");
            }

   
        }
    }
}

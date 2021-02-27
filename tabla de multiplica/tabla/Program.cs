using System;

namespace tabla
{
    class Program
    {
        static void Main(string[] args)
        {
            float m, y;
            Console.WriteLine("ingrese un numero");
            m = float.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                y = (float) (m * i);
                Console.WriteLine($"tabla de {m} y {i} = " + y);
            }
            Console.ReadKey();
        }
    }
}

using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string y;
            float x, a, t;
            Console.WriteLine("que quiere calcular (cuadrado, triangulo, rectangulo)");
            y= Console.ReadLine();
            if(y== "triangulo")
            {
                Console.WriteLine("Ingrese base");
                x = float.Parse(Console.ReadLine());
                Console.WriteLine("ingrese altura");
                a = float.Parse(Console.ReadLine());
                t = (float)(x * a / 2);
                Console.WriteLine("Area es igual a: " + t);
            }

            if (y == "cuadrado")
            {
                Console.WriteLine("Ingrese base");
                x = float.Parse(Console.ReadLine());
                Console.WriteLine("ingrese altura");
                a = float.Parse(Console.ReadLine());
                t = (float)(x * a);
                Console.WriteLine("Area es igual a: " + t);
            }

            if (y == "rectangulo")
            {
                Console.WriteLine("Ingrese base");
                x = float.Parse(Console.ReadLine());
                Console.WriteLine("ingrese altura");
                a = float.Parse(Console.ReadLine());
                t =(float) (x * a);
                Console.WriteLine("Area es igual a: " + t);
            }
        }
    }
}

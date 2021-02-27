using System;

namespace edad_mayor
{
    class Program
    {
        static void Main(string[] args)
        {
            int e1, e2, e3;
            Console.WriteLine("ingrese primera edad");
            e1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese segunda edad");
            e2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese tercera edad");
            e3 = int.Parse(Console.ReadLine());

            if (e1 > e2)
            {
                if (e1 > e3)
                {

                    Console.WriteLine("La primera edad es mayor: " + e1);
                }
            }

            else
            {
                if (e2 > e3)
                {
                    Console.WriteLine("La segunda edad es mayor: " + e2);
                }


                else
                {
                    Console.WriteLine("La tercera edad es mayor: " + e3);
                }
            }
       
        }
    }
}

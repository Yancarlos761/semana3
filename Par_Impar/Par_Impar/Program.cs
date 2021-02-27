using System;

namespace Par_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            double y,m;
            Console.WriteLine("Ingrese un numero");
            y = Double.Parse(Console.ReadLine());
            m = y % 2;
            if(m==0)
            { Console.WriteLine("El numero ingresado es par"); }
            else
            { Console.WriteLine("El numero ingresado es impar"); }
            
        }
    }
}

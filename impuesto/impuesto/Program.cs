using System;

namespace impuesto
{
    class Program
    {
        static void Main(string[] args)
        {
            string producto,medicina;
            float precio,y;
            Console.WriteLine("El producto tiene que ver con la medicina? (si, no)");
            medicina = Console.ReadLine();
            if (medicina == "si")
            {
                Console.WriteLine("No paga impuesto");
            }
            else
            {
                Console.WriteLine("Ingrese el producto");
                producto = Console.ReadLine();
                Console.WriteLine("Ingrese el Precio del Producto");
                precio = float.Parse(Console.ReadLine());
                y = (float)( precio * 0.12);
                Console.WriteLine("Nombre del Producto: " + producto);
                Console.WriteLine("impuesto: " + y);
            }
        }
    }
}

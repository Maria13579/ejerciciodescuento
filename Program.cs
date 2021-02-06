using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciodescuento
{
    class Program
    {
        static char opcion = 's';
        static char op;
        static string nombre;
        static double precio = 0, descuento = 0, sub = 0, total = 0;
        static void Main(string[] args)
        {
            while (opcion != 'n')
            {
                Console.Clear();
                Console.WriteLine("Nombre del producto");
                nombre = Console.ReadLine();
               
                try
                {
                    Console.WriteLine("Ingrese el precio del Producto");
                    precio = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Dato no valido");
                    Console.WriteLine("Ingrese el precio del Producto");
                    precio = double.Parse(Console.ReadLine());
                }

                    Console.WriteLine("Aplica descuento s/n");
                    op = char.Parse(Console.ReadLine());
                if (op == 's')
                {
                    Descuento();
                }
                else
                {
                    total = precio;
                }
                total = total + sub;
                try
                {
                    Console.WriteLine("Desea ingresar otro producto s/n ");
                    opcion = char.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Dato no valido");
                    Console.WriteLine("Desea ingresar otro producto s/n ");
                    opcion = char.Parse(Console.ReadLine());
                }

            }
            
            Console.WriteLine("El total a pagar es: " + total);
         
            Console.ReadKey();
        }
        static void Descuento()
        {
            try
            {
                Console.WriteLine("Ingrese el descuento");
                descuento = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Dato no valido");
                Console.WriteLine("Ingrese el descuento");
                descuento = double.Parse(Console.ReadLine());
            }
            sub = (precio - ((precio * descuento) / 100));

        }
    }
}

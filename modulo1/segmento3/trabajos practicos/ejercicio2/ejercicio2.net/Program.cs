using System;

namespace ejercicio2.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero entero: ");
            int num = Int32.Parse(Console.ReadLine());

            if ( num != 10 ) {
                Console.WriteLine("El numero ingresado no es 10");
            }
        }
    }
}

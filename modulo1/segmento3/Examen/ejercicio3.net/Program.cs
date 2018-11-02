using System;

namespace ejercicio3.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
			int num = Convert.ToInt32(Console.ReadLine());

			int res = ( num * num * num);

			Console.WriteLine("El resultado es: " + res);
			
			Console.Write("¿Desea realizar otra cuenta? s/n: ");
			string quit = Console.ReadLine();

			while ( quit != "n") 
			{
				 Console.Write("Ingrese un numero: ");
				 num = Convert.ToInt32(Console.ReadLine());
				          
				 res = ( num * num * num );
				          
				 Console.WriteLine("El resultado es: " + res);
				          
				 Console.Write("¿Desea realizar otra cuenta? s/n: ");
				 quit = Console.ReadLine();
			}
			Console.WriteLine("Adios.");
        }
    }
}

using System;

namespace ejercicio1.net
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;

			Console.Write("Ingrese un numero menor o igual a 100 para seguir o uno superior para salir: ");
			num = Int32.Parse(Console.ReadLine());
			
			while (num <= 100) {
				Console.WriteLine("El numero ingresado es: " + num);
				
				Console.Write("Ingrese un numero menor o igual a 100 para seguir o uno superior para salir: ");
				num = Int32.Parse(Console.ReadLine());

			}
        }
    }
}

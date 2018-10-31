using System;

namespace ejercicio2.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para realizar la suma debe ingresar dos numeros");

			Console.Write("Primer numero: ");
			int num1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Segundo numero: ");
			int num2 = Convert.ToInt32(Console.ReadLine());

			int res = num1 + num2;

			Console.WriteLine("El resultado es: " + res);
        
			Console.Write("¿Desea realizar hacer otra suma? s/n: ");
			string salir = Console.ReadLine();

			while (salir != "n") {
				Console.Write("Primer numero: ");
			    num1 = Convert.ToInt32(Console.ReadLine());

				Console.Write("Segundo numero: ");
				num2 = Convert.ToInt32(Console.ReadLine());
				
				res = num1 + num2;

				Console.WriteLine("El resultado es: " + res);

				Console.Write("¿Desea realizar otra suma? s/n: ");
				salir = Console.ReadLine();
			}
		}
	}
}




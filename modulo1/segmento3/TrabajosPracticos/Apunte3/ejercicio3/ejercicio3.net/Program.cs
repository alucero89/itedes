using System;

namespace ejercicio3.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero romano para su conversion a decimal: ");
			String num = Console.ReadLine();

			switch (num) {
				case "i":
					Console.WriteLine("El numero romano ingresado es I y su conversion a decimal es 1");
					break;
				case "v":
					Console.WriteLine("El numero romano ingresado es V y su conversion a decimal es 5");
					break;
				case "x":
					Console.WriteLine("El numero romano ingresado es X y su conversion a decimal es 10");
					break;
				case "l":
					Console.WriteLine("El numero romano ingresado es L y su conversion a decimal es 50");
					break;
				case "c":
					Console.WriteLine("El numero romano ingresado es C y su conversion a decimal es 100");
					break;
				case "d":
					Console.WriteLine("El numero romano ingresado es D y su conversion a decimal es 500");
					break;
				case "m":
					Console.WriteLine("El numero romano ingresado es M y su conversion a decimal es 1000");
					break;
	
				default:
					Console.WriteLine("Error. Ud. no ingreso un numero romano");
					break;
			}
        }
    }
}

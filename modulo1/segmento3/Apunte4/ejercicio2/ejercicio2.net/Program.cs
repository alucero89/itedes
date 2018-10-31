using System;

namespace ejercicio2.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un caracter para saber si es una vocal, consonante o numero: ");
			string caract = Console.ReadLine();

			switch (caract) {
				case "a": 
				case "e": 
				case "i":
				case "o":
				case "u":
					Console.WriteLine("Ud. ingreso una vocal");
					break;
			
				case "0":
				case "1":
				case "2":
				case "3":
				case "4":
				case "5":
				case "6":
				case "7":
				case "8":
				case "9":
					Console.WriteLine("Ud. ingreso un numero");
					break;
			
				case "b":
				case "c":
				case "d":
				case "f":
				case "g":
				case "h":
				case "j": 
				case "k":
				case "l":
				case "m":
				case "n":
				case "ñ": 
				case "p":
				case "q":
				case "r":
				case "s":
				case "t":
				case "v":
				case "w":
				case "x":
				case "y":
				case "z":
					Console.WriteLine("Ud. ingreso una consonante");
					break;
			
			
				default:
					Console.WriteLine("Ud. ingreso un simbolo");
					break;
			}
        }
    }
}

using System;

namespace ejercicio2.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
			String nom = Console.ReadLine();

			Console.Write("Ingrese su apellido: ");
			String apl = Console.ReadLine();

			Console.Write("Ingrese su DNI: ");
			int dni = Convert.ToInt32(Console.ReadLine()); 

			Console.Write("Ingrese su direccion: ");
			String dir = Console.ReadLine();

			Console.Write("Ingrese su telefono: ");
			int tel = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Su nombre y apellido es " + nom + " " + apl + " su documento es " + dni + " vive en la dirección " + dir + " y su teléfono es "+ tel);
        }
    }
}

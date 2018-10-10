using System;

namespace Pedro.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
			String name = Console.ReadLine();

			if ( name == "Pedro" ) {
				Console.WriteLine("Hola Pedro");
			}

        }
    }
}

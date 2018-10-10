using System;

namespace edad.net
{
    class Program
    {
        static void Main(string[] args)
        {
            
			Console.Write("Ingrese su edad: ");

			int edad = Int32.Parse(Console.ReadLine());

			if ( edad >= 18 )
			{
				Console.WriteLine("Ud es mayor de edad");
			}
			else
			{
				Console.WriteLine("Ud es menor de edad");
			}
        }
    }
}

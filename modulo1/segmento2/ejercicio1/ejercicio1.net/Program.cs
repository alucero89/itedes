using System;

namespace ejercicio1.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cual es el barrio de la comisaria?: ");
			String barrio = Console.ReadLine();

			Console.Write("¿Cual es su direccion?: ");
			String dir = Console.ReadLine();

			Console.Write("¿Entre que calles? Escriba el nombre de la primer calle: ");
			String calle1 = Console.ReadLine();

			Console.Write("¿Cual es la segunda calle?: ");
			String calle2 = Console.ReadLine();

			Console.WriteLine("La direccion de la comisaria es " + dir + " entre las calles "+ calle1 + " y " + calle2 + " ubicado en el barrio " + barrio);
        }
    }
}

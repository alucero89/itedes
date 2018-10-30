using System;

namespace ejercicio3.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer numero: ");
			int num1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Ingrese el segundo numero: ");
			int num2 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Ingrese el tercer numero: ");
			int num3 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Ingrese el cuarto numero: ");
			int num4 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Ingrese el quinto numero: ");
			int num5 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Los numeros ingresados de manera inversa queda de la siguiente forma: " +  num5 + " " + num4 + " " + num3 + " " + num2 + " " + num1);
        }
    }
}

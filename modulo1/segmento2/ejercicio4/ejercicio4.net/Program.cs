using System;

namespace ejercicio4.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese dos numeros para realizar la suma.");
			
			Console.Write("Primer numero: ");
			int num1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Segundo numero: ");
			int num2 = Convert.ToInt32(Console.ReadLine());

			int suma = num1 + num2;

			Console.WriteLine("El resultado es: " + suma);
        }
    }
}

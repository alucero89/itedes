using System;

namespace ejercicio7.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese dos numeros para realizar la division entre ambos");

			Console.Write("Primer numero: ");
			int num1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Segundo numero: ");
			int num2 = Convert.ToInt32(Console.ReadLine());

			int divi = num1 / num2;

			Console.WriteLine("El resultado de la division es: " + divi);
        }
    }
}

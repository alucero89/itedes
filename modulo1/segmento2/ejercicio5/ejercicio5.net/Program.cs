using System;

namespace ejercicio5.web
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese dos numeros para realizar la resta");

			Console.Write("Primer numero: ");
			int num1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Segundo numero: ");
			int num2 = Convert.ToInt32(Console.ReadLine());

			int res = num1 - num2;

			Console.WriteLine("El resultado de la resta es: " + res);
        }
    }
}

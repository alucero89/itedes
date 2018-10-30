using System;

namespace ejercicio6.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese dos numero para realizar la multiplicacion entre ambos");

			Console.Write("Primer numero: ");
			int num1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Segundo numero: ");
			int num2 = Convert.ToInt32(Console.ReadLine());
			
			int mult = num1 * num2;

			Console.WriteLine("El resultado de la multiplicacion es: " + mult);
        }
    }
}

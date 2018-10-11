using System;

namespace ejercicio4.net
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Para realizar la comparacion debe ingresar 4 numeros");

            Console.WriteLine("Ingrese el primer numero: ");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero");
            int num3 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el cuarto numero");
            int num4 = Int32.Parse(Console.ReadLine());

            if (( num1 == num2 ) && ( num3 !=num4 )) {
                Console.WriteLine("El primer y segundo numero son iguales");
            }
            
            if (( num3 == num4 ) && ( num1 != num2 )) {
                Console.WriteLine("El tercer y cuarto numero son iguales");
            }

           if (( num1 == num2 ) && ( num3 == num4 )) {
                Console.WriteLine("El primer y segundo son iguales. El tercer y cuarto numero son iguales");
            }
         }
    }
}

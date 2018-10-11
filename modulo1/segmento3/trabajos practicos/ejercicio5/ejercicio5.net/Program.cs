using System;

namespace ejercicio5.net
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("ingrese su genero: ") ;
           String genero = Console.ReadLine();

           Console.Write("Ingrese su edad: ");
           int edad = Int32.Parse(Console.ReadLine());

           if (( genero == "Masculino" || genero == "masculino" ) && ( edad >= 18 )){
                Console.WriteLine("Ud. es de genero masculino y es mayor de edad");
           }
        }
    }
}

using System;

namespace ejercicio3.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese su genero: ");
            String genero = Console.ReadLine();

            if (genero == "Femenino" || genero == "femenino") {
                Console.WriteLine("El usuario es femenino");
            }
        }
    }
}

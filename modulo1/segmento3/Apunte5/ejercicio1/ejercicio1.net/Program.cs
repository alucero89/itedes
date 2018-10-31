using System;

namespace ejercicio1.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
			int num = Convert.ToInt32(Console.ReadLine());

			for (int i=0;i<=10;i++) {
				int res = num * i;
				Console.WriteLine(num + "x" + i + "=" + res);
        	}
		}
    }
}

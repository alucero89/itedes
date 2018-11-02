using System;

namespace ejercicio3.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una base: ");
			int bas = Convert.ToInt32(Console.ReadLine());
			
			while( bas <= 0 ) 
			{
				do 
				{
					Console.Write("Vuelva a ingresar una base mayor a cero: ");
					bas = Convert.ToInt32(Console.ReadLine());
				} while( bas <= 0 );
			}	
			
			Console.Write("Ingrese una altura: ");
			int alt = Convert.ToInt32(Console.ReadLine());
			
			while( alt <= 0 ) 
			{
				do 
				{
					Console.Write("Vuelva a ingresar una altura mayor a cero: ");
					alt = Convert.ToInt32(Console.ReadLine());
				} while( alt <= 0 );
			}

			int	area = bas * alt;

			Console.WriteLine( "El area es: " + area );

			Console.Write("¿Desea calcular otra area? s/n: ");
			string salir = Console.ReadLine();

			while( salir != "n" ) 
			{
				Console.Write("Ingrese una base: ");
				bas = Convert.ToInt32(Console.ReadLine());
				
				while( bas <= 0 ) 
				{
				    do 
					{
						Console.Write("Vuelva a ingresar una base mayor a cero: ");
					    bas = Convert.ToInt32(Console.ReadLine());
					} while( bas <= 0 );
				}
				 
				Console.Write("Ingrese una altura: ");
				alt = Convert.ToInt32(Console.ReadLine());
				 
				while( alt <= 0 ) 
				{
					do 
					{
						Console.Write("Vuelva a ingresar una altura mayor a cero: ");
						alt = Convert.ToInt32(Console.ReadLine());
					} while( alt <= 0 );
				}
				 
				area = bas * alt;
				
				Console.WriteLine( "El area es: " + area );
				       
				Console.Write("¿Desea calcular otra area? s/n: ");
				salir = Console.ReadLine();
			}
        	
			Console.WriteLine("Adios");
		}
    }
}

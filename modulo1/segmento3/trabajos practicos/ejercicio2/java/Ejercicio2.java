import java.util.Scanner;

public class Ejercicio2 {
	public static void main(String args[]) {
		Scanner teclado = new Scanner(System.in);

		System.out.print( "Ingrese un numero entero: " );
		Integer num = teclado.nextInt();

		if ( num != 10 ) {
			System.out.print( "El numero ingresado no es 10." );
		}
		
	}
}

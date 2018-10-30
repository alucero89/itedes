import java.util.Scanner;

public class Edad {
	public static void main(String args[]) {
		Scanner teclado = new Scanner(System.in);

		System.out.println( "Cual es tu edad: " );
		Integer edad = Integer.parse(teclado.nextLine());

		if ( edad >= 18 ) {
			System.out.print( "Ud. es mayor de edad." );
		}
		
		else {
			System.out.println( "Ud. es menor de edad" );
		}	
			
	}
}

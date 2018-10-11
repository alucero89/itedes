import java.util.Scanner;

public class Ejercicio3 {
	public static void main(String args[]) {	
		Scanner keyboard = new Scanner(System.in);

		System.out.print( "Ingrese su genero: " );
		String genero = keyboard.nextLine();

    	if ( genero.equals("Femenino") || (genero.equals("femenino")) ) {
			System.out.print( "El usuario es femenino" );
		}
		keyboard.close();
	}
}

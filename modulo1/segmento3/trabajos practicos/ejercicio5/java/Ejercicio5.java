import java.util.Scanner;

public class Ejercicio5 {
	public static void main(String args[]) {	
		Scanner keyboard = new Scanner(System.in);

		System.out.print( "Ingrese su genero: " );
		String genero = keyboard.nextLine();

		System.out.print( "Ingrese su edad: " );
		int edad = keyboard.nextInt();

    	if ((genero.equals("Masculino")) || (genero.equals("masculino"))  && (edad >= 18)) {
			System.out.print( "Ud. es de genero masculino y es mayor de edad." );
		}
		keyboard.close();
	}

}


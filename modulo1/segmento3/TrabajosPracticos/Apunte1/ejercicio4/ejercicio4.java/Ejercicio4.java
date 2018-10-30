import java.util.Scanner;

public class Ejercicio4 {
	public static void main(String args[]) {	
		Scanner keyboard = new Scanner(System.in);

		System.out.print( "Ingrese el primer numero: " );
		int num1 = keyboard.nextInt();

		System.out.print( "Ingrese el segundo numero: " );
		int num2 = keyboard.nextInt();

		System.out.print( "Ingrese el tercer numero: " );
		int num3 = keyboard.nextInt();

		System.out.print( "Ingrese el cuarto numero: " );
		int num4 = keyboard.nextInt();


    	if ((num1 == num2) && (num3 != num4)) {
			System.out.print( "El primer numero y el segundo numero son iguales." );
		}

		if ((num3 == num4) && (num1 != num2)) {
			System.out.print( "El tercer numero y el cuarto numero son iguales" );
		}

    	if ((num1 == num2) && (num3 == num4)) {
			System.out.print( "El primer numero y el segundo numero son iguales. El tercer numero y el cuarto numero son iguales" );
		}

		keyboard.close();
	}
}

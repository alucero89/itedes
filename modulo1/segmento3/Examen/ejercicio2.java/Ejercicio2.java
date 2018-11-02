import java.util.Scanner;

public class Ejercicio2 {
	public static void main(String args[]) {
		Scanner keyboard = new Scanner(System.in);
		
		System.out.print("Ingrese el numero de inicio:  ");
		Integer numInicio = keyboard.nextInt();
		
		while ( numInicio <= 0 ) {
		System.out.print("El numero de inicio no puede ser 0. Vuelva a ingresar el numero: ");
			numInicio = keyboard.nextInt();
		}
		
		System.out.print("Ingrese el numero de fin: ");
		Integer numFin = keyboard.nextInt();

		while ( numFin <= 0 ) {
			System.out.print("El numero de fin no puede ser 0. Vuelva a ingresar el numero: ");
			numFin = keyboard.nextInt();
		}

		if ( numFin <= numInicio ) {
			while ( numFin <= numInicio ) {
				System.out.print("El numero de fin no puede ser menor al numero de inicio. Vuelva a ingresarlo: ");
				numFin = keyboard.nextInt();
			}
		}

		System.out.print("Ingrese el numero de referencia: ");
		Integer numRef = keyboard.nextInt();

		while ( numRef <= 0 ) {
			System.out.print("El numero de referecia no puede ser 0.Vuelva a ingresar el numero: ");
			numRef = keyboard.nextInt();
		} 	
		
		for ( int i=numInicio; i<=numFin; i++ ) {
			if ( i % numRef == 0 ) {
				System.out.println(i);
			}
		}
	}
}			

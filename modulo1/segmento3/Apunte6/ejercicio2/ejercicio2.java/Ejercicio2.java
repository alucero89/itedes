import java.util.Scanner;

public class Ejercicio2 {
	public static void main(String args []) {
		Scanner keyboard = new Scanner(System.in);
			
		System.out.println("Para realizar la suma debe ingresar dos numeros");
		
		String salir = "n";


		System.out.print("Primer numero: ");
		Integer num1 = keyboard.nextInt();

		System.out.print("Segundo numero: ");
		Integer num2 = keyboard.nextInt();

		Integer res = num1 + num2;

		System.out.println("El resultado es: " +  res);

		System.out.println("¿Desea realizar otra suma? s/n");
		salir = keyboard.next();
		
		do {
			System.out.print("Primer numero: ");
			num1 = keyboard.nextInt();

			System.out.print("Segundo numero: ");
			num2 = keyboard.nextInt();

			res = num1 + num2;

			System.out.println("El resultado es: " + res);

			System.out.print("¿Desea realizar otra suma? s/n");
			salir = keyboard.next();
		} while(salir.equals("s"));
	}	
}

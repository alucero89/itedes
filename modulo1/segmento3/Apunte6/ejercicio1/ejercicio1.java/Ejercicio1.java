import java.util.Scanner;

public class Ejercicio1 {
	public static void main(String args[]) {
		Scanner keyboard = new Scanner(System.in);

		System.out.print("Ingrese un numero menor o igual a 100 para seguir o uno superior para salir: ");
		Integer num = keyboard.nextInt();

		while (num <= 100) {
			System.out.println("El numero ingresado es: "+ num);

			System.out.print("Ingrese un numero menor o igual a 100 para seguir o uno superior para salir: ");
			num = keyboard.nextInt();
		}
		if (num >100) {
		System.out.println("Adios. Gracias por participar.");
		}
	}
}

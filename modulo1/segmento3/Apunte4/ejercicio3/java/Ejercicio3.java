import java.util.Scanner;

public class Ejercicio3 {
	public static void main(String args[]) {
		Scanner keyboard = new Scanner(System.in);

		System.out.print("Ingrese un numero romano para su conversion a decimal: ");
		String num = keyboard.nextLine();

		switch (num) {
			case "i":
				System.out.println("El numero romano ingresado es I y su conversion a decimal es 1");
				break;	
			case "v":
				System.out.println("El numero romano ingresado es V y su conversion a decimal es 5");
				break;
			case "x":
				System.out.println("El numero romano ingresado es X y su conversion a decimal es 10");
				break;
			case "l":
				System.out.println("El numero romano ingresado es L y su conversion a decimal es 50");
				break;
			case "c":
				System.out.println("El numero romano ingresado es C y su conversion a decimal es 100");
				break;
			case "d":
				System.out.println("El numero romano ingresado es D y su conversion a decimal es 500");
				break;
			case "M":
				System.out.println("El numero romano ingresado es M y su conversion a decimal es 1000");
				break;
		
			default:
				System.out.println("Error. Ud. no ingreso un numero romano");
		}
	}
}

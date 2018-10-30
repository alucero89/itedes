import java.util.Scanner;

public class Ejercicio2 {
	public static void main(String args[]) {
		Scanner keyboard = new Scanner(System.in);

		System.out.print("Ingrese un caracter para identificar si es una vocal, consonante o un numero: ");
		String caract = keyboard.nextLine();
		
		switch (caract) {
			case "a":
			case "e":
			case "i":
			case "o":
			case "u":
				System.out.println("Ud. ingreso una vocal");
				break;

			case "b":
			case "c":
			case "d":
			case "f":
			case "g":
			case "h":
			case "j":
			case "k":
			case "l":
			case "m":
			case "n":
			case "ñ":
			case "p":
			case "q":
			case "r":
			case "s":
			case "t":
			case "v":
			case "w":
			case "x":
			case "y":
			case "z":
				System.out.println("Ud. ingreso una consonante");
				break;

			case "0":
			case "1":
			case "2":
			case "3":
			case "4":
			case "5":
			case "6":
			case "7":
			case "8":
			case "9":
				System.out.println("Ud. ingreso un numero");
				break;
			
			default:
				System.out.println("Ud. ingreso un simbolo");
				break;
		}
	}
}


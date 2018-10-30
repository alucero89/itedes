import java.util.Scanner;

public class Ejercicio2
{
	public static void main(String args[])
	{
		Scanner keyboard = new Scanner(System.in);
		
		System.out.print("Ingrese su nombre: ");
		String name = keyboard.next();
		
		System.out.print("Ingrese su apellido: ");
		String lastName = keyboard.next();
	
		System.out.print("Ingrese su DNI: ");
		int dni = keyboard.nextInt();
		
		System.out.print("Ingrese su direccion: ");
		String street= keyboard.next();

		System.out.print("Ingrese su telefono: ");
		int tel = keyboard.nextInt();

		
		System.out.println("Su nombre y apellido es " + name + " " + lastName + " su documento es "+ dni + " vive en la direccion " + street + " y su telefono es " + tel);
	}
}

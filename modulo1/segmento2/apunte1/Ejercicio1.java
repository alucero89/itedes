import java.util.Scanner;

public class Ejercicio1 
{
	public static void main(String args[])
	{
		Scanner keyboard = new Scanner(System.in);
		
		System.out.print("Cual es el barrio de la comisaria: ");
		String location = keyboard.nextLine();
		
		System.out.print("Cual es su direccion: ");
		
		String address = keyboard.nextLine();
	
		System.out.print("Entre que calles. Escriba el nombre de la primera calle: ");
		String street1= keyboard.nextLine();
		
		System.out.print("Escriba el nombre de la segunda calle: ");
		String street2= keyboard.nextLine();
		
		System.out.println("La direccion de la comisaria es "+ address + " entre las calles "+ street1 + " y " + street2 + " ubicado en el barrio " + location);
	}
}

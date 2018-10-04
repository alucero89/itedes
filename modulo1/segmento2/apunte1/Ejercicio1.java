import java.util.Scanner;

public class Ejercicio1 
{
	public static void main(String args[])
	{
		Scanner keyboard = new Scanner(System.in);
		
		System.out.print("¿Cuál es el barrio de la comisaria?: ");
		String location = keyboard.next();
		
		System.out.print("¿Cuál es su dirección?: ");
		String address = keyboard.next();
	
		System.out.print("¿Entre que calles? Escriba el nombre de la primera calle: ");
		String street1= keyboard.next();
		
		System.out.print("Escriba el nombre de la segunda calle: ");
		String street2= keyboard.next();
		
		System.out.println("La dirección de la comisaria es "+ address + " entre las calles "+ street1 + " y " + street2 + " ubicado en el barrio " + location);
	}
}

import java.util.Scanner;

public class Ejercicio1 
{
	public static void main(String args[])
	{
		Scanner keyboard = new Scanner(System.in);
		
		System.out.print("�Cu�l es el barrio de la comisaria?: ");
		String location = keyboard.next();
		
		System.out.print("�Cu�l es su direcci�n?: ");
		String address = keyboard.next();
	
		System.out.print("�Entre que calles? Escriba el nombre de la primera calle: ");
		String street1= keyboard.next();
		
		System.out.print("Escriba el nombre de la segunda calle: ");
		String street2= keyboard.next();
		
		System.out.println("La direcci�n de la comisaria es "+ address + " entre las calles "+ street1 + " y " + street2 + " ubicado en el barrio " + location);
	}
}

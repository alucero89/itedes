import java.util.Scanner;

public class Ejercicio3
{
	public static void main(String args[])
	{
		Scanner keyboard = new Scanner(System.in);
		
		System.out.print("Ingrese n�mero 1: ");
		int num1= keyboard.nextInt();
		
		System.out.print("Ingrese n�mero 2: ");
		int num2 = keyboard.nextInt();
	
		System.out.print("Ingrese n�mero 3: ");
		int num3 = keyboard.nextInt();
		
		System.out.print("Ingrese n�mero 4: ");
		int num4 = keyboard.nextInt();

		System.out.print("Ingrese n�mero 5: ");
		int num5  = keyboard.nextInt();

		
		System.out.println("Los n�meros ingresados de manera inversa queda de la siguiente forma: " +  num5 + " " + num4 + " " + num3 + " " + num2 + " " + num1);
	}
}

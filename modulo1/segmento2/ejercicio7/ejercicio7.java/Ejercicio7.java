import java.util.Scanner;

public class Ejercicio7
{
	public static void main(String args[])
	{
		Scanner keyboard = new Scanner(System.in);
		
		int num1;
		System.out.print("Ingrese el primer numero: ");
		num1 = keyboard.nextInt();
		
		int num2;
		System.out.print("Ingrese el segundo numero: ");
		num2 = keyboard.nextInt();
	
		int result;
		result = (num1/num2);
		
		System.out.println("El resultado es: " + result);
	}
}

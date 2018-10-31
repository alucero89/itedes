import java.util.Scanner;

public class Ejercicio1 {
	public static void main(String args[]) {
		Scanner keyboard = new Scanner(System.in);

		System.out.print("Ingrese un numero: ");
		Integer num = keyboard.nextInt();

		for (Integer i=0;i<=10;i++) {
			Integer res = num * i;
			System.out.println(num + "x" + i + " = "+ res);
		}
	}
}

namespace Principales;
using Matematicas;

class Principal {
	public static void Main	(String [] args) {
		int a = 10;
		int b = 15;
		Operacion op = new Operacion ();
		Console.WriteLine("La suma de " + a + " y " + b + " es: " + op.Sumar(a,b));
		
		Console.WriteLine("La resta de " + a + " y " + b + " es: " + op.Restar(a,b));
	}
}
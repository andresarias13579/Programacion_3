namespace Principales;
using Matematicas;

public class Principal{
	public static void Main (String [] args) {
		int a = 10;
		int b = 10;
		Operacion op = new Operacion();
		Console.WriteLine("La suma de " + a + " y " + b + " es : " + op.Sumar(a,b));
		Console.WriteLine("La restade " + a + " y " + b + " es : " + op.Restar(a,b));
		Impresion.Imprimir("Mensaje de Prueba...");
	}
}
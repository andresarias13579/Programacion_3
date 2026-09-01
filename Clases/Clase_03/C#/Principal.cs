class Principal{
	public static void Main(string[] args){
		Console.WriteLine("Hello word");
		Curso c1 = new Curso("1INF30","PROGRAMACION 3");
		Console.Write(c1.devolverDatos());
		c1.Clave = "CIC602";
		Console.Write(c1.devolverDatos());
		c1.Nombre = "Lenguajes de programacion";
		Console.Write(c1.devolverDatos());
		
		c1.Vacantes = 35;
		Console.Write(c1.devolverDatos());
		
		Curso c2 = new Curso("1INF47","Tecnicas de programacion",40);
		Console.Write(c2.devolverDatos());
	}
}
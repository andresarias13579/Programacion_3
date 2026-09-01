class Curso{
	private String nombre;
	private String clave;
	
	public Curso(String clave, String nombre, int vacantes){
		this.clave = clave;
		this.nombre = nombre;
		this.Vacantes = vacantes;
	}
	
	public String Clave{
		get{
			return clave;
		}
		set{
			this.clave = value;
		}
	}
	
	//otra manera de getter and setter
	public String Nombre{
		get => nombre;
		set => nombre = value;
	}
	
	//otra manera, aca no hace falta crear un atributo arriba
	public int Vacantes{get;set;} //aqui siempre se maneja con V al inicio de manera interna
	
	public String devolverDatos(){
		return "CURSO: " + clave + " - " + nombre + " - Vacantes" + Vacantes +'\n';
	}
}
class Libro{
	private String nombre;
	private String autor;
	private String editorial;
	
	public Libro(String nombre, String autor, String editorial){
		this.nombre = nombre;
		this.autor = autor;
		this.editorial = editorial;
	}
	
	public String devolverInformacion(){
		return "LIBRO: " + nombre + " - " + autor + " - " + editorial + '\n';
	}
}
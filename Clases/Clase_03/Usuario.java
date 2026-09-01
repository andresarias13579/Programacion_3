import java.util.List;
import java.util.ArrayList;

class Usuario{
	private String nombre;
	private List<Prestamo> prestamos;
	
	public Usuario(String nombre){
		this.nombre = nombre;
		this.prestamos = new ArrayList<>();
	}
	
	public void agregarPrestamo(Prestamo prestamo){
		this.prestamos.add(prestamo);
	}
	
	public String getReporte(){
		String cadena = "";
		for(Prestamo p : prestamos){
			for(Libro l : p.getLibros()){
				cadena += l.devolverInformacion();
			}
			cadena += p.getMulta().devolverInformacion();
		}
		return cadena;
	}
}
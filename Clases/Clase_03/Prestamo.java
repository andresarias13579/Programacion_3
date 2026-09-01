import java.util.List;
import java.util.ArrayList;

class Prestamo{
	private List<Libro> libros;
	private Multa multa;
	
	public Multa getMulta(){
		return new Multa (multa);
	}
	
	public void setMulta(Multa multa){
		this.multa = multa;
	}
	
	public List<Libro> getLibros(){
		return new ArrayList<>(libros);
	}
	
	public void setLibros(List<Libro> libros){
		this.libros = new ArrayList<>(libros);
	}
}
import java.text.SimpleDateFormat;
import java.util.List;
import java.util.ArrayList;

class Principal{
	public static void main (String[] args) throws Exception{
		SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
		
		//creamos multa
		Multa multa = new Multa(sdf.parse("24-08-2026"),30);
		
		Prestamo prestamo = new Prestamo();
		prestamo.setMulta(multa);
		
		Libro l1 = new Libro("Fuego y sangre", "George .R.R", "Umbrella");
		Libro l2 = new Libro("Vientos de inverno", "George .R.R", "Coquito");
		
		List<Libro> libros = new ArrayList<>();
		libros.add(l1);
		libros.add(l2);
		
		prestamo.setLibros(libros);
		
		Usuario usuario = new Usuario("Andres");
		usuario.agregarPrestamo(prestamo);
		
		System.out.println(usuario.getReporte());
	}
}
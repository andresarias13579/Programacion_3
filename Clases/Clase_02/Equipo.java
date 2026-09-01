import java.util.ArrayList;
import java.util.List;

class Equipo{
	private String nombre;
	private String interes;
	private List<Miembro> miembros;
	private EQuipu EQuipu;
	
	public Equipo(String nombre, String interes){
		this.nombre = nombre;
		this.interes = interes;
		this.miembros = new ArrayList<>();
	}
}
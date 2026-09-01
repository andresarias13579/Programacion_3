import java.util.List;
import java.util.ArrayList;

class InstitucionEducativa{
	private int idInstitucionEducativa;
	private String RUC;
	private String nombre;
	
	private List<Sede> sedes;
	
	public InstitucionEducativa(int idInstitucionEducativa, String RUC, String nombre){
		this.idInstitucionEducativa = idInstitucionEducativa;
		this.RUC = RUC;
		this.nombre = nombre;
		
		this.sedes = new ArrayList<>();
	}
	
	public void agregarSede(Sede sed){
		sedes.add(sed);
	}
	
	public String consultarProgramasDeSede(int idSede){
		String cadena = "Programas disponibles para " + sedes.get(idSede).getNombre() + '\n' +sedes.get(idSede).consultarProgramas();
		return cadena;
	}
}
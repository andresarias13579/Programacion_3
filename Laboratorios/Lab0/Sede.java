import java.util.List;
import java.util.ArrayList;

class Sede {
	private int idSede;
	private String nombre;
	private String direccion;
	
	private List<ProgramaAcademico> programasAcademicos;
	
	public Sede(int idSede, String nombre, String direccion){
		this.idSede = idSede;
		this.nombre = nombre;
		this.direccion = direccion;
		
		this.programasAcademicos = new ArrayList<>();
	}
	
	public String getNombre(){
		return nombre;
	}
	
	public void agregarProgramaAcademico(ProgramaAcademico progra){
		programasAcademicos.add(progra);
	}
	
	public String consultarProgramas(){
		String cadena = "";
		for (ProgramaAcademico pa:programasAcademicos){
			cadena += pa.consultarDatos() + '\n';
		}
		return cadena;
	}
	
}
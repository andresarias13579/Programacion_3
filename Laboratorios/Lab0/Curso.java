import java.util.Date;
import java.time.LocalTime;

class Curso extends ProgramaAcademico{
	private int cantidadHorasClasePorSemana;
	private float cantidadCreditos;
	private Date fechaInicioClases;
	private Date fechaFinClases;
	private DiaSemana diaDeDictado;
	private LocalTime horaInicioClases;
	private LocalTime horaFinClases;
	
	Curso(String nombre, String clave, char modalidad, double precio, int cantidadHorasClasePorSemana, float cantidadCreditos,
		Date fechaInicioClases, Date fechaFinClases, DiaSemana diaDeDictado, LocalTime horaInicioClases, LocalTime horaFinClases){
		super(nombre,clave,modalidad,precio);
		this.cantidadHorasClasePorSemana = cantidadHorasClasePorSemana;
		this.cantidadCreditos =cantidadCreditos;
		this.fechaInicioClases = fechaInicioClases;
		this.fechaFinClases = fechaFinClases;
		this.diaDeDictado = diaDeDictado;
		this.horaInicioClases = horaInicioClases;
		this.horaFinClases = horaFinClases;
	}
	
	@Override
	public String consultarDatos(){
		String cadena = "CURSO: " + getClave() + " - " + getNombre() + " - S/." + String.format("%.2f",getPrecio()) + " - CRED: " +
			String.format("%.1f",this.cantidadCreditos);
		return cadena;
	}
	
}
import java.util.Date;
import java.time.LocalTime;
import java.text.SimpleDateFormat;

class Taller extends ProgramaAcademico{
	private Date fechaRealizacion;
	private LocalTime horaInicio;
	private LocalTime horaFin;
	
	public Taller(String nombre, String clave, char modalidad, double precio, Date fechaRealizacion, LocalTime horaInicio, LocalTime horaFin){
		super(nombre,clave,modalidad,precio);
		this.fechaRealizacion = fechaRealizacion;
		this.horaFin = horaFin;
		this.horaInicio = horaInicio;
	}
	
	@Override
	public String consultarDatos(){
		SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
		String cadena = "TALLER: " + getClave() + " - " + getNombre() + " -S/. " + String.format("%.2f",getPrecio()) + " - " 
			+ sdf.format(fechaRealizacion);
		return cadena;
	}
}
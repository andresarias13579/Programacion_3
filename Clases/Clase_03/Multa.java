import java.util.Date;
import java.text.SimpleDateFormat;

class Multa{
	private Date fechaCreacion;
	private int diasPenalizacion;
	
	public Multa(Multa mul){
		this.fechaCreacion = mul.fechaCreacion;
		this.diasPenalizacion = mul.diasPenalizacion;
	}
	
	public Multa(Date fechaCreacion, int diasPenalizacion){
		this.fechaCreacion = fechaCreacion;
		this.diasPenalizacion = diasPenalizacion;
	}
	
	public Date getFechaCreacion(){
		return fechaCreacion;
	}
	public void setFechaCreacion(Date fechaCreacion){
		this.fechaCreacion = fechaCreacion;
	}
	
	public int getDiasPenalizacion(){
		return diasPenalizacion;
	}
	public void setDiasPenalizacion(int diasPenalizacion){
		this.diasPenalizacion = diasPenalizacion;
	}
	
	public String devolverInformacion(){
		SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
		return "MULTA: " + diasPenalizacion + " dias - Creada: " + sdf.format(fechaCreacion);
	}
}
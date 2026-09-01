import java.util.List;
import java.util.ArrayList;
import java.util.Date;

class Assessment {
	private int duracionMin;
	private Date inicioExamen;
	private List<Teacher> profesores;
	private List<AssessmentPoint> items;
	
	public Assessment(int duracionMin,Date inicioExamen,List<Teacher> profesores,List<AssessmentPoint> items){
		this.duracionMin = duracionMin;
		this.inicioExamen = inicioExamen;
		this.profesores = new ArrayList<>();
		this.profesores = profesores;
		this.items = new ArrayList<>();
		this.items = items;
	}
	
	public int getDuracion(){
		return duracionMin;
	}
	
	public Date getInicioExamen(){
		return inicioExamen;
	}
	
	public List<AssessmentPoint> getItems(){
		return items;
	}
}
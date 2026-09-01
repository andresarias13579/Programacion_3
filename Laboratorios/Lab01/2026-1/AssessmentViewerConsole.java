import java.text.SimpleDateFormat;

class AssessmentViewerConsole {
	private Assessment examen;
	
	public void show(Assessment examen){
		System.out.println("Inicio de examen =========================");
		// Cambiado a printf y ajustado el nombre del método getter
		System.out.printf("Duracion: %d minutos\n", examen.getDuracion()); 
		
		SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy HH:mm");
		System.out.print("Fecha de examen: ");
		System.out.println(sdf.format(examen.getInicioExamen()));
		System.out.println();
		
		for(AssessmentPoint ite: examen.getItems()){
			ite.getQuestion().mostrarPregunta();
		}
	}
}
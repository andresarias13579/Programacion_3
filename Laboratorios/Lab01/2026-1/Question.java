import java.util.List;
import java.util.ArrayList;

class Question{
	private int idQuestion;
	private String prompt;
	private List<String> opciones;
	
	public Question(int idQuestion,String prompt, List<String> opciones){
		this.idQuestion = idQuestion;
		this.prompt = prompt;
		this.opciones = new ArrayList<>();
		this.opciones = opciones;
	}
	
	public void mostrarPregunta(){
		System.out.printf("Pregunta %d) %s\n", idQuestion, prompt);
		int i = 1;
		for(String op : opciones){
			// Usamos printf, %d para el número e, %s para el texto
			System.out.printf("%d. %s\n", i, op); 
			i++;
		}
		System.out.println("Ingrese su respuesta:\n");
	}
}
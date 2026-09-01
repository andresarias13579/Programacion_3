import java.util.List;
import java.util.ArrayList;
import java.util.Random;

class QuestionManager{
	private List<Question> preguntas;
	
	public QuestionManager(){
		preguntas = new ArrayList <>();
	}
	
	public void add(Question pregunta){
		preguntas.add(pregunta);
	}
	
	public List<Question> selectRandomN(int cantidadPreguntas){
		List<Question> aux = new ArrayList<>();
		Random rand = new Random();
		for(int i=0; i < cantidadPreguntas; i++){
			aux.add(preguntas.get(rand.nextInt(preguntas.size())));
		}
		
		return aux;
	}
}
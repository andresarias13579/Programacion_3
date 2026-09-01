import java.util.List;
import java.util.ArrayList;

class MultipleChoiceQuestion extends Question {
	private List<Integer> opcionCorrecta;
	
	public MultipleChoiceQuestion(int idQuestion,String prompt, List<String> opciones, 
		List<Integer> opcionCorrecta){
		super(idQuestion,prompt,opciones);
		this.opcionCorrecta = new ArrayList<>();
		this.opcionCorrecta = opcionCorrecta;
	}
}
import java.util.List;
import java.util.ArrayList;

class SingleChoiceQuestion extends Question{
	private int opcionCorrecta;

	public SingleChoiceQuestion(int idQuestion,String prompt, List<String> opciones, int opcionCorrecta){
		super(idQuestion,prompt,opciones);
		this.opcionCorrecta = opcionCorrecta;
	}
}
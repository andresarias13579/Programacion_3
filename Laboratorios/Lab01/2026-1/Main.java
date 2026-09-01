import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.text.SimpleDateFormat;
public class Main {
	 public static void main(String[] args) throws Exception{
		 QuestionManager questionManager = new QuestionManager();
		 SingleChoiceQuestion sc1 = new SingleChoiceQuestion(1, "1 + 1?", List.of("1", "2", "11", "0"), 2);
		 SingleChoiceQuestion sc2 = new SingleChoiceQuestion(2, "2*4?", List.of("24", "2", "8", "16"), 3);
		 MultipleChoiceQuestion mc1 = new MultipleChoiceQuestion(3, "is a planet?", List.of("Earth", "Moon", "Europe",
			"Mars"), List.of(1, 4));
			
		 questionManager.add(sc1);
		 questionManager.add(sc2);
		 questionManager.add(mc1);
		 
		 
		 // 2. Registro de Profesores
		 Teacher teacher1 = new Teacher("11111111", "Freddy", "Paz");
		 Teacher teacher2 = new Teacher("22222222", "Jose", "Corcuera");
		 List<Teacher> teachers = new ArrayList<>();
		 teachers.add(teacher1);
		 teachers.add(teacher2);
		 
		 
		 // 3. Selección de preguntas para el examen y asignación de puntajes
		 List<Question> questionsSelected = questionManager.selectRandomN(3);
		// TODO
		AssessmentPoint i1 = new AssessmentPoint(questionsSelected.get(0),5);
		AssessmentPoint i2 = new AssessmentPoint(questionsSelected.get(1),8);
		AssessmentPoint i3 = new AssessmentPoint(questionsSelected.get(2),7);
		List<AssessmentPoint> items = new ArrayList<>();
		items.add(i1);
		items.add(i2);
		items.add(i3);
		
		
		 // 4. Creación del Examen (Assessment) con su metadata
		 
		 SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
        Date fechaSegura = sdf.parse("12-06-2026");
		 Assessment assessment = new Assessment(
			 120, // Duración en minutos
			 fechaSegura, // Fecha y hora de inicio
			 teachers, // Lista de profesores
			 /* TODO */ // Lista de ítems (Pregunta + Puntaje)
			 items
		 );
		 // 5. Ejecución de la evaluación
		 AssessmentViewerConsole vista = new AssessmentViewerConsole();
		 vista.show(assessment);
	 }
}

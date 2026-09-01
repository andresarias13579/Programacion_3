class AssessmentPoint {
	private Question pregunta;
	private int puntaje;
	
	public AssessmentPoint(Question pregunta, int puntaje){
		this.pregunta = pregunta;
		this.puntaje = puntaje;
	}
	
	public Question getQuestion(){
		return pregunta;
	}
	
	public int getPuntaje(){
		return puntaje;
	}
}
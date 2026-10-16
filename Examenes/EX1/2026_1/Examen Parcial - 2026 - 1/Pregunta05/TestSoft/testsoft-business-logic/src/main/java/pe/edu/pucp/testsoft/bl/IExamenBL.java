package pe.edu.pucp.testsoft.bl;

import pe.edu.pucp.testsoft.model.Alumno;
import pe.edu.pucp.testsoft.model.Examen;

import java.util.ArrayList;

public interface IExamenBL {
    ArrayList<Examen> listarExamenesPendientes(Alumno alumno);
    Examen obtenerExamenCompleto(int idExamen, Alumno alumno);
}

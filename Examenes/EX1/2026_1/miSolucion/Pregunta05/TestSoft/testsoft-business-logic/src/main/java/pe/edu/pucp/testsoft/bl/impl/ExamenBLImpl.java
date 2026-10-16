package pe.edu.pucp.testsoft.bl.impl;

import pe.edu.pucp.testsoft.bl.IExamenBL;
import pe.edu.pucp.testsoft.dao.IExamenDAO;
import pe.edu.pucp.testsoft.dao.IExamenPreguntaDAO;
import pe.edu.pucp.testsoft.dao.IOpcionRespuestaDAO;
import pe.edu.pucp.testsoft.dao.IRespuestaAlumnoDAO;
import pe.edu.pucp.testsoft.dao.impl.ExamenDAOImpl;
import pe.edu.pucp.testsoft.dao.impl.ExamenPreguntaDAOImpl;
import pe.edu.pucp.testsoft.dao.impl.OpcionRespuestaDAOImpl;
import pe.edu.pucp.testsoft.dao.impl.RespuestaAlumnoDAOImpl;
import pe.edu.pucp.testsoft.model.*;

import java.util.ArrayList;

public class ExamenBLImpl implements IExamenBL {
    private IExamenDAO examenDAO = new ExamenDAOImpl();
    private IExamenPreguntaDAO examenPreguntaDAO = new ExamenPreguntaDAOImpl();
    private IOpcionRespuestaDAO opcionRespuestaDAO = new OpcionRespuestaDAOImpl();
    private IRespuestaAlumnoDAO respuestaAlumnoDAO = new RespuestaAlumnoDAOImpl();

    public ArrayList<Examen> listarExamenesPendientes(Alumno alumno) {
        return examenDAO.listarPendientesPorAlumno(alumno);
    }

    public Examen obtenerExamenCompleto(int idExamen, Alumno alumno){
        Examen examen = examenDAO.obtenerExamen(idExamen,alumno);
        ArrayList<ExamenPregunta> preguntasExamen = examenPreguntaDAO.obtenerPreguntas(idExamen);
        for (ExamenPregunta preguntaExamen : preguntasExamen){
            ArrayList<OpcionRespuesta> opciones = opcionRespuestaDAO.obtenerOpciones(preguntaExamen.getPregunta().getId());
            preguntaExamen.getPregunta().setOpciones(opciones);
        }
        examen.setPreguntas(preguntasExamen);
        return examen;
    }

    public int insertarRepuesta(RespuestaAlumno respuestaAlumno){
        return respuestaAlumnoDAO.insertarRespuesta(respuestaAlumno);
    }
}

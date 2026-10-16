package pe.edu.pucp.testsoft.consola;
import pe.edu.pucp.testsoft.bl.IAlumnoBL;
import pe.edu.pucp.testsoft.bl.IExamenBL;
import pe.edu.pucp.testsoft.bl.impl.AlumnoBLImpl;
import pe.edu.pucp.testsoft.bl.impl.ExamenBLImpl;
import pe.edu.pucp.testsoft.model.*;

import java.sql.SQLException;
import java.util.ArrayList;
import java.util.Scanner;

public class Program {
    public static void main(String[] args) throws SQLException {
        Scanner sc = new Scanner(System.in);
        IAlumnoBL alumnoBL = new AlumnoBLImpl();
        IExamenBL examenBL = new ExamenBLImpl();

        System.out.println("===== SISTEMA TESTSOFT =====");
        System.out.print("Ingrese ID del alumno: ");
        int idAlumno = sc.nextInt();
        Alumno alumno = alumnoBL.buscarAlumno(idAlumno);
        ArrayList<Examen> examenes = examenBL.listarExamenesPendientes(alumno);
        if (examenes.isEmpty()) {
            System.out.println("El alumno no tiene exámenes pendientes.");
            return;
        }
        System.out.println("\nExámenes pendientes:");
        for (Examen examen : examenes) {
            System.out.println("ID Examen: " + examen.getId()
                    + " | Titulo: " + examen.getTitulo() + " | Estado: " + examen.getEstado());
        }

        System.out.print("\nSeleccione el ID del examen a resolver: ");
        int idExamen = sc.nextInt();
        Examen examenRendir = examenBL.obtenerExamenCompleto(idExamen, alumno);

        if (examenRendir.getPreguntas().isEmpty()) {
            System.out.println("El examen seleccionado no tiene preguntas.");
            return;
        }

        System.out.println("\n===== RESOLUCIÓN DEL EXAMEN =====");
        for (ExamenPregunta preguntaExamen : examenRendir.getPreguntas()) {
            System.out.println("\nPregunta " + preguntaExamen.getPregunta().getId() + ":");
            System.out.println(preguntaExamen.getPregunta().getEnunciado());
            System.out.println("Puntaje: " + preguntaExamen.getPuntaje());

            System.out.println("Opciones:");
            for (OpcionRespuesta opcion : preguntaExamen.getPregunta().getOpciones()) {
                System.out.println(opcion.getOrden() + ". " + opcion.getTextoOpcion());
            }
            System.out.println("Coloque el numero de su respuesta: ");
            int elegido = sc.nextInt();
            RespuestaAlumno respuestaAlumno = new RespuestaAlumno();
            respuestaAlumno.setRespuesta(preguntaExamen.getPregunta().getOpciones().get(elegido-1));
            boolean esCorrecto = preguntaExamen.getPregunta().getOpciones().get(elegido-1).isEsCorrecta();
            respuestaAlumno.setEsCorrecta(esCorrecto);
            respuestaAlumno.setPregunta(preguntaExamen);
            if (esCorrecto) respuestaAlumno.setPuntajeObtenido(preguntaExamen.getPuntaje());
            else respuestaAlumno.setPuntajeObtenido(0);
            int correcto = examenBL.insertarRepuesta(respuestaAlumno);
            if (correcto == 1) System.out.println("Se guardo su respuesta correctamente");
            else  System.out.println("No se pudo guardar");
            System.out.println("--------------------------------------------");
        }
    }
}
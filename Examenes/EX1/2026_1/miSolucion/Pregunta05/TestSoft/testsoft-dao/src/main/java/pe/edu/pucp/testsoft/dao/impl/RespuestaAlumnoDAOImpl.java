package pe.edu.pucp.testsoft.dao.impl;

import pe.edu.pucp.testsoft.dao.IRespuestaAlumnoDAO;
import pe.edu.pucp.testsoft.dao.manager.DBManager;
import pe.edu.pucp.testsoft.model.RespuestaAlumno;

import java.sql.CallableStatement;
import java.sql.Connection;

public class RespuestaAlumnoDAOImpl implements IRespuestaAlumnoDAO {

    @Override
    public int insertarRespuesta(RespuestaAlumno respuestaAlumno) {
        String sql = "{call SP_INSERTAR_RESPUESTA_ALUMNO(?,?,?,?)}";
        try(Connection con = DBManager.getInstance().getConnection();
            CallableStatement cs = con.prepareCall(sql)){
            cs.setInt("p_id_examen_pregunta",respuestaAlumno.getPregunta().getId());
            cs.setInt("p_id_opcion_respuesta",respuestaAlumno.getRespuesta().getId());
            cs.setBoolean("p_es_correcta",respuestaAlumno.getRespuesta().isEsCorrecta());
            cs.setInt("p_puntaje_obtenido",respuestaAlumno.getPregunta().getPuntaje());
            cs.executeUpdate();
            return 1;

        }catch(Exception ex){
            System.out.println("Error al insertar una respuesta del alumno: "+ex.getMessage());
            throw new RuntimeException(ex);
        }
    }
}

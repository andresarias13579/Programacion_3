package pe.edu.pucp.softprog.rrhh.impl;

import pe.edu.pucp.softprog.config.DBManager;
import pe.edu.pucp.softprog.rrhh.dao.AreaDAO;
import pe.edu.pucp.softprog.rrhh.model.Area;

import java.sql.Connection;
import java.sql.Statement;
import java.util.List;

public class AreaImpl implements AreaDAO {

    @Override
    public int insertar(Area area) {
        String sql = "INSERT INTO area(nombre,activa) " +
                "VALUES('"+area.getNombre() +"',1)";
        try(Connection con = DBManager.getInstance().getConnection()){
            Statement st = con.createStatement();
            return st.executeUpdate(sql);

        }catch(Exception ex){
            System.out.println("ERROR: "
                    +ex.getMessage());
            throw  new RuntimeException(ex);
        }
    }

    @Override
    public int modificar(Area area) {
        return 0;
    }

    @Override
    public int eliminar(int idArea) {
        return 0;
    }

    @Override
    public Area buscarPorId(int idArea) {
        return null;
    }

    @Override
    public List<Area> listarTodos() {
        return List.of();
    }
}

package pe.edu.pucp.softprog.main;
import pe.edu.pucp.softprog.config.DBManager;
import pe.edu.pucp.softprog.rrhh.dao.AreaDAO;
import pe.edu.pucp.softprog.rrhh.impl.AreaImpl;
import pe.edu.pucp.softprog.rrhh.model.Area;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;

public class Principal {
    public static void main(String [] args){
        System.out.println("Funciona");
        Area area = new Area();
        area.setNombre("Direccion Academica");
        System.out.println(area.getNombre());

        AreaDAO daoArea = new AreaImpl();
        if(daoArea.insertar(area)!=0)
            System.out.println("El area " + area.getNombre()+
                    " se registro correctamente");

        //para listado
        try{
            Connection con = DBManager.getInstance().getConnection();
            Statement st = con.createStatement();
            String sql = "SELECT id_area,nombre FROM area WHERE activa = 1";
            ResultSet rs = st.executeQuery(sql);

            while (rs.next()){
                Area areaTemp = new Area();
                areaTemp.setIdArea(rs.getInt("id_area"));
                areaTemp.setNombre(rs.getString("nombre"));
                System.out.println(areaTemp.getIdArea() + " " + areaTemp.getNombre());
            }
            rs.close();

        }catch(Exception ex){
            System.out.println("ERROR: " + ex.getMessage());
        }




    }
}

package pe.edu.pucp.softprog.main;
import pe.edu.pucp.softprog.config.DBmanager;
import pe.edu.pucp.softprog.rrhh.model.Area;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.Statement;

public class Principal {
    public static void main(String[] args){
        System.out.println("Ejecucion del " +
                "software de Prog3...");
        Area area = new Area();
        area.setNombre("CONTABILIDAD");
        System.out.println(area.getNombre());

        try {
           Connection con = DBmanager.getInstance().getConnection();
            //Ejecutar una instruccion en el motor de BD
            Statement st = con.createStatement();
            //Indicamos la instruccion
            String sql = "INSERT INTO area(nombre,activa) VALUES('" +
                    area.getNombre() + "',1)";
            //Ejecutamos la instruccion
            int resultado = st.executeUpdate(sql);
            //Verificamos si se ejecutó la instrucción
            if(resultado!=0)
                System.out.println("El area de nombre '" + area.getNombre()
                + "' se registro correctamente");
            else
                System.out.println("Hubo un error en el registro");
            //Cerramos la conexión
            con.close();
        }catch(Exception ex){
            System.out.println("ERROR: " + ex.getMessage());
        }


    }
}

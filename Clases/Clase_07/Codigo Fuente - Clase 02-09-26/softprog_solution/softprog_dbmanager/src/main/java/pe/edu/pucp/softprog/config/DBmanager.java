package pe.edu.pucp.softprog.config;

import java.io.InputStream;
import java.sql.Connection;
import java.sql.DriverManager;
import java.util.Properties;

public class DBmanager {
    private static DBmanager instance;
    private final String hostname ;
    private final String user ;
    private final String password ;
    private final String port ;
    private final String database ;
    private Connection con;
    private Properties properties;
    private final String DB_CREDENTIALS_FILE = "db.properties";

    private DBmanager(){
        //instrucciones de creaion del objeto
        properties = new Properties();
        try{
            InputStream inputStream = getClass().getClassLoader().getResourceAsStream(DB_CREDENTIALS_FILE);
            properties.load(inputStream);
        }catch(Exception ex){
            System.out.println("ERROR AL LEER EL ARCHIVO DE CREDENCIALES" + ex.getMessage());
        }
        hostname = properties.getProperty("db.hostname");
        user = properties.getProperty("db.user");
        password = properties.getProperty("db.password");
        port = properties.getProperty("db.port");
        database = properties.getProperty("db.database");
    }

    public  static DBmanager getInstance(){
        if (instance == null) instance = new DBmanager();
        return instance;
    }

    public Connection getConnection(){
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            String url = "jdbc:mysql://" + hostname + ":" + port + "/" + database;
            con = DriverManager.getConnection(url,user,password);
        } catch (Exception ex){
            System.out.println("ERROR al conectar con la BD");
        }
        return con;
    }
}

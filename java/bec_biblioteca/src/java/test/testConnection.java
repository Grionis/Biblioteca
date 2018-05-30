
package test;


import java.sql.Connection;
import java.sql.DatabaseMetaData;
import java.sql.ResultSet;
import java.sql.SQLException;

public class testConnection {
    public static void main(String[] args) throws SQLException {
       
        
        try {
             
            Connection conn = cl.biblioteca.dal.Conexion.get();
            
            System.out.println("Conectado a la base de datos, las tablas encontradas son:");
            DatabaseMetaData dbm = conn.getMetaData();
            ResultSet rs = dbm.getTables(null, null, "%", new String[] { "TABLE" });
            while (rs.next()) { System.out.println(rs.getString("TABLE_NAME")); }
        } catch (Exception e) {
            System.out.println(e.getMessage());
        } 
    }
}


//v1.0.0
package cl.biblioteca.dal;

import cl.biblioteca.dal.*;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class Conexion {
    public static Connection get() throws Exception{
        Connection conn = null;
        try 
        {
            String driverClassName="com.mysql.jdbc.Driver";
            String driverUrl="jdbc:mysql://localhost:3306/bd_bec";
            Class.forName(driverClassName);
            conn=DriverManager.getConnection(driverUrl,"root","123");
            return conn;
            
        } catch (ClassNotFoundException e) 
        {
            throw new Exception("Error ClassNotFoundException "+e.getMessage());
        }catch (SQLException e)
        {
            throw new Exception("Error SQLException "+e.getMessage());
        }
    }
}

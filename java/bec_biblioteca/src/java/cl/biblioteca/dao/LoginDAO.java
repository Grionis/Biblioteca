/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cl.biblioteca.dao;
import cl.biblioteca.edm.Usuario;
import cl.biblioteca.dal.*;
import java.sql.*;
/**
 *
 * @author Acer
 */
public class LoginDAO {
    
     public boolean verificaUsuario(String nomU, String contraseña) throws Exception{
        
        //Usuario usuario=null;
        Connection accesoDB = Conexion.get();
      
            
            PreparedStatement ps = accesoDB.prepareStatement("select * from usuario where nombreUsuario=? and clave=?");
            ps.setString(1, nomU);
            ps.setString(2, contraseña);
            ResultSet rs = ps.executeQuery();
            return rs.next();
         
     
    }
     
      public int validarUs(String nomU, String contraseña) throws Exception{
        
        //Usuario usuario=null;
        Connection accesoDB = Conexion.get();
      
            
            PreparedStatement ps = accesoDB.prepareStatement("select * from usuario where nombreUsuario=? and clave=?");
            ps.setString(1, nomU);
            ps.setString(2, contraseña);
            ResultSet rs = ps.executeQuery();
            if(rs.next()){
              String id = rs.getString("idUsuario");
              int x = Integer.parseInt(id);
              return x;
            }
            else
            {
                return 0;
                
            }
            
         
     
    }
}

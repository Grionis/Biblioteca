package ws;

import cl.biblioteca.dao.FichaDAO;
import cl.biblioteca.dao.RolDAO;
import cl.biblioteca.dao.UsuarioDAO;
import cl.biblioteca.edm.Ficha;
import cl.biblioteca.edm.Rol;
import cl.biblioteca.edm.Usuario;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import java.io.*;
import java.sql.*;
import javax.swing.JOptionPane;

/**
 *
 * @author Acer
 */
@WebService(serviceName = "Actualizar")
public class Actualizar {

    
    
    @WebMethod
    
    public boolean ActualizarFicha(int idF,String rF, String nF, String dF, String eF, String tF, int hF){
        boolean funciono = true;
        boolean noFunciono = false;
        try {
           cl.biblioteca.negocio.Ficha f = new cl.biblioteca.negocio.Ficha();
           f.actualizarFicha(idF, rF, nF, dF, eF, tF, hF);
            
              return funciono;
            
        } catch (Exception e) {
             System.out.println(e.getMessage());
        }
        return noFunciono;
    }

       @WebMethod
        public boolean actualizarUsuario(int id, String nomU, String pass){
        boolean funciono = true;
        boolean noFunciono = false;
        try {
           
            cl.biblioteca.negocio.Usuario u = new cl.biblioteca.negocio.Usuario();
            u.actualizarUsuario(id ,nomU, pass);
            return funciono;
        } catch (Exception e) {
             System.out.println(e.getMessage());
        }
        return noFunciono;
    }
        @WebMethod
        public boolean actualizarRol(String des){
        boolean funciono = true;
        boolean noFunciono = false;
        try {
           
           cl.biblioteca.negocio.Rol r = new cl.biblioteca.negocio.Rol();
           r.actualizarRol(des);
           return funciono;
        } catch (Exception e) {
             System.out.println(e.getMessage());
        }
        return noFunciono;
    }
    
}

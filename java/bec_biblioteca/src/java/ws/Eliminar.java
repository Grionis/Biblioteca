package ws;

import cl.biblioteca.dao.FichaDAO;
import cl.biblioteca.dao.RolDAO;
import cl.biblioteca.dao.UsuarioDAO;
import cl.biblioteca.edm.Ficha;
import cl.biblioteca.edm.Rol;
import cl.biblioteca.edm.Usuario;
import cl.biblioteca.negocio.Prestamo;
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
@WebService(serviceName = "Eliminar")
public class Eliminar {

    
    
    @WebMethod
    
    public boolean eliminarFicha(int idFicha){
        boolean funciono = true;
        boolean noFunciono = false;
        try {
           cl.biblioteca.negocio.Ficha f = new cl.biblioteca.negocio.Ficha();
            f.eliminarFicha(idFicha);
        } catch (Exception e) {
             System.out.println(e.getMessage());
        }
        return noFunciono;
    }

    @WebMethod
    
     public boolean eliminarUsuario(int idUsuario){
        boolean funciono = true;
        boolean noFunciono = false;
        try {
           cl.biblioteca.negocio.Usuario u = new cl.biblioteca.negocio.Usuario();
           u.eliminarUsuario(idUsuario);
            return funciono;
        } catch (Exception e) {
             System.out.println(e.getMessage());
        }
        return noFunciono;
    }
     
     @WebMethod
     public boolean eliminarRol(int idRol){
        boolean funciono = true;
        boolean noFunciono = false;
        try {
         cl.biblioteca.negocio.Rol r = new cl.biblioteca.negocio.Rol();
            r.eliminarRol(idRol);
            return funciono;
        } catch (Exception e) {
             System.out.println(e.getMessage());
        }
        return noFunciono;
    }
     
     @WebMethod
     public boolean devolver(int idPrestamo){
         try {
         cl.biblioteca.negocio.Prestamo p = new Prestamo();
         
         return p.devolucion(idPrestamo);    
         } catch (Exception e) {
             return false;
         }
         
    }
     
}
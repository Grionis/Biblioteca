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
        public boolean actualizarUsuario(int id, String nomU, String pass,Integer codigo, int r, int f){
        boolean funciono = true;
        boolean noFunciono = false;
        try {
           
            cl.biblioteca.negocio.Usuario u = new cl.biblioteca.negocio.Usuario();
            u.actualizarUsuario(id ,nomU, pass,codigo,r,f);
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
        
        @WebMethod
        public boolean actualizarPrestamoLibro(int idPrestamo, String tipo, String estado, String fechaPrestamo, String fechaDevolucion, int idUsuario, int idLibro, int idMulta){
            try {
                cl.biblioteca.negocio.Prestamo p = new Prestamo();
              return p.actualizarPrestamoLibro(idPrestamo, tipo, estado, fechaPrestamo, fechaDevolucion, idUsuario, idLibro, idMulta);
            } catch (Exception e) {
                return false;
            }
        }
        
        @WebMethod
        public boolean actualizarPrestamoMultimedia(int idPrestamo, String tipo, String estado, String fechaPrestamo, String fechaDevolucion, int idUsuario, int idMultimedia, int idMulta){
            try {
                cl.biblioteca.negocio.Prestamo p = new Prestamo();
                return p.actualizarPrestamoMultimedia(idPrestamo, tipo, estado, fechaPrestamo, fechaDevolucion, idUsuario, idMultimedia, idMulta);
            } catch (Exception e) {
                return false;
            }
        }
        
        @WebMethod
        public boolean actualizarPrestamoMultimediaSinMora(int idPrestamo, String tipo, String estado, String fechaPrestamo, String fechaDevolucion, int idUsuario, int idMultimedia){
            try {
                cl.biblioteca.negocio.Prestamo p = new Prestamo();
              return p.actualizarPrestamoMultimediaSinMora(idPrestamo, tipo, estado, fechaPrestamo, fechaDevolucion, idUsuario, idMultimedia);
            } catch (Exception e) {
                return false;
            }
        }
         @WebMethod
        public boolean actualizarPrestamoLibroSinMora(int idPrestamo, String tipo, String estado, String fechaPrestamo, String fechaDevolucion, int idUsuario, int idLibro){
             try {
                 cl.biblioteca.negocio.Prestamo p = new Prestamo();
                return p.actualizarPrestamoLibroSinMora(idPrestamo, tipo, estado, fechaPrestamo, fechaDevolucion, idUsuario, idLibro);
             } catch (Exception e) {
                 return true;
             }
        }
        
        @WebMethod
        public boolean ActualizarStock(int id, int activo, int prestado, int total, int estante){
        boolean funciono = true;
        boolean noFunciono = false;
        try {
           
            cl.biblioteca.negocio.Stock u = new cl.biblioteca.negocio.Stock();
            u.ActualizarStock(id ,activo, prestado,total, estante);
            return funciono;
        } catch (Exception e) {
             System.out.println(e.getMessage());
        }
        return noFunciono;
    }
}

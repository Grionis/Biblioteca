/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ws;

import cl.biblioteca.negocio.Ficha;
import cl.biblioteca.dao.FichaDAO;
import cl.biblioteca.dao.RolDAO;
import cl.biblioteca.dao.UsuarioDAO;
import cl.biblioteca.edm.Rol;
import cl.biblioteca.edm.Usuario;
import cl.biblioteca.negocio.Estante;
import cl.biblioteca.negocio.Libro;
import cl.biblioteca.negocio.Multa;
import cl.biblioteca.negocio.Multimedia;
import cl.biblioteca.negocio.Prestamo;
import cl.biblioteca.negocio.Stock;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import java.io.*;
import java.sql.*;
import java.text.SimpleDateFormat;
import java.util.List;
import javax.swing.JOptionPane;

/**
 *
 * @author Acer
 */
@WebService(serviceName = "Agregar")
public class Agregar {

    
    
    @WebMethod
  public int insertarFicha(String rF, String nF, String dF, String eF, String tF, int hF){
        
  
           cl.biblioteca.negocio.Ficha f = new Ficha();
           int x = f.insertarFicha(rF, nF, dF, eF, tF, hF);
              
           if (x>0) {
            return x;
        }
         return x;
    }

   @WebMethod
    public boolean insertarUsuario(String nomU, String pass, int activo, int x, int r){
        boolean funciono;
       
        try {
            
           cl.biblioteca.negocio.Usuario u = new cl.biblioteca.negocio.Usuario();
           u.insertarUsuarioRol1(nomU, pass,activo, x,r);
              return funciono = true;
            
        } catch (Exception e) {
             System.out.println(e.getMessage());
             return funciono = false;
        }
        
    }
    @WebMethod
    public boolean insertarUsuario2(String nomU, String pass,int activo, int x, int r){
        boolean funciono;
       
        try {
            
           cl.biblioteca.negocio.Usuario u = new cl.biblioteca.negocio.Usuario();
           u.insertarUsuarioRol2(nomU, pass,activo, x, r);
              return funciono = true;
            
        } catch (Exception e) {
             System.out.println(e.getMessage());
             return funciono = false;
        }
        
    }
     @WebMethod
    public boolean insertarUsuario3(String nomU, String pass, int activo, int x, int r){
        boolean funciono;
       
        try {
            
           cl.biblioteca.negocio.Usuario u = new cl.biblioteca.negocio.Usuario();
           u.insertarUsuarioRol3(nomU, pass,activo, x,r);
              return funciono = true;
            
        } catch (Exception e) {
             System.out.println(e.getMessage());
             return funciono = false;
        }
        
    }
     @WebMethod
    public boolean insertarRol(String des){
        boolean funciono = true;
        try {
            
            cl.biblioteca.negocio.Rol  r = new cl.biblioteca.negocio.Rol();
            r.insertarRol(des);
              return funciono;
            
        } catch (Exception e) {
             System.out.println(e.getMessage());
        }
        return funciono;
    }
    
    @WebMethod
    public int InsertarLibro(String is, String co, String no, String Au, String ge, String fe, int po, int stock)
    {
        boolean funciona = false;
        
        
            cl.biblioteca.negocio.Libro l = new Libro();
            int x =  l.InsertarLibro(is, co, no, Au, ge, fe, po, stock);

          if (x>0) {
            return x;
        }
         return x;
                  
        }
        
    
     @WebMethod
     public int InsertarEstante(String piso, String seccion)
     {
        cl.biblioteca.negocio.Estante est = new Estante();
         int x = est.InsertarEstante(piso, seccion);
         
         if(x != 0)
         {
             return x;
         }
        
         return x;
     } 
            
  
    
    @WebMethod
    public int InsertarStock(int activo, int prestado, int total,int id)
    {
        cl.biblioteca.negocio.Stock st = new Stock();
        int x = st.InsertarStock(activo, prestado, total, id);
        
        if(x != 0)
        {
            return x;
        }
        return x;
    }
    
     @WebMethod
     public int InsertarMultimedia(String codigo, String tipo, String nombre, String autor, String fecha, int idstock)
     {
         cl.biblioteca.negocio.Multimedia mu = new Multimedia();
        int x = mu.InsertarMultimedia(codigo, tipo, nombre, autor, fecha, idstock);
    
         if(x != 0)
            {
                return x;
             }
            return x;
     }
     
      @WebMethod
    public boolean insertaPrestamo(String tipo, String estado, String fechaP, String fechaD, int idUsuario, int idLibro){
        boolean funciono = true;
        boolean noFunciono = false;
        try {
            
            cl.biblioteca.negocio.Prestamo p = new Prestamo();
            p.insertaPrestamo(tipo, estado, fechaP, fechaD, idUsuario, idLibro);
              return funciono;
            
        } catch (Exception e) {
             System.out.println(e.getMessage());
             return noFunciono;
        }
       
    }
    
      @WebMethod
    public boolean insertaPrestamoMultimedia(String tipo, String estado, String fechaP, String fechaD, int idUsuario, int idMultimedia){
        boolean funciono = true;
        boolean noFunciono = false;
        try {
            
            cl.biblioteca.negocio.Prestamo p = new Prestamo();
            p.insertaPrestamoMultimedia(tipo, estado, fechaP, fechaD, idUsuario, idMultimedia);
              return funciono;
            
        } catch (Exception e) {
             System.out.println(e.getMessage());
             return noFunciono;
        }
       
    }
    @WebMethod
    public int insertarMulta(String estado, int tiempo, int total){
        try {
            cl.biblioteca.negocio.Multa m = new Multa();
           return m.insertarMulta(estado, tiempo, total);
        } catch (Exception e) {
            return 0;
        }
    }
}
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
    public boolean insertarUsuario(String nomU, String pass, int x){
        boolean funciono;
       
        try {
            
           cl.biblioteca.negocio.Usuario u = new cl.biblioteca.negocio.Usuario();
           u.insertarUsuarioRol1(nomU, pass, x);
              return funciono = true;
            
        } catch (Exception e) {
             System.out.println(e.getMessage());
             return funciono = false;
        }
        
    }
    @WebMethod
    public boolean insertarUsuario2(String nomU, String pass, int x){
        boolean funciono;
       
        try {
            
           cl.biblioteca.negocio.Usuario u = new cl.biblioteca.negocio.Usuario();
           u.insertarUsuarioRol2(nomU, pass, x);
              return funciono = true;
            
        } catch (Exception e) {
             System.out.println(e.getMessage());
             return funciono = false;
        }
        
    }
     @WebMethod
    public boolean insertarUsuario3(String nomU, String pass, int x){
        boolean funciono;
       
        try {
            
           cl.biblioteca.negocio.Usuario u = new cl.biblioteca.negocio.Usuario();
           u.insertarUsuarioRol3(nomU, pass, x);
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
    public boolean insertaPrestamo(String tipo, String estado, Date fechaP, Date fechaD, cl.biblioteca.edm.Usuario u){
        boolean funciono = true;
        boolean noFunciono = false;
        try {
            
            cl.biblioteca.negocio.Prestamo p = new Prestamo();
            p.insertaPrestamo(tipo, estado, fechaP, fechaD, u);
              return funciono;
            
        } catch (Exception e) {
             System.out.println(e.getMessage());
             return noFunciono;
        }
       
    }
    
    @WebMethod
    public int InsertarLibro(String is, String co, String no, String Au, String ge, String fe, int po, int stock)
    {
        boolean funciona = false;
        SimpleDateFormat formato = new SimpleDateFormat("YYYY-MM-DD");
        
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
    
}
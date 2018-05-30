/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cl.biblioteca.negocio;

import cl.biblioteca.dao.RolDAO;
import java.util.*;
/**
 *
 * @author Acer
 */
public class Rol {

    public Rol() {
    }
    
    public boolean insertarRol(String des){
        boolean funciono = true;
        try {
            
            cl.biblioteca.edm.Rol r = new cl.biblioteca.edm.Rol();
            r.setDescripcion(des);
            
            
            cl.biblioteca.dao.RolDAO rdao = new RolDAO();
            rdao.add(r);
              return funciono;
            
        } catch (Exception e) {
             System.out.println(e.getMessage());
        }
        return funciono;
    }
    
    
    
         public List<cl.biblioteca.edm.Rol> listarRol() {

        try {
            cl.biblioteca.dao.RolDAO rdao = new RolDAO();
            return rdao.getList();
        } catch (Exception e) {
            return null;
        }
    }
         
         
         
        public boolean actualizarRol(String des){
        boolean funciono = true;
        boolean noFunciono = false;
        try {
           
            cl.biblioteca.edm.Rol r = new cl.biblioteca.edm.Rol();
            r.setDescripcion(des);
            
            cl.biblioteca.dao.RolDAO rdao = new RolDAO();
            rdao.update(r);
              return funciono;
            
        } catch (Exception e) {
             System.out.println(e.getMessage());
        }
        return noFunciono;
    }
        
             public boolean eliminarRol(int idRol){
            boolean funciono = true;
            boolean noFunciono = false;
            try {

                cl.biblioteca.edm.Rol r = new cl.biblioteca.edm.Rol();
               r.setIdRol(idRol);

                cl.biblioteca.dao.RolDAO rdao = new RolDAO();
                rdao.delete(r);
                  return funciono;

            } catch (Exception e) {
                 System.out.println(e.getMessage());
            }
            return noFunciono;
        }
}

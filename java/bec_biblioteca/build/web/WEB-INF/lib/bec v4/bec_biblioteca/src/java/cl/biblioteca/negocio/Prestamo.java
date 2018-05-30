/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cl.biblioteca.negocio;
import cl.biblioteca.dao.PrestamoDAO;
import java.util.*;
/**
 *
 * @author Acer
 */
public class Prestamo {

    public Prestamo() {
    }
    
    public boolean insertaPrestamo(String tipo, String estado, Date fechaP, Date fechaD, cl.biblioteca.edm.Usuario u){
        boolean funciono = true;
        boolean noFuncion = false;
        try {
            
            cl.biblioteca.edm.Prestamo p = new cl.biblioteca.edm.Prestamo();
            cl.biblioteca.dao.PrestamoDAO pdao = new PrestamoDAO();
           
            p.setTipo(tipo);
            p.setEstado(estado);
            p.setFechaPrestamo(fechaP);
            p.setFechaDevolucion(fechaD);
            p.setUsuario(u);
            pdao.add(p);
              return funciono;
            
        } catch (Exception e) {
             System.out.println(e.getMessage());
             return noFuncion;
        }
        
    }
}

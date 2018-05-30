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
    
    public boolean insertaPrestamo(String tipo, String estado, String fechaP, String fechaD, int idUsuario, int idLibro){
        boolean funciono = true;
        boolean noFuncion = false;
        try {
            
            cl.biblioteca.edm.Prestamo p = new cl.biblioteca.edm.Prestamo();
            cl.biblioteca.dao.PrestamoDAO pdao = new PrestamoDAO();
            cl.biblioteca.edm.Usuario u = new cl.biblioteca.edm.Usuario();
            cl.biblioteca.edm.Libro l = new cl.biblioteca.edm.Libro();
            u.setIdUsuario(idUsuario);
            l.setIdLibro(idLibro);
            p.setTipo(tipo);
            p.setEstado(estado);
            p.setFechaPrestamo(fechaP);
            p.setFechaDevolucion(fechaD);
            p.setIdUsuario(idUsuario);
            p.setIdLibro(idLibro);
            pdao.add(p);
              return funciono;
            
        } catch (Exception e) {
             System.out.println(e.getMessage());
             return noFuncion;
        }
        
    }
    
    public boolean devolucion(int idPrestamo) {
        
        try {

            cl.biblioteca.edm.Prestamo p = new cl.biblioteca.edm.Prestamo();
            p.setIdPrestamo(idPrestamo);

            cl.biblioteca.dao.PrestamoDAO pDAO = new PrestamoDAO();
            pDAO.delete(p);
            return true;

        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return false;
    }
    
     public boolean insertaPrestamoMultimedia(String tipo, String estado, String fechaP, String fechaD, int idUsuario, int idMultimedia){
        boolean funciono = true;
        boolean noFuncion = false;
        try {
            
            cl.biblioteca.edm.Prestamo p = new cl.biblioteca.edm.Prestamo();
            cl.biblioteca.dao.PrestamoDAO pdao = new PrestamoDAO();
            cl.biblioteca.edm.Usuario u = new cl.biblioteca.edm.Usuario();
            cl.biblioteca.edm.Multimedia m = new cl.biblioteca.edm.Multimedia();
            u.setIdUsuario(idUsuario);
            m.setIdMultimedia(idMultimedia);
            p.setTipo(tipo);
            p.setEstado(estado);
            p.setFechaPrestamo(fechaP);
            p.setFechaDevolucion(fechaD);
            p.setIdUsuario(idUsuario);
            p.setIdMultimedia(idMultimedia);
            pdao.add(p);
              return funciono;
            
        } catch (Exception e) {
             System.out.println(e.getMessage());
             return noFuncion;
        }
        
    }
     
     public boolean actualizarPrestamoLibro(int idPrestamo, String tipo, String estado, String fechaPrestamo, String fechaDevolucion, int idUsuario, int idLibro, int idMulta){
         try {
             cl.biblioteca.edm.Prestamo p = new cl.biblioteca.edm.Prestamo();
             cl.biblioteca.dao.PrestamoDAO pdao = new PrestamoDAO();
             p.setIdPrestamo(idPrestamo);
             p.setTipo(tipo);
             p.setEstado(estado);
             p.setFechaPrestamo(fechaPrestamo);
             p.setFechaDevolucion(fechaDevolucion);
             p.setIdUsuario(idUsuario);
             p.setIdLibro(idLibro);
             p.setIdMulta(idMulta);
             pdao.update(p);
             return true;
         } catch (Exception e) {
             return false;
         }
         
     }
     public boolean actualizarPrestamoMultimedia(int idPrestamo, String tipo, String estado, String fechaPrestamo, String fechaDevolucion, int idUsuario, int idMultimedia, int idMulta){
         try {
             cl.biblioteca.edm.Prestamo p = new cl.biblioteca.edm.Prestamo();
             cl.biblioteca.dao.PrestamoDAO pdao = new PrestamoDAO();
             p.setIdPrestamo(idPrestamo);
             p.setTipo(tipo);
             p.setEstado(estado);
             p.setFechaPrestamo(fechaPrestamo);
             p.setFechaDevolucion(fechaDevolucion);
             p.setIdUsuario(idUsuario);
             p.setIdMultimedia(idMultimedia);
             p.setIdMulta(idMulta);
             pdao.update(p);
             return true;
         } catch (Exception e) {
             return false;
         }
         
     }
     public boolean actualizarPrestamoMultimediaSinMora(int idPrestamo, String tipo, String estado, String fechaPrestamo, String fechaDevolucion, int idUsuario, int idMultimedia){
         try {
             cl.biblioteca.edm.Prestamo p = new cl.biblioteca.edm.Prestamo();
             cl.biblioteca.dao.PrestamoDAO pdao = new PrestamoDAO();
             p.setIdPrestamo(idPrestamo);
             p.setTipo(tipo);
             p.setEstado(estado);
             p.setFechaPrestamo(fechaPrestamo);
             p.setFechaDevolucion(fechaDevolucion);
             p.setIdUsuario(idUsuario);
             p.setIdMultimedia(idMultimedia);
             pdao.update(p);
             return true;
         } catch (Exception e) {
             return false;
         }
         
     }
     
     public boolean actualizarPrestamoLibroSinMora(int idPrestamo, String tipo, String estado, String fechaPrestamo, String fechaDevolucion, int idUsuario, int idLibro){
         try {
             cl.biblioteca.edm.Prestamo p = new cl.biblioteca.edm.Prestamo();
             cl.biblioteca.dao.PrestamoDAO pdao = new PrestamoDAO();
             p.setIdPrestamo(idPrestamo);
             p.setTipo(tipo);
             p.setEstado(estado);
             p.setFechaPrestamo(fechaPrestamo);
             p.setFechaDevolucion(fechaDevolucion);
             p.setIdUsuario(idUsuario);
             p.setIdLibro(idLibro);
             pdao.update(p);
             return true;
         } catch (Exception e) {
             return false;
         }
         
     }
    
}

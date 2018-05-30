/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cl.biblioteca.negocio;

import cl.biblioteca.dao.LibroDAO;
import static com.sun.org.apache.xalan.internal.lib.ExsltDatetime.date;
import java.util.Date;

/**
 *
 * @author Fabia
 */
public class Libro {
    
    public Libro() {}
    
    public int InsertarLibro(String is, String co, String no, String Au, String ge, String fe, int po, int stock) 
    {
        try
        {
        cl.biblioteca.edm.Libro libro = new cl.biblioteca.edm.Libro();
        libro.setIsbn(is);
        libro.setCodigo(co);
        libro.setNombre(no);
        libro.setAutor(Au);
        libro.setGenero(ge);
        libro.setFecha(fe);
        libro.setPopularidad(po);
        libro.setIdstock(stock);
        
        cl.biblioteca.dao.LibroDAO lidao = new LibroDAO();
        int result =  lidao.add(libro);
        return result;
        } catch (Exception e) {
       
        return 0;
        
        }}
    
    
    
}
    
    


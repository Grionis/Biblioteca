/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cl.biblioteca.negocio;

import cl.biblioteca.dao.MultimediaDAO;

/**
 *
 * @author Fabia
 */
public class Multimedia {
    
    public Multimedia(){}
    
    
    public int InsertarMultimedia(String co, String ti, String no, String au, String fe, int id)
    {
        try {
            cl.biblioteca.edm.Multimedia multi = new cl.biblioteca.edm.Multimedia();
            multi.setCodigo(co);
            multi.setTipo(ti);
            multi.setNombre(no);
            multi.setAutor(au);
            multi.setFecha(fe);
            multi.setIdstock(id);
            
            cl.biblioteca.dao.MultimediaDAO mudao = new MultimediaDAO();
            int result = mudao.add(multi);
             return result;       
        } catch (Exception e) {
            return 0;
        }
    }
}

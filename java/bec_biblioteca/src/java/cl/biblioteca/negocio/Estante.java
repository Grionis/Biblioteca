/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cl.biblioteca.negocio;

import cl.biblioteca.dao.EstanteDAO;

/**
 *
 * @author Fabia
 */
public class Estante {
    
    public Estante(){}
    
    public int InsertarEstante(String piso, String seccion)
    {
        
        try {
            cl.biblioteca.edm.Estante estante = new cl.biblioteca.edm.Estante();
            estante.setPiso(piso);
            estante.setSeccion(seccion);
            cl.biblioteca.dao.EstanteDAO estdao = new EstanteDAO();
            int x =estdao.add(estante);
            return x;
            
        } catch (Exception e) {
            
            return 0;
        }
    }
    
}

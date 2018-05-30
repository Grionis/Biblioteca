/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cl.biblioteca.negocio;

import cl.biblioteca.dao.EstanteDAO;
import cl.biblioteca.dao.StockDAO;

/**
 *
 * @author Fabia
 */
public class Stock {
    
    public Stock(){}
    
    
    public int InsertarStock(int activo, int total, int prestado, int idestante)
    {
        try {
             cl.biblioteca.edm.Stock st = new cl.biblioteca.edm.Stock();
        st.setActivo(activo);
        st.setPrestado(prestado);
        st.setTotal(total);
        st.setIdestante(idestante);
        
        cl.biblioteca.dao.StockDAO stDa = new StockDAO();
        
        int x = stDa.add(st);
        
       
            return x;
        } catch (Exception e) {
             return 0;
        }
       
      
       
    }
    
}

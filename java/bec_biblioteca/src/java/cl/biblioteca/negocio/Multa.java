/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cl.biblioteca.negocio;

import cl.biblioteca.dao.MultaDAO;

/**
 *
 * @author MLAGOS
 */
public class Multa {
    public int insertarMulta(String estado, int tiempo, int total){
        try {
             cl.biblioteca.edm.Multa m = new cl.biblioteca.edm.Multa();
             cl.biblioteca.dao.MultaDAO mdao = new MultaDAO();
             m.setEstado(estado);
             m.setTiempo(tiempo);
             m.setTotal(total);
             return mdao.add(m);
        } catch (Exception e) {
            return 0;
        }
       
        
    }
}

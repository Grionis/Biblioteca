/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cl.biblioteca.negocio;

import java.util.*;
import cl.biblioteca.dao.FichaDAO;

import javax.swing.JComboBox;

/**
 *
 * @author Acer
 */
public class Ficha {

    public Ficha() {
    }

    public int insertarFicha(String rF, String nF, String dF, String eF, String tF, int hF) {

        try {

            cl.biblioteca.edm.Ficha ficha = new cl.biblioteca.edm.Ficha();

            ficha.setRut(rF);
            ficha.setNombres(nF);
            ficha.setDireccion(dF);
            ficha.setCorreo(eF);
            ficha.setTelefono(tF);
            // ficha.setFotografiaFicha(fF);
            ficha.setHuella(hF);

            cl.biblioteca.dao.FichaDAO fDAO = new FichaDAO();
            int x = fDAO.add(ficha);

            return x;
        } catch (Exception e) {
            return 0;

        }

    }

    public List<cl.biblioteca.edm.Ficha> listarFicha() {

        try {
            cl.biblioteca.dao.FichaDAO fdao = new FichaDAO();
            return fdao.getList();
        } catch (Exception e) {
            return null;
        }
    }

    public List<cl.biblioteca.edm.Ficha> listarFichaEspecifica() {

        try {
            cl.biblioteca.dao.FichaDAO fdao = new FichaDAO();
            return fdao.getList();
        } catch (Exception e) {
            return null;
        }
    }
    
    public boolean actualizarFicha(int idF, String rF, String nF, String dF, String eF, String tF, int hF) {
        boolean funciono = true;
        boolean noFunciono = false;
        try {

            cl.biblioteca.edm.Ficha f = new cl.biblioteca.edm.Ficha();
            f.setIdFicha(idF);
            f.setRut(rF);
            f.setNombres(eF);
            f.setDireccion(dF);
            f.setCorreo(eF);
            f.setTelefono(tF);
            // ficha.setFotografiaFicha(fF);
            f.setHuella(hF);

            cl.biblioteca.dao.FichaDAO fDAO = new FichaDAO();
            fDAO.update(f);
            return funciono;

        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return noFunciono;
    }

    public boolean eliminarFicha(int idFicha) {
        boolean funciono = true;
        boolean noFunciono = false;
        try {

            cl.biblioteca.edm.Ficha f = new cl.biblioteca.edm.Ficha();
            f.setIdFicha(idFicha);

            cl.biblioteca.dao.FichaDAO fDAO = new FichaDAO();
            fDAO.delete(f);
            return funciono;

        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return noFunciono;
    }

}

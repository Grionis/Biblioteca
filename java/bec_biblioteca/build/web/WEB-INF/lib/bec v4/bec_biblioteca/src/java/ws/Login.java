/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ws;

import cl.biblioteca.dao.FichaDAO;
import cl.biblioteca.dao.RolDAO;
import cl.biblioteca.dao.UsuarioDAO;
import cl.biblioteca.edm.Ficha;
import cl.biblioteca.edm.Rol;
import cl.biblioteca.edm.Usuario;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import java.io.*;
import java.sql.*;
import javax.swing.JOptionPane;

/**
 *
 * @author Acer
 */
@WebService(serviceName = "Login")
public class Login {

    
    
    @WebMethod
    
    public boolean iniciarSesion(int idU){
        boolean pasa = true;
        boolean noPasa = false;
        try {
           
           
            cl.biblioteca.dao.UsuarioDAO udao = new UsuarioDAO();
            udao.getUsuarioById(idU);
            
            
            
            if (idU == 3) {
                return pasa;
            }
            
        } catch (Exception e) {
             System.out.println(e.getMessage());
        }
        return noPasa;
    }

    
    
}
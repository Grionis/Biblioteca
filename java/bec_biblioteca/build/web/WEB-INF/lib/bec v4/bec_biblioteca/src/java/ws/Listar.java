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
import java.util.List;
import javax.swing.JOptionPane;

/**
 *
 * @author Acer
 */
@WebService(serviceName = "Listar")
public class Listar {

    @WebMethod
    public List<cl.biblioteca.edm.Ficha> listarFicha() {

        try {
            cl.biblioteca.dao.FichaDAO fdao = new FichaDAO();
             
            return fdao.getList();
        } catch (Exception e) {
            return null;
        }

    }

    @WebMethod
    public List<cl.biblioteca.edm.Usuario> listarUsuario() {

        try {
            cl.biblioteca.dao.UsuarioDAO udao = new UsuarioDAO();
            List<cl.biblioteca.edm.Usuario> l = udao.getList();
            return l;
        } catch (Exception e) {
            return null;
        }

    }

    @WebMethod
    public List<cl.biblioteca.edm.Rol> listarRol() {

        cl.biblioteca.dao.RolDAO r = new RolDAO();
        try {
            List<cl.biblioteca.edm.Rol> l = r.getList();
            
            return l;
        } catch (Exception e) {
            return null;
        }
    }
}

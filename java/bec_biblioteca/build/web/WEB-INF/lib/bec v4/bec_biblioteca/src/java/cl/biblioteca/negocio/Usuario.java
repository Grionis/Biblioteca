/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cl.biblioteca.negocio;

import cl.biblioteca.dao.FichaDAO;
import cl.biblioteca.dao.RolDAO;
import cl.biblioteca.dao.UsuarioDAO;
import java.util.List;
import javax.swing.JComboBox;

/**
 *
 * @author Acer
 */
public class Usuario {

    public Usuario() {
    }
    
    public void insertarUsuarioRol1(String nomU, String pass, int x){
       
        try {
            
            cl.biblioteca.edm.Usuario usuario = new cl.biblioteca.edm.Usuario();
            cl.biblioteca.edm.Rol r = new cl.biblioteca.edm.Rol();
            cl.biblioteca.edm.Ficha fi = new cl.biblioteca.edm.Ficha();
            //cl.biblioteca.dao.FichaDAO f = new FichaDAO();
             //x = f.add(fi);
            fi.setIdFicha(x);
            r.setIdRol(1);
            usuario.setNombreUsuario(nomU);
            usuario.setClave(pass);
            usuario.setRol(r);
            usuario.setFicha(fi);
           // ficha.setFotografiaFicha(fF);
            
            
            cl.biblioteca.dao.UsuarioDAO udao = new UsuarioDAO();
            udao.add(usuario);
              
            
        } catch (Exception e) {
             System.out.println(e.getMessage());
        }
        
    }
    
    public void insertarUsuarioRol2(String nomU, String pass, int x){
       
        try {
            
            cl.biblioteca.edm.Usuario usuario = new cl.biblioteca.edm.Usuario();
            cl.biblioteca.edm.Rol r = new cl.biblioteca.edm.Rol();
            cl.biblioteca.edm.Ficha fi = new cl.biblioteca.edm.Ficha();
            //cl.biblioteca.dao.FichaDAO f = new FichaDAO();
             //x = f.add(fi);
            fi.setIdFicha(x);
            r.setIdRol(2);
            usuario.setNombreUsuario(nomU);
            usuario.setClave(pass);
            usuario.setRol(r);
            usuario.setFicha(fi);
           // ficha.setFotografiaFicha(fF);
            
            
            cl.biblioteca.dao.UsuarioDAO udao = new UsuarioDAO();
            udao.add(usuario);
              
            
        } catch (Exception e) {
             System.out.println(e.getMessage());
        }
        
    }
    
    public void insertarUsuarioRol3(String nomU, String pass, int x){
       
        try {
            
            cl.biblioteca.edm.Usuario usuario = new cl.biblioteca.edm.Usuario();
            cl.biblioteca.edm.Rol r = new cl.biblioteca.edm.Rol();
            cl.biblioteca.edm.Ficha fi = new cl.biblioteca.edm.Ficha();
            //cl.biblioteca.dao.FichaDAO f = new FichaDAO();
             //x = f.add(fi);
            fi.setIdFicha(x);
            r.setIdRol(3);
            usuario.setNombreUsuario(nomU);
            usuario.setClave(pass);
            usuario.setRol(r);
            usuario.setFicha(fi);
           // ficha.setFotografiaFicha(fF);
            
            
            cl.biblioteca.dao.UsuarioDAO udao = new UsuarioDAO();
            udao.add(usuario);
              
            
        } catch (Exception e) {
             System.out.println(e.getMessage());
        }
        
    }
         public List<cl.biblioteca.edm.Usuario> listarFicha() {

        try {
            cl.biblioteca.dao.UsuarioDAO udao = new UsuarioDAO();
            return udao.getList();
        } catch (Exception e) {
            return null;
        }
    }
         
         
         
        public boolean actualizarUsuario(int id, String nomU, String pass){
        boolean funciono = true;
        boolean noFunciono = false;
        try {
           
            cl.biblioteca.edm.Usuario u = new cl.biblioteca.edm.Usuario();
            u.setIdUsuario(id);
            u.setNombreUsuario(nomU);
            u.setClave(pass);
            
            cl.biblioteca.dao.UsuarioDAO udao = new UsuarioDAO();
            udao.update(u);
              return funciono;
            
        } catch (Exception e) {
             System.out.println(e.getMessage());
        }
        return noFunciono;
    }
        
         public boolean eliminarUsuario(int idUsuario){
        boolean funciono = true;
        boolean noFunciono = false;
        try {
           
            cl.biblioteca.edm.Usuario u = new cl.biblioteca.edm.Usuario();
            u.setIdUsuario(idUsuario);
            
            cl.biblioteca.dao.UsuarioDAO udao = new UsuarioDAO();
            udao.delete(u);
              return funciono;
            
        } catch (Exception e) {
             System.out.println(e.getMessage());
        }
        return noFunciono;
    }

}

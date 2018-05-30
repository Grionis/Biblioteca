/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ws;

import cl.biblioteca.dao.EstanteDAO;
import cl.biblioteca.dao.FichaDAO;
import cl.biblioteca.dao.LibroDAO;
import cl.biblioteca.dao.MultaDAO;
import cl.biblioteca.dao.MultimediaDAO;
import cl.biblioteca.dao.PrestamoDAO;
import cl.biblioteca.dao.RolDAO;
import cl.biblioteca.dao.StockDAO;
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
    public List<cl.biblioteca.edm.Stock> listarStockPorId(int id) {

        try {
            cl.biblioteca.dao.StockDAO sdao = new StockDAO();
             List<cl.biblioteca.edm.Stock> s = sdao.getStockById(id);
            return s;
        } catch (Exception e) {
            return null;
        }

    }
    @WebMethod
    public List<cl.biblioteca.edm.Ficha> listarFicha() {

        try {
            cl.biblioteca.dao.FichaDAO fdao = new FichaDAO();
             List<cl.biblioteca.edm.Ficha> f = fdao.getList();
            return f;
        } catch (Exception e) {
            return null;
        }

    }

    @WebMethod
    public List<cl.biblioteca.edm.Prestamo> ListarPrestamo()
    {
        try {
            cl.biblioteca.dao.PrestamoDAO pdao = new PrestamoDAO();
            List<cl.biblioteca.edm.Prestamo> p = pdao.getList();
            return p;
                    
        } catch (Exception e) {
            return null;
        }
    }
      @WebMethod
    public List<cl.biblioteca.edm.Prestamo> PrestamoMayor()
    {
        try {
            cl.biblioteca.dao.PrestamoDAO pdao = new PrestamoDAO();
            List<cl.biblioteca.edm.Prestamo> p = pdao.PrestamoMayor();
            return p;
                    
        } catch (Exception e) {
            return null;
        }
    }
     public List<cl.biblioteca.edm.Prestamo> PrestamoPendiente()
    {
        try {
            cl.biblioteca.dao.PrestamoDAO pdao = new PrestamoDAO();
            List<cl.biblioteca.edm.Prestamo> p = pdao.PrestamoPendiente();
            return p;
                    
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
    public List<cl.biblioteca.edm.Usuario> listarUsuarioPorId(int id) {

        try {
            
            cl.biblioteca.dao.UsuarioDAO udao = new UsuarioDAO();
            List<cl.biblioteca.edm.Usuario> l = udao.getUsuarioById(id);
            return l;
        } catch (Exception e) {
            return null;
        }

    }

    
    @WebMethod
    public List<cl.biblioteca.edm.Usuario> listarUsuarioPorNombre(String name)
    {
          try {
            cl.biblioteca.dao.UsuarioDAO udao = new UsuarioDAO();
            List<cl.biblioteca.edm.Usuario> l = udao.getUsuarioByNombre(name);
            
            
            return l;
        } catch (Exception e) {
            return null;
        }
    }  
          
    @WebMethod
    public List<cl.biblioteca.edm.Ficha> listarFichaPorId(int id)
    {
        
          try {
            cl.biblioteca.dao.FichaDAO udao = new FichaDAO();
            List<cl.biblioteca.edm.Ficha> l = udao.getFichaById(id);
            
            
            return l;
        } catch (Exception e) {
            return null;
        }
        
    }
    
      @WebMethod
    public List<cl.biblioteca.edm.Prestamo> ListarPrestamoPorId(int id)
    {
        try {
            cl.biblioteca.dao.PrestamoDAO pdao = new PrestamoDAO();
            List<cl.biblioteca.edm.Prestamo> p = pdao.getPrestamoById(id);
            return p;
                    
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
    
      @WebMethod
    public List<cl.biblioteca.edm.Libro> listarLibro() {

        cl.biblioteca.dao.LibroDAO lib = new LibroDAO();
        try {
            List<cl.biblioteca.edm.Libro> l = lib.getList();
            
            return l;
        } catch (Exception e) {
            return null;
        }
    }
    
      @WebMethod
    public List<cl.biblioteca.edm.Libro> listarLibroPorId(int id) {

        cl.biblioteca.dao.LibroDAO lib = new LibroDAO();
        try {
            List<cl.biblioteca.edm.Libro> l = lib.getLibroById(id);
            
            return l;
        } catch (Exception e) {
            return null;
        }
    }
    
    
    @WebMethod
    public List<cl.biblioteca.edm.Multimedia> listarMultimedia() {

        cl.biblioteca.dao.MultimediaDAO mul = new MultimediaDAO();
        try {
            List<cl.biblioteca.edm.Multimedia> m = mul.getList();
            
            return m;
        } catch (Exception e) {
            return null;
        }
    }
    
     @WebMethod
    public List<cl.biblioteca.edm.Libro> ListarLibroPorNombre(String nombre)
    {
         try {
            cl.biblioteca.dao.LibroDAO udao = new LibroDAO();
            List<cl.biblioteca.edm.Libro> l = udao.getLibroByNombre(nombre);
            
            
            return l;
        } catch (Exception e) {
            return null;
        }
    }
    
     @WebMethod
    public List<cl.biblioteca.edm.Multimedia> ListarMultimediaPorNombre(String nombre)
    {
         try {
            cl.biblioteca.dao.MultimediaDAO udao = new MultimediaDAO();
            List<cl.biblioteca.edm.Multimedia> l = udao.getMultimediaByNombre(nombre);
            
            
            return l;
        } catch (Exception e) {
            return null;
        }
    }
  
    @WebMethod
    public List<cl.biblioteca.edm.Prestamo> ListarPrestamoPorIdLibro(int id)
    {
        try {
            cl.biblioteca.dao.PrestamoDAO pdao = new PrestamoDAO();
            List<cl.biblioteca.edm.Prestamo> p = pdao.getPrestamoByIdLibro(id);
            return p;
                    
        } catch (Exception e) {
            return null;
        }
    }
    
    @WebMethod
    public int listarLibroByCodigo(String Codigo) {

        cl.biblioteca.dao.LibroDAO lib = new LibroDAO();
        try {
           return lib.getLibroByCodigo(Codigo);
            
           
        } catch (Exception e) {
            return 0;
        }
    }
    
     @WebMethod
    public List<cl.biblioteca.edm.Prestamo> ListarPrestamoPorIdMultimedia(int id)
    {
        try {
            cl.biblioteca.dao.PrestamoDAO pdao = new PrestamoDAO();
            List<cl.biblioteca.edm.Prestamo> p = pdao.getPrestamoByIdMultimedia(id);
            return p;
                    
        } catch (Exception e) {
            return null;
        }
    }
    
    @WebMethod
    public int listarMultimediaByCodigo(String Codigo) {

        cl.biblioteca.dao.MultimediaDAO mult = new MultimediaDAO();
        try {
           return mult.getMultimediaByCodigo(Codigo);
            
           
        } catch (Exception e) {
            return 0;
        }
    }
    
    @WebMethod
    public List<cl.biblioteca.edm.Multimedia>ListarMultimediaPorId(int id) {
            try {
            cl.biblioteca.dao.MultimediaDAO pdao = new MultimediaDAO();
            List<cl.biblioteca.edm.Multimedia> p = pdao.getMultimediaById(id);
            return p;
                    
        } catch (Exception e) {
            return null;
        }
    }
    
     @WebMethod
    public List<cl.biblioteca.edm.Stock>ListarStock() {
            try {
            cl.biblioteca.dao.StockDAO pdao = new StockDAO();
            List<cl.biblioteca.edm.Stock> p = pdao.getList();
            return p;
                    
        } catch (Exception e) {
            return null;
        }
    }
    
     @WebMethod
    public boolean StockMayor(int id) {
            try {
            cl.biblioteca.dao.StockDAO pdao = new StockDAO();
            boolean  p = pdao.ListarMayor(id);
            return p;
                    
        } catch (Exception e) {
            return false;
        }
    }
    
    @WebMethod
    public int Prestados(int id) {
            try {
            cl.biblioteca.dao.StockDAO pdao = new StockDAO();
            int  p = pdao.Prestados(id);
            return p;
                    
        } catch (Exception e) {
            return 0;
        }
    }
    
     @WebMethod
    public List<cl.biblioteca.edm.Estante> listarEstante() {
            try {
            cl.biblioteca.dao.EstanteDAO pdao = new EstanteDAO();
            List<cl.biblioteca.edm.Estante> e = pdao.getList();
            return e;
                    
        } catch (Exception e) {
            return null;
        }
    }
    
}

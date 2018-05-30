//v1.0.0
package cl.biblioteca.dao;

import cl.biblioteca.dal.HibernateUtil;
import cl.biblioteca.edm.Usuario;
import java.math.BigInteger;
import java.util.List;
import org.hibernate.Query;
import org.hibernate.Session;
import org.hibernate.Transaction;
import org.hibernate.criterion.Restrictions;

public class UsuarioDAO {
    public int add(cl.biblioteca.edm.Usuario u) throws Exception {
        Session sessionA = HibernateUtil.getSessionFactory().openSession();
        sessionA.beginTransaction();
        try 
        {
            sessionA.save(u);
            sessionA.getTransaction().commit();
            int result = ((BigInteger) sessionA.createSQLQuery("SELECT LAST_INSERT_ID()")
            .uniqueResult()).intValue();
            sessionA.close();
            
            return result;
        } 
        catch (Exception e) 
        {
            sessionA.getTransaction().rollback();
            sessionA.close();
            System.err.println(e.getMessage());
            throw e;            
        }      
    }
    
    
    
    
    public List<cl.biblioteca.edm.Usuario> getList() throws Exception {
        
        Session session = HibernateUtil.getSessionFactory().openSession();
        session.beginTransaction();
        try 
        {
            
            List<cl.biblioteca.edm.Usuario> lista =  (List<cl.biblioteca.edm.Usuario>) session.createCriteria(cl.biblioteca.edm.Usuario.class).list(); 
            session.getTransaction().commit();
            return lista;
        } 
        catch (Exception e) 
        {
            session.getTransaction().rollback();
            session.close();
            System.err.println(e.getMessage());
            throw e;
        } 
        finally
        {
            session.close();
        }
    }
    
    public boolean delete(cl.biblioteca.edm.Usuario u) throws Exception {
        Session session = HibernateUtil.getSessionFactory().openSession();
        session.beginTransaction();
        try 
        {
            session.delete(u);
            session.getTransaction().commit();
            session.close();
            return true;  
        } catch (Exception e) 
        {
            session.getTransaction().rollback();
            session.close();
            System.err.println(e.getMessage());
            throw e;
        } 
    }
     
    public boolean update(cl.biblioteca.edm.Usuario u) throws Exception {
        Session session = HibernateUtil.getSessionFactory().openSession();
        session.beginTransaction();
        try 
        {
            session.update(u);
            session.getTransaction().commit();
            session.close();
            return true;  
        } catch (Exception e) 
        {
            session.getTransaction().rollback();
            session.close();
            System.err.println(e.getMessage());
            throw e;
        } 
    }
    
    public List<cl.biblioteca.edm.Usuario> getUsuarioById(int id) throws Exception
    {
         Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            session.beginTransaction();

            List<cl.biblioteca.edm.Usuario> tmp = (List<cl.biblioteca.edm.Usuario>) session.createCriteria(cl.biblioteca.edm.Usuario.class)
                    .add(Restrictions.eq("idUsuario", id)).list();
                    
            session.getTransaction().commit();
            session.close();
            return tmp;

        } catch (Exception e) 
        {
            System.err.print(e.getMessage());
            session.close();
            throw e;
        }
        
    }
    
    public List<cl.biblioteca.edm.Usuario> getUsuarioByNombre(String DS) throws Exception
    {
         Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            session.beginTransaction();

        List<cl.biblioteca.edm.Usuario> tmp = (List<cl.biblioteca.edm.Usuario>) session.createCriteria(cl.biblioteca.edm.Usuario.class)
                    .add(Restrictions.eq("nombreUsuario", DS)).list();
                    
            session.getTransaction().commit();
            session.close();
            return tmp;

        } catch (Exception e) 
        {
            System.err.print(e.getMessage());
            session.close();
            throw e;
        }
        
    
    }
    
    //Obtiene todos los datos de usuario
    public List<cl.biblioteca.edm.Usuario> getall() {
        
        Session session = HibernateUtil.getSessionFactory().openSession();

        Transaction tran = session.beginTransaction();
        Query query = session.createQuery("From usuario");
        List<cl.biblioteca.edm.Usuario> listaLogin = (List<cl.biblioteca.edm.Usuario>)query.list();
        tran.commit();
        session.close();
        return listaLogin;
        
    }
    
  
    
     
     public List<cl.biblioteca.edm.Usuario> getListbyname(String name) throws Exception {
        
        Session session = HibernateUtil.getSessionFactory().openSession();
        session.beginTransaction();
        try 
        {
            
            List<cl.biblioteca.edm.Usuario> lista =  (List<cl.biblioteca.edm.Usuario>) session.createCriteria(cl.biblioteca.edm.Usuario.class).list(); 
            
            for (Usuario usuario : lista) {
                
            if(usuario.getNombreUsuario() == name);
            session.getTransaction().commit();
            return lista;
            }
            return lista;
        } 
        catch (Exception e) 
        {
            session.getTransaction().rollback();
            session.close();
            System.err.println(e.getMessage());
            throw e;
        } 
        finally
        {
            session.close();
        }
    }
}





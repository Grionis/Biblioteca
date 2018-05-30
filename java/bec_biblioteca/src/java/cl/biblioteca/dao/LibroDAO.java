//v1.0.0
package cl.biblioteca.dao;

import cl.biblioteca.dal.HibernateUtil;
import cl.biblioteca.edm.Libro;
import java.math.BigInteger;
import java.util.List;
import org.hibernate.Session;
import org.hibernate.criterion.Restrictions;

public class LibroDAO {
    public int add(cl.biblioteca.edm.Libro l) throws Exception {
        Session sessionA = HibernateUtil.getSessionFactory().openSession();
        sessionA.beginTransaction();
        try 
        {
            sessionA.save(l);
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
    
    public List<cl.biblioteca.edm.Libro> getList() throws Exception {
        
        Session session = HibernateUtil.getSessionFactory().openSession();
        session.beginTransaction();
        try 
        {
            
            List<cl.biblioteca.edm.Libro> lista =  (List<cl.biblioteca.edm.Libro>) session.createCriteria(cl.biblioteca.edm.Libro.class)
                    .add(Restrictions.isNotNull("idLibro")).list();
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
    
    public boolean delete(cl.biblioteca.edm.Libro l) throws Exception {
        Session session = HibernateUtil.getSessionFactory().openSession();
        session.beginTransaction();
        try 
        {
            session.delete(l);
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
     
    public boolean update(cl.biblioteca.edm.Libro l) throws Exception {
        Session session = HibernateUtil.getSessionFactory().openSession();
        session.beginTransaction();
        try 
        {
            session.update(l);
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
    
    public List<cl.biblioteca.edm.Libro> getLibroById(int id) throws Exception
    {
         Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            session.beginTransaction();

            List<cl.biblioteca.edm.Libro> tmp = (List<cl.biblioteca.edm.Libro>) session.createCriteria(cl.biblioteca.edm.Libro.class)
                    .add(Restrictions.eq("idLibro", id)).list();
                    
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
    
    public List<cl.biblioteca.edm.Libro> getLibroByNombre(String DS) throws Exception
    {
       Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            session.beginTransaction();
       
            List<cl.biblioteca.edm.Libro> tmp = (List<cl.biblioteca.edm.Libro>) session.createCriteria(cl.biblioteca.edm.Libro.class)
                    .add(Restrictions.like("nombre", DS+"%")).list();
            
            
            if(tmp.isEmpty())
            {
                 tmp = (List<cl.biblioteca.edm.Libro>) session.createCriteria(cl.biblioteca.edm.Libro.class)
                    .add(Restrictions.like("autor", DS+"%")).list();
                 
                 if(tmp.isEmpty())
                 {
                    
                     tmp = (List<cl.biblioteca.edm.Libro>) session.createCriteria(cl.biblioteca.edm.Libro.class)
                    .add(Restrictions.like("genero", DS+"%")).list();
                 }
            }
            
                    
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
    
     public int getLibroByCodigo(String codigo) throws Exception
    {
         Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            session.beginTransaction();

            cl.biblioteca.edm.Libro tmp = (cl.biblioteca.edm.Libro) session.createCriteria(cl.biblioteca.edm.Libro.class)
                    .add(Restrictions.eq("codigo", codigo))
                    .uniqueResult();
            session.getTransaction().commit();
            session.close();
            return tmp.getIdLibro();

        } catch (Exception e) 
        {
            System.err.print(e.getMessage());
            session.close();
            throw e;
        }
        
    }
}



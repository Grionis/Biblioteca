//v1.0.0
package cl.biblioteca.dao;

import cl.biblioteca.dal.HibernateUtil;
import java.math.BigInteger;
import java.util.List;
import org.hibernate.Session;
import org.hibernate.criterion.Restrictions;

public class MultimediaDAO {
    public int add(cl.biblioteca.edm.Multimedia mu) throws Exception {
        Session sessionA = HibernateUtil.getSessionFactory().openSession();
        sessionA.beginTransaction();
        try 
        {
            sessionA.save(mu);
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
    
    public List<cl.biblioteca.edm.Multimedia> getList() throws Exception {
        
        Session session = HibernateUtil.getSessionFactory().openSession();
        session.beginTransaction();
        try 
        {
            
            List<cl.biblioteca.edm.Multimedia> lista =  (List<cl.biblioteca.edm.Multimedia>) session.createCriteria(cl.biblioteca.edm.Multimedia.class).list(); 
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
    
    public boolean delete(cl.biblioteca.edm.Multimedia mu) throws Exception {
        Session session = HibernateUtil.getSessionFactory().openSession();
        session.beginTransaction();
        try 
        {
            session.delete(mu);
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
     
    public boolean update(cl.biblioteca.edm.Multimedia mu) throws Exception {
        Session session = HibernateUtil.getSessionFactory().openSession();
        session.beginTransaction();
        try 
        {
            session.update(mu);
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
    
    public cl.biblioteca.edm.Multimedia getMultimediaById(int id) throws Exception
    {
         Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            session.beginTransaction();

            cl.biblioteca.edm.Multimedia tmp = (cl.biblioteca.edm.Multimedia) session.createCriteria(cl.biblioteca.edm.Multimedia.class)
                    .add(Restrictions.eq("multimediaId", id))
                    .uniqueResult();
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
    
    public cl.biblioteca.edm.Multimedia getMultimediaByNombre(String DS) throws Exception
    {
         Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            session.beginTransaction();

            cl.biblioteca.edm.Multimedia tmp = (cl.biblioteca.edm.Multimedia) session.createCriteria(cl.biblioteca.edm.Multimedia.class)
                    .add(Restrictions.eq("multimediaNombre", DS))
                    .uniqueResult();
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
}




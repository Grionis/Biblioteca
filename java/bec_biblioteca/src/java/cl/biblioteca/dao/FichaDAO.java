//v1.0.0
package cl.biblioteca.dao;

import cl.biblioteca.dal.HibernateUtil;
import cl.biblioteca.edm.Ficha;
import java.math.BigInteger;
import java.util.List;
import org.hibernate.Session;
import org.hibernate.criterion.Restrictions;

public class FichaDAO {
    public int add(cl.biblioteca.edm.Ficha f) throws Exception {
        Session sessionA = HibernateUtil.getSessionFactory().openSession();
        sessionA.beginTransaction();
        try 
        {
            sessionA.save(f);
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
    
    public List<cl.biblioteca.edm.Ficha> getList() throws Exception {
        
        Session session = HibernateUtil.getSessionFactory().openSession();
       
        try 
        {
          
            session.beginTransaction();
            List<cl.biblioteca.edm.Ficha> lista =  (List<cl.biblioteca.edm.Ficha>) session.createCriteria(cl.biblioteca.edm.Ficha.class)
                    .add(Restrictions.isNotNull("idFicha")).list();
            
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
    
    public boolean delete(cl.biblioteca.edm.Ficha f) throws Exception {
        Session session = HibernateUtil.getSessionFactory().openSession();
        session.beginTransaction();
        try 
        {
            session.delete(f);
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
     
    public boolean update(cl.biblioteca.edm.Ficha f) throws Exception {
        Session session = HibernateUtil.getSessionFactory().openSession();
        session.beginTransaction();
        try 
        {
            session.update(f);
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
    
    public List<cl.biblioteca.edm.Ficha> getFichaById(int id) throws Exception
    {
         Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            session.beginTransaction();

            List<cl.biblioteca.edm.Ficha> tmp = (List<cl.biblioteca.edm.Ficha>) session.createCriteria(cl.biblioteca.edm.Ficha.class)
                    .add(Restrictions.eq("idFicha", id)).list();
                    
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
    
    public cl.biblioteca.edm.Ficha getFichaByNombre(String DS) throws Exception
    {
         Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            session.beginTransaction();

            cl.biblioteca.edm.Ficha tmp = (cl.biblioteca.edm.Ficha) session.createCriteria(cl.biblioteca.edm.Ficha.class)
                    .add(Restrictions.eq("nombreFicha", DS))
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


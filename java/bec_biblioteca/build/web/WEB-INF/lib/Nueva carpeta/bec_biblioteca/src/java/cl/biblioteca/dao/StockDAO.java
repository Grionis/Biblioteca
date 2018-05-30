//v1.0.0
package cl.biblioteca.dao;

import cl.biblioteca.dal.HibernateUtil;
import java.math.BigInteger;
import java.util.List;
import org.hibernate.Session;
import org.hibernate.criterion.Restrictions;

public class StockDAO {
    public int add(cl.biblioteca.edm.Stock s) throws Exception {
        Session sessionA = HibernateUtil.getSessionFactory().openSession();
        sessionA.beginTransaction();
        try 
        {
            sessionA.save(s);
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
    
    public List<cl.biblioteca.edm.Stock> getList() throws Exception {
        
        Session session = HibernateUtil.getSessionFactory().openSession();
        session.beginTransaction();
        try 
        {
            
            List<cl.biblioteca.edm.Stock> lista =  (List<cl.biblioteca.edm.Stock>) session.createCriteria(cl.biblioteca.edm.Stock.class).list(); 
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
    
    public boolean delete(cl.biblioteca.edm.Stock s) throws Exception {
        Session session = HibernateUtil.getSessionFactory().openSession();
        session.beginTransaction();
        try 
        {
            session.delete(s);
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
     
    public boolean update(cl.biblioteca.edm.Stock s) throws Exception {
        Session session = HibernateUtil.getSessionFactory().openSession();
        session.beginTransaction();
        try 
        {
            session.update(s);
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
    
    public cl.biblioteca.edm.Stock getStockById(int id) throws Exception
    {
         Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            session.beginTransaction();

            cl.biblioteca.edm.Stock tmp = (cl.biblioteca.edm.Stock) session.createCriteria(cl.biblioteca.edm.Stock.class)
                    .add(Restrictions.eq("stockId", id))
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
    
    public cl.biblioteca.edm.Stock getStockByNombre(String DS) throws Exception
    {
         Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            session.beginTransaction();

            cl.biblioteca.edm.Stock tmp = (cl.biblioteca.edm.Stock) session.createCriteria(cl.biblioteca.edm.Stock.class)
                    .add(Restrictions.eq("stockNombre", DS))
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




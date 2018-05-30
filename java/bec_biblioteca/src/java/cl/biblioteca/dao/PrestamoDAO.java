//v1.0.0
package cl.biblioteca.dao;

import cl.biblioteca.dal.HibernateUtil;
import java.math.BigInteger;
import java.util.Calendar;
import java.util.GregorianCalendar;
import java.util.List;
import java.util.Map;
import org.hibernate.Query;
import org.hibernate.Session;
import org.hibernate.criterion.Restrictions;

public class PrestamoDAO {
    public int add(cl.biblioteca.edm.Prestamo p) throws Exception {
        Session sessionA = HibernateUtil.getSessionFactory().openSession();
        sessionA.beginTransaction();
        try 
        {
            sessionA.save(p);
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
    
    public List<cl.biblioteca.edm.Prestamo> getList() throws Exception {
        
        Session session = HibernateUtil.getSessionFactory().openSession();
        session.beginTransaction();
        try 
        {
            
            List<cl.biblioteca.edm.Prestamo> lista =  (List<cl.biblioteca.edm.Prestamo>) session.createCriteria(cl.biblioteca.edm.Prestamo.class)
                    .add(Restrictions.isNotNull("idPrestamo")).list(); 
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
    
    public List<cl.biblioteca.edm.Prestamo> PrestamoMayor() throws Exception {
        
        Session session = HibernateUtil.getSessionFactory().openSession();
        session.beginTransaction();
        try 
        {
            
            List<cl.biblioteca.edm.Prestamo> lista =  (List<cl.biblioteca.edm.Prestamo>) session.createCriteria(cl.biblioteca.edm.Prestamo.class)
                    .add(Restrictions.conjunction()
                    .add(Restrictions.gt("idMulta", 0))
                    .add(Restrictions.and(Restrictions.eq("estado", "Domicilio")))).list();
                    
           
           
            
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
    
     public List<cl.biblioteca.edm.Prestamo> PrestamoPendiente() throws Exception {
        
        Session session = HibernateUtil.getSessionFactory().openSession();
        session.beginTransaction();
        Calendar calendario = new GregorianCalendar();
        int hora,minuto;
        
        hora = calendario.get(Calendar.HOUR_OF_DAY);
        minuto = calendario.get((Calendar.MINUTE));
        
        String time = hora+":"+minuto;
                
        try 
        {
            
            List<cl.biblioteca.edm.Prestamo> lista =  (List<cl.biblioteca.edm.Prestamo>) session.createCriteria(cl.biblioteca.edm.Prestamo.class)
                    .add(Restrictions.conjunction()
                    .add(Restrictions.lt("fechaDevolucion", time))
                    .add(Restrictions.and(Restrictions.eq("estado", "Meson")))).list();
                    
           
           
            
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
    
    
    public boolean delete(cl.biblioteca.edm.Prestamo p) throws Exception {
        Session session = HibernateUtil.getSessionFactory().openSession();
        session.beginTransaction();
        try 
        {
            session.delete(p);
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
     
    public boolean update(cl.biblioteca.edm.Prestamo p) throws Exception {
        Session session = HibernateUtil.getSessionFactory().openSession();
        session.beginTransaction();
        try 
        {
            session.update(p);
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
    
    public List<cl.biblioteca.edm.Prestamo> getPrestamoById(int id) throws Exception
    {
         Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            session.beginTransaction();

            List<cl.biblioteca.edm.Prestamo> tmp = (List<cl.biblioteca.edm.Prestamo>) session.createCriteria(cl.biblioteca.edm.Prestamo.class)
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
    
    public cl.biblioteca.edm.Prestamo getPrestamoByNombre(String DS) throws Exception
    {
         Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            session.beginTransaction();

            cl.biblioteca.edm.Prestamo tmp = (cl.biblioteca.edm.Prestamo) session.createCriteria(cl.biblioteca.edm.Prestamo.class)
                    .add(Restrictions.eq("prestamoNombre", DS))
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

public List<cl.biblioteca.edm.Prestamo> getPrestamoByIdLibro(int id) throws Exception
    {
         Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            session.beginTransaction();

            List<cl.biblioteca.edm.Prestamo> tmp = (List<cl.biblioteca.edm.Prestamo>) session.createCriteria(cl.biblioteca.edm.Prestamo.class)
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

public List<cl.biblioteca.edm.Prestamo> getPrestamoByIdMultimedia(int id) throws Exception
    {
         Session session = HibernateUtil.getSessionFactory().openSession();
        try {
            session.beginTransaction();

            List<cl.biblioteca.edm.Prestamo> tmp = (List<cl.biblioteca.edm.Prestamo>) session.createCriteria(cl.biblioteca.edm.Prestamo.class)
                    .add(Restrictions.eq("idMultimedia", id)).list();
                    
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





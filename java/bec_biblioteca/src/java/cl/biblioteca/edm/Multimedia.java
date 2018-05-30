package cl.biblioteca.edm;
// Generated 28-oct-2017 22:26:50 by Hibernate Tools 4.3.1


import java.util.Date;
import java.util.HashSet;
import java.util.Set;

/**
 * Multimedia generated by hbm2java
 */
public class Multimedia  implements java.io.Serializable {


     private Integer idMultimedia;
     private String codigo;
     private String tipo;
     private String nombre;
     private String autor;
     private String fecha;
     private int idstock;

   

    public Multimedia() {
    }

	
    public Multimedia(Stock stock, String codigo,String tipo, String nombre, String autor, String fecha, int idstock) {
        this.codigo = codigo;
        this.tipo = tipo;
        this.nombre = nombre;
        this.autor = autor;
        this.fecha = fecha;
        this.idstock = idstock;
    }
 
    public Integer getIdMultimedia() {
        return this.idMultimedia;
    }
    
    public void setIdMultimedia(Integer idMultimedia) {
        this.idMultimedia = idMultimedia;
    }
    
     public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }
 
    public String getTipo() {
        return this.tipo;
    }
    
    public void setTipo(String tipo) {
        this.tipo = tipo;
    }
    public String getNombre() {
        return this.nombre;
    }
    
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
    public String getAutor() {
        return this.autor;
    }
    
    public void setAutor(String autor) {
        this.autor = autor;
    }
 
    public String getFecha() {
        return fecha;
    }

    public void setFecha(String fecha) {
        this.fecha = fecha;
    }

    public int getIdstock() {
        return idstock;
    }

    public void setIdstock(int idstock) {
        this.idstock = idstock;
    }



}



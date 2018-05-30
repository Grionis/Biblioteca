package cl.biblioteca.edm;
// Generated 28-oct-2017 22:26:50 by Hibernate Tools 4.3.1


import java.util.HashSet;
import java.util.Set;

/**
 * Stock generated by hbm2java
 */
public class Stock  implements java.io.Serializable {


     private Integer idStock;
     private Estante estante;
     private int activo;
     private int prestado;
     private int total;
     private Set<Libro> libros = new HashSet<Libro>(0);
     private Set<Multimedia> multimedias = new HashSet<Multimedia>(0);

    public Stock() {
    }

	
    public Stock(Estante estante, int activo, int prestado, int total) {
        this.estante = estante;
        this.activo = activo;
        this.prestado = prestado;
        this.total = total;
    }
    public Stock(Estante estante, int activo, int prestado, int total, Set<Libro> libros, Set<Multimedia> multimedias) {
       this.estante = estante;
       this.activo = activo;
       this.prestado = prestado;
       this.total = total;
       this.libros = libros;
       this.multimedias = multimedias;
    }
   
    public Integer getIdStock() {
        return this.idStock;
    }
    
    public void setIdStock(Integer idStock) {
        this.idStock = idStock;
    }
    public Estante getEstante() {
        return this.estante;
    }
    
    public void setEstante(Estante estante) {
        this.estante = estante;
    }
    public int getActivo() {
        return this.activo;
    }
    
    public void setActivo(int activo) {
        this.activo = activo;
    }
    public int getPrestado() {
        return this.prestado;
    }
    
    public void setPrestado(int prestado) {
        this.prestado = prestado;
    }
    public int getTotal() {
        return this.total;
    }
    
    public void setTotal(int total) {
        this.total = total;
    }
    public Set<Libro> getLibros() {
        return this.libros;
    }
    
    public void setLibros(Set<Libro> libros) {
        this.libros = libros;
    }
    public Set<Multimedia> getMultimedias() {
        return this.multimedias;
    }
    
    public void setMultimedias(Set<Multimedia> multimedias) {
        this.multimedias = multimedias;
    }




}


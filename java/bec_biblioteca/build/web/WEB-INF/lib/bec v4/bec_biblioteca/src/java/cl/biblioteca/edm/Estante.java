package cl.biblioteca.edm;
// Generated 28-oct-2017 22:26:50 by Hibernate Tools 4.3.1


import java.util.HashSet;
import java.util.Set;

/**
 * Estante generated by hbm2java
 */
public class Estante  implements java.io.Serializable {


     private Integer idEstante;
     private String piso;
     private String seccion;
     private Set<Stock> stocks = new HashSet<Stock>(0);

    public Estante() {
    }

	
    public Estante(String piso, String seccion) {
        this.piso = piso;
        this.seccion = seccion;
    }
    public Estante(String piso, String seccion, Set<Stock> stocks) {
       this.piso = piso;
       this.seccion = seccion;
       this.stocks = stocks;
    }
   
    public Integer getIdEstante() {
        return this.idEstante;
    }
    
    public void setIdEstante(Integer idEstante) {
        this.idEstante = idEstante;
    }
    public String getPiso() {
        return this.piso;
    }
    
    public void setPiso(String piso) {
        this.piso = piso;
    }
    public String getSeccion() {
        return this.seccion;
    }
    
    public void setSeccion(String seccion) {
        this.seccion = seccion;
    }
    public Set<Stock> getStocks() {
        return this.stocks;
    }
    
    public void setStocks(Set<Stock> stocks) {
        this.stocks = stocks;
    }




}


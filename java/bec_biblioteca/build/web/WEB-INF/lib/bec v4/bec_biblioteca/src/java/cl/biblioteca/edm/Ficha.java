package cl.biblioteca.edm;
// Generated 28-oct-2017 22:26:50 by Hibernate Tools 4.3.1


import java.util.HashSet;
import java.util.Set;

/**
 * Ficha generated by hbm2java
 */
public class Ficha  implements java.io.Serializable {


     private Integer idFicha;
     private String rut;
     private String nombres;
     private String direccion;
     private String correo;
     private String telefono;
     private byte[] fotografia;
     private int huella;
     

    public Ficha() {
    }

	
    public Ficha(String rut, String nombres, String direccion, String correo, String telefono, int huella) {
        this.rut = rut;
        this.nombres = nombres;
        this.direccion = direccion;
        this.correo = correo;
        this.telefono = telefono;
        this.huella = huella;
    }
    public Ficha(String rut, String nombres, String direccion, String correo, String telefono, byte[] fotografia, int huella) {
       this.rut = rut;
       this.nombres = nombres;
       this.direccion = direccion;
       this.correo = correo;
       this.telefono = telefono;
       this.fotografia = fotografia;
       this.huella = huella;
      
    }
   
    public Integer getIdFicha() {
        return this.idFicha;
    }
    
    public void setIdFicha(Integer idFicha) {
        this.idFicha = idFicha;
    }
    public String getRut() {
        return this.rut;
    }
    
    public void setRut(String rut) {
        this.rut = rut;
    }
    public String getNombres() {
        return this.nombres;
    }
    
    public void setNombres(String nombres) {
        this.nombres = nombres;
    }
    public String getDireccion() {
        return this.direccion;
    }
    
    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }
    public String getCorreo() {
        return this.correo;
    }
    
    public void setCorreo(String correo) {
        this.correo = correo;
    }
    public String getTelefono() {
        return this.telefono;
    }
    
    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }
    public byte[] getFotografia() {
        return this.fotografia;
    }
    
    public void setFotografia(byte[] fotografia) {
        this.fotografia = fotografia;
    }
    public int getHuella() {
        return this.huella;
    }
    
    public void setHuella(int huella) {
        this.huella = huella;
    }
   



}


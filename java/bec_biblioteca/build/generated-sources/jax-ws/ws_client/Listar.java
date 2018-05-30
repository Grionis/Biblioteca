
package ws_client;

import java.util.List;
import javax.jws.WebMethod;
import javax.jws.WebResult;
import javax.jws.WebService;
import javax.xml.bind.annotation.XmlSeeAlso;
import javax.xml.ws.Action;
import javax.xml.ws.RequestWrapper;
import javax.xml.ws.ResponseWrapper;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.11-b150120.1832
 * Generated source version: 2.2
 * 
 */
@WebService(name = "Listar", targetNamespace = "http://ws/")
@XmlSeeAlso({
    ObjectFactory.class
})
public interface Listar {


    /**
     * 
     * @return
     *     returns java.util.List<java.lang.String>
     */
    @WebMethod
    @WebResult(targetNamespace = "")
    @RequestWrapper(localName = "listarFicha", targetNamespace = "http://ws/", className = "ws_client.ListarFicha")
    @ResponseWrapper(localName = "listarFichaResponse", targetNamespace = "http://ws/", className = "ws_client.ListarFichaResponse")
    @Action(input = "http://ws/Listar/listarFichaRequest", output = "http://ws/Listar/listarFichaResponse")
    public List<String> listarFicha();

    /**
     * 
     * @return
     *     returns java.util.List<ws_client.Usuario>
     */
    @WebMethod
    @WebResult(targetNamespace = "")
    @RequestWrapper(localName = "listarUsuario", targetNamespace = "http://ws/", className = "ws_client.ListarUsuario")
    @ResponseWrapper(localName = "listarUsuarioResponse", targetNamespace = "http://ws/", className = "ws_client.ListarUsuarioResponse")
    @Action(input = "http://ws/Listar/listarUsuarioRequest", output = "http://ws/Listar/listarUsuarioResponse")
    public List<Usuario> listarUsuario();

    /**
     * 
     * @return
     *     returns java.util.List<ws_client.Rol>
     */
    @WebMethod
    @WebResult(targetNamespace = "")
    @RequestWrapper(localName = "listarRol", targetNamespace = "http://ws/", className = "ws_client.ListarRol")
    @ResponseWrapper(localName = "listarRolResponse", targetNamespace = "http://ws/", className = "ws_client.ListarRolResponse")
    @Action(input = "http://ws/Listar/listarRolRequest", output = "http://ws/Listar/listarRolResponse")
    public List<Rol> listarRol();

}

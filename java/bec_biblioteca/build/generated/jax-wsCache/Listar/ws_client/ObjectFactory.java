
package ws_client;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the ws_client package. 
 * <p>An ObjectFactory allows you to programatically 
 * construct new instances of the Java representation 
 * for XML content. The Java representation of XML 
 * content can consist of schema derived interfaces 
 * and classes representing the binding of schema 
 * type definitions, element declarations and model 
 * groups.  Factory methods for each of these are 
 * provided in this class.
 * 
 */
@XmlRegistry
public class ObjectFactory {

    private final static QName _ListarFicha_QNAME = new QName("http://ws/", "listarFicha");
    private final static QName _ListarFichaResponse_QNAME = new QName("http://ws/", "listarFichaResponse");
    private final static QName _ListarRol_QNAME = new QName("http://ws/", "listarRol");
    private final static QName _ListarRolResponse_QNAME = new QName("http://ws/", "listarRolResponse");
    private final static QName _ListarUsuario_QNAME = new QName("http://ws/", "listarUsuario");
    private final static QName _ListarUsuarioResponse_QNAME = new QName("http://ws/", "listarUsuarioResponse");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: ws_client
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link ListarFicha }
     * 
     */
    public ListarFicha createListarFicha() {
        return new ListarFicha();
    }

    /**
     * Create an instance of {@link ListarFichaResponse }
     * 
     */
    public ListarFichaResponse createListarFichaResponse() {
        return new ListarFichaResponse();
    }

    /**
     * Create an instance of {@link ListarRol }
     * 
     */
    public ListarRol createListarRol() {
        return new ListarRol();
    }

    /**
     * Create an instance of {@link ListarRolResponse }
     * 
     */
    public ListarRolResponse createListarRolResponse() {
        return new ListarRolResponse();
    }

    /**
     * Create an instance of {@link ListarUsuario }
     * 
     */
    public ListarUsuario createListarUsuario() {
        return new ListarUsuario();
    }

    /**
     * Create an instance of {@link ListarUsuarioResponse }
     * 
     */
    public ListarUsuarioResponse createListarUsuarioResponse() {
        return new ListarUsuarioResponse();
    }

    /**
     * Create an instance of {@link Usuario }
     * 
     */
    public Usuario createUsuario() {
        return new Usuario();
    }

    /**
     * Create an instance of {@link Ficha }
     * 
     */
    public Ficha createFicha() {
        return new Ficha();
    }

    /**
     * Create an instance of {@link Rol }
     * 
     */
    public Rol createRol() {
        return new Rol();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ListarFicha }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://ws/", name = "listarFicha")
    public JAXBElement<ListarFicha> createListarFicha(ListarFicha value) {
        return new JAXBElement<ListarFicha>(_ListarFicha_QNAME, ListarFicha.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ListarFichaResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://ws/", name = "listarFichaResponse")
    public JAXBElement<ListarFichaResponse> createListarFichaResponse(ListarFichaResponse value) {
        return new JAXBElement<ListarFichaResponse>(_ListarFichaResponse_QNAME, ListarFichaResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ListarRol }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://ws/", name = "listarRol")
    public JAXBElement<ListarRol> createListarRol(ListarRol value) {
        return new JAXBElement<ListarRol>(_ListarRol_QNAME, ListarRol.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ListarRolResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://ws/", name = "listarRolResponse")
    public JAXBElement<ListarRolResponse> createListarRolResponse(ListarRolResponse value) {
        return new JAXBElement<ListarRolResponse>(_ListarRolResponse_QNAME, ListarRolResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ListarUsuario }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://ws/", name = "listarUsuario")
    public JAXBElement<ListarUsuario> createListarUsuario(ListarUsuario value) {
        return new JAXBElement<ListarUsuario>(_ListarUsuario_QNAME, ListarUsuario.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ListarUsuarioResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://ws/", name = "listarUsuarioResponse")
    public JAXBElement<ListarUsuarioResponse> createListarUsuarioResponse(ListarUsuarioResponse value) {
        return new JAXBElement<ListarUsuarioResponse>(_ListarUsuarioResponse_QNAME, ListarUsuarioResponse.class, null, value);
    }

}

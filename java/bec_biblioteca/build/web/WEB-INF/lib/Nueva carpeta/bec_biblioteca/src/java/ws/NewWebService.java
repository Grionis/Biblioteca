/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ws;

import cl.biblioteca.dao.FichaDAO;
import java.util.AbstractList;
import java.util.ArrayList;
import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author Acer
 */
@WebService(serviceName = "NewWebService")
public class NewWebService {

   @WebMethod
    public List<String> listarFicha() {

        try {
            cl.biblioteca.dao.FichaDAO fdao = new FichaDAO();
            List<String> l = new ArrayList<>();
            l.add("dasdsadas");
            l.add("c");
            fdao.getList();
            return l;
        } catch (Exception e) {
            return null;
        }

    }
}

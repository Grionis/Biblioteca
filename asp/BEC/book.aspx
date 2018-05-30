﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="book.aspx.cs" Inherits="BEC.book" %>


<!DOCTYPE html>
<html lang="es">
<head>
    <title>Registrar Libro</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="Shortcut Icon" type="image/x-icon" href="assets/icons/book.ico" />
    <script src="js/sweet-alert.min.js"></script>
    <link rel="stylesheet" href="css/sweet-alert.css">
    <link rel="stylesheet" href="css/material-design-iconic-font.min.css">
    <link rel="stylesheet" href="css/normalize.css">
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/jquery.mCustomScrollbar.css">
    <link rel="stylesheet" href="css/style.css">
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>
    <script>window.jQuery || document.write('<script src="js/jquery-1.11.2.min.js"><\/script>')</script>
    <script src="js/modernizr.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/jquery.mCustomScrollbar.concat.min.js"></script>
    <script src="js/main.js"></script>
</head>
<body>
     <div class="navbar-lateral full-reset">
        <div class="visible-xs font-movile-menu mobile-menu-button"></div>
        <div class="full-reset container-menu-movile custom-scroll-containers">
            <div class="logo full-reset all-tittles">
                <i class="visible-xs zmdi zmdi-close pull-left mobile-menu-button" style="line-height: 55px; cursor: pointer; padding: 0 10px; margin-left: 7px;"></i> 
                sistema bibliotecario
            </div>
            <div class="full-reset" style="background-color:#2B3D51; padding: 10px 0; color:#fff;">
                <figure>
                   <a href="home.aspx" > <img src="assets/img/logo.png" alt="Biblioteca" class="img-responsive center-box" style="width:55%;"></a>
                </figure>
                <p class="text-center" style="padding-top: 15px;">Sistema Bibliotecario</p>
            </div>
            <div class="full-reset nav-lateral-list-menu">
                <ul class="list-unstyled">
                    <li><a href="home.aspx"><i class="zmdi zmdi-home zmdi-hc-fw"></i>&nbsp;&nbsp; Inicio</a></li>
                 <%--   <li>
                        <div class="dropdown-menu-button"><i class="zmdi zmdi-case zmdi-hc-fw"></i>&nbsp;&nbsp; Administración <i class="zmdi zmdi-chevron-down pull-right zmdi-hc-fw"></i></div>
                        <ul class="list-unstyled">
                            <li><a href="institution.aspx"><i class="zmdi zmdi-balance zmdi-hc-fw"></i>&nbsp;&nbsp; Datos institución</a></li>
                            <li><a href="provider.aspx"><i class="zmdi zmdi-truck zmdi-hc-fw"></i>&nbsp;&nbsp; Nuevo proveedor</a></li>
                            <li><a href="category.aspx"><i class="zmdi zmdi-bookmark-outline zmdi-hc-fw"></i>&nbsp;&nbsp; Nueva categoría</a></li>
                            <li><a href="section.aspx"><i class="zmdi zmdi-assignment-account zmdi-hc-fw"></i>&nbsp;&nbsp; Nueva sección</a></li>
                        </ul>
                    </li>

                   
                      <li>
                        <div class="dropdown-menu-button"><i class="zmdi zmdi-account-add zmdi-hc-fw"></i>&nbsp;&nbsp; Informacion<i class="zmdi zmdi-chevron-down pull-right zmdi-hc-fw"></i></div>
                        <ul class="list-unstyled">
                            <li><a href="informacionUsuario.aspx"><i class="zmdi zmdi-face zmdi-hc-fw"></i>&nbsp;&nbsp; Informacion de usuario</a></li>
                             <li><a href="teacher.aspx"><i class="zmdi zmdi-male-alt zmdi-hc-fw"></i>&nbsp;&nbsp; Ver usuarios</a></li> 
                            <li><a href="actualizarUsuario.aspx"><i class="zmdi zmdi-accounts zmdi-hc-fw"></i>&nbsp;&nbsp; Actualizar informacion</a></li>
                            <li><a href="eliminarUsuario.aspx"><i class="zmdi zmdi-male-female zmdi-hc-fw"></i>&nbsp;&nbsp; Eliminar usuario</a></li>
                        </ul>
                    </li>
                    
                


                    <li>
                        <div class="dropdown-menu-button"><i class="zmdi zmdi-account-add zmdi-hc-fw"></i>&nbsp;&nbsp; Registro de usuarios <i class="zmdi zmdi-chevron-down pull-right zmdi-hc-fw"></i></div>
                        <ul class="list-unstyled">
                            <li><a href="admin.aspx"><i class="zmdi zmdi-face zmdi-hc-fw"></i>&nbsp;&nbsp; Nuevo administrador</a></li>
                            <li><a href="teacher.aspx"><i class="zmdi zmdi-male-alt zmdi-hc-fw"></i>&nbsp;&nbsp; Nuevo docente</a></li>
                            <li><a href="student.aspx"><i class="zmdi zmdi-accounts zmdi-hc-fw"></i>&nbsp;&nbsp; Nuevo estudiante</a></li>
                            <li><a href="personal.aspx"><i class="zmdi zmdi-male-female zmdi-hc-fw"></i>&nbsp;&nbsp; Nuevo personal administrativo</a></li>
                        </ul>
                    </li>
                     <li>
                        <div class="dropdown-menu-button"><i class="zmdi zmdi-account-add zmdi-hc-fw"></i>&nbsp;&nbsp; Listados <i class="zmdi zmdi-chevron-down pull-right zmdi-hc-fw"></i></div>
                        <ul class="list-unstyled">
                            <li><a href="liststudent.aspx"><i class="zmdi zmdi-face zmdi-hc-fw"></i>&nbsp;&nbsp; Ver Fichas</a></li>
                            <li><a href="listadmin.aspx"><i class="zmdi zmdi-face zmdi-hc-fw"></i>&nbsp;&nbsp; Ver Usuarios</a></li>
                            
                        </ul>
                    </li>--%>
                    <li>
                        <div class="dropdown-menu-button"><i class="zmdi zmdi-assignment-o zmdi-hc-fw"></i>&nbsp;&nbsp; Libros y catálogo <i class="zmdi zmdi-chevron-down pull-right zmdi-hc-fw"></i></div>
                        <ul class="list-unstyled">
                            <li><a href="book.aspx"><i class="zmdi zmdi-book zmdi-hc-fw"></i>&nbsp;&nbsp; Nuevo libro</a></li>
                            <li><a href="multimedia.aspx"><i class="zmdi zmdi-book zmdi-hc-fw"></i>&nbsp;&nbsp; Nuevo multimedia</a></li>
                            <li><a href="catalog.aspx"><i class="zmdi zmdi-bookmark-outline zmdi-hc-fw"></i>&nbsp;&nbsp; Catálogo</a></li>
                        </ul>
                    </li>
                    <li>
                        <div class="dropdown-menu-button"><i class="zmdi zmdi-alarm zmdi-hc-fw"></i>&nbsp;&nbsp; Préstamos y reservaciones <i class="zmdi zmdi-chevron-down pull-right zmdi-hc-fw"></i></div>
                        <ul class="list-unstyled">
                           <a href="prestamo.aspx"><i class="zmdi zmdi-time-restore zmdi-hc-fw"></i>&nbsp;&nbsp; Nuevo Prestamo  </a>

                            <li><a href="loan.aspx"><i class="zmdi zmdi-calendar zmdi-hc-fw"></i>&nbsp;&nbsp; Todos los préstamos</a></li>
                            <li>
                                <a href="loanpending.aspx"><i class="zmdi zmdi-time-restore zmdi-hc-fw"></i>&nbsp;&nbsp; Devoluciones</a>
                            </li>
                            <li>
                                <a href="loanreservation.aspx"><i class="zmdi zmdi-timer zmdi-hc-fw"></i>&nbsp;&nbsp; Reservaciones </a>
                            </li>
                        </ul>
                    </li>
                    <%-- 
                    <li><a href="report.aspx"><i class="zmdi zmdi-trending-up zmdi-hc-fw"></i>&nbsp;&nbsp; Reportes y estadísticas</a></li>
                    <li><a href="advancesettings.aspx"><i class="zmdi zmdi-wrench zmdi-hc-fw"></i>&nbsp;&nbsp; Configuraciones avanzadas</a></li>--%>
                </ul>
            </div>
        </div>
    </div>
    <div class="content-page-container full-reset custom-scroll-containers">
        <nav class="navbar-user-top full-reset">
            <ul class="list-unstyled full-reset">
                <figure>
                   <img src="assets/img/user01.png" alt="user-picture" class="img-responsive img-circle center-box">
                </figure>
                <li style="color:#fff; cursor:default;">
                    <span class="all-tittles"><asp:Label ID="lblNick" runat="server" Text=""></asp:Label></span>
                </li>
                <li  class="tooltips-general exit-system-button" data-href="Salir.aspx" data-placement="bottom" title="Salir del sistema">
                    <i class="zmdi zmdi-power"></i>
                </li>
                <%--<li  class="tooltips-general search-book-button" data-href="searchbook.aspx" data-placement="bottom" title="Buscar libro">
                    <i class="zmdi zmdi-search"></i>
                </li>--%>
                <li  class="tooltips-general btn-help" data-placement="bottom" title="Ayuda">
                    <i class="zmdi zmdi-help-outline zmdi-hc-fw"></i>
                </li>
                <li class="mobile-menu-button visible-xs" style="float: left !important;">
                    <i class="zmdi zmdi-menu"></i>
                </li>
            </ul>
        </nav>
        <div class="container">
            <div class="page-header">
              <h1 class="all-tittles">Sistema bibliotecario <small>Libros</small></h1>
            </div>
        </div>
        <div class="container-fluid"  style="margin: 50px 0;">
            <div class="row">
                <div class="col-xs-12 col-sm-4 col-md-3">
                    <img src="assets/img/flat-book.png" alt="pdf" class="img-responsive center-box" style="max-width: 110px;">
                </div>
                <div class="col-xs-12 col-sm-8 col-md-8 text-justify lead">
                    Bienvenido a la sección para agregar nuevos libros a la biblioteca, deberas de llenar todos los campos para poder registrar el libro
                </div>
            </div>
        </div>
        <div class="container-fluid">
            <form autocomplete="off" runat="server">
                <div class="container-flat-form">
                    <div class="title-flat-form title-flat-blue">Nuevo libro</div>
                    <div class="row">
                       <div class="col-xs-12 col-sm-8 col-sm-offset-2">
                            <legend><strong>Información básica</strong></legend><br>
                            
                            <div class="group-material">
                                
                                <asp:TextBox ID="txtIsbn" runat="server" class="tooltips-general material-control" placeholder="Escribe aquí el código correlativo del libro" pattern="[0-9]{1,20}" required="" maxlength="20" data-toggle="tooltip" data-placement="top" title="Escribe el código correlativo del libro, solamente números" Width="648px"></asp:TextBox>
                                <span class="highlight"></span>
                                <span class="bar"></span>
                                <label>ISBN</label>
                            </div>

                           <div class="group-material">
                                <label>Codigo</label><br />
                                <asp:TextBox ID="txtCodigo" runat="server" class="tooltips-general material-control" placeholder="Escribe el codigo interno para el libro" pattern="[0-9]{1,20}" required="" maxlength="20" data-toggle="tooltip" data-placement="top" title="Escribe el código correlativo del libro, solamente números" Width="648px" ReadOnly="True"></asp:TextBox>
                                <span class="highlight"></span>
                                <span class="bar"></span>
                                
                            </div>

                            <div class="group-material">

                                <asp:TextBox ID="txtTitulo" runat="server" class="tooltips-general material-control" placeholder="Escribe aquí el título o nombre del libro" required="" maxlength="70" data-toggle="tooltip" data-placement="top" title="Escribe el título o nombre del libro" Width="648px"></asp:TextBox>
                                <span class="highlight"></span>
                                <span class="bar"></span>
                                <label>Título</label>
                            </div>
                            <div class="group-material">

                                <asp:TextBox ID="txtAutor" runat="server" class="tooltips-general material-control" placeholder="Escribe aquí el autor del libro" required="" maxlength="70" data-toggle="tooltip" data-placement="top" title="Escribe el nombre del autor del libro" Width="648px" ></asp:TextBox>
                                <span class="highlight"></span>
                                <span class="bar"></span>
                                <label>Autor</label>
                            </div>

                           <div class="group-material">
                                <asp:Label ID="lblGenero" runat="server" Text="Genero"></asp:Label>
                                <asp:DropDownList ID="ddlGenero" runat="server" class="tooltips-general material-control"  required=""  data-toggle="tooltip" data-placement="top"  Width="648px"></asp:DropDownList>
                                <span class="highlight"></span>
                                <span class="bar"></span>
                                <%--<label>Genero</label>--%>
                               
                            </div>
                        
                            <legend><strong>Otros datos</strong></legend><br>
                            <div class="group-material">
                                
                           <div class="group-material">
                               
                                <asp:TextBox ID="txtAño" runat="server" class="material-control tooltips-general" placeholder="Escribe aquí el año del libro" required="" pattern="[0-9]{1,4}" maxlength="4" data-toggle="tooltip" data-placement="top" title="Solamente números, sin espacios" Width="648px" ></asp:TextBox>
                                <span class="highlight"></span>
                                <span class="bar"></span>
                                <label>Año</label>
                           </div>
                            
                            <div class="group-material">

                                <asp:TextBox ID="txtStock" runat="server" class="material-control tooltips-general" placeholder="Escribe aquí la cantidad de libros que registraras" required=" " pattern="[1-9]{1,7}" maxlength="7" data-toggle="tooltip" data-placement="top" title="¿Cuántos libros registraras?" Width="648px" ></asp:TextBox>
                                
                                <span class="highlight"></span>
                                <span class="bar"></span>
                                <label>Stock</label>
                            </div>
                            <legend><strong> ubicación </strong></legend><br>
                            <div class="group-material">
                            <asp:TextBox ID="txtPiso" runat="server" class="material-control tooltips-general" placeholder="Escribe aquí la ubicación del libro" required="" maxlength="50" data-toggle="tooltip" data-placement="top" title="¿En que piso estara el libro?"></asp:TextBox>
                                <span class="highlight"></span>
                                <span class="bar"></span>
                                <label>Piso</label>
                            </div>
                              <div class="group-material">
                              <asp:TextBox ID="txtEstante" runat="server" class="material-control tooltips-general" placeholder="Escribe aquí la ubicación del libro" required="" maxlength="50" data-toggle="tooltip" data-placement="top" title="¿En que estante estara?"></asp:TextBox>
                                <span class="highlight"></span>
                                <span class="bar"></span>
                                <label>Seccion</label>
                            </div>
                            
                       
                            <p class="text-center">

                                <asp:Label ID="lblAlert" runat="server" Text=""></asp:Label>
                                <button type="reset" class="btn btn-info" style="margin-right: 20px;"><i class="zmdi zmdi-roller"></i>&nbsp;&nbsp; Limpiar</button>
                                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" class="btn btn-primary" OnClick="btnGuardar_Click"/>
                            </p>
                       </div>
                   </div>
                </div>
            </form>
        </div>
        <div class="modal fade" tabindex="-1" role="dialog" id="ModalHelp">
          <div class="modal-dialog modal-lg">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title text-center all-tittles">ayuda del sistema</h4>
                </div>
                <div class="modal-body">
                    Si tiene dudas, sugerencias, reclamos o una opinion de como podemos mejorar el sistema, escribanos a bibliotecabecchile@gmail.com. <br />
                    Su opinion es importante para nosotros.                
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-primary" data-dismiss="modal"><i class="zmdi zmdi-thumb-up"></i> &nbsp; De acuerdo</button>
                </div>
            </div>
          </div>
        </div>
      <footer class="footer full-reset">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-xs-12 col-sm-6">
                        <h4 class="all-tittles">Acerca de</h4>
                        <p>
                            Biblioteca Estacion Central  <br /> ubicada en Alameda #4300 de la comuna Estacion Central <br /> Telefono: +569 45478796 <br/> Email: bibliotecabecchile@gmail.com
                        </p>
                    </div>
                    <div class="col-xs-12 col-sm-6">
                        <h4 class="all-tittles">Desarrollador</h4>
                        <ul class="list-unstyled">
                            <li><i class="zmdi zmdi-check zmdi-hc-fw"></i>&nbsp; MFC <i class="zmdi zmdi-facebook zmdi-hc-fw footer-social"></i><i class="zmdi zmdi-twitter zmdi-hc-fw footer-social"></i></li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class="footer-copyright full-reset all-tittles">© 2017 MFC</div>
        </footer>
    </div>
</body>
</html>
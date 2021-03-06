﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="BEC.Admin" %>

<!DOCTYPE html>
<html lang="es">
<head>
    <title>Administradores</title>
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
                   <a href="homeAdministrativo.aspx" > <img src="assets/img/logo.png" alt="Biblioteca" class="img-responsive center-box" style="width:55%;"></a>
                </figure>
                <p class="text-center" style="padding-top: 15px;">Sistema Bibliotecario</p>
            </div>
            <div class="full-reset nav-lateral-list-menu">
                <ul class="list-unstyled">
                    <li><a href="homeAdministrativo.aspx"><i class="zmdi zmdi-home zmdi-hc-fw"></i>&nbsp;&nbsp; Inicio</a></li>
                 <%--   <li>
                        <div class="dropdown-menu-button"><i class="zmdi zmdi-case zmdi-hc-fw"></i>&nbsp;&nbsp; Administración <i class="zmdi zmdi-chevron-down pull-right zmdi-hc-fw"></i></div>
                        <ul class="list-unstyled">
                            <li><a href="institution.aspx"><i class="zmdi zmdi-balance zmdi-hc-fw"></i>&nbsp;&nbsp; Datos institución</a></li>
                            <li><a href="provider.aspx"><i class="zmdi zmdi-truck zmdi-hc-fw"></i>&nbsp;&nbsp; Nuevo proveedor</a></li>
                            <li><a href="category.aspx"><i class="zmdi zmdi-bookmark-outline zmdi-hc-fw"></i>&nbsp;&nbsp; Nueva categoría</a></li>
                            <li><a href="section.aspx"><i class="zmdi zmdi-assignment-account zmdi-hc-fw"></i>&nbsp;&nbsp; Nueva sección</a></li>
                        </ul>
                    </li>--%>

                     <%-- 
                      <li>
                        <div class="dropdown-menu-button"><i class="zmdi zmdi-account-add zmdi-hc-fw"></i>&nbsp;&nbsp; Informacion<i class="zmdi zmdi-chevron-down pull-right zmdi-hc-fw"></i></div>
                        <ul class="list-unstyled">
                            <li><a href="informacionUsuario.aspx"><i class="zmdi zmdi-face zmdi-hc-fw"></i>&nbsp;&nbsp; Informacion de usuario</a></li>
                            <li><a href="teacher.aspx"><i class="zmdi zmdi-male-alt zmdi-hc-fw"></i>&nbsp;&nbsp; Ver usuarios</a></li>
                            <li><a href="actualizarUsuario.aspx"><i class="zmdi zmdi-accounts zmdi-hc-fw"></i>&nbsp;&nbsp; Actualizar informacion</a></li>
                            <li><a href="personal.aspx"><i class="zmdi zmdi-male-female zmdi-hc-fw"></i>&nbsp;&nbsp; Eliminar usuario</a></li>
                        </ul>
                    </li>--%>
                    



                   <li>
                        <div class="dropdown-menu-button"><i class="zmdi zmdi-account-add zmdi-hc-fw"></i>&nbsp;&nbsp; Registro de usuarios <i class="zmdi zmdi-chevron-down pull-right zmdi-hc-fw"></i></div>
                        <ul class="list-unstyled">
                            <li><a href="admin.aspx"><i class="zmdi zmdi-face zmdi-hc-fw"></i>&nbsp;&nbsp; Nuevo Administrativo de Biblioteca</a></li>
<%--                            <li><a href="teacher.aspx"><i class="zmdi zmdi-male-alt zmdi-hc-fw"></i>&nbsp;&nbsp; Nuevo docente</a></li>--%>
                            <li><a href="student.aspx"><i class="zmdi zmdi-accounts zmdi-hc-fw"></i>&nbsp;&nbsp; Nuevo estudiante</a></li>
                            <li><a href="personal.aspx"><i class="zmdi zmdi-male-female zmdi-hc-fw"></i>&nbsp;&nbsp; Nuevo Bibliotecario</a></li>
                        </ul>
                    </li>
                     <li>
                        <div class="dropdown-menu-button"><i class="zmdi zmdi-account-add zmdi-hc-fw"></i>&nbsp;&nbsp; Listados <i class="zmdi zmdi-chevron-down pull-right zmdi-hc-fw"></i></div>
                        <ul class="list-unstyled">
                            <li><a href="liststudent.aspx"><i class="zmdi zmdi-face zmdi-hc-fw"></i>&nbsp;&nbsp; Ver Fichas</a></li>
                            <li><a href="listadmin.aspx"><i class="zmdi zmdi-face zmdi-hc-fw"></i>&nbsp;&nbsp; Ver Usuarios</a></li>
                            
                        </ul>
                    </li>
                    <%-- 
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
                           <a href="prestamo.aspx"><i class="zmdi zmdi-time-restore zmdi-hc-fw"></i>&nbsp;&nbsp; Nuevo Prestamo  <span class="label label-danger pull-right label-mhover">7</span></a>

                            <li><a href="loan.aspx"><i class="zmdi zmdi-calendar zmdi-hc-fw"></i>&nbsp;&nbsp; Todos los préstamos</a></li>
                            <li>
                                <a href="loanpending.aspx"><i class="zmdi zmdi-time-restore zmdi-hc-fw"></i>&nbsp;&nbsp; Devoluciones pendientes <span class="label label-danger pull-right label-mhover">7</span></a>
                            </li>
                            <li>
                                <a href="loanreservation.aspx"><i class="zmdi zmdi-timer zmdi-hc-fw"></i>&nbsp;&nbsp; Reservaciones <span class="label label-danger pull-right label-mhover">7</span></a>
                            </li>
                        </ul>
                    </li>
                        --%>
                    <li><a href="report.aspx"><i class="zmdi zmdi-trending-up zmdi-hc-fw"></i>&nbsp;&nbsp; Reportes y estadísticas</a></li>
                   <%--  <li><a href="advancesettings.aspx"><i class="zmdi zmdi-wrench zmdi-hc-fw"></i>&nbsp;&nbsp; Configuraciones avanzadas</a></li>--%>
                </ul>
            </div>
        </div>
    </div>
    <div class="content-page-container full-reset custom-scroll-containers">
        <nav class="navbar-user-top full-reset">
            <ul class="list-unstyled full-reset">
                <figure>
                   <img src="assets/img/user02.png" alt="user-picture" class="img-responsive img-circle center-box">
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
              <h1 class="all-tittles">Sistema bibliotecario <small>Inicio</small></h1>
            </div>
        </div>
       
        <div class="container-fluid"  style="margin: 50px 0;">
            <div class="row">
                <div class="col-xs-12 col-sm-4 col-md-3">
                    <img src="assets/img/user02.png" alt="user" class="img-responsive center-box" style="max-width: 110px;">
                </div>
                <div class="col-xs-12 col-sm-8 col-md-8 text-justify lead">
                    Bienvenido a la sección para registrar nuevos administrativo bibliotecario, debes de llenar todos los campos del siguiente formulario para registrar un administrador
                </div>
            </div>
        </div>
       
        <div class="container-fluid">
            <div class="container-flat-form">
                <div class="title-flat-form title-flat-blue">Registrar un nuevo administrativo bibliotecario</div>
               <form autocomplete="off" runat ="server">
                    <div class="row">
                       <div class="col-xs-12 col-sm-8 col-sm-offset-2">
                            <legend>Datos Personales<br><br>
                            <div class="group-material">
                                
                                <asp:TextBox ID="txtRut" runat="server" class="material-control tooltips-general" placeholder="Escribe aquí el Rut del Usuario" required="" maxlength="200" data-toggle="tooltip" data-placement="top" title="Rut De usuario" AutoPostBack="True" OnTextChanged="txtRut_TextChanged" ></asp:TextBox>
                              
                                <span class="highlight"></span>
                                <span class="bar"></span>
                                <label>Rut</label>
                            </div>
                            <div class="group-material">

                            <asp:TextBox ID="txtNombre" runat="server" class="material-control tooltips-general" placeholder="Escribe aquí el Nombre completo del Usuario" required="" maxlength="200" data-toggle="tooltip" data-placement="top" title="Nombre De usuario" ></asp:TextBox>

                                <span class="highlight"></span>
                                <span class="bar"></span>
                                <label>Nombre Completo</label>
                            </div>
                            <div class="group-material">
                                <asp:TextBox ID="txtDIreccion" runat="server" class="material-control tooltips-general" placeholder="Escribe aquí la direccion del Usuario" required="" maxlength="200" data-toggle="tooltip" data-placement="top" title="Direccion De usuario" ></asp:TextBox>
                                <span class="highlight"></span>
                                <span class="bar"></span>
                                <label>Direccion</label>
                            </div>
                           
                            <div class="group-material">
                                <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" class="material-control tooltips-general" placeholder="Escribe aquí el Email del Usuario" required="" maxlength="100" data-toggle="tooltip" data-placement="top" title="Email De usuario" ></asp:TextBox>
                                <span class="highlight"></span>
                                <span class="bar"></span>
                                <label>Email</label>
                            </div>

                           
                            <div class="group-material">
                                <asp:TextBox ID="txtTelefono" runat="server" class="material-control tooltips-general" placeholder="Escribe aquí el Telefono del Usuario" required="" maxlength="20" data-toggle="tooltip" data-placement="top" title="Telefono De usuario" ></asp:TextBox>
                                <span class="highlight"></span>
                                <span class="bar"></span>
                                <label>Telefono</label>
                            </div>
                            
                           <%-- <div class="group-material">
                                <asp:TextBox ID="txtFotografia" runat="server" class="material-control tooltips-general" placeholder="Ingresa aquí la fotografia del Usuario" required="" maxlength="20" data-toggle="tooltip" data-placement="top" title="Fotografia De usuario" ></asp:TextBox>
                                <span class="highlight"></span>
                                <span class="bar"></span>
                                <label>Fotografia</label>
                            </div>
                            <div class="group-material">
                                <asp:TextBox ID="txtHuella" runat="server" class="material-control tooltips-general" placeholder="Ingresa la huella digital del usuario" required="" maxlength="20" data-toggle="tooltip" data-placement="top" title="Huella De usuario" ></asp:TextBox>
                                <span class="highlight"></span>
                                <span class="bar"></span>
                                <label>Huella Digital</label>
                            </div>--%>


                           <%-- Datos de usuario para ingresar al sistema --%>
                         

                            <p class="text-center">

                                <asp:Label ID="lblAlert" runat="server" Text=""></asp:Label> <br /> <br />
                                <button type="reset" class="btn btn-info" style="margin-right: 20px;"><i class="zmdi zmdi-roller"></i>&nbsp;&nbsp; Limpiar</button>
                                
                                <asp:Button ID="btnGuardar" runat="server" Text="Registrar"  class="btn btn-primary" OnClick="btnGuardar_Click" />
                            
                            </p> 
                       </div>
                    </div>
                </form>
            </div>
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
                            Biblioteca Municipal de la comuna estacion centrar ubicada en Alameda #3400 <br />
                            Horario de atencion: <br />
                            Lunes a viernes de 09:00 am - 21:00 pm<br />
                            Sabados y domingo de 09:00 am - 15:00 pm 
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
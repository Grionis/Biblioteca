<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="BEC.home" %>
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
<body >
    <div class="navbar-lateral full-reset">
        <div class="visible-xs font-movile-menu mobile-menu-button"></div>
        <div class="full-reset container-menu-movile custom-scroll-containers">
            <div class="logo full-reset all-tittles">
                <i class="visible-xs zmdi zmdi-close pull-left mobile-menu-button" style="line-height: 55px; cursor: pointer; padding: 0 10px; margin-left: 7px;"></i> 
                sistema bibliotecario
            </div>
            <div class="full-reset" style="background-color:#2B3D51; padding: 10px 0; color:#fff;">
                <figure>
                   <a href="home.aspx" ><img src="assets/img/logo.png" alt="Biblioteca" class="img-responsive center-box" style="width:55%;"></a>
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
              <h1 class="all-tittles">Sistema bibliotecario <small>Inicio</small></h1>
            </div>
        </div>
        <section class="full-reset text-center" style="padding: 40px 0;">
            
            
          
            <article class="tile">
               
               
                <div class="tile-icon full-reset"><i class="zmdi zmdi-face"></i></div><br /><br /><br /><br />
                
                 <div class="tile-name all-tittles"> <a runat="server" onserverclick="btnAdmin_Click">Administrativos Bibliotecarios</a> <br /><br /> <label runat="server" id="lblAdmin" Text="" ></label> <br /> <br /></div>
               
               <div class="tile-num full-reset">&nbsp;</div>
              
            </article>
                
            <article class="tile">
                <div class="tile-icon full-reset"><i class="zmdi zmdi-accounts"></i></div><br /><br /><br /><br />
                <div class="tile-name all-tittles"><a runat="server" onserverclick="Usuario_Click">Usuarios </a><br /><br /> <label runat="server" id="lblUser" Text="" ></label> <br /> <br /></div>
                <div class="tile-num full-reset">&nbsp;</div>
            </article>
            <article class="tile">
                <div class="tile-icon full-reset"><i class="zmdi zmdi-male-alt"></i></div><br /><br /><br /><br />
                <div class="tile-name all-tittles"><a runat="server" onserverclick="Bibliotecario_Click">Bibliotecarios</a> <br /><br /> <label runat="server" id="lblBibliotecario" Text="" ></label> <br /> <br /></div>
                <div class="tile-num full-reset">&nbsp;</div>
            </article>
            
         
            <article class="tile">
                <div class="tile-icon full-reset"><i class="zmdi zmdi-book"></i></div><br /><br /><br /><br />
                <div class="tile-name all-tittles"><a runat="server" onserverclick="Libro_Click">Libros</a> <br /><br /> <label runat="server" id="lblLibros" Text="" ></label> <br /> <br /></div>
                
                <div class="tile-num full-reset">&nbsp;</div>
           
            </article>
            <article class="tile">
                <div class="tile-icon full-reset"><i class="zmdi zmdi-bookmark-outline"></i></div><br /><br /><br /><br />
                <div class="tile-name all-tittles"><a runat="server" onserverclick="Multimedia_Click">Multimedia</a> <br /><br /> <label runat="server" id="lblMultimedia" Text="" ></label> <br /> <br /></div>
                <div class="tile-num full-reset">&nbsp;</div>
            </article>
            <article class="tile">
                <div class="tile-icon full-reset"><i class="zmdi zmdi-timer"></i></div><br /><br /><br /><br />
                <div class="tile-name all-tittles"><a runat="server" onserverclick="Reservaciones_Click">reservaciones</a> <br /><br /> <label runat="server" id="lblReservaciones" Text="" ></label> <br /> <br /></div>
                <div class="tile-num full-reset">&nbsp;</div>
            </article>
            <article class="tile">
                <div class="tile-icon full-reset"><i class="zmdi zmdi-time-restore"></i></div><br /><br /><br /><br />
                <div class="tile-name all-tittles" style="width: 90%;"><a runat="server" onserverclick="Meson_Click">En meson</a> <br /><br /> <label runat="server" id="lblPendiente" Text="" ></label> <br /> <br /></div>
                <div class="tile-num full-reset">&nbsp;</div>
            </article>
            <article class="tile">
                <div class="tile-icon full-reset"><i class="zmdi zmdi-calendar"></i></div><br /><br /><br /><br />
                <div class="tile-name all-tittles"><a runat="server" onserverclick="TotalPrestados_Click">préstamos</a> <br /><br /> <label runat="server" id="lblPrestamos" Text="" ></label> <br /> <br /></div>
                <div class="tile-num full-reset">&nbsp;</div>
            </article>
          
        </section>
         <br />

        <div class="group-material" >
         
            <form runat="server"> 
                 <p class="text-center">
                <asp:DropDownList ID="ddlExportExcel" runat="server" class="zmdi-photo-size-select-small"></asp:DropDownList>  
                <asp:Button ID="Export" runat="server" Text="Exportar a excel" OnClick="Export_Click" class="btn-info"/>
                </p>

<%-- Gridview para mostrar informacion --%>


<%-- Administrativo --%>
    <asp:GridView ID="gvAdmin" runat="server" HorizontalAlign="Center" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" class="table" AllowPaging="True" OnPageIndexChanging="gvAdmin_PageIndexChanging" OnSelectedIndexChanged="gvLibros_SelectedIndexChanged" PageSize="7" OnSorted="gvLibros_Sorted">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
 </asp:GridView>

<%-- Bibliotecario --%>


        <asp:GridView ID="gvBibliotecario" runat="server" HorizontalAlign="Center" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" class="table" AllowPaging="True" OnPageIndexChanging="gvBibliotecario_PageIndexChanging" OnSelectedIndexChanged="gvLibros_SelectedIndexChanged" PageSize="7" OnSorted="gvLibros_Sorted">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
 </asp:GridView>

<%-- Usuario --%>
        <asp:GridView ID="gvUsuario" runat="server" HorizontalAlign="Center" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" class="table" AllowPaging="True" OnPageIndexChanging="gvUsuario_PageIndexChanging" OnSelectedIndexChanged="gvLibros_SelectedIndexChanged" PageSize="7" OnSorted="gvLibros_Sorted">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
 </asp:GridView>
<%-- Libros --%>

        <asp:GridView ID="gvLibros" runat="server" HorizontalAlign="Center" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" class="table" AllowPaging="True" OnPageIndexChanging="gvLibros_PageIndexChanging" OnSelectedIndexChanged="gvLibros_SelectedIndexChanged" PageSize="7" OnSorted="gvLibros_Sorted">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
 </asp:GridView>

<%-- Multimedia --%>
                <asp:GridView ID="gvMultimedia" runat="server" HorizontalAlign="Center" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" class="table" AllowPaging="True" OnPageIndexChanging="gvMultimedia_PageIndexChanging" OnSelectedIndexChanged="gvLibros_SelectedIndexChanged" PageSize="7" OnSorted="gvLibros_Sorted">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
 </asp:GridView>
<%-- Reservaciones Libro--%>

        <asp:GridView ID="gvResLibro" runat="server" HorizontalAlign="Center" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" class="table" AllowPaging="True" OnPageIndexChanging="gvResLibro_PageIndexChanging" OnSelectedIndexChanged="gvLibros_SelectedIndexChanged" PageSize="7" OnSorted="gvLibros_Sorted">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
 </asp:GridView>

                <%-- Reservaciones Multimedia--%>

        <asp:GridView ID="gvResMulti" runat="server" HorizontalAlign="Center" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" class="table" AllowPaging="True" OnPageIndexChanging="gvResMulti_PageIndexChanging" OnSelectedIndexChanged="gvLibros_SelectedIndexChanged" PageSize="7" OnSorted="gvLibros_Sorted">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
 </asp:GridView>
<%-- En meson libro--%>
                <asp:GridView ID="gvMesonLibro" runat="server" HorizontalAlign="Center" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" class="table" AllowPaging="True" OnPageIndexChanging="gvMesonLibro_PageIndexChanging" OnSelectedIndexChanged="gvLibros_SelectedIndexChanged" PageSize="7" OnSorted="gvLibros_Sorted">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
 </asp:GridView>

 <%-- En meson Multimedia--%>
                <asp:GridView ID="gvMesonMultimedia" runat="server" HorizontalAlign="Center" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" class="table" AllowPaging="True" OnPageIndexChanging="gvMesonMultimedia_PageIndexChanging" OnSelectedIndexChanged="gvLibros_SelectedIndexChanged" PageSize="7" OnSorted="gvLibros_Sorted">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
 </asp:GridView>

<%-- Prestamos libro --%>

        <asp:GridView ID="gvPrestamosLib" runat="server" HorizontalAlign="Center" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" class="table" AllowPaging="True" OnPageIndexChanging="gvPrestamosLib_PageIndexChanging" OnSelectedIndexChanged="gvLibros_SelectedIndexChanged" PageSize="7" OnSorted="gvLibros_Sorted">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
 </asp:GridView>


<%-- Prestamos libro Multimedia --%>

<asp:GridView ID="gvPrestamoMulti" runat="server" HorizontalAlign="Center" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" class="table" AllowPaging="True" OnPageIndexChanging="gvPrestamoMulti_PageIndexChanging" OnSelectedIndexChanged="gvLibros_SelectedIndexChanged" PageSize="7" OnSorted="gvLibros_Sorted">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
 </asp:GridView>



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
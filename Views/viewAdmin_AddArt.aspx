<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewAdmin_AddArt.aspx.cs" Inherits="tp_web_equipo_19.Views.WebForm1" %>

<%--<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Master.Master" AutoEventWireup="true" CodeBehind="viewAdmin_AddArt.aspx.cs" Inherits="tp_web_equipo_19.Views.WebForm1" %>--%>

<%--<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">--%>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Content/bootstrap.rtl.min.css" rel="stylesheet" />
    <script src="../Scripts/bootstrap.min.js"></script>
    <title>Agregar Articulo</title>
</head>
<body>
    <%-- Form. necesito el formulario para poder utilizar los controles se servidor aspnet. --%>
   <form runat="server">

<%-- Navegacion --%>
  <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
  <div class="container-fluid">
    <a class="navbar-brand" href="viewArticulos.aspx">Volver</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
      <div class="mx-auto text-center">
     <h2 class=" text-white "> AGREGAR ARTICULO </h2>
     </div>
  </div>
</nav>

<%-- Agregar articulo --%>


<div style="margin-top: 1%"  > 

        <div  style="display: flex; margin-top: 1%;"> 
             <p class="fs-5" > Codigo: </p>
             <asp:TextBox ID="txtCodigo" runat="server" type="nonull">  </asp:TextBox> 
            <asp:RequiredFieldValidator ID="rfvCodigo" runat="server" ControlToValidate="txtCodigo"
                ErrorMessage="El codigo es obligatorio" Display="Dynamic"></asp:RequiredFieldValidator>  <%--Campo obligatorio--%>

        </div>

        <div  style="display: flex; margin-top: 1%;"> 
             <p class="fs-5" > Nombre: </p>
             <asp:TextBox ID="txtArticulo" runat="server">  </asp:TextBox> 
            <asp:RequiredFieldValidator ID="rfvArticulo" runat="server" ControlToValidate="txtArticulo"
    ErrorMessage="El nombre es obligatorio" Display="Dynamic"></asp:RequiredFieldValidator>  <%--Campo obligatorio--%>
        </div>

        <div  style="display: flex; margin-top: 1%;"> 
             <p class="fs-5" > Descripcion: </p>
             <asp:TextBox ID="txtDescripcion" runat="server">  </asp:TextBox> 
              <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ControlToValidate="txtDescripcion"
ErrorMessage="La descripcion es obligatoria" Display="Dynamic"></asp:RequiredFieldValidator>  <%--Campo obligatorio--%>

        </div>

        <div style="display: flex; margin-top: 1%;"> 
             <p class="fs-5"> Categoria: </p>
             <asp:DropDownList ID="listCat" runat="server"></asp:DropDownList>
               <asp:RequiredFieldValidator ID="rfvListaCat" runat="server" ControlToValidate="listCat"
ErrorMessage="Lista obligatoria" Display="Dynamic"></asp:RequiredFieldValidator>  <%--Campo obligatorio--%>
     
        </div>
        <div style="display: flex; margin-top: 1%;"> 
             <p class="fs-5"> Marca: </p>
             <asp:DropDownList ID="listMarca" runat="server"></asp:DropDownList>
                           <asp:RequiredFieldValidator ID="rfvListaMarca" runat="server" ControlToValidate="listMarca"
ErrorMessage="Lista obligatoria" Display="Dynamic"></asp:RequiredFieldValidator>  <%--Campo obligatorio--%>
            
        </div>

        <div style="display: flex; margin-top: 1%;"> 
             <p class="fs-5""> URL Imagen: </p>
             <asp:TextBox ID="txtImagenUrl" runat="server"></asp:TextBox>

        </div>

        <div style="display: flex; margin-top: 1%;"> 
             <p class="fs-5"> Precio: </p>
             <asp:TextBox ID="txtPrecio" runat="server" type="number"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="rfvPrecio" runat="server" ControlToValidate="txtPrecio"
ErrorMessage="El precio es obligatorio" Display="Dynamic"></asp:RequiredFieldValidator>  <%--Campo obligatorio--%>

        </div>
         
     <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
     <script> </script>
        
</div>

</form>
   
</body>
</html>

<%--   </asp:Content>--%>
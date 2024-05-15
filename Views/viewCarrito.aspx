<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="viewCarrito.aspx.cs" Inherits="tp_web_equipo_19.Views.viewCarrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container mb-lg-5">
        <asp:Repeater runat="server" ID="RptArticulos">
            <ItemTemplate>
                <div class="row border border-3 border-success ">
                    <div class="col-md-3">
                        <img src="<%# Eval("ImagenUrl") %>" runat="server" id="imagenArituculo" onerror="this.src = 'https://i.ibb.co/SwxTQny/imagen.png'" alt="Alternate Text" class="border border-2 border-black border-opacity-75 m-2" style="width: 180px; height: 120px" />
                    </div>
                    <div class="col-md-2 mt-5 text-center">
                        <asp:Label runat="server" ID="lblNombre" CssClass="fs-5 text-success text-opacity-75 fw-bolder ">Nombre</asp:Label>
                    </div>
                    <div class="col-md-2 mt-5 text-center">
                        <asp:Label runat="server" ID="lblCategoria" CssClass="fs-5 text-primary text-opacity-50 fw-bolder">Categoria</asp:Label>
                    </div>
                    <div class="col-md-2 mt-5 text-center">
                        <asp:Label runat="server" ID="lblMarca" CssClass="fs-5 text-primary text-opacity-50 fw-bolder">Marca</asp:Label>
                    </div>
                    <div class="col-md-2 d-flex justify-content-end align-items-end me-5">
                        <asp:Label runat="server" CssClass="text-end fs-5 text-warning text-opacity-75 fw-bolder" ID="lblPrecio">$Precio</asp:Label>
                    </div>
                    <asp:ImageButton runat="server" ID="ibEliminar" OnClick="ibEliminar_Click" ImageUrl="https://i.ibb.co/dcwWddg/basura.png" AlternateText="Eliminar" Style="width: 55px; height: 30px; margin-top: 2px; margin-right: 6px" />

                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>

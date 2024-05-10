<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="viewArticulos.aspx.cs" Inherits="tp_web_equipo_19.Views.viewArticulos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row justify-content-center align-items-center">
        <%--<asp:Repeater ID="Repeater1" runat="server">--%>
            <ItemTemplate>
                <div class="col-md-3 me-1 py-3">
                    <div class="card border border-3 border-dark border-opacity-10 rounded-4" style="max-width: 350px">
                        <div class="card-header">
                            <img class="img-fluid rounded-3" src="https://imgs.search.brave.com/-RLSD-VwfrdvJlQIn9ZKhe3lFwfnVzOxXCOV2UQZke8/rs:fit:860:0:0/g:ce/aHR0cHM6Ly9wbHVz/LnVuc3BsYXNoLmNv/bS9wcmVtaXVtX3Bo/b3RvLTE2ODA5ODU1/NTEwMDktMDUxMDdj/ZDI3NTJjP3E9ODAm/dz0xMDAwJmF1dG89/Zm9ybWF0JmZpdD1j/cm9wJml4bGliPXJi/LTQuMC4zJml4aWQ9/TTN3eE1qQTNmREI4/TUh4elpXRnlZMmg4/T1h4OGRHVnNKVU16/SlVFNVptOXVieVV5/TUcwbFF6TWxRak4y/YVd4OFpXNThNSHg4/TUh4OGZEQT0" alt="Foto" style="width: 340px; height: 250px;" />
                        </div>
                        <div class="card-body text-center">
                            <p class="card-text fw-semibold fs-4">Nombre</p>
                        </div>
                        <div class="card-body text-start">
                            <p class="card-title badge text-bg-dark  text-light text-wrap fs-5 ms-4">Marca</p>
                            <h5 class="card-title badge text-bg-dark  text-light text-wrap fs-5 ms-5">Categoria</h5>
                        </div>
                        <div class="list-group list-group-flush text-center justify-content-center align-items-center">
                            <asp:Button Text="Ver Detalle" runat="server" class=" mt-1 rounded-3 border border-2 border-dark w-100 fs-4 fw-bolder" />
                            <asp:Button Text="Agregar al carrito" runat="server" class="mt-2 mb-1 list-group-item rounded-3  border border-2 border-primary w-100 fs-5 fw-bolder" />
                        </div>
                        <div class="card-footer text-body-secondary text-end bg-success bg-opacity-50">
                            <p class="card-text fs-4 fw-semibold text-white">Precio</p>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        <%--</asp:Repeater>--%>
    </div>
</asp:Content>

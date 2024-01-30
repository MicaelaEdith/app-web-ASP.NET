<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPFinalNivel3RomeroMicaela.Default" EnableViewState="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .cardProducto {
            transition: transform 0.2s, box-shadow 0.3s;
            margin: 1vw;
            max-width: 100%;
        }

            .cardProducto:hover {
                transform: scale(1.005);
                box-shadow: 0 0 15px rgba(0, 0, 0, 0.3);
            }

        .sideBar {
            margin-right: 2vw;
            margin-left: 1vw;
            width: 20%;
            border-right: inset;
        }
    </style>

    <script type="text/javascript">
        function soloNumeros(e) {
            var key = window.event ? e.keyCode : e.which;
            var keychar = String.fromCharCode(key);

            if (!/^\d*\.?\d*$/.test(keychar) && key !== 8) {
                e.preventDefault();
            }
        }
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">

        <div class="sideBar col-2 m-3 mt-2">
            <div class="dropdown mb-2">

                <div>
                    <asp:Label Text="Categoria" runat="server" CssClass="m-1" />
                    <asp:DropDownList runat="server" CssClass="form-select mt-1 mb-2 " ID="drpCategoria" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div>
                    <asp:Label Text="Marca" runat="server" CssClass="m-1" />
                    <asp:DropDownList runat="server" CssClass="form-select mt-1 mb-4 " ID="drpMarca"></asp:DropDownList>
                </div>

                <div class="input-group mb-2">
                    <span class="input-group-text p-1">$</span>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtMin" placeholder="mínimo" onkeypress="return soloNumeros(event)" />
                </div>
                <div class="input-group mb-2">
                    <span class="input-group-text p-1">$</span>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtMax" placeholder="máximo" onkeypress="return soloNumeros(event)" />
                </div>
                <asp:Button Text="Buscar" runat="server" CssClass="btn btn-secondary p-1 float-end" ID="btnBuscarSidebar" OnClick="btnBuscarSidebar_Click" />
            </div>
        </div>

        <div class="col-9">
            <div class="row">
                <%
                    if (ListaProductos.Count > 0)
                    {
                        foreach (Dominio.Producto prod in ListaProductos)
                        { %>
                <div class="col-3 cardProducto position-relative p-1 m-2" style="width: calc(25% - 2vw); text-align: center">
                    <div class="img-container">
                        <img src="<%: prod.ImagenUrl %>" class="card-img-top img-fluid" style="object-fit: contain;">
                    </div>
                    <div class="card-body p-0 mb-5 align-content-center">
                        <h5 class="card-title"><%: prod.Nombre %> </h5>
                        <p class="card-text pb-2 MB-3"><%: prod.Descripcion%></p>
                    </div>
                    <div>
                        <a href="DetalleProducto.aspx?id=<%=prod.Id%>" class="btn btn-secondary position-absolute bottom-0 start-50 translate-middle-x mb-1 p-1">Ver detalle</a>
                    </div>
                </div>
                <% }
                    }
                    else
                    { %>
                <div class="m-1 mt-5">
                    <span class="m-2 alert alert-primary">No se encontraron productos</span>
                </div>

                <%} %>
            </div>
        </div>
    </div>
</asp:Content>

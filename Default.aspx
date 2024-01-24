<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPFinalNivel3RomeroMicaela.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .cardProducto {
            transition: transform 0.2s, box-shadow 0.3s;
        }

            .cardProducto:hover {
                transform: scale(1.005);
                box-shadow: 0 0 15px rgba(0, 0, 0, 0.3);
            }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card text-center" style="display: flex; flex-direction: row; margin-left: 4vw; margin-right: 4vw; border: none;">
        <%
            foreach (Dominio.Producto prod in ListaProductos)
            { %>
        <div class="cardProducto position-relative">
            <div class="img-container" style="display: flex; align-items: flex-end; margin: 0;">
                <img src="<%: prod.ImagenUrl %>" class="card-img-top img-fluid" style="max-width: 100%; height: auto;" alt="<%: prod.Nombre %>">
            </div>
            <div class="card-body ">
                <h5 class="card-title"><%: prod.Nombre %> </h5>
                <p class="card-text pb-2 MB-2"><%: prod.Descripcion%></p>
                <a href="DetalleProducto.aspx?id=<%=prod.Id%>" class="btn btn-secondary position-absolute bottom-0 start-50 translate-middle-x mb-1 p-1">Ver Detalle</a>
            </div>
        </div>
        <% } %>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPFinalNivel3RomeroMicaela.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="card text-center" style="display: flex; flex-direction: row; margin-left:4vw; margin-right:4vw; border:none;">

        <%
            foreach (Dominio.Producto prod in ListaProductos)
            { %>
        <div class="cardProducto">
            <img src="<%: prod.ImagenUrl %>" class="card-img-top" alt="<%: prod.Nombre %>" style="height:20vh;">
            <div class="card-body">
                <h5 class="card-title"><%: prod.Nombre %> </h5>
                <p class="card-text"><%: prod.Descripcion %></p>
                <a href="#" class="btn btn-secondary">Ver Detalle</a>
            </div>
        </div>
        <% } %>
    </div>

</asp:Content>

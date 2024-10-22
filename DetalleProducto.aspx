﻿<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="DetalleProducto.aspx.cs" Inherits="Proyecto_FlowerPower.DetalleProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="card mb-5 mt-5 mx-auto p-4" style="max-width: 650px;">
        <div class="row g-0">
            <div class="col-md-4">
                <img src="<%: prod.ImagenUrl %>" runat="server" id="imgProducto" class="img-fluid rounded-start" alt="<%: prod.Nombre %>" />
            </div>
            <div class="col-md-8">
                <div class="card-body">
                    
                    <a href="Perfil.aspx?id=<%=prod.Id%>"><div class="position-absolute top-0 end-0 bg-danger m-2" style="border:solid 3px #dc3545;border-radius:50%;">🤍</div></a>
                    <asp:Label Text="" ID="txtTitulo" runat="server" CssClass="card-title display-6 mb-3" />
                    <p runat="server" id="txtPrecio" class="card-text mt-3"></p>
                    <p runat="server" id="txtDescripcion" class="card-text mt-3"></p>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

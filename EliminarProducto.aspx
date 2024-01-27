<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="EliminarProducto.aspx.cs" Inherits="TPFinalNivel3RomeroMicaela.EliminarProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row mt-3">
        <div class="col-3"></div>
        <div class=" col-6 alert alert-danger align-items-center text-center" role="alert">
            <div>
                <p>
                    ¡Atención! Usted va a eliminar el siguiente artículo: 
                </p>
            </div>
        </div>
        <div class="col-3"></div>
    </div>
    <div class="card mb-5 mt-2 mx-auto p-4" style="max-width: 650px;">
        <div class="row g-0">
            <div class="col-md-4">
                <img runat="server" id="imgProducto" class="img-fluid rounded-start" alt="Producto" />
            </div>
            <div class="col-md-8">
                <div class="card-body">
                    <asp:Label Text="" ID="txtTitulo" runat="server" CssClass="card-title display-6 mb-3" />
                    <p runat="server" id="txtPrecio" class="card-text mt-3"></p>
                    <p runat="server" id="txtDescripcion" class="card-text mt-3"></p>
                </div>
            </div>
        </div>
        <div class="mx-auto" style="display:flex;">
                <asp:Button Text="Eliminar Definitivamente" runat="server" CssClass="btn btn-danger m-1" ID="btnEliminarDefinitivo" OnClick="btnEliminarDefinitivo_Click" /></asp:button>
                <asp:Button Text="Cancelar" runat="server" CssClass="btn btn-primary m-1" ID="cancelar" OnClick="cancelar_Click"/></asp:button>
    </div>
        </div>
</asp:Content>

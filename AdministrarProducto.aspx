<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="AdministrarProducto.aspx.cs" Inherits="TPFinalNivel3RomeroMicaela.AdministrarProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <style>
        .eliminar .eliminar:hover {
            transform: scale(1.02);
            color:dimgray;
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


    <div class="row mx-auto m-3 mb-5 mt-5">

        <div class="col-1"></div>

        <div class="col-md-2" style="margin-left: 4vw;">
            <img runat="server" id="imgProducto" class="img-fluid rounded-start" alt="Producto" />
        </div>

        <div class="col-md-6">
            <div class="row g-3">
                <div class="col-3">
                    <label class="col-form-label">Código:</label>
                </div>
                <div class="col-9">
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtCodigo" />
                </div>
            </div>

            <div class="row g-3 mt-1">
                <div class="col-3">
                    <label class="col-form-label">Nombre:</label>
                </div>
                <div class="col-9">
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtNombre" />
                </div>
            </div>
            <div class="row g-3 mt-1">
                <div class="col-3">
                    <label class="col-form-label">Descripción:</label>
                </div>
                <div class="col-9">
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtDescripcion" />
                </div>
            </div>

            <div class="row g-3 mt-1">
                <div class="col-3">
                    <label class="col-form-label">Precio:</label>
                </div>
                <div class="col-9">
                    <asp:TextBox runat="server" onkeypress="return soloNumeros(event)" CssClass="form-control" ID="txtPrecio" />
                </div>
            </div>

            <div class="row g-3 mt-1">
                <div class="col-3">
                    <label class="col-form-label">Categoría:</label>
                </div>
                <div class="col-9">
                    <asp:DropDownList runat="server" ID="drpCategoria" CssClass="form-select"></asp:DropDownList>
                </div>
            </div>

            <div class="row g-3 mt-1">
                <div class="col-3">
                    <label class="col-form-label">Marca:</label>
                </div>
                <div class="col-9">
                    <asp:DropDownList runat="server" ID="drpMarca" CssClass="form-select"></asp:DropDownList>
                </div>
            </div>

            <div class="row g-3 mt-1">
                <div class="col-3">
                    <label class="col-form-label">Url Imagen:</label>
                </div>
                <div class="col-9">
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtUrlImg"/>
                    <div class="float-end mt-3">
                        <asp:Button Text="Aceptar" runat="server" CssClass="btn btn-outline-secondary fw-semibold mt-2 p-1 pt-0 pb-0 " id="Aceptar" OnClick="Aceptar_Click"/>
                        <asp:Button Text="Cancelar" runat="server" CssClass="btn btn-outline-secondary fw-semibold mt-2 p-1 pt-0 pb-0 " id="Cancelar" OnClick="Cancelar_Click"/>
                    </div>
                </div>
            </div>
            <asp:Button Text="Eliminar Producto" runat="server" CssClass="btn btn-outline-danger fw-semibold mt-2 p-1 pt-1 pb-1 float-end" ID="EliminarProducto" OnClick="EliminarProducto_Click"/>
        </div>
    </div>
</asp:Content>

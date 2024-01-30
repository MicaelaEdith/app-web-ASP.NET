<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="CrearCuenta.aspx.cs" Inherits="TPFinalNivel3RomeroMicaela.CrearCuenta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-3"></div>
        <div class="col-6">
            <asp:Label ID="lblErrorPass" Text="Las passwords ingresadas no coinciden, intente nuevamente" Visible="false" CssClass="btn btn-danger float-center mt-1" runat="server" />
        </div>
        <div class="col-3"></div>
        <div class="col-3"></div>
        <div class="col-sm-5">
            <asp:Label Text="Usuario o contraseña incorrectos, intente nuevamente." ID="lblIncorrecto" CssClass="form-control text-bg-danger" Visible="false" runat="server" />
            <br />
        </div>
        <div class="col-1"></div>
    </div>
    <div class="row">
        <div class="mb-2 row">
            <asp:Label Text="Ingrese E-Mail: " CssClass="col-sm-3 col-form-label text-sm-end" runat="server" />
            <div class="col-sm-6">
                <asp:TextBox ID="txtEmail" CssClass="form-control" placeholder="Usuario" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="mb-2 row">
            <asp:Label Text="Ingrese Nombre: " CssClass="col-sm-3 col-form-label text-sm-end" runat="server" />
            <div class="col-sm-6">
                <asp:TextBox ID="txtNombre" CssClass="form-control" placeholder="Nombre" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="mb-2 row">
            <asp:Label Text="Ingrese Apellido: " CssClass="col-sm-3 col-form-label text-sm-end" runat="server" />
            <div class="col-sm-6">
                <asp:TextBox ID="txtApellido" CssClass="form-control" placeholder="Apellido" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="mb-2 row">
            <asp:Label Text="Ingrese Password:" CssClass="col-sm-3 col-form-label text-sm-end" runat="server" />
            <div class="col-sm-6">
                <asp:TextBox ID="txtPassword1" CssClass="form-control" placeholder="********" TextMode="Password" runat="server" />
            </div>
        </div>
    </div>
    <div class="row">

        <div class="mb-2 row">
            <asp:Label Text="Confirme Password:" CssClass="col-sm-3 col-form-label text-sm-end" runat="server" />
            <div class="col-sm-6">
                <asp:TextBox ID="txtPassword2" CssClass="form-control" placeholder="********" TextMode="Password" runat="server" />
                <br />
                <asp:Button Text="Registrarse" ID="btnRegistrarse" OnClick="btnRegistrarse_Click" CssClass="btn btn-secondary border m-1 float-end" runat="server" />
                <a href="/Default.aspx" class="btn btn-secondary border m-1 float-end">Cancelar</a>
            </div>
        </div>
    </div>

</asp:Content>

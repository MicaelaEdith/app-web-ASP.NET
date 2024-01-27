<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TPFinalNivel3RomeroMicaela.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Panel runat="server" DefaultButton="btnIngresar">
        <div class="row">
            <div class="col-3"></div>
            <div class="col-sm-6">
                <asp:Label Text="Usuario o contraseña incorrectos, intente nuevamente." ID="lblIncorrecto" CssClass="form-control text-bg-danger mt-1 mb-2" Visible="false" runat="server" />
            </div>
            <div class="col-1"></div>
        </div>
        <div class="row">
            <div class="mt-3 mb-2 row justify-content-center">
                <asp:Label Text="E-Mail: " CssClass="col-1 col-form-label" runat="server" />
                <div class="col-sm-6">
                    <asp:TextBox ID="txtUser" CssClass="form-control" placeholder="Usuario" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="mb-2 row justify-content-center">
                <asp:Label Text="Password:" CssClass="col-sm-1 col-form-label" runat="server" />
                <div class="col-sm-6">
                    <asp:TextBox ID="txtPassword" CssClass="form-control" placeholder="********" TextMode="Password" runat="server" />
                    <asp:Button Text="Ingresar" ID="btnIngresar" OnClick="btnIngresar_Click" CssClass="btn btn-secondary mt-2" runat="server" />
                    <a href="/CrearCuenta.aspx" class="text-decoration-none fw-medium float-end">Crear cuenta</a>
                </div>
            </div>
        </div>
    </asp:Panel>
</asp:Content>

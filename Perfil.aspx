<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="TPFinalNivel3RomeroMicaela.Favoritos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="card mb-3 mt-5 m-3" style="max-width: 500px;">
        <div class="row g-0">
            <div class="col-md-4">
                <img src="..." class="img-fluid rounded-start" alt="...">
            </div>
            <div class="col-md-8">
                <div class="card-body">
                    <h4 class="card-title mt-4">Nombre Usuario </h4>
                    <h4 class="card-title mb-4">Apellido Usuario </h4>
                    <asp:Button Text="Modificar" runat="server" ID="btnModificarPerfil" OnClick="btnSalir_Click" CssClass="btn btn-secondary mr-3 mt-4" />
                    <asp:Button Text="Salir" runat="server" ID="btnSalir" OnClick="btnSalir_Click" CssClass="btn btn-secondary mt-4" />
                    <%if (Session["administrar"] != null)
                        { %>
                    <asp:Button Text="Administrar" ID="btnAdministrar" OnClick="btnAdministrar_Click" runat="server" CssClass="float-end p-2 text-primary-emphasis bg-primary-subtle border border-primary-subtle rounded-3" />
                    <%}%>
                </div>
            </div>
        </div>
    </div>
   <div>
  </div>

</asp:Content>

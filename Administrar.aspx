<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Administrar.aspx.cs" Inherits="TPFinalNivel3RomeroMicaela.Administrar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col">
            <div class="col-4 m-4">
                <div style="display: inline;">
                    <asp:TextBox ID="txtFiltrar" CssClass="form-control bg-body-secondary col-3" AutoPostBack="true" runat="server" placeholder="filtrar" OnTextChanged="txtFiltrar_TextChanged"/>
                    
                    <asp:CheckBox Text="" ID="chkFiltroAvanzado" AutoPostBack="true" runat="server"/>
                        
                    <asp:Label Text=" Filtro Avanzado" CssClass="mb-1 w-100" runat="server" />
                </div>
            </div>
        </div>
        <%if (filtroAvanzado)
            {%>

        <div class="row m-3 mt-1">
            <div class="col-3">
                <asp:Label Text="Categoria" runat="server" />
                <asp:DropDownList runat="server" ID="drpCategoria" AutoPostBack="true" CssClass="form-control">
                </asp:DropDownList>
            </div>
            <div class="col-3">
                <asp:Label Text="Marca" runat="server" />
                <asp:DropDownList ID="drpMarca" CssClass="form-control" runat="server"></asp:DropDownList>
            </div>
            <div class="col-3">
                <asp:Label Text="Filtro" runat="server" />
                <div style="display:flex">
                <asp:TextBox ID="txtFiltroAvanzado" CssClass="form-control" runat="server" />
                <asp:Button Text="Buscar" ID="btnBuscar" CssClass="btn btn-secondary" OnClick="btnBuscar_Click" style="margin-left:1vw" runat="server" />
                    </div>
            </div>
        </div>
    </div>
    <%} %>
    <div style="max-width:95%; margin:auto">
        <asp:GridView ID="dgvProductos" runat="server" DataKeyNames="Id" CssClass="table" AutoGenerateColumns="false" AllowPaging="true" PageSize="10" OnRowCommand="dgvProductos_RowCommand">
            <Columns>
                <asp:BoundField HeaderText="Id" DataField="Id" />
                <asp:BoundField HeaderText="Código" DataField="codigo" />
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Descripción" DataField="Descripcion" />
                <asp:BoundField HeaderText="Categoria" DataField="Categoria.Descripcion" />
                <asp:BoundField HeaderText="Marca" DataField="Marca.Descripcion" />
                <asp:BoundField HeaderText="Precio" DataField="Precio" />
                <asp:CommandField HeaderText="Modificar" ShowSelectButton="true" SelectText="Modificar" ControlStyle-CssClass="text-decoration-none fw-medium" />
            </Columns>
        </asp:GridView>
        <asp:Button Text="Agregar Producto" runat="server" CssClass="btn btn-link fw-medium link-underline-opacity-0" Id="btnAgregar" OnClick="btnAgregar_Click"/>
    </div>
</asp:Content>

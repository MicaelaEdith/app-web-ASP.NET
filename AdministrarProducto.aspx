<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="AdministrarProducto.aspx.cs" Inherits="TPFinalNivel3RomeroMicaela.AdministrarProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row mx-auto m-3 mb-5 mt-5">

        <div class="col-1"></div>

        <div class="col-md-2" style="margin-left:4vw;">
            <img src="https://images.samsung.com/is/image/samsung/assets/ar/p6_gro2/p6_initial_mktpd/smartphones/galaxy-s10/specs/galaxy-s10-plus_specs_design_colors_prism_black.jpg?$163_346_PNG$" alt="Alternate Text" class="img-fluid" />
        </div>

        <div class="col-md-6">
            <div class="row g-3">
                <div class="col-3">
                    <label class="col-form-label">Código:</label>
                </div>
                <div class="col-9">
                    <asp:TextBox runat="server" CssClass="form-control" />
                </div>
            </div>

            <div class="row g-3 mt-1">
                <div class="col-3">
                    <label class="col-form-label">Nombre:</label>
                </div>
                <div class="col-9">
                    <asp:TextBox runat="server" CssClass="form-control" />
                </div>
            </div>
            <div class="row g-3 mt-1">
                <div class="col-3">
                    <label class="col-form-label">Descripción:</label>
                </div>
                <div class="col-9">
                    <asp:TextBox runat="server" CssClass="form-control" />
                </div>
            </div>

            <div class="row g-3 mt-1">
                <div class="col-3">
                    <label class="col-form-label">Precio:</label>
                </div>
                <div class="col-9">
                    <asp:TextBox runat="server" CssClass="form-control" />
                </div>
            </div>

            <div class="row g-3 mt-1">
                <div class="col-3">
                    <label class="col-form-label">Categoría:</label>
                </div>
                <div class="col-9">
                    <asp:TextBox runat="server" CssClass="form-control" />
                </div>
            </div>

            <div class="row g-3 mt-1">
                <div class="col-3">
                    <label class="col-form-label">Marca:</label>
                </div>
                <div class="col-9">
                    <asp:TextBox runat="server" CssClass="form-control" />
                </div>
            </div>

            <div class="row g-3 mt-1">
                <div class="col-3">
                    <label class="col-form-label">Url Imagen:</label>
                </div>
                <div class="col-9">
                    <asp:TextBox runat="server" CssClass="form-control" />
                    <div class="float-end mt-3">
                        <a href="/CrearCuenta.aspx" class="text-decoration-none fw-medium m-2">Aceptar</a>
                        <a href="/CrearCuenta.aspx" class="text-decoration-none fw-medium m-2">Cancelar</a>
                    </div>    
                </div>
            </div>

        </div>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="TPFinalNivel3RomeroMicaela.Favoritos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="
https://cdn.jsdelivr.net/npm/@splidejs/splide@4.1.4/dist/js/splide.min.js
"></script>
    <link href="
https://cdn.jsdelivr.net/npm/@splidejs/splide@4.1.4/dist/css/splide.min.css
"
        rel="stylesheet">
    <style>
.splide__track--nav>.splide__list>.splide__slide.is-active {
    border: none;
    transform:scale(1.03);
}
    </style>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="display: flex">
        <div class="card mb-3 mt-5 m-3 p-3" style="max-width: 350px;">
            <div class="row g-0">
                <div class="col-md-3">
                    <img src=".." runat="server" class="img-fluid rounded-start" alt="Perfil" id="imgPerfil" />
                </div>
                <div class="col-md-8">
                    <div class="card-body">
                        <div>
                            <asp:Label Text="" runat="server" CssClass="card-title fs-3 mb-3 mt-4 text-secondary" ID="txtNombre" />
                            <asp:Label Text="" runat="server" CssClass="card-title fs-3 mt-4 text-secondary" ID="txtApellido" />
                        </div>
                    </div>
                </div>
            </div>
            <div style="display: flex">
                <asp:Button Text="Modificar" runat="server" ID="btnModificarPerfil" OnClick="btnModificarPerfil_Click" CssClass="btn btn-secondary mr-3 mt-4 m-1 w-40" />
                <asp:Button Text="Salir" runat="server" ID="btnSalir" OnClick="btnSalir_Click" CssClass="btn btn-secondary mt-4 m-1 w-40" />
            </div>
            <%if (Session["administrar"] != null)

                { %>
            <asp:Button Text="Administrar" ID="btnAdministrar" OnClick="btnAdministrar_Click" runat="server" CssClass="m-3 mt-4 p-2 fw-medium text-primary-emphasis bg-primary-subtle border border-primary-subtle rounded-3 float-end end" />
            <%}%>
        </div>

        <div class="m-0" style="width: 70%;">
            <h4>Favs</h4>

            <div id="splide" class="splide">
                <div class="splide__track">
                    <ul class="splide__list p-0 float-start grid text-center" style="display: flex">
                        <% foreach (Dominio.Producto prod in listaFavs)
                            { %>
                        <li class="splide__slide" style="list-style: none; margin: 1vw;">
                            <div class="col-4 cardProducto position-relative p-1 m-2" style="width: 18vw;">
                                <div class="img-container">
                                    <img src="<%= prod.ImagenUrl %>" class="card-img-top img-fluid" style="object-fit: contain;">
                                </div>
                                <div class="card-body p-0 mb-5">
                                    <h5 class="card-title"><%= prod.Nombre %></h5>
                                    <p class="card-text pb-2 MB-3"><%= prod.Descripcion %></p>
                                </div>
                                <div>
                                    <asp:Button Text="Eliminar de Favoritos" runat="server" ID="eliminarFav" OnClick="eliminarFav_Click" data-producto-id='<%= prod.Id %>' class="btn btn-secondary position-absolute bottom-0 start-50 translate-middle-x mb-1 p-1 w-75" />
                                </div>
                            </div>
                        </li>
                        <% } %>
                    </ul>
                </div>
            </div>
        </div>
    </div>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            new Splide('#splide', {
                type: 'carousel',
                fixedWidth: 350,
                fixedHeight: 100,
                gap: 10,
                pagination: false,
                focus: 'center',
                isNavigation: true,
                breakpoints: {
                    600: {
                        fixedWidth: 400,
                        fixedHeight: 225,
                    }
                }
            }).mount();
        });

        var splide = new Splide('.splide', {
            perPage: 3,
            rewind: true,
        });

        splide.mount();

    </script>

</asp:Content>

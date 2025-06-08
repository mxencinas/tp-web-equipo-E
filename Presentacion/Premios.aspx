<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Premios.aspx.cs" Inherits="Presentacion.Premios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1 class="display-6 text-center">Elegi tu premio!!</h1>
    <br />
    <div class="row">

        <asp:Repeater ID="rptArticulos" runat="server">

            <ItemTemplate>

                <div class="col-md-4 mb-4">

                    <div class="card" style="width: 18rem;">
                        <img src='<%# Eval("ImagenPrincipal") %>'
                            class="img-fluid object-fit-cover rounded-top"
                            style="height: 240px;"
                            alt='<%# Eval("Nombre") %>' />

                        <div class="card-body">
                            <h5 class="card-title"><%# Eval("Nombre") %></h5>
                            <p class="card-text"><%# Eval("Descripcion") %></p>
                            <asp:Button ID="btnElegir" runat="server" Text="Elegir" CssClass="btn btn-primary" 
                                CommandName="ArticuloId" 
                                CommandArgument='<%# Eval("IdArticulos") %>' 
                                Onclick="btnElegir_Click"/>
                        </div>
                    </div>
                </div>

            </ItemTemplate>

        </asp:Repeater>

    </div>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Presentacion.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%--<p><%:Session["codigoVoucher"] %></p>
    <p><%:Session["idArticulo"] %></p>--%>
    <div class="text-center">
        <h1>Ingresá tus datos</h1>
    </div>
    <div class="col">
        <asp:Label ID="lblDNI" runat="server" Text="DNI"></asp:Label>
        <asp:TextBox ID="txtDni" TextMode="SingleLine" MaxLength="8"  CssClass="form-control"  runat="server"></asp:TextBox>
        <asp:Label ID="lblRegistro"  runat="server" Text=""></asp:Label>
    </div>

    <div>
        <div class="row">
            <div class="col">
                <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server"></asp:TextBox>

            </div>
            <div class="col">
                <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>
                <asp:TextBox ID="txtApellido" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col">
                <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                <div class="imput-group">
                    <span class="imput-group-text"></span>
                    <asp:TextBox ID="txtEmail"  CssClass="form-control" PlaceHolder="example@gmail.com" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
    </div>
    <div>
        <div class="row">
            <div class="col">
                <asp:Label ID="lblDireccion" runat="server" Text="Dirección"></asp:Label>
                <asp:TextBox ID="txtDireccion" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col">
                <asp:Label ID="lblCiudad" runat="server" Text="Ciudad"></asp:Label>
                <asp:TextBox ID="txtCiudad" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col">
                <asp:Label ID="lblCp" runat="server" Text="Cp"></asp:Label>
                <asp:TextBox ID="txtCp" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
    </div>

    <asp:CheckBox ID="chkTerminos" runat="server" />
    <asp:Label ID="lblTerminos" runat="server" Text="Acepto los términos y condiciones"></asp:Label>

    <div class="mb">
        <asp:Button ID="btnParticipar" CssClass="btn btn-primary" OnClick="btnParticipar_Click" runat="server" Text="PARTICIPAR!" />
    </div>
</asp:Content>

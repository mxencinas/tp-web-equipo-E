<%@ Page Title="Ingresá tu voucher" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Voucher.aspx.cs" Inherits="Presentacion.Voucher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Promo ¡Ganá!</h2>
    <hr />
    <div class="form-group">
        <label for="txtCodigo">Ingresá el código de tu voucher:</label>
        <asp:TextBox ID="txtCodigo" CssClass="form-control" runat="server" MaxLength="20"></asp:TextBox>
    </div>
    <br />
    <asp:Button ID="btnSiguiente" runat="server" CssClass="btn btn-primary" Text="Siguiente" OnClick="btnSiguiente_Click" />
    <br /><br />
    <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
</asp:Content>


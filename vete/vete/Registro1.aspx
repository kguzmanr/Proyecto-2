<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registro1.aspx.cs" Inherits="vete.Registro1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h2>Registrarse</h2>
    <div class="reportes">
        <fieldset>
            <legend>Mascotas</legend>
            <div class="pregunta-horizontal">
                <div>
                    <label>Nombre:</label>
                    <br>
                    <asp:TextBox ID="tnombre" class="textbox" runat="server"></asp:TextBox>
                </div>
                <div>
                    <label>Apellidos:</label>
                    <br>
                    <asp:TextBox ID="tapellidos" class="textbox" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="pregunta-horizontal">
                <div>
                    <label>Usuario:</label>
                    <br>
                    <asp:TextBox ID="tusuario" class="textbox" runat="server"></asp:TextBox>
                </div>
                <div>
                    <label>Contraseña:</label>
                    <br>
                    <asp:TextBox type="password" placeholder="Digite su contraseña" ID="tcontrasena" class="textbox" runat="server"></asp:TextBox>
                </div>
            </div>
            <br>
            <div>
                <asp:Button ID="bregistrar" CssClass="button button1" runat="server" Text="Registrarse" />
            </div>
        </fieldset>
    </div>
</asp:Content>

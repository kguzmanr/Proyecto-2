<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Reporusu.aspx.cs" Inherits="vete.Reporusu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h2>Reporte de Usuarios</h2>
<div class="reportes">
    <div style="margin: 27px auto; width: 23%;">
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </div>
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
            <asp:Button ID="bingresar" CssClass="button button1" runat="server" Text="Agregar" OnClick="Bingresar_Click" />
            <asp:Button ID="bborrar" CssClass="button button2" runat="server" Text="Eliminar" OnClick="Bborrar_Click" />
            <asp:Button ID="bcambiar" CssClass="button button3" runat="server" Text="Modificar" OnClick="Bcambiar_Click" />
        </div>
    </fieldset>
    </div>
</asp:Content>

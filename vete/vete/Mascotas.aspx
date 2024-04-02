<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Mascotas.aspx.cs" Inherits="vete.Mascotas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Reporte de Mascotas</h2>
    <div class="reportes">
        <div style="margin: 27px auto; width: 23%;" >
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
                    <label>Código:</label>
                    <br>
                    <asp:TextBox ID="codigo" class="textbox" runat="server"></asp:TextBox>
                </div>
                <div>
                    <label>Nombre Mascota:</label>
                    <br>
                    <asp:TextBox ID="mascota" class="textbox" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="pregunta-horizontal">
                <div>
                    <label>Tipo Mascotas:</label>
                    <br>
                    <asp:TextBox ID="tipo" class="textbox" runat="server"></asp:TextBox>
                </div>
                <div>
                    <label>Comida Favorita:</label>
                    <br>
                    <asp:TextBox ID="comida" class="textbox" runat="server"></asp:TextBox>
                </div>
            </div>
            <br>
            <div>
                <asp:Button ID="bagregar" CssClass="button button1" runat="server" Text="Agregar" OnClick="Bagregar_Click" />
                <asp:Button ID="beliminar" CssClass="button button2" runat="server" Text="Eliminar" OnClick="Beliminar_Click" />
                <asp:Button ID="bmodificar" CssClass="button button3" runat="server" Text="Modificar" OnClick="Bmodificar_Click" />
            </div>
        </fieldset>
    </div>
</asp:Content>


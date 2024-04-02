<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Reportcit.aspx.cs" Inherits="vete.Reportcit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style>
        .gridview {
            width: 100%;
            border-collapse: collapse;
        }

        .gridview th, .gridview td {
            border: 1px solid #dddddd;
            padding: 8px;
        }

        .gridview th {
            background-color: #f2f2f2;
            font-weight: bold;
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Reporte de Control de Citas</h2>
    <div class="reportes">
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="NombreMascota" HeaderText="Nombre Mascota" />
        <asp:BoundField DataField="FechaCita" HeaderText="Fecha de Cita" DataFormatString="{0:yyyy-MM-dd}" />
        <asp:BoundField DataField="Doctor" HeaderText="Doctor(a)" />
    </Columns>
</asp:GridView>
    </div>
</asp:Content>

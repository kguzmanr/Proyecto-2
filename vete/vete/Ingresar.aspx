<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ingresar.aspx.cs" Inherits="vete.Ingresar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="estilos/login.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="login-page">
                <div class="form">
                    <form class="login-form">
                        <h3>Ingresar</h3>
                        <br />

                        <asp:TextBox ID="Tnombre" placeholder="Usuario" required runat="server"></asp:TextBox>
                         <asp:TextBox ID="Tclave" placeholder="Contraseña" required runat="server" TextMode="Password"></asp:TextBox>
                        <asp:Button ID="Bingresar" runat="server" Text="Ingresar" OnClick="Bingresar_Click" />
                    </form>
                </div>
            </div>
        </div>
    </form>
</body>
</html>

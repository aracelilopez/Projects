<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaPrincipal.aspx.cs" Inherits="CapaDeUsuarioWeb.PaginaPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style4 {
            width: 347px;
            height: 87px;
        }
        .auto-style5 {
            width: 219px;
            height: 87px;
        }
        .auto-style7 {
            height: 87px;
        }
        .auto-style12 {
            width: 347px;
            height: 23px;
        }
        .auto-style13 {
            width: 219px;
            height: 23px;
        }
        .auto-style15 {
            height: 23px;
        }
        .auto-style16 {
            width: 347px;
            height: 3px;
        }
        .auto-style17 {
            width: 219px;
            height: 3px;
        }
        .auto-style19 {
            height: 3px;
        }
        .auto-style20 {
            width: 107px;
            height: 87px;
        }
        .auto-style21 {
            width: 107px;
            height: 3px;
        }
        .auto-style22 {
            width: 107px;
            height: 23px;
        }
        .nuevoEstilo1 {
            font-family: Impact, Haettenschweiler, "Arial Narrow Bold", sans-serif;
        }
        .auto-style24 {
            color: #CC3300;
        }
        .nuevoEstilo2 {
            font-family: Impact, Haettenschweiler, "Arial Narrow Bold", sans-serif;
        }
        .auto-style25 {
            font-family: Impact, Haettenschweiler, "Arial Narrow Bold", sans-serif;
            font-size: xx-large;
            color: #CC3300;
        }
        .auto-style26 {
            text-decoration: underline;
        }
    </style>
</head>
<body style="height: 427px; background-color: #C0C0C0">
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
        <span class="auto-style25">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style26">MENU DE LA BILIOTECA DE LA UM<br />
        </span></strong></span></div>
        <table style="width: 100%; height: 268px;">
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="Button3" runat="server" Height="71px" OnClick="Button3_Click" Text="Ver Usuario" Width="222px" />
                </td>
                <td class="auto-style20"></td>
                <td class="auto-style7">
                    <asp:Button ID="Button5" runat="server" Height="71px" Text="Reservar un libro" Width="222px" OnClick="Button5_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style16"></td>
                <td class="auto-style17"></td>
                <td class="auto-style21"></td>
                <td class="auto-style19"></td>
            </tr>
            <tr>
                <td class="auto-style12"></td>
                <td class="auto-style13">
                    <asp:Button ID="Button4" runat="server" Height="71px" Text="Ver Transacciones" Width="222px" OnClick="Button4_Click" />
                </td>
                <td class="auto-style22"></td>
                <td class="auto-style15">
            <span class="auto-style24">
                    <asp:Button ID="Button7" runat="server" Height="71px" OnClick="Button7_Click" Text="Renovar Prestamo" Width="222px" />
                    </span>
                </td>
            </tr>
        </table>
        <br />
        <asp:Panel ID="Panel2" runat="server" Height="32px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style24"><a href="http://localhost:55374/PaginaInicial.aspx">[CERRAR SESSION]</a></span></asp:Panel>
    </form>
    </body>
</html>

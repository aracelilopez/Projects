<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Transacciones.aspx.cs" Inherits="CapaDeUsuarioWeb.Transacciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1109px;
            height: 382px;
            background-color: #999999;
        }
        .auto-style10 {
            height: 49px;
            width: 184px;
        }
        .auto-style13 {
            height: 49px;
            width: 185px;
        }
        .auto-style21 {
            height: 49px;
            width: 198px;
        }
        .auto-style28 {
            width: 184px;
            height: 190px;
        }
        .auto-style30 {
            width: 198px;
            height: 190px;
        }
        .auto-style32 {
            width: 185px;
            height: 190px;
        }
        .auto-style33 {
            font-size: x-large;
        }
        .nuevoEstilo1 {
            font-family: Impact, Haettenschweiler, "Arial Narrow Bold", sans-serif;
        }
        .auto-style34 {
            font-family: Impact, Haettenschweiler, "Arial Narrow Bold", sans-serif;
            font-size: x-large;
            color: #CC3300;
            text-decoration: underline;
        }
        .auto-style35 {
            color: #FF3300;
        }
        .auto-style36 {
            background-color: #999999;
        }
    </style>
</head>
<body style="margin-bottom: 67px">
    <form id="form1" runat="server">
    <div class="auto-style36">
    
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style34"><strong>DATOS DE TRANSACCIONES DE EL USUARIO</strong></span><br class="auto-style33" />
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style10"></td>
                <td class="auto-style21">&nbsp;&nbsp;&nbsp;&nbsp; Lista de Prestamos</td>
                <td class="auto-style13">&nbsp;&nbsp;&nbsp; Lista de Reservas</td>
                <td class="auto-style13">
                    Busqueda Especifica</td>
                <td class="auto-style13"></td>
            </tr>
            <tr>
                <td class="auto-style28"></td>
                <td class="auto-style30">
                    <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="165px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="162px"></asp:ListBox>
                </td>
                <td class="auto-style32">
                    <asp:ListBox ID="ListBox2" runat="server" AutoPostBack="True" Height="165px" OnSelectedIndexChanged="ListBox2_SelectedIndexChanged" Width="162px"></asp:ListBox>
                </td>
                <td class="auto-style32">Ingrese Codigo:<br />
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <br />
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
                        <asp:ListItem>Prestamo</asp:ListItem>
                        <asp:ListItem>Reserva</asp:ListItem>
                    </asp:RadioButtonList>
                    <br />
&nbsp;
                    <asp:Label ID="Label1" runat="server" CssClass="auto-style35"></asp:Label>
                    <br />
&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Height="35px" OnClick="Button1_Click" Text="Mostrar" Width="82px" />
                    <br />
                </td>
                <td class="auto-style32"></td>
            </tr>
            <tr>
                <td colspan="5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Height="50px" OnClick="Button2_Click" Text="Volver" Width="109px" />
                </td>
            </tr>
            </table>
    </form>
</body>
</html>

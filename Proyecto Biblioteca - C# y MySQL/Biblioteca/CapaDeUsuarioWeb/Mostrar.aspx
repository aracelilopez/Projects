<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mostrar.aspx.cs" Inherits="CapaDeUsuarioWeb.Mostrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 387px;
        }
        .auto-style3 {
            height: 27px;
            background-color: #999999;
        }
        .auto-style6 {
            height: 36px;
            background-color: #999999;
        }
        .auto-style8 {
            height: 32px;
            background-color: #999999;
        }
        .auto-style9 {
            height: 30px;
            background-color: #999999;
        }
        .auto-style10 {
            height: 28px;
            background-color: #999999;
        }
        .auto-style11 {
            height: 28px;
            width: 324px;
            background-color: #999999;
        }
        .auto-style12 {
            height: 32px;
            width: 324px;
            background-color: #999999;
        }
        .auto-style13 {
            height: 36px;
            width: 324px;
            background-color: #999999;
        }
        .auto-style14 {
            height: 30px;
            width: 324px;
            background-color: #999999;
        }
        .auto-style18 {
            height: 28px;
            width: 181px;
            background-color: #999999;
        }
        .auto-style19 {
            height: 32px;
            width: 181px;
            background-color: #999999;
        }
        .auto-style20 {
            height: 36px;
            width: 181px;
            background-color: #999999;
        }
        .auto-style21 {
            height: 30px;
            width: 181px;
            background-color: #999999;
        }
        .auto-style25 {
            height: 33px;
            width: 324px;
            background-color: #999999;
        }
        .auto-style26 {
            height: 33px;
            width: 181px;
            background-color: #999999;
        }
        .auto-style27 {
            height: 33px;
            background-color: #999999;
        }
        .nuevoEstilo1 {
            font-family: Impact, Haettenschweiler, "Arial Narrow Bold", sans-serif;
        }
        .auto-style28 {
            font-family: Impact, Haettenschweiler, "Arial Narrow Bold", sans-serif;
            color: #CC3300;
            font-size: x-large;
            text-decoration: underline;
        }
        .auto-style29 {
            background-color: #999999;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style29">
    
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LabelTitulo" runat="server" CssClass="auto-style28"></asp:Label>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style11"></td>
                <td class="auto-style18">
                    <asp:Label ID="LabelCod" runat="server"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBoxCodigo" runat="server" Width="143px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style12"></td>
                <td class="auto-style19">Nombre de cliente:</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBoxNombre" runat="server" Width="143px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style13"></td>
                <td class="auto-style20">Nombre del libro:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBoxLibro" runat="server" Width="143px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14"></td>
                <td class="auto-style21">
                    <asp:Label ID="LabelFecha1" runat="server"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBoxFecha" runat="server" Width="143px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style25"></td>
                <td class="auto-style26">
                    <asp:Label ID="LabelFecha2" runat="server"></asp:Label>
                </td>
                <td class="auto-style27">
                    <asp:TextBox ID="TextBoxFecha2" runat="server" Width="143px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" Height="33px" Text="Volver" Width="120px" OnClick="Button1_Click" />
                </td>
            </tr>
            </table>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReservarLibro.aspx.cs" Inherits="CapaDeUsuarioWeb.ReservarLibro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 245px;
        }
        .auto-style2 {
            height: 34px;
            background-color: #999999;
        }
        .auto-style4 {
            height: 34px;
            width: 178px;
            background-color: #999999;
        }
        .auto-style5 {
            width: 178px;
            background-color: #999999;
        }
        .auto-style6 {
            height: 34px;
            width: 395px;
            background-color: #999999;
        }
        .auto-style7 {
            width: 395px;
            background-color: #999999;
        }
        .auto-style8 {
            width: 395px;
            height: 204px;
            background-color: #999999;
        }
        .auto-style9 {
            width: 178px;
            height: 204px;
            background-color: #999999;
        }
        .auto-style10 {
            height: 204px;
            background-color: #999999;
        }
        .auto-style11 {
            color: #FF0000;
        }
        .auto-style12 {
            background-color: #999999;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style6"></td>
                <td class="auto-style4">Lista de Reservas:</td>
                <td class="auto-style2">Desea Algun filtro:</td>
            </tr>
            <tr>
                <td class="auto-style8"></td>
                <td class="auto-style9">
                    <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="112px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="154px"></asp:ListBox>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <br />
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem>Por Isbn</asp:ListItem>
                        <asp:ListItem>Por Autor</asp:ListItem>
                        <asp:ListItem>Por Editorial</asp:ListItem>
                        <asp:ListItem>Por genero</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:Button ID="Button1" runat="server" Height="24px" OnClick="Button1_Click" Text="Filtrar" Width="109px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <br />
                    <br />
                    <br />
                </td>
                <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" CssClass="auto-style11"></asp:Label>
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Height="28px" OnClick="Button2_Click" Text="Volver" Width="116px" />
                </td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>

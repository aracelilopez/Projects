<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Renovar.aspx.cs" Inherits="CapaDeUsuarioWeb.Renovar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 413px;
        }
        .auto-style2 {
            height: 215px;
        }
        .auto-style3 {
            height: 215px;
            width: 255px;
        }
        .auto-style5 {
            height: 215px;
            width: 516px;
        }
        .auto-style7 {
            height: 215px;
            width: 277px;
            background-color: #999999;
        }
        .auto-style8 {
            width: 516px;
            background-color: #999999;
        }
        .auto-style13 {
            width: 324px;
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
        .auto-style28 {
            height: 30px;
            width: 516px;
            background-color: #999999;
        }
        .auto-style29 {
            height: 33px;
            width: 516px;
            background-color: #999999;
        }
        .auto-style30 {
            color: #FF0000;
        }
        .auto-style31 {
            height: 26px;
            background-color: #999999;
        }
        .auto-style32 {
            height: 33px;
            background-color: #999999;
        }
        .auto-style33 {
            height: 67px;
            background-color: #999999;
        }
        .auto-style34 {
            color: #006600;
        }
        .auto-style35 {
            background-color: #999999;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style35">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <br />
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style3">Seleccione el prestamo a renovar<br />
                    <br />
                    <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="157px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="256px"></asp:ListBox>
                </td>
                <td class="auto-style5">&nbsp;&nbsp;&nbsp; Ingrese el codigo que desea buscar<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="174px"></asp:TextBox>
                    <br />
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="ButtonBuscar" runat="server" Height="32px" OnClick="ButtonBuscar_Click" Text="Buscar" Width="61px" />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="LabelError" runat="server" CssClass="auto-style30" Visible="False"></asp:Label>
                </td>
                <td class="auto-style7">
                    <br />
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style33" colspan="3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="LabelError2" runat="server" CssClass="auto-style30" Visible="False"></asp:Label>
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Height="38px" OnClick="Button1_Click" Text="Volver" Width="83px" />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label4" runat="server" CssClass="auto-style34" Text="El prestamo cumple los requisitos" Visible="False"></asp:Label>
                </td>
                </tr>
            <tr>
                <td class="auto-style13" rowspan="3"></td>
                <td class="auto-style20">
                    <asp:Label ID="Label2" runat="server" Text="Nombre del libro:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBoxLibro" runat="server" Width="143px" Enabled="False" Visible="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style21">
                    <asp:Label ID="LabelFecha1" runat="server" Visible="False">Fecha de efectuacion:</asp:Label>
                </td>
                <td class="auto-style28">
                    <asp:TextBox ID="TextBoxFecha" runat="server" Width="143px" Enabled="False" Visible="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style26">
                    <asp:Label ID="LabelFecha2" runat="server" Visible="False">Vieja fecha de devolucion:</asp:Label>
                </td>
                <td class="auto-style29">
                    <asp:TextBox ID="TextBoxFecha2" runat="server" Width="143px" Enabled="False" Visible="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style26">
                    <asp:Label ID="Label3" runat="server" Text="Fecha Nueva de devolucion:" Visible="False"></asp:Label>
                </td>
                <td class="auto-style29">
                    <asp:TextBox ID="TextBoxFecha3" runat="server" Enabled="False" Visible="False" Width="142px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style32" colspan="3">
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="ButtonConfirmar" runat="server" Height="37px" OnClick="ButtonConfirmar_Click" Text="Confirmar" Visible="False" Width="79px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="ButtonCancelar" runat="server" Height="37px" OnClick="ButtonCancelar_Click" Text="Cancelar" Width="79px" Visible="False" />
                </td>
                </tr>
            <tr>
                <td class="auto-style31" colspan="5"></td>
            </tr>
        </table>
    </form>
</body>
</html>

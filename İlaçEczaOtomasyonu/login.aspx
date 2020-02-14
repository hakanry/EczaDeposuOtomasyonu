<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="İlaçEczaOtomasyonu.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>GİRİŞ YAPIN</title>
    <!-- Bootstrap  -->
	<link rel="stylesheet" href="css/bootstrap.css"/>

	<!-- Theme style  -->
	<link rel="stylesheet" href="css/style.css"/>
    <style type="text/css">
        .auto-style1 {
            height: 160px;
            width: 180px;
            margin-left: 0px;
        }
        .auto-style3 {
            width: 211px;
        }
        .auto-style4 {
            width: 267px;
        }
        .auto-style6 {
            height: 240px;
            width: 389px;
            margin-left: 0px;
        }
        .auto-style7 {
            width: 340px;
        }
        .auto-style9 {
            left: 1px;
            top: 0px;
        }
    </style>
</head>
<body id="gtco-header" class="gtco-cover" role="banner" style="background-image:url('images/şubeler.jpg'); left: 0px; top: 11px; height: 422px; width: 88%;">
    <form id="form1" runat="server" class="auto-style1">
        <div class="col-xs-6 text-left menu-1" style="left: 472px; top: 293px; width: 214%; height: 208px;">
            <table class="auto-style6">
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label1" runat="server" Text="KULLANICI ADI:" Font-Size="X-Large" ForeColor="White"></asp:Label>
                    <br />
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label2" runat="server" Text="ŞİFRE:" Font-Size="X-Large" ForeColor="White"></asp:Label>
                    <br />
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style3">
                    <br />
                    <asp:Button ID="btnGiris" runat="server" OnClick="btnGiris_Click" Text="Giriş" Width="180px" CssClass="btn btn-white btn-outline  btn-lg" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4" Font-Size="X-Large" ForeColor="White" colspan="2">
                    &nbsp;&nbsp;
                    <asp:Label ID="lblDurum" runat="server" Text="Label" Font-Size="15"></asp:Label>
                </td>
            </tr>
        </table>
        </div>
        <div class="col-xs-6 text-center menu-1" style="left: 463px; top: -76px; width: 218%; height: 143px">
        <asp:Label ID="loginbaslik" Font-Size="20" Font-Bold="true" ForeColor="SkyBlue" Text="ECZA DEPOSU OTOMASYONU KULLANICI GİRİŞ SAYFASI" runat="server" CssClass="auto-style9"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
</form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="anasayfa.aspx.cs" Inherits="İlaçEczaOtomasyonu.Grid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

 
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>ECZA DEPOSU OTOMASYONU</title>
    	
	
	<!-- Bootstrap  -->
	<link rel="stylesheet" href="css/bootstrap.css"/>

	<!-- Theme style  -->
	<link rel="stylesheet" href="css/style.css"/>

	
    <style>
* {
    padding: 0; 
    margin: 0; 
}
grbody {
	font: 11px Tahoma;
	background-color: #F7F7E9;
}
grh1 {
    font: bold 32px Times;
	color: #666;
	text-align: center;
	padding: 20px 0;    
}
#container {
    width: 700px;
    margin: 10px auto;
}

.mGrid { width: 100%; background-color: #fff; margin: 5px 0 10px 0; border: solid 1px #525252; border-collapse:collapse; }
    .mGrid td { padding: 2px; border: solid 1px #c1c1c1; color: #717171; }
    .mGrid th { padding: 4px 2px; color: #fff; background: #424242 url(grd_head.png) repeat-x top; border-left: solid 1px #525252; font-size: 0.9em; }
.mGrid .alt { background: #fcfcfc url(grd_alt.png) repeat-x top; }
.mGrid .pgr {background: #424242 url(grd_pgr.png) repeat-x top; }
    .mGrid .pgr table { margin: 5px 0; }
    .mGrid .pgr td { border-width: 0; padding: 0 6px; border-left: solid 1px #666; font-weight: bold; color: #fff; line-height: 12px; }   
    .mGrid .pgr a { color: #666; text-decoration: none; }
    .mGrid .pgr a:hover { color: #000; text-decoration: none; }

        .auto-style1 {
            height: 27px;
            width: 413px;
        }
        .auto-style3 {
            height: 27px;
            width: 248px;
        }
        .auto-style4 {
            width: 248px;
        }

        .auto-style7 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 99%;
            left: -12px;
            top: -217px;
            padding-left: 15px;
            padding-right: 15px;
        }

        .auto-style8 {
            width: 83%;
        }

        .auto-style9 {
            width: 413px;
        }

        .auto-style10 {
            height: 886px;
            width: 1218px;
        }

        </style>
    </head>
<body id="gtco-header" class="gtco-cover" role="banner" style="background-image:url('images/PiPS%204k%20(11).jpg'); Height: 100%px; Width: 100%;">
    
    <form id="form1" runat="server" style="Width:100%; Height:100%;">
        <div>
            <br />
            <asp:Label ID="Label10"  class="col-xs-12 text-center menu-1" runat="server" Text="Label" Font-Size="40" Font-Bold="true" ForeColor="SkyBlue"></asp:Label>
        </div>
    <div class="col-xs-12 text-center menu-1" style="left: -1px; top: 4px; height: 65px; width: 100%;">
                        <asp:Button ID="Buton_Anasayfa" runat="server" OnClick="Buton_Anasayfa_Click" Text="ANASAYFA" ForeColor="DarkBlue" Font-Size="15" Font-Bold="true" Cssclass="btn btn-white btn-outline btn-lg"/>
        &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Buton_Musteriler" runat="server" OnClick="Buton_Musteriler_Click" Text="MÜŞTERİLER" ForeColor="DarkBlue" Font-Size="15" Font-Bold="true" CssClass="btn btn-white btn-outline  btn-lg" />
                    &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Buton_Ilaclar" runat="server" OnClick="Buton_Ilaclar_Click" Text="İLAÇLAR" ForeColor="DarkBlue" Font-Size="15" Font-Bold="true" Cssclass="btn btn-white  btn-outline btn-lg" />
                    &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Buton_Calisanlar" runat="server" OnClick="Buton_Calisanlar_Click" Text="ÇALIŞANLAR"  ForeColor="DarkBlue" Font-Size="15" Font-Bold="true" Cssclass="btn btn-white btn-outline btn-lg" />
                    &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Buton_Subeler" runat="server" OnClick="Buton_Subeler_Click" Text="ŞUBELER" ForeColor="DarkBlue" Font-Size="15" Font-Bold="true"  Cssclass="btn btn-white btn-outline btn-lg" />
                    &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Buton_SatisListesi" runat="server" OnClick="Buton_SatisListesi_Click" Text="SATIŞ LİSTESİ" ForeColor="DarkBlue" Font-Size="15" Font-Bold="true" Cssclass="btn btn-white btn-outline btn-lg" />
                    &nbsp;
                    &nbsp;&nbsp;&nbsp;
                        </div>

        <br />
            <div class="col-xs-7 text-center menu-1" style="left: 1px; top: 16px; width: 100%;height: 70px; margin-bottom: 0;">
        <asp:Button ID="Buton_Guncelle" runat="server"  OnClick="Buton_Guncelle_Click" Text="Güncelleyin" ForeColor="Green" Font-Bold="true" Width="160px" CssClass="btn btn-white btn-outline  btn-lg" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Buton_Ara" runat="server"  OnClick="Buton_Ara_Click" Text="Arayın" ForeColor="Green" Font-Bold="true" Width="150px" CssClass="btn btn-white btn-outline  btn-lg"/>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Buton_Ekle" runat="server"  OnClick="Buton_Ekle_Click" Text="Ekleyin" ForeColor="Green" Font-Bold="true" Width="150px" CssClass="btn btn-white btn-outline  btn-lg"/>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Buton_Sil" runat="server"  OnClick="Buton_Sil_Click" Text="Silin" Width="150px" ForeColor="Green" Font-Bold="true" CssClass="btn btn-white btn-outline  btn-lg"/>
            &nbsp;&nbsp;&nbsp;
            </div>

             <div class="col-xs-7 text-center menu-1" style="left: 1px; top: -48px; width: 100%;height: 70px;">
        <asp:Button ID="Buton_Guncelle0" runat="server"  OnClick="Buton_Guncelle0_Click0" Text="Güncelleyin" ForeColor="Green" Font-Bold="true" Width="160px" CssClass="btn btn-white btn-outline  btn-lg" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Buton_Ara0" runat="server"  OnClick="Buton_Ara0_Click0" Text="Arayın" Width="150px" ForeColor="Green" Font-Bold="true" CssClass="btn btn-white btn-outline  btn-lg"/>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Buton_Ekle0" runat="server"  OnClick="Buton_Ekle0_Click0" Text="Ekleyin" Width="150px" ForeColor="Green" Font-Bold="true" CssClass="btn btn-white btn-outline  btn-lg"/>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Buton_Sil0" runat="server"  OnClick="Buton_Sil0_Click0" Text="Silin" Width="150px" ForeColor="Green" Font-Bold="true" CssClass="btn btn-white btn-outline  btn-lg"/>
            &nbsp;&nbsp;&nbsp;
            </div>


             <div class="col-xs-7 text-center menu-1" style="left: 3px; top: -113px; width: 100%;height: 70px;">
        <asp:Button ID="Buton_Guncelle1" runat="server"  OnClick="Buton_Guncelle1_Click1" Text="Güncelleyin" ForeColor="Green" Font-Bold="true" Width="160px" CssClass="btn btn-white btn-outline  btn-lg" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Buton_Ara1" runat="server"  OnClick="Buton_Ara1_Click1" Text="Arayın" Width="150px" ForeColor="Green" Font-Bold="true" CssClass="btn btn-white btn-outline  btn-lg"/>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Buton_Ekle1" runat="server"  OnClick="Buton_Ekle1_Click1" Text="Ekleyin" Width="150px" ForeColor="Green" Font-Bold="true" CssClass="btn btn-white btn-outline  btn-lg"/>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Buton_Sil1" runat="server"  OnClick="Buton_Sil1_Click1" Text="Silin" Width="150px" ForeColor="Green" Font-Bold="true" CssClass="btn btn-white btn-outline  btn-lg"/>
            &nbsp;&nbsp;&nbsp;
            </div>


            <div class="col-xs-7 text-center menu-1" style="left: 2px; top: -177px; width: 100%;height: 70px;">
        <asp:Button ID="Buton_Guncelle2" runat="server"  OnClick="Buton_Guncelle2_Click2" Text="Güncelleyin" ForeColor="Green" Font-Bold="true" Width="160px" CssClass="btn btn-white btn-outline  btn-lg" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Buton_Ara2" runat="server"  OnClick="Buton_Ara2_Click2" Text="Arayın" Width="150px" ForeColor="Green" Font-Bold="true" CssClass="btn btn-white btn-outline  btn-lg"/>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Buton_Ekle2" runat="server"  OnClick="Buton_Ekle2_Click2" Text="Ekleyin" Width="150px" ForeColor="Green" Font-Bold="true" CssClass="btn btn-white btn-outline  btn-lg"/>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Buton_Sil2" runat="server"  OnClick="Buton_Sil2_Click2" Text="Silin" Width="150px" ForeColor="Green" Font-Bold="true" CssClass="btn btn-white btn-outline  btn-lg"/>
            &nbsp;&nbsp;&nbsp;
            </div>


        <div class="col-xs-7 text-center menu-1" style="left: 3px; top: -238px; width: 100%;height: 70px;">
        <asp:Button ID="Buton_Guncelle3" runat="server"  OnClick="Buton_Guncelle3_Click3" Text="Güncelleyin" ForeColor="Green" Font-Bold="true" Width="160px" CssClass="btn btn-white btn-outline  btn-lg" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Buton_Ara3" runat="server"  OnClick="Buton_Ara3_Click3" Text="Arayın" Width="150px" ForeColor="Green" Font-Bold="true" CssClass="btn btn-white btn-outline  btn-lg"/>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Buton_Ekle3" runat="server"  OnClick="Buton_Ekle3_Click3" Text="Ekleyin" Width="150px" ForeColor="Green" Font-Bold="true" CssClass="btn btn-white btn-outline  btn-lg"/>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Buton_Sil3" runat="server"  OnClick="Buton_Sil3_Click3" Text="Silin" Width="150px" ForeColor="Green" Font-Bold="true" CssClass="btn btn-white btn-outline  btn-lg"/>
            &nbsp;&nbsp;&nbsp;
            </div>

       <div class="col-xs-6 text-left menu-1" style="left: 187px; top: -233px; width: 83%; height: 369px;">         
               <table class="auto-style8">
                   <tr>
                       <td class="auto-style4">&nbsp;<asp:Label ID="Label1" runat="server" Text="Label" Font-Size="X-Large" ForeColor="White"></asp:Label></td>
                       <td class="auto-style9">&nbsp;<asp:TextBox ID="TextBox1" runat="server" BackColor="White" Height="30px" Width="400px"  ></asp:TextBox></td>
                   </tr>
                   <tr>
                       <td class="auto-style4">&nbsp;<asp:Label ID="Label2" runat="server" Text="Label" Font-Size="X-Large" ForeColor="White"></asp:Label></td>
                       <td class="auto-style9">&nbsp;<asp:TextBox ID="TextBox2" runat="server" BackColor="White" Height="30px" Width="400px"></asp:TextBox></td>
                   </tr>
                   <tr>
                       <td class="auto-style4">&nbsp;<asp:Label ID="Label3" runat="server" Text="Label" Font-Size="X-Large" ForeColor="White"></asp:Label></td>
                       <td class="auto-style9">&nbsp;<asp:TextBox ID="TextBox3" runat="server" BackColor="White" Height="30px" Width="400px"></asp:TextBox></td>
                   </tr>
                   <tr>
                       <td class="auto-style4">&nbsp;<asp:Label ID="Label4" runat="server" Text="Label" Font-Size="X-Large" ForeColor="White"></asp:Label></td>
                       <td class="auto-style9">&nbsp;<asp:TextBox ID="TextBox4" runat="server" BackColor="White" Height="30px" Width="400px"></asp:TextBox></td>
                   </tr>
                   <tr>
                       <td class="auto-style3">&nbsp; <asp:Label ID="Label5" runat="server" Text="Label" Font-Size="X-Large" ForeColor="White"></asp:Label></td>
                       <td class="auto-style1">&nbsp;<asp:TextBox ID="TextBox5" runat="server" BackColor="White" Height="30px" Width="400px"></asp:TextBox></td>
                   </tr>
                   <tr>
                       <td class="auto-style4">&nbsp;<asp:Label ID="Label6" runat="server" Text="Label" Font-Size="X-Large" ForeColor="White"></asp:Label></td>
                       <td class="auto-style9">&nbsp;<asp:TextBox ID="TextBox6" runat="server" BackColor="White" Height="30px" Width="400px" ></asp:TextBox></td>
                   </tr>
                   <tr>
                       <td class="auto-style4">&nbsp;<asp:Label ID="Label7" runat="server" Text="Label" Font-Size="X-Large" ForeColor="White"></asp:Label></td>
                       <td class="auto-style9">&nbsp;<asp:TextBox ID="TextBox7" runat="server" BackColor="White" Height="30px" Width="400px"></asp:TextBox></td>
                   </tr>
                   <tr>
                       <td class="auto-style4">&nbsp;<asp:Label ID="Label8" runat="server" Text="Label" Font-Size="X-Large" ForeColor="White"></asp:Label></td>
                       <td class="auto-style9">&nbsp;<asp:TextBox ID="TextBox8" runat="server" BackColor="White" Height="30px" Width="400px"></asp:TextBox></td>
                   </tr>
                   <tr>
                       <td class="auto-style4">&nbsp;<asp:Label ID="Label9" runat="server" Text="Label" Font-Size="X-Large" ForeColor="White"></asp:Label></td>
                       <td class="auto-style9">&nbsp;<asp:TextBox ID="TextBox9" runat="server" BackColor="White" Height="30px" Width="400px" ></asp:TextBox></td>
                   </tr>
               </table> 
            </div>
        <div class="auto-style7">
            
            <asp:GridView ID="GridView1" cssclass="mGrid" Width="1500px" runat="server" Font-Bold="True" Font-Names="Arial" GridLines="Vertical" ShowHeaderWhenEmpty="True">
            </asp:GridView>
            
        </div>
            </form>
        </body>
</html>

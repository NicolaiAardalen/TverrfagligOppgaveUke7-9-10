<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrasjon.aspx.cs" Inherits="Default.Administrasjon" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Administrasjon</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <style>
        .textbox{
            width: 907px;
        }
        @media (max-width: 767px) {
            .textbox {
            width: 80%;
            }
        }
    </style>
</head>
<body>
    <center>
    <form id="form1" runat="server">
        <asp:Button ID="Default" runat="server" Text="Tilbake" OnClick="Default_Click" />
        <br />
        <br />
        <asp:Image ID="Image" runat="server" width="300px"/>
        <br />
        <asp:DropDownList ID="DropDownListImg" runat="server"></asp:DropDownList>
        <asp:Button ID="ChangeImg" runat="server" Text="Bytt bildet" OnClick="ChangeImage_Click"/>
        <asp:Button ID="DeleteImg" runat="server" Text="Slett bildet" OnClick="DeleteImage_Click"/>
        <br />
        <br />
        
        <asp:FileUpload ID="FileUpload" runat="server" />
        <br />
        <br />
        <asp:Button ID="UploadImage" runat="server" Text="Last opp bildet!" OnClick="UploadImage_Click" />
        <br />
        <br />
        <br />
        <asp:TextBox ID="EditArlyOppgHeader" runat="server" TextMode="MultiLine" style="resize: horizontal" Height="15px"></asp:TextBox>
        <br />
        <asp:TextBox ID="EditArlyOppgIntro" CssClass="textbox" runat="server" Height="150px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="EditArlyOppgUnderHeader1" runat="server" TextMode="MultiLine" style="resize: horizontal" Height="15px"></asp:TextBox>
        <br />
        <asp:TextBox ID="EditGenerellBrukerstøtte1" CssClass="textbox" runat="server" Height="150px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:TextBox ID="EditGenerellBrukerstøtte2" CssClass="textbox" runat="server" Height="150px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:TextBox ID="EditGenerellBrukerstøtte3" CssClass="textbox" runat="server" Height="150px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:TextBox ID="EditGenerellBrukerstøtte4" CssClass="textbox" runat="server" Height="150px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:TextBox ID="EditGenerellBrukerstøtte5" CssClass="textbox" runat="server" Height="150px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="EditArlyOppgUnderHeader2" runat="server" TextMode="MultiLine" style="resize: horizontal" Height="15px"></asp:TextBox>
        <br />
        <asp:TextBox ID="EditForedragBrukerstøtte1" CssClass="textbox" runat="server" Height="150px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:TextBox ID="EditForedragBrukerstøtte2" CssClass="textbox" runat="server" Height="150px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:TextBox ID="EditForedragBrukerstøtte3" CssClass="textbox" runat="server" Height="150px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:TextBox ID="EditForedragBrukerstøtte4" CssClass="textbox" runat="server" Height="150px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="EditArlyOppgUnderHeader3" runat="server" TextMode="MultiLine" style="resize: horizontal" Height="15px"></asp:TextBox>
        <br />
        <asp:TextBox ID="EditAndreBrukerstøtte1" CssClass="textbox" runat="server" Height="150px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:TextBox ID="EditAndreBrukerstøtte2" CssClass="textbox" runat="server" Height="150px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="EditArlyOppgUnderHeader4" runat="server" TextMode="MultiLine" style="resize: horizontal" Height="15px"></asp:TextBox>
        <br />
        <asp:TextBox ID="EditAvslutning1" CssClass="textbox" runat="server" Height="150px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:TextBox ID="EditAvslutning2" CssClass="textbox" runat="server" Height="150px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:TextBox ID="EditAvslutning3" CssClass="textbox" runat="server" Height="150px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:TextBox ID="EditAvslutning4" CssClass="textbox" runat="server" Height="150px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="EditArlyOppgUnderHeader5" runat="server" TextMode="MultiLine" style="resize: horizontal" Height="15px"></asp:TextBox>
        <br />
        <asp:TextBox ID="EditSammendrag" CssClass="textbox" runat="server" Height="150px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="EditArlyAI" runat="server" Text="OK" OnClick="EditArlyAI_Click"/>
        <br />
        <br />
        <br />
         <asp:LoginStatus ID="LogOut" runat="server" LogoutText="Logg ut" />
    </form>
    </center>
</body>
</html>

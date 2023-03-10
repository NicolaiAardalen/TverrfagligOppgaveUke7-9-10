<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrasjon.aspx.cs" Inherits="Default.Administrasjon" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Administrasjon</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <style>
        .textbox{
            width: 907px;
            height: 1000px;
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
        <asp:TextBox ID="EditArlyText" CssClass="textbox" runat="server" TextMode="MultiLine"></asp:TextBox>
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

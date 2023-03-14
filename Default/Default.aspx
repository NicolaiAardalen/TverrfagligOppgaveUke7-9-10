<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Default.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tverrfaglig</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <style>
        p {
            width: 25%;
        }

        @media (max-width: 767px) {
            p {
            width: 80%;
            }
        }
    </style>
</head>
<body>
    <center>
    <form id="form1" runat="server">
        <asp:Button ID="Administrasjon" runat="server" Text="Administrasjon" OnClick="Administrasjon_Click" />
        <br />
        <br />
        <asp:Image ID="Image" runat="server" width="300px"/>
        <br />
        <br />
        <asp:Label ID="ArlyText" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <br />
        <asp:LoginStatus ID="LogOut" runat="server" LogoutText="Logg ut" LoginText="Logg inn" />
    </form>
    </center>
</body>
</html>

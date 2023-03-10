<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Default.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
</head>
<body>
    <center>
    <form id="form1" runat="server">
        <asp:Button ID="BackToSite" runat="server" Text="Tilbake" OnClick="BackToSite_Click" />
        <br />
        <h2>
            Skriv inn passord for administrasjon for å logge inn
        </h2>
        <br />

        <asp:TextBox ID="LoginPasswordTextbox" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="CheckPassword" runat="server" Text="Logg inn" OnClick="CheckPassword_Click" />
        <asp:Label ID="WrongPassword" runat="server" Text="Passordet er feil!" Visible="false"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="ChangePassword" runat="server">Endre passord</asp:HyperLink>
    </form>
    </center>
</body>
</html>
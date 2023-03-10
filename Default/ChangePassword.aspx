<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="Default.ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
</head>
<body>
    <center>
    <form id="form1" runat="server">
        <asp:Button ID="backToLogin" runat="server" Text="Tilbake til Login" OnClick="backToLogin_Click" />
        <br />
        <br />
        <br />
        <h3>
            Nåværende passord
        </h3>
        <asp:TextBox ID="CurrentPasswordTextbox" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <h3>
            Nytt passord
        </h3>
        <asp:TextBox ID="NewPasswordTextbox" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="ChangePasswordButton" runat="server" Text="Endre passord" OnClick="ChangePassword_Click" />
        <asp:Label ID="WrongPassword" runat="server" Text="Det nåværende passordet er feil!" Visible="false"></asp:Label>
        <asp:Label ID="Changed" runat="server" Text="Passord endret!" Visible="false"></asp:Label>
    </form>
    </center>
</body>
</html>

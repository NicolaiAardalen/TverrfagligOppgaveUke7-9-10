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
        <h1>
            <asp:Label ID="ArlyOppgHeader" runat="server" Text=""></asp:Label>
        </h1>
        <p>
            <asp:Label ID="ArlyOppgIntro" runat="server" Text=""></asp:Label>
        </p>
        <br />
        <h3>
            <asp:Label ID="ArlyOppgUnderHeader1" runat="server" Text=""></asp:Label>
        </h3>
        <p>
            <asp:Label ID="GenerellBrukerstøtte1" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Label ID="GenerellBrukerstøtte2" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Label ID="GenerellBrukerstøtte3" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Label ID="GenerellBrukerstøtte4" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Label ID="GenerellBrukerstøtte5" runat="server" Text=""></asp:Label>
        </p>
        <br />
        <h3>
            <asp:Label ID="ArlyOppgUnderHeader2" runat="server" Text=""></asp:Label>
        </h3>
        <p>
            <asp:Label ID="ForedragBrukerstøtte1" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Label ID="ForedragBrukerstøtte2" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Label ID="ForedragBrukerstøtte3" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Label ID="ForedragBrukerstøtte4" runat="server" Text=""></asp:Label>
        </p>
        <br />
        <h3>
            <asp:Label ID="ArlyOppgUnderHeader3" runat="server" Text=""></asp:Label>
        </h3>
        <p>
            <asp:Label ID="AndreBrukerstøtte1" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Label ID="AndreBrukerstøtte2" runat="server" Text=""></asp:Label>
        </p>
        <br />
        <h3>
            <asp:Label ID="ArlyOppgUnderHeader4" runat="server" Text=""></asp:Label>
        </h3>
        <p>
            <asp:Label ID="Avslutning1" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Label ID="Avslutning2" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Label ID="Avslutning3" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Label ID="Avslutning4" runat="server" Text=""></asp:Label>
        </p>
        <br />
        <h3>
            <asp:Label ID="ArlyOppgUnderHeader5" runat="server" Text=""></asp:Label>
        </h3>
        <p>
            <asp:Label ID="Sammendrag" runat="server" Text=""></asp:Label>
        </p>
        <br />
        <br />
        <br />
        <asp:LoginStatus ID="LogOut" runat="server" LogoutText="Logg ut" LoginText="Logg inn" />
    </form>
    </center>
</body>
</html>

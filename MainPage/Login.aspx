<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link type="text/css" rel="stylesheet" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul id="MainNav">
                <li class="Name">Pokémon Competitive Team Builder</li>
                <li><a href="Default.aspx">Home</a></li>
                <li><a href="">Design Pokémon</a></li>
                <li><a href="">Design Party</a></li>
                <li class="Acc"><a href="Login.aspx">Login</a></li>
            </ul>
        </div>
    <div>
        <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>

        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>

        <br />

        <br />

        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>

        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>

        <br />

        <br />

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:Button ID="btnlogin" runat="server" Text="Login" onclick="btnlogin_Click" Width="47px" />

        &nbsp;

        <asp:Button ID="btnCancel" runat="server" Text="Cancel"  />

        <br />

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>

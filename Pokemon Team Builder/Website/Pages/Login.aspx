<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Pages_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link type="text/css" rel="stylesheet" href="../Styles/StyleSheet.css" />
    <link type="text/css" rel="stylesheet" href="../Styles/AccountStyle.css" />
</head>
<body>
    <ul id="MainNav">
        <li><a href="index.html">Home</a></li>
        <li><a href="">Design Pokémon</a></li>
        <li><a href="">Design Party</a></li>
        <li class="Acc"><a href="Account.aspx">Account</a></li>
    </ul>
    <form id="form1" runat="server">
    <div class="accContent" aria-orientation="vertical" spellcheck="True">



        <br />



        <asp:Label ID="Label1" runat="server" Text="Username(Max 25) : " Height="22px"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Username" runat="server" MaxLength="25"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="Label3" runat="server" Height="22px" Text="Password(Max 20) :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Password" runat="server" MaxLength="20" Type="password"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Button ID="Login" runat="server" Text="Login" OnClick="Login_Click" Width="100px" />



    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Register" runat="server" Text="Register" Width="100px" OnClick="Register_Click" />
        <br />



    </div>
    </form>
</body>
</html>

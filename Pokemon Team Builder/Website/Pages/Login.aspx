<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Pages_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log-in Page</title>
    <link type="text/css" rel="stylesheet" href="../Styles/StyleSheet.css" />
</head>
<body>
    <ul id="MainNav">
        <li><a href="index.html">Home</a></li>
        <li><a href="">Design Pokémon</a></li>
        <li><a href="">Design Party</a></li>
        <li class="Acc"><a href="Login.aspx">Account</a></li>   
    </ul>

    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Login ID="Login1" runat="server" >
        </asp:Login>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="Login1" />
    </form>
</body>
</html>

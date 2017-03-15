<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SinglePokemon.aspx.cs" Inherits="SinglePokemon" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pokémon Builder</title>
    <link type="text/css" rel="stylesheet" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <ul id="MainNav">
        <li class="Name">Pokémon Competitive Team Builder</li>
        <li><a href="Default.aspx">Home</a></li>
        <li><a href="SinglePokemon.aspx">Design Pokémon</a></li>
        <li><a href="PartyPokemon.aspx">Design Party</a></li>
        <li class="Acc"><a href="Login.aspx">Login</a></li>
        </ul>
    <div id="stats">
        <asp:textbox class="stats" runat="server" Width="188">Nickname</asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="188">Name</asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80">HpEv</asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80">HpIv</asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80">AtkEv</asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80">AtkIv</asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80">DefEv</asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80">DefIv</asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80">SpAtkEV</asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80">SpAtkIv</asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80">SpDefEv</asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80">SpDefIv</asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80">SpdEv</asp:textbox>        
        <asp:textbox class="stats" runat="server" Width="80">SpdIv</asp:textbox><br />
    <!--
    <DROP DOWN LIST>
    Nature
    Ability
    Item
    Attack1
    Attack2
    Attack3
    Attack4
    Picture if i feel like downloading them.
       -->
    <asp:Button class="SaveB" runat="server" Text="Save" OnClick="SaveButton"></asp:Button>
    <asp:Button class="DeleteB" runat="server" Text="Delete" OnClick="DeleteButton"></asp:Button>
    </div>
    </form>
</body>
</html>

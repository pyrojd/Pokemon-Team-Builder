<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PartyPokemon.aspx.cs" Inherits="PartyPokemon" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pokémon Builder</title>
    <link type="text/css" rel="stylesheet" href="StyleSheet.css" />
    <style type="text/css">
        #stats5 {
            width: 219px;
        }
        #stats6 {
            width: 225px;
        }
    </style>
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
<div id="BillyBob">
    <div id="stats1">
        <asp:textbox class="stats" runat="server" Width="188" placeholder = "NickName"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="188" placeholder = "Name"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Hp Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Hp Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Atk Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Atk Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Def Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Def Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "SpAtk Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "SpAtk Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "SpDef Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "SpDef Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Spd Ev"></asp:textbox>        
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Spd Iv"></asp:textbox><br />
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
    </div>
        <div id="stats2">
        <asp:textbox class="stats" runat="server" Width="188" placeholder = "NickName"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="188" placeholder = "Name"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Hp Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Hp Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Atk Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Atk Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Def Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Def Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "SpAtk Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "SpAtk Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "SpDef Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "SpDef Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Spd Ev"></asp:textbox>        
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Spd Iv"></asp:textbox><br />
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
    </div>
        <div id="stats3">
        <asp:textbox class="stats" runat="server" Width="188" placeholder = "NickName"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="188" placeholder = "Name"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Hp Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Hp Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Atk Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Atk Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Def Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Def Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "SpAtk Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "SpAtk Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "SpDef Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "SpDef Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Spd Ev"></asp:textbox>        
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Spd Iv"></asp:textbox><br />
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
    </div>
        <div id="stats4">
        <asp:textbox class="stats" runat="server" Width="188" placeholder = "NickName"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="188" placeholder = "Name"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Hp Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Hp Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Atk Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Atk Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Def Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Def Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "SpAtk Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "SpAtk Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "SpDef Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "SpDef Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Spd Ev"></asp:textbox>        
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Spd Iv"></asp:textbox><br />
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
    </div>
        <div id="stats5">
        <asp:textbox class="stats" runat="server" Width="188" placeholder = "NickName"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="188" placeholder = "Name"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Hp Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Hp Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Atk Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Atk Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Def Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Def Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "SpAtk Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "SpAtk Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "SpDef Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "SpDef Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Spd Ev"></asp:textbox>        
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Spd Iv"></asp:textbox><br />
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
    </div>
        <div id="stats6">
        <asp:textbox class="stats" runat="server" Width="188" placeholder = "NickName"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="188" placeholder = "Name"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Hp Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Hp Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Atk Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Atk Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Def Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Def Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "SpAtk Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "SpAtk Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "SpDef Ev"></asp:textbox>
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "SpDef Iv"></asp:textbox><br />
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Spd Ev"></asp:textbox>        
        <asp:textbox class="stats" runat="server" Width="80" placeholder = "Spd Iv"></asp:textbox><br />
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

    </div>
 </div>
        <div id="SaveDelete">
            <asp:Button class="SaveB" runat="server" Text="Save" OnClick="SaveButton"></asp:Button>
            <asp:Button class="DeleteB" runat="server" Text="Delete" OnClick="DeleteButton"></asp:Button>
        </div>
    </form>
</body>
</html>
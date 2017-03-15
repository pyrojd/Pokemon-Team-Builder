<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pokémon Competitive Team Builder</title>
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
    <div>
    <img src="Images/Mimikyu.png" alt="Mimikyu"
        style="width:300px; height:300px;">

        <p id="Vtext">For those who want to make a competitive team and are unsure how to go about it, watch this.</p>
        <iframe width="746" height="420" src="https://www.youtube.com/embed/Y3cKZPPtWCM" frameborder="0" allowfullscreen></iframe>
   

    </div>
    </form>
</body>
</html>

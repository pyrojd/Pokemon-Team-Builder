<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Account.aspx.cs" Inherits="Account" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pokémon Competitive Team Builder</title>
     <link type="text/css" rel="stylesheet" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <ul id="MainNav">
        <li class="Name">Pokémon Competitive Team Builder</li>
        <li><a href="Default.aspx">Home</a></li>
        <li><a href="SinglePokemon.aspx">Design Pokémon</a></li>
        <li><a href="PartyPokemon.aspx">Design Party</a></li>
        <li class="Acc"><a href="Login.aspx">Login</a></li>
    </ul>

    </div>
    <div id="RightSide">
           
        
       <asp:dropdownlist class="PokeDD" ID="Single" runat="server"  Width="250px" DataSourceID="SqlDataSource1">           
       </asp:dropdownlist>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString %>" SelectCommand="SELECT [ID], [NickName] FROM [SavedPokemon] WHERE (([In_Party] = @In_Party) AND ([Users_ID] = @Users_ID))">
            <SelectParameters>
                <asp:Parameter DefaultValue="0" Name="In_Party" Type="Boolean" />
                <asp:SessionParameter Name="Users_ID" SessionField="ID" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>

       <asp:dropdownlist class="PokeDD" ID="Party" runat="server"  Width="250px">
         <asp:ListItem>Select a Team</asp:ListItem>
         <asp:ListItem>Team 1</asp:ListItem>
         <asp:ListItem>Team 2</asp:ListItem>
         <asp:ListItem>Team 3</asp:ListItem>
       </asp:dropdownlist>
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
       <asp:Button class="PokemonButton" runat="server" Height="50px" OnClick="Button1_Click" Text="Enter Single" Width="200px" />
       <asp:Button class="PokemonButton" runat="server" Height="50px" OnClick="Button2_Click" Text="Enter Party" Width="200px" />
        
       
    </div>

    </form>
</body>

    

</html>

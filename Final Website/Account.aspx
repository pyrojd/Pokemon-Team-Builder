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
        <% if (Session["UserName"] == null)
                    { %>
                    <li class="Acc"><a href="Login.aspx">Login</a></li>
                <% }  else { %>
                    <li class="Acc"><a href="Account.aspx">Account</a></li>
                <% } %>
    </ul>

    </div>
    <div id="RightSide">
           
        
        <asp:dropdownlist class="PokeDD" ID="Single" runat="server"  Width="250px" DataSourceID="SqlDataSource2" DataTextField="NickName" DataValueField="PDB_ID">
        </asp:dropdownlist> 

        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString3 %>" SelectCommand="SELECT [NickName], [PDB_ID] FROM [SavedPokemon] WHERE (([Users_ID] = @Users_ID) AND ([In_Party] = @In_Party))">
            <SelectParameters>
                <asp:SessionParameter Name="Users_ID" SessionField="ID" Type="Int32" />
                <asp:Parameter DefaultValue="False" Name="In_Party" Type="Boolean" />
            </SelectParameters>
        </asp:SqlDataSource>
        
       <asp:dropdownlist class="PokeDD" ID="Party" runat="server"  Width="250px" DataSourceID="SqlDataSource1" DataTextField="Team_Name" DataValueField="Team_Name">
       </asp:dropdownlist>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString4 %>" SelectCommand="SELECT DISTINCT [Team_Name] FROM [SavedPokemon] WHERE (([In_Party] = @In_Party) AND ([Users_ID] = @Users_ID))">
            <SelectParameters>
                <asp:Parameter DefaultValue="True" Name="In_Party" />
                <asp:SessionParameter DefaultValue="" Name="Users_ID" SessionField="ID" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
       <asp:Button class="PokemonButton" runat="server" Height="50px" OnClick="Button1_Click" Text="Enter Single" Width="200px" />
       <asp:Button class="PokemonButton" runat="server" Height="50px" OnClick="Button2_Click" Text="Enter Party" Width="200px" />
        
       
    </div>

        <div id="LeftSide">
            <asp:Label ID="Label2" runat="server" Text="Username:"></asp:Label>&nbsp;&nbsp;
            <asp:TextBox ID="UserName" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="Password:"></asp:Label>&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Password" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label4" runat="server" Text="Email:"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Email" runat="server"></asp:TextBox><br />
            <asp:Button class="LogOut" runat="server" Height="50px" OnClick="UpdateAccount" Text="Update" Width="200px" ID="Button1" />

            <asp:Button class="LogOut" runat="server" Height="50px" OnClick="LogOut" Text="Log Out" Width="200px" />

        </div>

    </form>
</body>

    

</html>

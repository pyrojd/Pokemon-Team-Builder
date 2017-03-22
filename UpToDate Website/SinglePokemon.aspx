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
        
        
        <asp:dropdownlist class="stats" ID="Nature" runat="server"  Width="188px" DataSourceID="SqlDataSource1" DataTextField="Nature_Name" DataValueField="Nature_Name">
       </asp:dropdownlist> 
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Nature_Name] FROM [Natures]"></asp:SqlDataSource>
        <br />

        <asp:dropdownlist class="stats" ID="Ability" runat="server"  Width="188px" DataSourceID="SqlDataSource2" DataTextField="Ability_Name" DataValueField="Ability_Name">
       </asp:dropdownlist> 
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Ability_Name] FROM [Ability]"></asp:SqlDataSource>
        <br />

        <asp:dropdownlist class="stats" ID="Item" runat="server"  Width="188px" DataSourceID="SqlDataSource3" DataTextField="Item_Name" DataValueField="Item_Name">
       </asp:dropdownlist> 
        
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Item_Name] FROM [Items]"></asp:SqlDataSource>
        
        <br />

        <asp:dropdownlist class="stats" ID="Attack1" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_Name">
       </asp:dropdownlist>
        
        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Move_Name] FROM [Moves]"></asp:SqlDataSource>
        
        <br />

        <asp:dropdownlist class="stats" ID="Attack2" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_Name">
       </asp:dropdownlist> 
       
        <br />

        <asp:dropdownlist class="stats" ID="Attack3" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_Name">
       </asp:dropdownlist> 
       
        <br />

        <asp:dropdownlist class="stats" ID="Attack4" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_Name">
       </asp:dropdownlist>
        
        <br />

    <asp:Button class="SaveB" runat="server" Text="Save" OnClick="SaveButton"></asp:Button>
    <asp:Button class="DeleteB" runat="server" Text="Delete" OnClick="DeleteButton"></asp:Button>
    </div>
    </form>
</body>
</html>

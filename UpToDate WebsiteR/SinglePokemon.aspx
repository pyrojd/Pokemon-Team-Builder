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
        <asp:textbox class="stats" runat="server" Width="188" placeholder = "NickName"></asp:textbox><br />
        <asp:DropDownList class="stats" ID="Pokemon" runat="server" Width="188px" DataSourceID="SqlDataSource5" DataTextField="Name" DataValueField="ID" ></asp:DropDownList><br />
        <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [ID], [Name] FROM [Pokemon] ORDER BY [ID]"></asp:SqlDataSource>
        <asp:dropdownlist class="stats" ID="Gender" runat="server"  Width="188px">
         <asp:ListItem>Select a Gender</asp:ListItem>
         <asp:ListItem Value="1">Male</asp:ListItem>
         <asp:ListItem Value="2">Female</asp:ListItem>
         <asp:ListItem Value="0">Genderless</asp:ListItem>
       </asp:dropdownlist> <br />
        <input type="number" name="hpev" class="stats" placeholder="Hp Ev" min="0" max="252"/>
        <input type="number" name="hpiv" class="stats" placeholder="Hp Iv" min="0" max="31"/><br />
        <input type="number" name="atkev" class="stats" placeholder="Atk Ev" min="0" max="252"/>
        <input type="number" name="atkiv" class="stats" placeholder="Atk Iv" min="0" max="31"/><br />
        <input type="number" name="defev" class="stats" placeholder="Def Ev" min="0" max="252"/>
        <input type="number" name="defiv" class="stats" placeholder="Def Iv" min="0" max="31"/><br />
        <input type="number" name="spatkev" class="stats" placeholder="SpAtk Ev" min="0" max="252"/>
        <input type="number" name="spatkiv" class="stats" placeholder="SpAtk Iv" min="0" max="31"/><br />
        <input type="number" name="spdefev" class="stats" placeholder="SpDef Ev" min="0" max="252"/>
        <input type="number" name="spdefiv" class="stats" placeholder="SpDef Iv" min="0" max="31"/><br />
        <input type="number" name="spdev" class="stats" placeholder="Spd Ev" min="0" max="252"/>        
        <input type="number" name="spdiv" class="stats" placeholder="Spd Iv" min="0" max="31"/><br />
        
        
        <asp:dropdownlist class="stats" ID="Nature" runat="server"  Width="188px" DataSourceID="SqlDataSource1" DataTextField="Nature_Name" DataValueField="Nature_ID">
       </asp:dropdownlist> 
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Nature_Name], [Nature_ID] FROM [Natures]"></asp:SqlDataSource>
        <br />

        <asp:dropdownlist class="stats" ID="Ability" runat="server"  Width="188px" DataSourceID="SqlDataSource2" DataTextField="Ability_Name" DataValueField="Ability_ID">
       </asp:dropdownlist> 
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Ability_Name], [Ability_ID] FROM [Ability]"></asp:SqlDataSource>
        <br />

        <asp:dropdownlist class="stats" ID="Item" runat="server"  Width="188px" DataSourceID="SqlDataSource3" DataTextField="Item_Name" DataValueField="Item_ID">
       </asp:dropdownlist> 
        
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Item_Name], [Item_ID] FROM [Items]"></asp:SqlDataSource>
        
        <br />

        <asp:dropdownlist class="stats" ID="Attack1" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist>
        
        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Move_Name], [Move_ID] FROM [Moves]"></asp:SqlDataSource>
        
        <br />

        <asp:dropdownlist class="stats" ID="Attack2" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist> 
       
        <br />

        <asp:dropdownlist class="stats" ID="Attack3" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist> 
       
        <br />

        <asp:dropdownlist class="stats" ID="Attack4" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist>
        
        <br />

    <asp:Button class="SaveB" runat="server" Text="Save" OnClick="SaveButton"></asp:Button>
    <asp:Button class="DeleteB" runat="server" Text="Delete" OnClick="DeleteButton"></asp:Button>
    </div>
    </form>
</body>
</html>

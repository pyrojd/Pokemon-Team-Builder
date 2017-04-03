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
        <% if (Session["UserName"] == null)
                    { %>
                    <li class="Acc"><a href="Login.aspx">Login</a></li>
                <% }  else { %>
                    <li class="Acc"><a href="Account.aspx">Account</a></li>
                <% } %>
        </ul>
<div id="BillyBob">
    <div id="stats1">
        <asp:textbox class="stats" ID="NickName1" runat="server" Width="188" placeholder = "NickName"></asp:textbox><br />
        <asp:DropDownList class="stats" ID="Pokemon1" runat="server" Width="188px" DataSourceID="SqlDataSource5" DataTextField="Name" DataValueField="ID" ></asp:DropDownList><br />
        <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [ID], [Name] FROM [Pokemon] ORDER BY [ID]"></asp:SqlDataSource>
        <asp:dropdownlist class="stats" ID="Gender1" runat="server"  Width="188px">
         <asp:ListItem>Select a Gender</asp:ListItem>
         <asp:ListItem Value="1">Male</asp:ListItem>
         <asp:ListItem Value="2">Female</asp:ListItem>
         <asp:ListItem Value="0">Genderless</asp:ListItem>
       </asp:dropdownlist> <br />

        <asp:textbox class="stats" ID="hpev1" runat="server" Width="80" placeholder = "Hv Ev"></asp:textbox>
        <asp:textbox class="stats" ID="hpiv1" runat="server" Width="80" placeholder = "Hv Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="atkev1" runat="server" Width="80" placeholder = "Atk Ev"></asp:textbox>
        <asp:textbox class="stats" ID="atkiv1" runat="server" Width="80" placeholder = "Atk Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="defev1" runat="server" Width="80" placeholder = "Def Ev"></asp:textbox>
        <asp:textbox class="stats" ID="defiv1" runat="server" Width="80" placeholder = "Def Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="spatkev1" runat="server" Width="80" placeholder = "SpAtk Ev"></asp:textbox>
        <asp:textbox class="stats" ID="spatkiv1" runat="server" Width="80" placeholder = "SpAtk Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="spdefev1" runat="server" Width="80" placeholder = "SpDef Ev"></asp:textbox>
        <asp:textbox class="stats" ID="spdefiv1" runat="server" Width="80" placeholder = "SpDef Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="spdev1" runat="server" Width="80" placeholder = "Spd Ev"></asp:textbox>        
        <asp:textbox class="stats" ID="spdiv1" runat="server" Width="80" placeholder = "Spd Iv"></asp:textbox><br />
        
        
        <asp:dropdownlist class="stats" ID="Nature1" runat="server"  Width="188px" DataSourceID="SqlDataSource1" DataTextField="Nature_Name" DataValueField="Nature_ID">
       </asp:dropdownlist> 
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Nature_Name], [Nature_ID] FROM [Natures]"></asp:SqlDataSource>
        <br />

        <asp:dropdownlist class="stats" ID="Ability1" runat="server"  Width="188px" DataSourceID="SqlDataSource2" DataTextField="Ability_Name" DataValueField="Ability_ID">
       </asp:dropdownlist> 
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Ability_Name], [Ability_ID] FROM [Ability]"></asp:SqlDataSource>
        <br />

        <asp:dropdownlist class="stats" ID="Item1" runat="server"  Width="188px" DataSourceID="SqlDataSource3" DataTextField="Item_Name" DataValueField="Item_ID">
       </asp:dropdownlist> 
        
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Item_Name], [Item_ID] FROM [Items]"></asp:SqlDataSource>
        
        <br />

        <asp:dropdownlist class="stats" ID="Attack1_1" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist>
        
        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Move_Name], [Move_ID] FROM [Moves]"></asp:SqlDataSource>
        
        <br />

        <asp:dropdownlist class="stats" ID="Attack2_1" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist> 
       
        <br />

        <asp:dropdownlist class="stats" ID="Attack3_1" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist> 
       
        <br />

        <asp:dropdownlist class="stats" ID="Attack4_1" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist>
        
        <br />
    </div>
        <div id="stats2">
        <asp:textbox class="stats" ID="NickName2" runat="server" Width="188" placeholder = "NickName"></asp:textbox><br />
        <asp:DropDownList class="stats" ID="Pokemon2" runat="server" Width="188px" DataSourceID="SqlDataSource5" DataTextField="Name" DataValueField="ID"></asp:DropDownList><br />
        <asp:SqlDataSource ID="SqlDataSource6" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [ID], [Name] FROM [Pokemon] ORDER BY [ID]"></asp:SqlDataSource>
        <asp:dropdownlist class="stats" ID="Gender2" runat="server"  Width="188px">
         <asp:ListItem>Select a Gender</asp:ListItem>
         <asp:ListItem Value="1">Male</asp:ListItem>
         <asp:ListItem Value="2">Female</asp:ListItem>
         <asp:ListItem Value="0">Genderless</asp:ListItem>
       </asp:dropdownlist> <br />

        <asp:textbox class="stats" ID="hpev2" runat="server" Width="80" placeholder = "Hv Ev"></asp:textbox>
        <asp:textbox class="stats" ID="hpiv2" runat="server" Width="80" placeholder = "Hv Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="atkev2" runat="server" Width="80" placeholder = "Atk Ev"></asp:textbox>
        <asp:textbox class="stats" ID="atkiv2" runat="server" Width="80" placeholder = "Atk Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="defev2" runat="server" Width="80" placeholder = "Def Ev"></asp:textbox>
        <asp:textbox class="stats" ID="defiv2" runat="server" Width="80" placeholder = "Def Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="spatkev2" runat="server" Width="80" placeholder = "SpAtk Ev"></asp:textbox>
        <asp:textbox class="stats" ID="spatkiv2" runat="server" Width="80" placeholder = "SpAtk Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="spdefev2" runat="server" Width="80" placeholder = "SpDef Ev"></asp:textbox>
        <asp:textbox class="stats" ID="spdefiv2" runat="server" Width="80" placeholder = "SpDef Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="spdev2" runat="server" Width="80" placeholder = "Spd Ev"></asp:textbox>        
        <asp:textbox class="stats" ID="spdiv2" runat="server" Width="80" placeholder = "Spd Iv"></asp:textbox><br />
        
        
        <asp:dropdownlist class="stats" ID="Nature2" runat="server"  Width="188px" DataSourceID="SqlDataSource1" DataTextField="Nature_Name" DataValueField="Nature_ID">
       </asp:dropdownlist> 
        <asp:SqlDataSource ID="SqlDataSource7" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Nature_Name], [Nature_ID] FROM [Natures]"></asp:SqlDataSource>
        <br />

        <asp:dropdownlist class="stats" ID="Ability2" runat="server"  Width="188px" DataSourceID="SqlDataSource2" DataTextField="Ability_Name" DataValueField="Ability_ID">
       </asp:dropdownlist> 
        <asp:SqlDataSource ID="SqlDataSource8" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Ability_Name], [Ability_ID] FROM [Ability]"></asp:SqlDataSource>
        <br />

        <asp:dropdownlist class="stats" ID="Item2" runat="server"  Width="188px" DataSourceID="SqlDataSource3" DataTextField="Item_Name" DataValueField="Item_ID">
       </asp:dropdownlist> 
        
        <asp:SqlDataSource ID="SqlDataSource9" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Item_Name], [Item_ID] FROM [Items]"></asp:SqlDataSource>
        
        <br />

        <asp:dropdownlist class="stats" ID="Attack1_2" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist>
        
        <asp:SqlDataSource ID="SqlDataSource10" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Move_Name], [Move_ID] FROM [Moves]"></asp:SqlDataSource>
        
        <br />

        <asp:dropdownlist class="stats" ID="Attack2_2" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist> 
       
        <br />

        <asp:dropdownlist class="stats" ID="Attack3_2" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist> 
       
        <br />

        <asp:dropdownlist class="stats" ID="Attack4_2" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist>
        
        <br />
    </div>
        <div id="stats3">
        <asp:textbox class="stats" ID="NickName3" runat="server" Width="188" placeholder = "NickName"></asp:textbox><br />
        <asp:DropDownList class="stats" ID="Pokemon3" runat="server" Width="188px" DataSourceID="SqlDataSource5" DataTextField="Name" DataValueField="ID" ></asp:DropDownList><br />
        <asp:SqlDataSource ID="SqlDataSource11" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [ID], [Name] FROM [Pokemon] ORDER BY [ID]"></asp:SqlDataSource>
        <asp:dropdownlist class="stats" ID="Gender3" runat="server"  Width="188px">
         <asp:ListItem>Select a Gender</asp:ListItem>
         <asp:ListItem Value="1">Male</asp:ListItem>
         <asp:ListItem Value="2">Female</asp:ListItem>
         <asp:ListItem Value="0">Genderless</asp:ListItem>
       </asp:dropdownlist> <br />

        <asp:textbox class="stats" ID="hpev3" runat="server" Width="80" placeholder = "Hv Ev"></asp:textbox>
        <asp:textbox class="stats" ID="hpiv3" runat="server" Width="80" placeholder = "Hv Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="atkev3" runat="server" Width="80" placeholder = "Atk Ev"></asp:textbox>
        <asp:textbox class="stats" ID="atkiv3" runat="server" Width="80" placeholder = "Atk Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="defev3" runat="server" Width="80" placeholder = "Def Ev"></asp:textbox>
        <asp:textbox class="stats" ID="defiv3" runat="server" Width="80" placeholder = "Def Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="spatkev3" runat="server" Width="80" placeholder = "SpAtk Ev"></asp:textbox>
        <asp:textbox class="stats" ID="spatkiv3" runat="server" Width="80" placeholder = "SpAtk Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="spdefev3" runat="server" Width="80" placeholder = "SpDef Ev"></asp:textbox>
        <asp:textbox class="stats" ID="spdefiv3" runat="server" Width="80" placeholder = "SpDef Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="spdev3" runat="server" Width="80" placeholder = "Spd Ev"></asp:textbox>        
        <asp:textbox class="stats" ID="spdiv3" runat="server" Width="80" placeholder = "Spd Iv"></asp:textbox><br />
        
        
        <asp:dropdownlist class="stats" ID="Nature3" runat="server"  Width="188px" DataSourceID="SqlDataSource1" DataTextField="Nature_Name" DataValueField="Nature_ID">
       </asp:dropdownlist> 
        <asp:SqlDataSource ID="SqlDataSource12" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Nature_Name], [Nature_ID] FROM [Natures]"></asp:SqlDataSource>
        <br />

        <asp:dropdownlist class="stats" ID="Ability3" runat="server"  Width="188px" DataSourceID="SqlDataSource2" DataTextField="Ability_Name" DataValueField="Ability_ID">
       </asp:dropdownlist> 
        <asp:SqlDataSource ID="SqlDataSource13" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Ability_Name], [Ability_ID] FROM [Ability]"></asp:SqlDataSource>
        <br />

        <asp:dropdownlist class="stats" ID="Item3" runat="server"  Width="188px" DataSourceID="SqlDataSource3" DataTextField="Item_Name" DataValueField="Item_ID">
       </asp:dropdownlist> 
        
        <asp:SqlDataSource ID="SqlDataSource14" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Item_Name], [Item_ID] FROM [Items]"></asp:SqlDataSource>
        
        <br />

        <asp:dropdownlist class="stats" ID="Attack1_3" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist>
        
        <asp:SqlDataSource ID="SqlDataSource15" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Move_Name], [Move_ID] FROM [Moves]"></asp:SqlDataSource>
        
        <br />

        <asp:dropdownlist class="stats" ID="Attack2_3" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist> 
       
        <br />

        <asp:dropdownlist class="stats" ID="Attack3_3" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist> 
       
        <br />

        <asp:dropdownlist class="stats" ID="Attack4_3" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist>
        
        <br />
    </div>
        <div id="stats4">
        <asp:textbox class="stats" ID="NickName4" runat="server" Width="188" placeholder = "NickName"></asp:textbox><br />
        <asp:DropDownList class="stats" ID="Pokemon4" runat="server" Width="188px" DataSourceID="SqlDataSource5" DataTextField="Name" DataValueField="ID" ></asp:DropDownList><br />
        <asp:SqlDataSource ID="SqlDataSource16" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [ID], [Name] FROM [Pokemon] ORDER BY [ID]"></asp:SqlDataSource>
        <asp:dropdownlist class="stats" ID="Gender4" runat="server"  Width="188px">
         <asp:ListItem>Select a Gender</asp:ListItem>
         <asp:ListItem Value="1">Male</asp:ListItem>
         <asp:ListItem Value="2">Female</asp:ListItem>
         <asp:ListItem Value="0">Genderless</asp:ListItem>
       </asp:dropdownlist> <br />

        <asp:textbox class="stats" ID="hpev4" runat="server" Width="80" placeholder = "Hv Ev"></asp:textbox>
        <asp:textbox class="stats" ID="hpiv4" runat="server" Width="80" placeholder = "Hv Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="atkev4" runat="server" Width="80" placeholder = "Atk Ev"></asp:textbox>
        <asp:textbox class="stats" ID="atkiv4" runat="server" Width="80" placeholder = "Atk Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="defev4" runat="server" Width="80" placeholder = "Def Ev"></asp:textbox>
        <asp:textbox class="stats" ID="defiv4" runat="server" Width="80" placeholder = "Def Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="spatkev4" runat="server" Width="80" placeholder = "SpAtk Ev"></asp:textbox>
        <asp:textbox class="stats" ID="spatkiv4" runat="server" Width="80" placeholder = "SpAtk Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="spdefev4" runat="server" Width="80" placeholder = "SpDef Ev"></asp:textbox>
        <asp:textbox class="stats" ID="spdefiv4" runat="server" Width="80" placeholder = "SpDef Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="spdev4" runat="server" Width="80" placeholder = "Spd Ev"></asp:textbox>        
        <asp:textbox class="stats" ID="spdiv4" runat="server" Width="80" placeholder = "Spd Iv"></asp:textbox><br />
        
        
        <asp:dropdownlist class="stats" ID="Nature4" runat="server"  Width="188px" DataSourceID="SqlDataSource1" DataTextField="Nature_Name" DataValueField="Nature_ID">
       </asp:dropdownlist> 
        <asp:SqlDataSource ID="SqlDataSource17" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Nature_Name], [Nature_ID] FROM [Natures]"></asp:SqlDataSource>
        <br />

        <asp:dropdownlist class="stats" ID="Ability4" runat="server"  Width="188px" DataSourceID="SqlDataSource2" DataTextField="Ability_Name" DataValueField="Ability_ID">
       </asp:dropdownlist> 
        <asp:SqlDataSource ID="SqlDataSource18" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Ability_Name], [Ability_ID] FROM [Ability]"></asp:SqlDataSource>
        <br />

        <asp:dropdownlist class="stats" ID="Item4" runat="server"  Width="188px" DataSourceID="SqlDataSource3" DataTextField="Item_Name" DataValueField="Item_ID">
       </asp:dropdownlist> 
        
        <asp:SqlDataSource ID="SqlDataSource19" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Item_Name], [Item_ID] FROM [Items]"></asp:SqlDataSource>
        
        <br />

        <asp:dropdownlist class="stats" ID="Attack1_4" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist>
        
        <asp:SqlDataSource ID="SqlDataSource20" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Move_Name], [Move_ID] FROM [Moves]"></asp:SqlDataSource>
        
        <br />

        <asp:dropdownlist class="stats" ID="Attack2_4" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist> 
       
        <br />

        <asp:dropdownlist class="stats" ID="Attack3_4" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist> 
       
        <br />

        <asp:dropdownlist class="stats" ID="Attack4_4" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist>
        
        <br />
    </div>
        <div id="stats5">
        <asp:textbox class="stats" ID="NickName5" runat="server" Width="188" placeholder = "NickName"></asp:textbox><br />
        <asp:DropDownList class="stats" ID="Pokemon5" runat="server" Width="188px" DataSourceID="SqlDataSource5" DataTextField="Name" DataValueField="ID" ></asp:DropDownList><br />
        <asp:SqlDataSource ID="SqlDataSource21" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [ID], [Name] FROM [Pokemon] ORDER BY [ID]"></asp:SqlDataSource>
        <asp:dropdownlist class="stats" ID="Gender5" runat="server"  Width="188px">
         <asp:ListItem>Select a Gender</asp:ListItem>
         <asp:ListItem Value="1">Male</asp:ListItem>
         <asp:ListItem Value="2">Female</asp:ListItem>
         <asp:ListItem Value="0">Genderless</asp:ListItem>
       </asp:dropdownlist> <br />

        <asp:textbox class="stats" ID="hpev5" runat="server" Width="80" placeholder = "Hv Ev"></asp:textbox>
        <asp:textbox class="stats" ID="hpiv5" runat="server" Width="80" placeholder = "Hv Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="atkev5" runat="server" Width="80" placeholder = "Atk Ev"></asp:textbox>
        <asp:textbox class="stats" ID="atkiv5" runat="server" Width="80" placeholder = "Atk Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="defev5" runat="server" Width="80" placeholder = "Def Ev"></asp:textbox>
        <asp:textbox class="stats" ID="defiv5" runat="server" Width="80" placeholder = "Def Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="spatkev5" runat="server" Width="80" placeholder = "SpAtk Ev"></asp:textbox>
        <asp:textbox class="stats" ID="spatkiv5" runat="server" Width="80" placeholder = "SpAtk Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="spdefev5" runat="server" Width="80" placeholder = "SpDef Ev"></asp:textbox>
        <asp:textbox class="stats" ID="spdefiv5" runat="server" Width="80" placeholder = "SpDef Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="spdev5" runat="server" Width="80" placeholder = "Spd Ev"></asp:textbox>        
        <asp:textbox class="stats" ID="spdiv5" runat="server" Width="80" placeholder = "Spd Iv"></asp:textbox><br />
        
        
        <asp:dropdownlist class="stats" ID="Nature5" runat="server"  Width="188px" DataSourceID="SqlDataSource1" DataTextField="Nature_Name" DataValueField="Nature_ID">
       </asp:dropdownlist> 
        <asp:SqlDataSource ID="SqlDataSource22" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Nature_Name], [Nature_ID] FROM [Natures]"></asp:SqlDataSource>
        <br />

        <asp:dropdownlist class="stats" ID="Ability5" runat="server"  Width="188px" DataSourceID="SqlDataSource2" DataTextField="Ability_Name" DataValueField="Ability_ID">
       </asp:dropdownlist> 
        <asp:SqlDataSource ID="SqlDataSource23" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Ability_Name], [Ability_ID] FROM [Ability]"></asp:SqlDataSource>
        <br />

        <asp:dropdownlist class="stats" ID="Item5" runat="server"  Width="188px" DataSourceID="SqlDataSource3" DataTextField="Item_Name" DataValueField="Item_ID">
       </asp:dropdownlist> 
        
        <asp:SqlDataSource ID="SqlDataSource24" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Item_Name], [Item_ID] FROM [Items]"></asp:SqlDataSource>
        
        <br />

        <asp:dropdownlist class="stats" ID="Attack1_5" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist>
        
        <asp:SqlDataSource ID="SqlDataSource25" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Move_Name], [Move_ID] FROM [Moves]"></asp:SqlDataSource>
        
        <br />

        <asp:dropdownlist class="stats" ID="Attack2_5" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist> 
       
        <br />

        <asp:dropdownlist class="stats" ID="Attack3_5" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist> 
       
        <br />

        <asp:dropdownlist class="stats" ID="Attack4_5" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist>
        
        <br />
    </div>
        <div id="stats6">
        <asp:textbox class="stats" ID="NickName6" runat="server" Width="188" placeholder = "NickName"></asp:textbox><br />
        <asp:DropDownList class="stats" ID="Pokemon6" runat="server" Width="188px" DataSourceID="SqlDataSource5" DataTextField="Name" DataValueField="ID" ></asp:DropDownList><br />
        <asp:SqlDataSource ID="SqlDataSource26" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [ID], [Name] FROM [Pokemon] ORDER BY [ID]"></asp:SqlDataSource>
        <asp:dropdownlist class="stats" ID="Gender6" runat="server"  Width="188px">
         <asp:ListItem>Select a Gender</asp:ListItem>
         <asp:ListItem Value="1">Male</asp:ListItem>
         <asp:ListItem Value="2">Female</asp:ListItem>
         <asp:ListItem Value="0">Genderless</asp:ListItem>
       </asp:dropdownlist> <br />

        <asp:textbox class="stats" ID="hpev6" runat="server" Width="80" placeholder = "Hv Ev"></asp:textbox>
        <asp:textbox class="stats" ID="hpiv6" runat="server" Width="80" placeholder = "Hv Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="atkev6" runat="server" Width="80" placeholder = "Atk Ev"></asp:textbox>
        <asp:textbox class="stats" ID="atkiv6" runat="server" Width="80" placeholder = "Atk Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="defev6" runat="server" Width="80" placeholder = "Def Ev"></asp:textbox>
        <asp:textbox class="stats" ID="defiv6" runat="server" Width="80" placeholder = "Def Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="spatkev6" runat="server" Width="80" placeholder = "SpAtk Ev"></asp:textbox>
        <asp:textbox class="stats" ID="spatkiv6" runat="server" Width="80" placeholder = "SpAtk Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="spdefev6" runat="server" Width="80" placeholder = "SpDef Ev"></asp:textbox>
        <asp:textbox class="stats" ID="spdefiv6" runat="server" Width="80" placeholder = "SpDef Iv"></asp:textbox><br />
        <asp:textbox class="stats" ID="spdev6" runat="server" Width="80" placeholder = "Spd Ev"></asp:textbox>        
        <asp:textbox class="stats" ID="spdiv6" runat="server" Width="80" placeholder = "Spd Iv"></asp:textbox><br />
        
        
        <asp:dropdownlist class="stats" ID="Nature6" runat="server"  Width="188px" DataSourceID="SqlDataSource1" DataTextField="Nature_Name" DataValueField="Nature_ID">
       </asp:dropdownlist> 
        <asp:SqlDataSource ID="SqlDataSource27" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Nature_Name], [Nature_ID] FROM [Natures]"></asp:SqlDataSource>
        <br />

        <asp:dropdownlist class="stats" ID="Ability6" runat="server"  Width="188px" DataSourceID="SqlDataSource2" DataTextField="Ability_Name" DataValueField="Ability_ID">
       </asp:dropdownlist> 
        <asp:SqlDataSource ID="SqlDataSource28" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Ability_Name], [Ability_ID] FROM [Ability]"></asp:SqlDataSource>
        <br />

        <asp:dropdownlist class="stats" ID="Item6" runat="server"  Width="188px" DataSourceID="SqlDataSource3" DataTextField="Item_Name" DataValueField="Item_ID">
       </asp:dropdownlist> 
        
        <asp:SqlDataSource ID="SqlDataSource29" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Item_Name], [Item_ID] FROM [Items]"></asp:SqlDataSource>
        
        <br />

        <asp:dropdownlist class="stats" ID="Attack1_6" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist>
        
        <asp:SqlDataSource ID="SqlDataSource30" runat="server" ConnectionString="<%$ ConnectionStrings:EnterpriseJDW35ConnectionString2 %>" SelectCommand="SELECT [Move_Name], [Move_ID] FROM [Moves]"></asp:SqlDataSource>
        
        <br />

        <asp:dropdownlist class="stats" ID="Attack2_6" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist> 
       
        <br />

        <asp:dropdownlist class="stats" ID="Attack3_6" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist> 
       
        <br />

        <asp:dropdownlist class="stats" ID="Attack4_6" runat="server"  Width="188px" DataSourceID="SqlDataSource4" DataTextField="Move_Name" DataValueField="Move_ID">
       </asp:dropdownlist>
        
        <br />
            
    </div>
 </div>
        <div id="SaveDelete">
            <asp:textbox class="stats" ID="TeamName" runat="server" Width="188" placeholder = "Team Name"></asp:textbox><br />
            <asp:Button class="SaveB" runat="server" Text="Save" OnClick="SaveButton"></asp:Button>
            <asp:Button class="DeleteB" runat="server" Text="Delete" OnClick="DeleteButton"></asp:Button>
        </div>
    </form>
</body>
</html>
<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeFile="searchBus.aspx.cs" Inherits="searchBus" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="BodyContent">
<div class="content_container">
    <asp:Label ID="Label1" runat="server" Text="From"></asp:Label><br /><br />
    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="Index_Changed">
        <asp:ListItem Value="1">Dhaka</asp:ListItem>
        <asp:ListItem Value="2">Chittagong</asp:ListItem>
        <asp:ListItem Value="3">Bogra</asp:ListItem>
        <asp:ListItem Value="4">Rangpur</asp:ListItem>
        <asp:ListItem Value="5">Naogaon</asp:ListItem>
        <asp:ListItem Value="6">Coxs Bazar</asp:ListItem>
    </asp:DropDownList>
</div>
<div class="content_container">
    <asp:Label ID="Label2" runat="server" Text="To"></asp:Label><br /><br />
    <asp:DropDownList ID="DropDownList2" runat="server" >
        <asp:ListItem Value="1">Dhaka</asp:ListItem>
        <asp:ListItem Value="2">Chittagong</asp:ListItem>
        <asp:ListItem Value="3">Bogra</asp:ListItem>
        <asp:ListItem Value="4">Rangpur</asp:ListItem>
        <asp:ListItem Value="5">Naogaon</asp:ListItem>
        <asp:ListItem Value="6">Coxs Bazar</asp:ListItem>
    </asp:DropDownList>
</div>
<div class="content_container">
    <asp:Label ID="Label3" runat="server" Text="Bus Type"></asp:Label><br /><br />
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
        <asp:ListItem Value="1">AC</asp:ListItem>
        <asp:ListItem Value="2">NON AC</asp:ListItem>
    </asp:RadioButtonList>
</div>
    <asp:Button ID="Button1" runat="server" Text="Search Bus" OnClick="Search_Bus" /><br /><br />

    <br />
</asp:Content>
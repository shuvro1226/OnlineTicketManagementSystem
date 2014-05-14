<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addschedule.aspx.cs" MasterPageFile="~/Site.master" Inherits="addschedule" %>

<%@ MasterType VirtualPath="~/Site.master" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="BodyContent">
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <%# Eval("id") %> | <%# Eval("name") %><br />
        </ItemTemplate>
    </asp:Repeater>
    <br /><br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Add_Brand" />
</asp:Content>
<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeFile="adminLogin.aspx.cs" Inherits="adminLogin" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
    <div class="bodycontent">
        <h2>Login as an Admin or Operator</h2>
        <h3>Enter login details below...</h3>
        <asp:TextBox ID="username" runat="server" BorderStyle="Inset" ValidationGroup="group1" Height="25px" Width="350px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="validator1" ValidationGroup="group1" ControlToValidate="username" Text="Username Required" ForeColor="Red" runat="server"></asp:RequiredFieldValidator><br /><br />
        <asp:TextBox ID="password" TextMode="Password" runat="server" BorderStyle="Inset" ValidationGroup="group1" Height="25px" Width="350px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="validator2" ValidationGroup="group1" ControlToValidate="password" Text="Password Required" ForeColor="Red" runat="server"></asp:RequiredFieldValidator><br /><br />
        <div style="padding-left:270px"><asp:Button ID="loginbutton" runat="server" Text="Login" ValidationGroup="group1" ForeColor="White" BackColor="#2d659c" Width="80px" Height="40px" OnClick="Button_Click" /></div>
    </div>
</asp:Content>
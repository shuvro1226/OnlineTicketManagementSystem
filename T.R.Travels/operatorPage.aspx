<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeFile="operatorPage.aspx.cs" Inherits="operatorPage" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="BodyContent">
<h3>You have logged in as an Operator</h3>
<div class="access">
<div class="operatorcontent">
<ol>
<li><a href="schedule.aspx">Manage Bus Schedule</a></li>
<li><a href="OperatorPayment.aspx">Direct Payment</a></li>
</ol>
</div>
</div><div class="pnr">
<div class="operatorcontent">
    <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="grp1" BackColor="ControlLight" Width="200px"></asp:TextBox><br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Provide PNR" ControlToValidate="TextBox1" ValidationGroup="grp1" ForeColor="Red"></asp:RequiredFieldValidator><br />
    <asp:Button ID="Button1" runat="server" Text="Search" ValidationGroup="grp1" OnClick="Search_Passenger" />
</div>
</div>
<div class="operatorsearch" style="margin-top:200px;">
<div class="searchcontent1">
<p style="margin-top:50px;">From</p>
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="Index_Changed" Font-Bold="true" Height="30px" BackColor="#ccffff" AutoPostBack="true">
        <asp:ListItem Value="0">Select</asp:ListItem>
        <asp:ListItem Value="1">Dhaka</asp:ListItem>
        <asp:ListItem Value="2">Chittagong</asp:ListItem>
        <asp:ListItem Value="3">Bogra</asp:ListItem>
        <asp:ListItem Value="4">Rangpur</asp:ListItem>
        <asp:ListItem Value="5">Naogaon</asp:ListItem>
        <asp:ListItem Value="6">Coxs Bazar</asp:ListItem>
        </asp:DropDownList>
</div>
<div class="searchcontent1">
<p style="margin-top:50px;">To</p>
        <asp:DropDownList ID="DropDownList2" runat="server" Font-Bold="true" Height="30px" BackColor="#ccffff">
        <asp:ListItem Value="1">Dhaka</asp:ListItem>
        <asp:ListItem Value="2">Chittagong</asp:ListItem>
        <asp:ListItem Value="3">Bogra</asp:ListItem>
        <asp:ListItem Value="4">Rangpur</asp:ListItem>
        <asp:ListItem Value="5">Naogaon</asp:ListItem>
        <asp:ListItem Value="6">Coxs Bazar</asp:ListItem>
        </asp:DropDownList>
</div>
<div class="searchcontent1">
<p>Bus Type</p>
    <asp:DropDownList ID="DropDownList3" runat="server" Font-Bold="true" Height="30px" BackColor="#ccffff">
    <asp:ListItem Value="1">AC</asp:ListItem>
    <asp:ListItem Value="2">NON AC</asp:ListItem>
    </asp:DropDownList>
</div>
<asp:Button ID="Button2" runat="server" OnClick="Search_Bus" CssClass="search" BorderStyle="None" />
</div>
<div class="passgrid">
    <asp:GridView ID="GridView1" runat="server" OnRowDataBound="rowDataBound" AutoGenerateColumns="true">
    </asp:GridView>
</div>
</asp:Content>
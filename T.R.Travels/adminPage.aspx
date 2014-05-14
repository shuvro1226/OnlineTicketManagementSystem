﻿<%@ Page Language="C#" Debug="true" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeFile="adminPage.aspx.cs" Inherits="adminPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
<h3>You have logged in as an Admin</h3>

<h4><asp:Label ID="Label4" runat="server" Text=""></asp:Label></h4>
<div class="operator">
<asp:SqlDataSource ID="SqlDataSource1" runat="server" DataSourceMode="DataSet" ConnectionString="<%$ ConnectionStrings:ConString %>"
 SelectCommand="SELECT * FROM [adminoperator] WHERE name!='Ashif' and name!='Shuvro'" DeleteCommand="DELETE FROM [adminoperator] WHERE id=@ID"
  OnDeleting="OnDeleting" OnDeleted="OnDeleted">
</asp:SqlDataSource><br />
<div class="operatorcontent">
    <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="true" Text="Check to delete operator" /><br /><br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" AutoGenerateDeleteButton="true" PageSize="20" DataSourceID="SqlDataSource1" DataKeyNames="id" OnRowDataBound="rowDataBound"
    CellPadding="3" CellSpacing="2" BorderStyle="None" BackColor="#40aece" BorderWidth="0px" SelectedRowStyle-BackColor="Black" SelectedRowStyle-ForeColor="White">
    <HeaderStyle BackColor="#173552" ForeColor="White" />
     <PagerStyle BackColor="#173552" ForeColor="White" HorizontalAlign="Center" />
     <AlternatingRowStyle BackColor="#328aa4" />
    <Columns>
        <asp:BoundField DataField="name" />
        <asp:BoundField DataField="id" />
        <asp:BoundField DataField="Password" />
    </Columns>
    </asp:GridView>
    </div>
</div>    
    <div class="addoperator">
    <div class="operatorcontent">
        <asp:Label ID="Label1" runat="server" Text="Operator Name" CssClass="label1"></asp:Label><br />
        <asp:TextBox ID="name" runat="server" ValidationGroup="group1" BackColor="ControlLight"></asp:TextBox><br />
        <asp:RequiredFieldValidator runat="server" ID="validator1" ControlToValidate="name" Text="Provide Operator name" ValidationGroup="group1" ForeColor="Red"></asp:RequiredFieldValidator><br />
        <asp:Label ID="Label2" runat="server" Text="Operator ID" CssClass="label1"></asp:Label><br />
        <asp:TextBox ID="oid" runat="server" ValidationGroup="group1" BackColor="ControlLight"></asp:TextBox><br />
        <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="oid" Text="Provide Operator ID" ValidationGroup="group1" ForeColor="Red"></asp:RequiredFieldValidator><br />
        <asp:Label ID="Label3" runat="server" Text="Password" CssClass="label1"></asp:Label><br />
        <asp:TextBox ID="password" runat="server" ValidationGroup="group1" BackColor="ControlLight"></asp:TextBox><br />
        <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator2" ControlToValidate="password" Text="Select a password" ValidationGroup="group1" ForeColor="Red"></asp:RequiredFieldValidator><br />
    <asp:Button ID="addOperator" runat="server" Text="Add an Operator" ValidationGroup="group1" OnClick="Add_Operator" />
    </div>
    </div><br /><br />
</asp:Content>
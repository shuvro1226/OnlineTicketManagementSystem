<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeFile="schedule.aspx.cs" Inherits="schedule" %>
<%@ MasterType VirtualPath="~/Site.master" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="BodyContent">
        
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <%# Eval("id") %>&nbsp;<%# Eval("bus") %>
        </ItemTemplate>
    </asp:Repeater>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="BUS" HeaderText="BUS" SortExpression="BUS" />
            <asp:BoundField DataField="TYPE" HeaderText="TYPE" SortExpression="TYPE" />
            <asp:BoundField DataField="PRICE" HeaderText="PRICE" SortExpression="PRICE" />
            <asp:BoundField DataField="DEPARTURE" HeaderText="DEPARTURE" SortExpression="DEPARTURE" />
            <asp:BoundField DataField="SEATS" HeaderText="SEATS" SortExpression="SEATS" />
            <asp:BoundField DataField="BEGINNING" HeaderText="BEGINNING" SortExpression="BEGINNING" />
            <asp:BoundField DataField="DESTINATION" HeaderText="DESTINATION" SortExpression="DESTINATION" />
            <asp:BoundField DataField="DEPART_DATE" HeaderText="DEPART_DATE" SortExpression="DEPART_DATE" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConString %>" ProviderName="<%$ ConnectionStrings:ConString.ProviderName %>" SelectCommand="SELECT * FROM &quot;BUSES&quot;"></asp:SqlDataSource>
</asp:Content>
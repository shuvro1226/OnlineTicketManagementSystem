<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeFile="BusSchedule.aspx.cs" Inherits="BusSchedule" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="BodyContent">
<div style="width:auto; height:auto;">
<div class="schedulesort">
    <p style="font-family:Lucida Sans">
    <b style="color:Green">(Select both to sort more)</b><br />
    <asp:Label ID="Label1" runat="server" Text="Sort buses by Date" Font-Size="Large" Font-Bold="true"></asp:Label></p>
<asp:DropDownList ID="DropDownList7" runat="server" AutoPostBack="true" DataValueField="date" DataSourceID="SqlDataSource2" AppendDataBoundItems="true" Font-Bold="true" Height="30px" BackColor="#ccffff">
            <asp:ListItem Value="%" Text="Date"></asp:ListItem>
            </asp:DropDownList>
</div>
<div class="schedulesort">
    <p style="font-family:Lucida Sans"><asp:Label ID="Label2" runat="server" Text="Sort buses by Destination" Font-Size="Large" Font-Bold="true"></asp:Label><br />
    (Select Rangpur if you are a passenger of Naogaon, Bogra or Rangpur)<br />
    (Select Coxs Bazar if you are a passenger of Chittagong or Coxs Bazar)<br /></p>
        <asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="true" DataValueField="reach" DataSourceID="SqlDataSource3" AppendDataBoundItems="true" Font-Bold="true" Height="30px" BackColor="#ccffff">
        <asp:ListItem Value="%" Text="Destination"></asp:ListItem>
        </asp:DropDownList>
</div>
</div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConString %>" SelectCommand="SELECT * FROM [buses]" FilterExpression="date like '{0}%' and reach like '{1}%'">
      <FilterParameters>
        <asp:ControlParameter Name="date" ControlID="DropDownList7" PropertyName="SelectedValue" />
        <asp:ControlParameter Name="reach" ControlID="DropDownList5" PropertyName="SelectedValue" />
      </FilterParameters>    
    </asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" PageSize="12" DataSourceID="SqlDataSource1" DataKeyNames="id" AllowPaging="true" AllowSorting="true"
     CellPadding="3" CellSpacing="2" BorderStyle="None" OnRowCreated="RowCreate" BackColor="#40aece" BorderWidth="0px">
     <HeaderStyle BackColor="#173552" ForeColor="White" />
     <PagerStyle BackColor="#173552" ForeColor="White" HorizontalAlign="Center" />
     <AlternatingRowStyle BackColor="#328aa4" />
    <Columns>
                
        <asp:TemplateField HeaderText="Bus Number">
        <ItemTemplate>
        <asp:Label ID="lblbus" runat="server" Text='<%# Eval("busid") %>'/>
        </ItemTemplate>
        <ItemStyle HorizontalAlign="Center" />
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Bus Type">
        <ItemTemplate>
        <asp:Label ID="lbltype" runat="server" Text='<%# Eval("type") %>'/>
        </ItemTemplate>
        <ItemStyle HorizontalAlign="Center" />
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Depart From">
        <ItemTemplate>
        <asp:Label ID="lblfrom" runat="server" Text='<%# Eval("leave") %>'/>
        </ItemTemplate>
        <ItemStyle HorizontalAlign="Center" />
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Destination">
        <ItemTemplate>
        <asp:Label ID="lblto" runat="server" Text='<%# Eval("reach") %>'/>
        </ItemTemplate>
        <ItemStyle HorizontalAlign="Center" />
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Departure Date">
        <ItemTemplate>
        <asp:Label ID="lbldate" runat="server" Text='<%# Eval("date") %>'/>
        </ItemTemplate>
        <ItemStyle HorizontalAlign="Center" />
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Time">
        <ItemTemplate>
        <asp:Label ID="lblitemtime" runat="server" Text='<%# Eval("departure") %>'/>
        </ItemTemplate>
        <ItemStyle HorizontalAlign="Center" />
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Ticket Price">
        <ItemTemplate>
        <asp:Label ID="lblprice" runat="server" Text='<%# Eval("tprice") %>'/>
        </ItemTemplate>
        <ItemStyle HorizontalAlign="Center" />
        </asp:TemplateField>
        
    </Columns>
    </asp:GridView>
    
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConString %>" SelectCommand="SELECT DISTINCT [date] from [buses]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConString %>" SelectCommand="SELECT DISTINCT [reach] from [buses]"></asp:SqlDataSource>
</asp:Content>
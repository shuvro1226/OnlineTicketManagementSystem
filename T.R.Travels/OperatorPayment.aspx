<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="OperatorPayment.aspx.cs" Inherits="OperatorPayment" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="BodyContent">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" AutoGenerateSelectButton="true" PageSize="10" DataKeyNames="busid" AllowPaging="true" OnRowDataBound="rowDataBound" OnSelectedIndexChanged="Changed" OnSelectedIndexChanging="Changing">
</asp:GridView>
    <asp:Panel ID="pnl1" runat="server">
    <asp:Table BorderStyle="Solid" ID="seattable" runat="server">
        <asp:TableRow>
            <asp:TableCell ID="TableCell1" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s1" ToolTip="Window Side" ImageUrl="~/images/available_seat_img.png" OnClick="s1click" runat="server" />A4</asp:TableCell>
            <asp:TableCell ID="TableCell2" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s6" OnClick="s6click" ImageUrl="~/images/available_seat_img.png" runat="server" />B4</asp:TableCell>
            <asp:TableCell ID="TableCell3" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s7" OnClick="s7click" ToolTip="Window Side" ImageUrl="~/images/available_seat_img.png" runat="server" />C4</asp:TableCell>
            <asp:TableCell ID="TableCell4" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s12" OnClick="s12click" ImageUrl="~/Images/available_seat_img.png" runat="server" />D4</asp:TableCell>
            <asp:TableCell ID="TableCell5" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s13" OnClick="s13click" ImageUrl="~/Images/available_seat_img.png" runat="server" />E4</asp:TableCell>
            <asp:TableCell ID="TableCell6" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s18" OnClick="s18click" ImageUrl="~/Images/available_seat_img.png" runat="server" />F4</asp:TableCell>
            <asp:TableCell ID="TableCell7" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s19" OnClick="s19click" ImageUrl="~/Images/available_seat_img.png" runat="server" />G4</asp:TableCell>
            <asp:TableCell ID="TableCell8" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s24" OnClick="s24click" ImageUrl="~/Images/available_seat_img.png" runat="server" />H4</asp:TableCell>
            <asp:TableCell ID="TableCell9" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s25" OnClick="s25click" ImageUrl="~/Images/available_seat_img.png" runat="server" />I4</asp:TableCell>
            <asp:TableCell ID="TableCell10" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s31" OnClick="s31click" ImageUrl="~/Images/available_seat_img.png" runat="server" />J4</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ID="TableCell11" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s2" ImageUrl="~/images/available_seat_img.png" OnClick="s2click" runat="server" />A3</asp:TableCell>
            <asp:TableCell ID="TableCell12" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s5" OnClick="s5click" ImageUrl="~/images/available_seat_img.png" runat="server" />B3</asp:TableCell>
            <asp:TableCell ID="TableCell13" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s8" OnClick="s8click" ImageUrl="~/images/available_seat_img.png" runat="server" />C3</asp:TableCell>
            <asp:TableCell ID="TableCell14" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s11" OnClick="s11click" ImageUrl="~/images/available_seat_img.png" runat="server" />D3</asp:TableCell>
            <asp:TableCell ID="TableCell15" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s14" OnClick="s14click" ImageUrl="~/images/available_seat_img.png" runat="server" />E3</asp:TableCell>
            <asp:TableCell ID="TableCell16" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s17" OnClick="s17click" ImageUrl="~/images/available_seat_img.png" runat="server" />F3</asp:TableCell>
            <asp:TableCell ID="TableCell17" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s20" OnClick="s20click" ImageUrl="~/Images/available_seat_img.png" runat="server" />G3</asp:TableCell>
            <asp:TableCell ID="TableCell18" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s23" OnClick="s23click" ImageUrl="~/Images/available_seat_img.png" runat="server" />H3</asp:TableCell>
            <asp:TableCell ID="TableCell19" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s26" OnClick="s26click" ImageUrl="~/Images/available_seat_img.png" runat="server" />I3</asp:TableCell>
            <asp:TableCell ID="TableCell20" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s30" OnClick="s30click" ImageUrl="~/Images/available_seat_img.png" runat="server" />J3</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
        <asp:TableCell ID="TableCell41" runat="server">&nbsp; </asp:TableCell>
        <asp:TableCell ID="TableCell42" runat="server">&nbsp; </asp:TableCell>
        <asp:TableCell ID="TableCell43" runat="server">&nbsp; </asp:TableCell>
        <asp:TableCell ID="TableCell44" runat="server">&nbsp; </asp:TableCell>
        <asp:TableCell ID="TableCell45" runat="server">&nbsp; </asp:TableCell>
        <asp:TableCell ID="TableCell46" runat="server">&nbsp; </asp:TableCell>
        <asp:TableCell ID="TableCell47" runat="server">&nbsp; </asp:TableCell>
        <asp:TableCell ID="TableCell48" runat="server">&nbsp; </asp:TableCell>
        <asp:TableCell ID="TableCell49" runat="server">&nbsp; </asp:TableCell>
        <asp:TableCell ID="TableCell50" runat="server">&nbsp; </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ID="TableCell21" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s32" OnClick="s32click" ImageUrl="~/images/available_seat_img.png" runat="server" />A2</asp:TableCell>
            <asp:TableCell ID="TableCell22" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s33" OnClick="s33click" ImageUrl="~/images/available_seat_img.png" runat="server" />B2</asp:TableCell> 
            <asp:TableCell ID="TableCell23" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s34" OnClick="s34click" ImageUrl="~/images/available_seat_img.png" runat="server" />C2</asp:TableCell>
            <asp:TableCell ID="TableCell24" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s35" OnClick="s35click" ImageUrl="~/images/available_seat_img.png" runat="server" />D2</asp:TableCell>
            <asp:TableCell ID="TableCell25" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s36" OnClick="s36click" ImageUrl="~/images/available_seat_img.png" runat="server" />E2</asp:TableCell>
            <asp:TableCell ID="TableCell26" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s37" OnClick="s37click" ImageUrl="~/images/available_seat_img.png" runat="server" />F2</asp:TableCell>
            <asp:TableCell ID="TableCell27" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s38" OnClick="s38click" ImageUrl="~/images/available_seat_img.png" runat="server" />G2</asp:TableCell>
            <asp:TableCell ID="TableCell28" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s39" OnClick="s39click" ImageUrl="~/images/available_seat_img.png" runat="server" />H2</asp:TableCell>
            <asp:TableCell ID="TableCell29" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s40" OnClick="s40click" ImageUrl="~/images/available_seat_img.png" runat="server" />I2</asp:TableCell>
            <asp:TableCell ID="TableCell30" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s29" OnClick="s29click" ImageUrl="~/images/available_seat_img.png" runat="server" />J2</asp:TableCell>
       
       </asp:TableRow>
       <asp:TableRow>
            <asp:TableCell ID="TableCell31" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s3" OnClick="s3click" ImageUrl="~/images/available_seat_img.png" runat="server" />A1</asp:TableCell>
            <asp:TableCell ID="TableCell32" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s4" OnClick="s4click" ImageUrl="~/images/available_seat_img.png" runat="server" />B1</asp:TableCell>
            <asp:TableCell ID="TableCell33" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s9" OnClick="s9click" ImageUrl="~/images/available_seat_img.png" runat="server" />C1</asp:TableCell>
            <asp:TableCell ID="TableCell34" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s10" OnClick="s10click" ImageUrl="~/images/available_seat_img.png" runat="server" />D1</asp:TableCell>
            <asp:TableCell ID="TableCell35" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s15" OnClick="s15click" ImageUrl="~/images/available_seat_img.png" runat="server" />E1</asp:TableCell>
            <asp:TableCell ID="TableCell36" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s16" OnClick="s16click" ImageUrl="~/images/available_seat_img.png" runat="server" />F1</asp:TableCell>
            <asp:TableCell ID="TableCell37" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s21" OnClick="s21click" ImageUrl="~/Images/available_seat_img.png" runat="server" />G1</asp:TableCell>
            <asp:TableCell ID="TableCell38" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s22" OnClick="s22click" ImageUrl="~/Images/available_seat_img.png" runat="server" />H1</asp:TableCell>
            <asp:TableCell ID="TableCell39" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s27" OnClick="s27click" ImageUrl="~/Images/available_seat_img.png" runat="server" />I1</asp:TableCell>
            <asp:TableCell ID="TableCell40" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s28" OnClick="s28click" ImageUrl="~/Images/available_seat_img.png" runat="server" />J1</asp:TableCell>
       </asp:TableRow>
    </asp:Table>

    <br /><br />
        <asp:Label ID="cheatSeatNumber" runat="server" ForeColor="White" BackColor="White"></asp:Label>
    <asp:Label ID="Label1" runat="server" Text="Selected Seats"></asp:Label>
    <asp:TextBox ID="txtseatnumber" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ibnext" runat="server" OnClick="ibnext_Click" Text="Next&gt;&gt;" />
        <br /><br />
</asp:Panel>
<div>
    <div style="float: left; width: 50%; height: 225px;">
        <asp:Panel ID="pnl2" runat="server" Visible="False" Height="225px">
          <h4>CUSTOMER INFORMATION</h4>
       <asp:Label ID="Label8" runat="server" Text="Ticket Number"></asp:Label>
       <asp:Literal ID="litpnr" runat="server" /><br />
       <asp:Label ID="Label7" runat="server" Text="Passenger Name"></asp:Label>
       <asp:TextBox ID="txtname" runat="server" /><br />
       <asp:RequiredFieldValidator ID="rfvname" runat="server" ErrorMessage="*" ControlToValidate="txtname" />
       <%--<asp:RangeValidator ID="range" Text ="Invalid Name" Type="String"   ControlToValidate="txtname" runat="server" /> --%><br />
       <asp:Label ID="Label6" runat="server" Text="Phone Number"></asp:Label>
       <asp:TextBox ID="txtphone" runat="server" />
       <asp:RequiredFieldValidator ID="rfvph" ControlToValidate="txtphone" ErrorMessage="*" runat="server" />
       <asp:RangeValidator ID="rangephnumber" Text="Invalid Number" Type="Double" MaximumValue="10000000000" MinimumValue="1" ControlToValidate="txtphone" runat="server" /><br />
       <asp:Label ID="Label5" runat="server" Text="Total Seat"></asp:Label>
       <asp:Literal ID="littotalseat" runat="server"></asp:Literal><br />
       <asp:Label ID="Label4" runat="server" Text="Cost per seat"></asp:Label>
       <asp:Literal ID="litrent" runat="server"></asp:Literal><br />
       <asp:Label ID="Label3" runat="server" Text="Bus No."></asp:Label>
       <asp:Literal ID="litbusnumber" runat="server" /><br />
       <asp:Label ID="Label2" runat="server" Text="Total Cost"></asp:Label>
       <asp:Literal ID="littotalrent" runat="server" /><br />
</asp:Panel>
    
    </div>
   <div style="float: right; width: 50%; height: 225px;">
<asp:Panel ID="paychkpnl" runat="server" Height="175px">
               <br />
               
               <asp:Button ID="checkButton" runat="server" Text="Confirm" 
                   onclick="checkButton_Click" style="margin-left: 168px" />
               <br />
               
</asp:Panel>
<asp:Label ID="Label12" runat="server" Text="Payment Successful"></asp:Label>
               &nbsp;&nbsp;&nbsp;&nbsp;
       <br />
           <asp:Button ID="btnSave" runat="server" Text="Get Ticket" 
        OnClick="btnSave_Click" Height="29px" Width="162px" />
               <br />
   </div>
   <div style="float: left; width: 50%; height: 375px;">
<asp:Panel ID="cardimage" runat="server" Height="375px">
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:RadioButton ID="OpRadioBtn" text="Direct Payment" runat="server" 
               AutoPostBack="true" ForeColor="Black" 
               oncheckedchanged="RadioButton2_CheckedChanged" />
</asp:Panel>
    </div>
   <div style="float: right; width: 50%; height:375px;">
<asp:Panel ID="cmpltpanel" runat="server" Height="253px">
    <asp:table id="Table1" runat="server" Height="250" Width="450" CellPadding="3" CellSpacing="0">
        <asp:TableRow TableSection="TableHeader" BackColor="LightGreen">
            <asp:TableCell ID="BusNo" runat="server" Text="T.R. Travels <br /> Bus No :"  HorizontalAlign="Center" ColumnSpan="4">
            <asp:Literal ID="busnolitrel" runat="server"></asp:Literal>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell Text="PNR"></asp:TableCell>
            <asp:TableCell >
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            </asp:TableCell>
            <asp:TableCell Text="From"></asp:TableCell>
            <asp:TableCell >
            <asp:Literal ID="Literal5" runat="server"></asp:Literal>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell Text="Passenger Name"></asp:TableCell>
            <asp:TableCell >
            <asp:Literal ID="Literal2" runat="server"></asp:Literal>
            </asp:TableCell>
            <asp:TableCell Text="To"></asp:TableCell>
            <asp:TableCell >
            <asp:Literal ID="Literal6" runat="server"></asp:Literal>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell Text="Phone Num"></asp:TableCell>
            <asp:TableCell>
            <asp:Literal ID="Literal3" runat="server"></asp:Literal>
            </asp:TableCell>
            <asp:TableCell Text="Seat"></asp:TableCell>
            <asp:TableCell >
            <asp:Literal ID="Literal7" runat="server"></asp:Literal>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell Text="Journey Date"></asp:TableCell>
            <asp:TableCell>
            <asp:Literal ID="Literal4" runat="server"></asp:Literal>
            </asp:TableCell>
            <asp:TableCell Text="Dp.Time"></asp:TableCell>
            <asp:TableCell >
            <asp:Literal ID="Literal8" runat="server"></asp:Literal>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow TableSection="TableFooter" BackColor="Pink">
            <asp:TableCell Text="Total Price : TK." HorizontalAlign="Center" ColumnSpan="4">
            <asp:Literal ID="finalamount" runat="server"></asp:Literal>
            </asp:TableCell>
        </asp:TableRow>
    </asp:table>
    
</asp:Panel>
<asp:Button ID="export_Button" runat="server" onclick="export_Button_Click" 
        style="margin-left: 375px" Text="Export" />
</div>

               <h3><asp:Label ID="lblError" runat="server"></asp:Label></h3>

</div>

    </asp:Content>


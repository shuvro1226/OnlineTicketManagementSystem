<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeFile="seatStatus.aspx.cs" Inherits="seatStatus" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="BodyContent">
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" AutoGenerateSelectButton="true" PageSize="10" DataKeyNames="busid" AllowPaging="true" OnRowDataBound="rowDataBound" OnSelectedIndexChanged="Changed" OnSelectedIndexChanging="Changing"
CellPadding="3" CellSpacing="2" BorderStyle="None" BackColor="#40aece" BorderWidth="0px" SelectedRowStyle-BackColor="Black" SelectedRowStyle-ForeColor="White">
<HeaderStyle BackColor="#173552" ForeColor="White" />
     <PagerStyle BackColor="#173552" ForeColor="White" HorizontalAlign="Center" />
     <AlternatingRowStyle BackColor="#328aa4" />
</asp:GridView>
<div style="margin:0px auto">
    <asp:Panel ID="pnl1" runat="server" CssClass="panel1" Visible="false">
    <table width="700px" style="border:1px solid BLACK">
    <tr style="border:none">
    <td style="width:20%">
        <asp:Image ID="Image3" ImageUrl="~/images/6894934-steering-wheel-icon-in-red-color-with-shine.jpg" Height="40px" Width="40px" runat="server" CssClass="imagedriver" />
        <asp:Image ID="Image5" runat="server" ImageUrl="~/images/Driver.png" Height="40px" Width="40px" CssClass="imagedriver" /><br />
        <asp:Image ID="Image4" ImageUrl="~/images/canstock11412874.jpg" Height="50px" Width="50px" runat="server" CssClass="image4" />
    </td>
    <td style="width:80%">
    <asp:Table ID="seattable" runat="server">
        <asp:TableRow HorizontalAlign="Right">
            <asp:TableCell ID="TableCell1" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s1" ToolTip="Window Side" ImageUrl="~/images/available_seat_img.png" OnClick="s1click" runat="server" Height="40px" Width="40px" />A4</asp:TableCell>
            <asp:TableCell ID="TableCell2" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s6" OnClick="s6click" ImageUrl="~/images/available_seat_img.png" runat="server" Height="40px" Width="40px" />B4</asp:TableCell>
            <asp:TableCell ID="TableCell3" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s7" OnClick="s7click" ToolTip="Window Side" ImageUrl="~/images/available_seat_img.png" runat="server" Height="40px" Width="40px" />C4</asp:TableCell>
            <asp:TableCell ID="TableCell4" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s12" OnClick="s12click" ImageUrl="~/Images/available_seat_img.png" runat="server" Height="40px" Width="40px" />D4</asp:TableCell>
            <asp:TableCell ID="TableCell5" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s13" OnClick="s13click" ImageUrl="~/Images/available_seat_img.png" runat="server" Height="40px" Width="40px" />E4</asp:TableCell>
            <asp:TableCell ID="TableCell6" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s18" OnClick="s18click" ImageUrl="~/Images/available_seat_img.png" runat="server" Height="40px" Width="40px" />F4</asp:TableCell>
            <asp:TableCell ID="TableCell7" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s19" OnClick="s19click" ImageUrl="~/Images/available_seat_img.png" runat="server" Height="40px" Width="40px" />G4</asp:TableCell>
            <asp:TableCell ID="TableCell8" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s24" OnClick="s24click" ImageUrl="~/Images/available_seat_img.png" runat="server" Height="40px" Width="40px" />H4</asp:TableCell>
            <asp:TableCell ID="TableCell9" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s25" OnClick="s25click" ImageUrl="~/Images/available_seat_img.png" runat="server" Height="40px" Width="40px" />I4</asp:TableCell>
            <asp:TableCell ID="TableCell10" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s31" OnClick="s31click" ImageUrl="~/Images/available_seat_img.png" runat="server" Height="40px" Width="40px" />J4</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow HorizontalAlign="Right" CssClass="tablerow">
            <asp:TableCell ID="TableCell11" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s2" ImageUrl="~/images/available_seat_img.png" OnClick="s2click" runat="server" Height="40px" Width="40px" />A3</asp:TableCell>
            <asp:TableCell ID="TableCell12" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s5" OnClick="s5click" ImageUrl="~/images/available_seat_img.png" runat="server" Height="40px" Width="40px" />B3</asp:TableCell>
            <asp:TableCell ID="TableCell13" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s8" OnClick="s8click" ImageUrl="~/images/available_seat_img.png" runat="server" Height="40px" Width="40px" />C3</asp:TableCell>
            <asp:TableCell ID="TableCell14" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s11" OnClick="s11click" ImageUrl="~/images/available_seat_img.png" runat="server" Height="40px" Width="40px" />D3</asp:TableCell>
            <asp:TableCell ID="TableCell15" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s14" OnClick="s14click" ImageUrl="~/images/available_seat_img.png" runat="server" Height="40px" Width="40px" />E3</asp:TableCell>
            <asp:TableCell ID="TableCell16" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s17" OnClick="s17click" ImageUrl="~/images/available_seat_img.png" runat="server" Height="40px" Width="40px" />F3</asp:TableCell>
            <asp:TableCell ID="TableCell17" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s20" OnClick="s20click" ImageUrl="~/Images/available_seat_img.png" runat="server" Height="40px" Width="40px" />G3</asp:TableCell>
            <asp:TableCell ID="TableCell18" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s23" OnClick="s23click" ImageUrl="~/Images/available_seat_img.png" runat="server" Height="40px" Width="40px" />H3</asp:TableCell>
            <asp:TableCell ID="TableCell19" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s26" OnClick="s26click" ImageUrl="~/Images/available_seat_img.png" runat="server" Height="40px" Width="40px" />I3</asp:TableCell>
            <asp:TableCell ID="TableCell20" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s30" OnClick="s30click" ImageUrl="~/Images/available_seat_img.png" runat="server" Height="40px" Width="40px" />J3</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow HorizontalAlign="Right" CssClass="tablerow">
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
        <asp:TableRow HorizontalAlign="Right" CssClass="tablerow">
            <asp:TableCell ID="TableCell21" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s32" OnClick="s32click" ImageUrl="~/images/available_seat_img.png" runat="server" Height="40px" Width="40px" />A2</asp:TableCell>
            <asp:TableCell ID="TableCell22" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s33" OnClick="s33click" ImageUrl="~/images/available_seat_img.png" runat="server" Height="40px" Width="40px" />B2</asp:TableCell> 
            <asp:TableCell ID="TableCell23" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s34" OnClick="s34click" ImageUrl="~/images/available_seat_img.png" runat="server" Height="40px" Width="40px" />C2</asp:TableCell>
            <asp:TableCell ID="TableCell24" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s35" OnClick="s35click" ImageUrl="~/images/available_seat_img.png" runat="server" Height="40px" Width="40px" />D2</asp:TableCell>
            <asp:TableCell ID="TableCell25" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s36" OnClick="s36click" ImageUrl="~/images/available_seat_img.png" runat="server" Height="40px" Width="40px" />E2</asp:TableCell>
            <asp:TableCell ID="TableCell26" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s37" OnClick="s37click" ImageUrl="~/images/available_seat_img.png" runat="server" Height="40px" Width="40px" />F2</asp:TableCell>
            <asp:TableCell ID="TableCell27" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s38" OnClick="s38click" ImageUrl="~/images/available_seat_img.png" runat="server" Height="40px" Width="40px" />G2</asp:TableCell>
            <asp:TableCell ID="TableCell28" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s39" OnClick="s39click" ImageUrl="~/images/available_seat_img.png" runat="server" Height="40px" Width="40px" />H2</asp:TableCell>
            <asp:TableCell ID="TableCell29" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s40" OnClick="s40click" ImageUrl="~/images/available_seat_img.png" runat="server" Height="40px" Width="40px" />I2</asp:TableCell>
            <asp:TableCell ID="TableCell30" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s29" OnClick="s29click" ImageUrl="~/images/available_seat_img.png" runat="server" Height="40px" Width="40px" />J2</asp:TableCell>
       </asp:TableRow>
       <asp:TableRow HorizontalAlign="Right" CssClass="tablerow">
            <asp:TableCell ID="TableCell31" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s3" OnClick="s3click" ImageUrl="~/images/available_seat_img.png" runat="server" Height="40px" Width="40px" />A1</asp:TableCell>
            <asp:TableCell ID="TableCell32" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s4" OnClick="s4click" ImageUrl="~/images/available_seat_img.png" runat="server" Height="40px" Width="40px" />B1</asp:TableCell>
            <asp:TableCell ID="TableCell33" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s9" OnClick="s9click" ImageUrl="~/images/available_seat_img.png" runat="server" Height="40px" Width="40px" />C1</asp:TableCell>
            <asp:TableCell ID="TableCell34" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s10" OnClick="s10click" ImageUrl="~/images/available_seat_img.png" runat="server" Height="40px" Width="40px" />D1</asp:TableCell>
            <asp:TableCell ID="TableCell35" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s15" OnClick="s15click" ImageUrl="~/images/available_seat_img.png" runat="server" Height="40px" Width="40px" />E1</asp:TableCell>
            <asp:TableCell ID="TableCell36" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s16" OnClick="s16click" ImageUrl="~/images/available_seat_img.png" runat="server" Height="40px" Width="40px" />F1</asp:TableCell>
            <asp:TableCell ID="TableCell37" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s21" OnClick="s21click" ImageUrl="~/Images/available_seat_img.png" runat="server" Height="40px" Width="40px" />G1</asp:TableCell>
            <asp:TableCell ID="TableCell38" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s22" OnClick="s22click" ImageUrl="~/Images/available_seat_img.png" runat="server" Height="40px" Width="40px" />H1</asp:TableCell>
            <asp:TableCell ID="TableCell39" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s27" OnClick="s27click" ImageUrl="~/Images/available_seat_img.png" runat="server" Height="40px" Width="40px" />I1</asp:TableCell>
            <asp:TableCell ID="TableCell40" CssClass="seatCell" VerticalAlign="Middle" runat="server">
            <asp:ImageButton ID="s28" OnClick="s28click" ImageUrl="~/Images/available_seat_img.png" runat="server" Height="40px" Width="40px" />J1</asp:TableCell>
       </asp:TableRow>
    </asp:Table>
    </td>
    </tr>
    </table>
    <table>
    <tr>
    <td valign="middle"><img src="images/Driver.png" alt="" height="40px" width="40px" /> = Driver Seat</td>
    <td valign="middle"><img src="images/selected_seat_img.png" alt="" height="40px" width="40px" /> = Selected Seat</td>
    <td valign="middle"><img src="images/available_seat_img.png" alt="" height="40px" width="40px" /> = Available Seat</td>
    <td valign="middle"><img src="images/booked_seat_img.png" alt="" height="40px" width="40px" /> = Booked Seat</td>
    </tr>
    </table>
    <br /><br />

    <asp:Label ID="Label1" runat="server" Text="Selected Seats" CssClass="label1"></asp:Label>
    <asp:TextBox ID="cheatSeatNumber" runat="server" BackColor="ControlLight"></asp:TextBox>
        <asp:Button ID="ibnext" runat="server" OnClick="ibnext_Click" Text="Next&gt;&gt;" />
        <asp:Label ID="txtseatnumber" runat="server" ForeColor="White"></asp:Label>
        <br /><br />
</asp:Panel>
<div>
    
        <asp:Panel ID="pnl2" runat="server" Visible="False" CssClass="panel1">
        <div class="passinfo">
        <div class="passcontent">
        <asp:Label ID="Label7" runat="server" Text="Passenger Name: " CssClass="label1"></asp:Label>
       <asp:TextBox ID="txtname" runat="server" BackColor="ControlLight" /><br />
       <asp:RequiredFieldValidator ID="rfvname" runat="server" ErrorMessage="*" ControlToValidate="txtname" />
       <%--<asp:RangeValidator ID="range" Text ="Invalid Name" Type="String"   ControlToValidate="txtname" runat="server" /> --%><br />
       <asp:Label ID="Label6" runat="server" Text="Phone Number: " CssClass="label1"></asp:Label>
       <asp:TextBox ID="txtphone" runat="server" BackColor="ControlLight" />
       <asp:RequiredFieldValidator ID="rfvph" ControlToValidate="txtphone" ErrorMessage="*" runat="server" />
       <asp:RangeValidator ID="rangephnumber" Text="Invalid Number" Type="Double" MaximumValue="10000000000" MinimumValue="1" ControlToValidate="txtphone" runat="server" /><br /><br />
       <asp:Label ID="Label8" runat="server" Text="Ticket Number: " CssClass="label1"></asp:Label>
       <asp:Literal ID="litpnr" runat="server" /><br />       
       <asp:Label ID="Label5" runat="server" Text="Total Seat: " CssClass="label1"></asp:Label>
       <asp:Literal ID="littotalseat" runat="server"></asp:Literal><br />
       <asp:Label ID="Label4" runat="server" Text="Cost per seat: " CssClass="label1"></asp:Label>
       <asp:Literal ID="litrent" runat="server"></asp:Literal><br />
       <asp:Label ID="Label3" runat="server" Text="Bus No.: " CssClass="label1"></asp:Label>
       <asp:Literal ID="litbusnumber" runat="server" /><br />
       <asp:Label ID="Label2" runat="server" Text="Total Cost: " CssClass="label1"></asp:Label>
       <asp:Literal ID="littotalrent" runat="server" /><br />
       </div>
       <div style="margin-left:50px; margin-bottom:20px;">
       <asp:Panel ID="cardimage" runat="server">
       <asp:Image ID="Image1" runat="server" Height="36px" ImageUrl="~/images/visa_card.jpg" Width="58px" />
       <asp:RadioButton ID="RadioButton1" text="Visa Card" runat="server" AutoPostBack="true" ForeColor="White"
               oncheckedchanged="RadioButton1_CheckedChanged" />

           <asp:Image ID="Image2" runat="server" Height="36px" ImageUrl="~/images/master_card.jpg" Width="58px" />           
           <asp:RadioButton ID="RadioButton2" text="Master Card" runat="server" AutoPostBack="true" ForeColor="White" 
               oncheckedchanged="RadioButton2_CheckedChanged" />
        </asp:Panel>
        </div>
        </div>
</asp:Panel>
    
    
   
<asp:Panel ID="paychkpnl" runat="server" CssClass="panel2">
<div class="payinfo">
<div class="passcontent">
               <asp:Label ID="Label9" runat="server" Text="Name On Card:" CssClass="label1"></asp:Label><br />
               <asp:TextBox ID="cardnamebox" runat="server" BackColor="ControlLight"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ValidationGroup="grp4" ControlToValidate="cardnamebox" ForeColor="Red"></asp:RequiredFieldValidator>
               <br />
               <asp:Label ID="Label10" runat="server" Text="Card Number:" CssClass="label1"></asp:Label><br />
               <asp:TextBox ID="cardnobox" runat="server" BackColor="ControlLight"></asp:TextBox>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ValidationGroup="grp4" ControlToValidate="cardnobox" ForeColor="Red"></asp:RequiredFieldValidator>
               <br />
               <asp:Label ID="Label11" runat="server" Text="Security Code" CssClass="label1"></asp:Label><br />
               <asp:TextBox ID="seccodebox" runat="server" BackColor="ControlLight"></asp:TextBox>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ValidationGroup="grp4" ControlToValidate="seccodebox" ForeColor="Red"></asp:RequiredFieldValidator>
               <br />
               <br />
               <asp:Button ID="checkButton" runat="server" Text="Confirm Payment" onclick="checkButton_Click" ValidationGroup="grp4" />
               <br />
               </div>
      </div>         
</asp:Panel>
 <div style="margin-left:300px; margin-top:100px;">
<h3><asp:Label ID="Label12" runat="server" Text="Payment Successful"></asp:Label></h3>
      
           <asp:Button ID="btnSave" runat="server" Text="Get Ticket" OnClick="btnSave_Click" Height="29px" Width="162px" />
               </div>
  
<asp:Panel ID="cmpltpanel" runat="server" Height="253px">
    <asp:table id="Table1" runat="server" Height="250" Width="450" CellPadding="3" CellSpacing="0" BorderColor="Black" BorderWidth="1px">
        <asp:TableRow TableSection="TableHeader">
            <asp:TableCell ID="BusNo" runat="server" Text="T.R. Travels <br /> Bus No :"  HorizontalAlign="Center" ColumnSpan="4">
            <asp:Literal ID="busnolitrel" runat="server"></asp:Literal>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell Text="PNR:"></asp:TableCell>
            <asp:TableCell >
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            </asp:TableCell>
            <asp:TableCell Text="From:"></asp:TableCell>
            <asp:TableCell >
            <asp:Literal ID="Literal5" runat="server"></asp:Literal>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell Text="Passenger Name:"></asp:TableCell>
            <asp:TableCell >
            <asp:Literal ID="Literal2" runat="server"></asp:Literal>
            </asp:TableCell>
            <asp:TableCell Text="Destination:"></asp:TableCell>
            <asp:TableCell >
            <asp:Literal ID="Literal6" runat="server"></asp:Literal>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell Text="Phone No.:"></asp:TableCell>
            <asp:TableCell>
            <asp:Literal ID="Literal3" runat="server"></asp:Literal>
            </asp:TableCell>
            <asp:TableCell Text="Seat No.:"></asp:TableCell>
            <asp:TableCell >
            <asp:Literal ID="Literal7" runat="server"></asp:Literal>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell Text="Journey Date:"></asp:TableCell>
            <asp:TableCell>
            <asp:Literal ID="Literal4" runat="server"></asp:Literal>
            </asp:TableCell>
            <asp:TableCell Text="Dp.Time:"></asp:TableCell>
            <asp:TableCell >
            <asp:Literal ID="Literal8" runat="server"></asp:Literal>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow TableSection="TableFooter">
            <asp:TableCell Text="Total Price : TK." HorizontalAlign="Center" ColumnSpan="4">
            <asp:Literal ID="finalamount" runat="server"></asp:Literal>
            </asp:TableCell>
        </asp:TableRow>
    </asp:table>
    <asp:Button ID="export_Button" runat="server" onclick="export_Button_Click" style="margin-left: 75px" Text="Export" />
</asp:Panel>


               <h3><asp:Label ID="lblError" runat="server"></asp:Label></h3>

</div>
</div>

    </asp:Content>
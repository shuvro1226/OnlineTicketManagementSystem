<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="nav.css" type="text/css" rel="Stylesheet" />
    <link href="style.css" type="text/css" rel="Stylesheet" />
    <link href="default.css" type="text/css" rel="Stylesheet" />
    <link href="orbit-1.2.3.css" type="text/css" rel="Stylesheet" />
    <script src="js/jquery-1.5.1.min.js" type="text/javascript"></script>
    <script src="js/jquery.orbit-1.2.3.js" type="text/javascript"></script>
    <script src="js/jquery.orbit-1.2.3.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(window).load(function () {
            $('#featured').orbit({
                animation: 'fade',                  // fade, horizontal-slide, vertical-slide, horizontal-push
                animationSpeed: 800,                // how fast animtions are
                timer: true, 			 // true or false to have the timer
                advanceSpeed: 8000, 		 // if timer is enabled, time between transitions 
                pauseOnHover: false, 		 // if you hover pauses the slider
                startClockOnMouseOut: true, 	 // if clock should start on MouseOut
                startClockOnMouseOutAfter: 500, 	 // how long after MouseOut should the timer start again
                directionalNav: true, 		 // manual advancing directional navs
                captions: true, 			 // do you want captions?
                captionAnimation: 'fade', 		 // fade, slideOpen, none
                captionAnimationSpeed: 800, 	 // if so how quickly should they animate in
                bullets: false, 		 // true or false to activate the bullet navigation
                bulletThumbs: false, 	 // thumbnails for the bullets
                bulletThumbLocation: '', 	 // location from this file where thumbs will be
                afterSlideChange: function () { } 	 // empty function 
            });
        });
    </script>
    <!--[if IE]>
     <style type="text/css">
         .timer { display: none !important; }
         div.caption { background:transparent; filter:progid:DXImageTransform.Microsoft.gradient(startColorstr=#99000000,endColorstr=#99000000);zoom: 1; }
    </style>
    <![endif]-->
</head>
<body>
    <form id="form1" runat="server">
    <div class="wrapper">
    <div class="header">
        <img src="images/logo.png" width="32px" height="50px" style="position:absolute;" alt="" />
        <b>TR Travels</b>
        <div style="padding-left:240px; padding-top:28px; font-family:Lucida Sans; font-size:small; position:absolute; color:White;">The best transport agency in Bangladesh</div>
        <ul class="nav">
            <li><a href="Default.aspx" class="one">Home</a></li>
            <li><a href="counters.aspx" class="two">Ticket Counters</a></li>
            <li><a href="about.aspx" class="three">About T.R.Travels</a></li>
            <li><a href="BusSchedule.aspx" class="four">Bus Schedule</a></li>
        </ul>
        <div class="siteicon">
            <a href="https://www.facebook.com/TR.TRAVELS.BD"><img src="images/Facebook.png" alt="" height="30px" width="30px" /></a>
            <a href="https://www.facebook.com/TR.TRAVELS.BD"><img src="images/twitter.png" alt="" height="30px" width="30px" /></a>
        </div>
    </div>
    <div class="inner">
<div style="margin-left:-10px; margin-top:-1px;">
<div id="featured" style="position:absolute"> 
     <img src="images/1.jpg" alt="Overflow: Hidden No More" />
     <img src="images/2.jpg"  alt="HTML Captions"  />
     <img src="images/3.jpg" alt="and more features" />
</div>
<!-- Captions for Orbit -->
<span class="orbit-caption" id="htmlCaption">I'm A Badass Caption</span>
</div>
<div id="content">
<div class="searchcontent">
<div class="searchcontent1">
<p style="margin-top:50px;">From</p>
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="Index_Changed" Font-Bold="true" Height="30px" BackColor="#ccffff" AutoPostBack="true"></asp:DropDownList>
</div>
<div class="searchcontent1">
<p style="margin-top:50px;">To</p>
        <asp:DropDownList ID="DropDownList2" runat="server" Font-Bold="true" Height="30px" BackColor="#ccffff"></asp:DropDownList>
</div>
<div class="searchcontent1">
<p>Bus Type</p>
    <asp:DropDownList ID="DropDownList3" runat="server" Font-Bold="true" Height="30px" BackColor="#ccffff"></asp:DropDownList>
</div>
<asp:Button ID="Button1" runat="server" OnClick="Search_Bus" CssClass="search" BorderStyle="None" />
</div>
</div>
<div class="contactcontent">
<div class="bodycontent">
<b>Email:</b> mohit125tr@yahoo.com<br /><br />
<b>Address:</b> T.R.Travels office, Gabtoli Bus Terminal, Gabtoli, Mirpur, Dhaka.
<p>You can simply contact to any of our counters personally. All the counter's contact info are provided in the <a href="counters.aspx">Counters</a> page</p>
</div>
</div>
</div>
    </div>
    </form>
    <div class="footer">
        <ul class="footer_list">
            <li><a href="Default.aspx">Home</a></li>
            <li><a href="about.aspx">About TR Travels</a></li>
            <li><a href="counters.aspx">Ticket Counters</a></li>
            <li><a href="https://www.facebook.com/TR.TRAVELS.BD">Join us in Facebook</a></li>
            <li><a href="adminLogin.aspx">Admin Login</a></li>
        </ul>
    </div>
</body>
</html>
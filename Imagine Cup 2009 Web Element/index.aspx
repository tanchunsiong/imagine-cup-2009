<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebService1.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="X-UA-Compatible" content="IE=7;" /><meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>I'm a PC</title>
    <script src="javascripts/jquery-1.3.2.min.js" type="text/javascript"></script>
    <style type="text/css">
        .customInfoBox-noBeak,.customInfoBox-with-rightBeak,.customInfoBox-with-leftBeak
		{
		    border:0 solid black;
		    color:#676767;
		    display:block;
		    font-size:1.2em;
		    position:absolute;
		    z-index:500 !important;
		    background:transparent
		}
		.customInfoBox-with-rightBeak {padding:0 19px 0 0}
		.customInfoBox-with-leftBeak {padding:0 0 0 19px}
		.customInfoBox-noBeak {padding:0 4px}
		.customInfoBox-body {
		    border:1px solid #000;
		    left:-3px;
		    overflow:hidden;
		    position:relative;
		    top:-5000px;
		    width:500px;
		    background:#fff;
		}
		.customInfoBox-shadow {float:left;position:relative;background-color:#000}
		.customInfoBox-previewArea {width:100%;background:#FFF}
		.customInfoBox-previewArea p {font-size:1.1em;margin:0;padding:0 12px 10px 0}
		.customInfoBox-previewArea div.firstChild {margin:12px;overflow:hidden}
		.customInfoBox-previewArea .title {color:#000;font-size:1.1em;font-weight:bold;
		margin:0 0 8px}
		.customInfoBox-previewArea .ero-previewArea-image {display:block;float:left;height:80px;
		padding:3px 10px 5px 0;position:relative;width:80px}
		.customInfoBox-actionsBackground {
		    margin:4px;
		    background:#fff;
		}
		.customInfoBox-beak,.customInfoBox-progressAnimation {visibility:visible}
		.customInfoBox-actions {padding:4px 8px 0}
		* html .customInfoBox-actions {padding-top:8px}
		.customInfoBox-actions ul {list-style-image:none;margin:0;padding:0;
		list-style:none outside none}
		.customInfoBox-actions ul a,.customInfoBox-actions ul a:link,
		.customInfoBox-actions ul a:visited {color:#0088E4;text-decoration:none}
		.customInfoBox-actions ul a:hover {text-decoration:underline}
		.customInfoBox-actions ul li {margin-bottom:4px}
		.customInfoBox-paddingHack {font-size:8px;height:8px;width:1px}
		.customInfoBox-beak {height:34px;position:absolute;top:100px;width:19px}
		.customInfoBox-with-leftBeak .customInfoBox-beak {
		    background:transparent
		        url(http://maps.live.com/i/bin/1.3.20070327220207.22/ero/beakLeft.gif)
		        no-repeat scroll 0;left:0
		}
		.customInfoBox-with-rightBeak .customInfoBox-beak {background:transparent
		url(http://maps.live.com/i/bin/1.3.20070327220207.22/ero/beakRight.gif)
		no-repeat scroll 0;right:4px}
		.customInfoBox-noBeak .customInfoBox-beak {display:none}
		.customInfoBox-progressAnimation {font-size:0;height:3px;overflow:hidden;position:absolute;
		width:13px;z-index:500}
		.customInfoBox-progressAnimation div {font-size:0;height:100%;position:absolute;width:3px;
		background:#54CE43}
		.customInfoBox-progressAnimation div.frame0 {left:-3px}
		.customInfoBox-progressAnimation div.frame1 {left:0}
		.customInfoBox-progressAnimation div.frame2 {left:5px}
		.customInfoBox-progressAnimation div.frame3 {left:10px}
        </style>
    <link href="styles/style.css" rel="stylesheet" type="text/css"> 
    
</head>
<body>
<form runat=server>
<div id="header">
	<div class="container">
	<div id="greetings">Welcome, <strong>mickeyckm</strong> <span style="font-size: 12px">(<a id="logout" href="#">logout</a>)</span></div>
	SmartFarm&trade;
	</div>
</div>

<div id="navbar">
	<div class="container">
	<ul id="nav">
		<li><a href="index.aspx" id="nav_selected">Dashboard</a></li>
		<li><a href="alert.aspx">Alert System</a></li>
		<li><a href="knowledgebase.aspx">Knowledgebase</a></li>
		<li><a href="marketinfo.aspx">Market Info</a></li>
		<li><a href="marketplace.aspx">Marketplace</a></li>
		<div style="clear: both"></div>
	</ul>
	</div>
</div>
	
<div id="content">
	<div class="container">
	<table class="layout">
	<tr>
		<td colspan="2">
		<h2>Farms condition</h2>
		

		<div id="theMap" 
            style="position: relative; width: 100%; height: 400px;margin:0 auto "> 
        </div> 
        
        <asp:ScriptManager ID="sm" runat="server">    
        <Scripts>
            <asp:ScriptReference Path="http://dev.virtualearth.net/mapcontrol/mapcontrol.ashx?v=6.2" ScriptMode="Release" />
            <asp:ScriptReference Path="~/JS/Default.aspx.js" />         
        </Scripts>
        </asp:ScriptManager>

        <script type="text/javascript">
            setTimeout("drawFarms()", 500);
            function overlay_onclick() {

            }

        </script>
		

        </td>
	</tr>
	<tr>
		<td style="width: 50%">
		<h2>Weather Forecast</h2>
		
            <img src="Weather.jpg" />
		</td>
		
		<td>
		<h2>Marketplace</h2>
		
		</td>
	</tr>
	</table>
	</div>	
</div>
	
<div id="footer">
	<div class="container">
	<table id="footer_credits">
	<tr>
		<td class="left">&copy; 2009 I'm a PC. All Rights Reserved.</td>
		<td class="right">In collaboration with </td>
		<td class="right" width="100px"><img src="images/microsoft-logo.jpg" title="microsoft" style="width: 100px" /></td>
	</tr>
	</table>	
	</div>
</div>
</form>
</body>
</html>
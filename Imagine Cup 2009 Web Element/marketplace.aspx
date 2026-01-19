<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="marketplace.aspx.cs" Inherits="WebService1.marketplace" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
	<title>SmartFarm&trade; - I'm a PC</title>
	<script src="javascripts/jquery-1.3.2.min.js" type="text/javascript"></script>
	<script src="javascripts/jquery.sparkline.min.js" type="text/javascript"></script>
	<script src="javascripts/jgcharts.js" type="text/javascript"></script>
	<link href="styles/style.css" rel="stylesheet" type="text/css">
</head>

<body>
<div id="header">
	<div class="container">
	<div id="greetings">Welcome, <strong>mickeyckm</strong> <span style="font-size: 12px">(<a id="logout" href="#">logout</a>)</span></div>
	SmartFarm&trade;
	</div>
</div>

<div id="navbar">
	<div class="container">
	<ul id="nav">
		<li><a href="index.aspx">Dashboard</a></li>
		<li><a href="alert.aspx">Alert System</a></li>
		<li><a href="knowledgebase.aspx">Knowledgebase</a></li>
		<li><a href="marketinfo.aspx">Market Info</a></li>
		<li><a href="marketplace.aspx" id="nav_selected">Marketplace</a></li>
		<div style="clear: both"></div>
	</ul>
	</div>
</div>
	
<div id="content">
	<div class="container">
	<table class="layout">
	<tr>
		<td width="45%">
		<h2>Crops Market</h2>
		
		<div id="buying_form">
		<table id="">
		<tr>
			<th>Crop:</th>
			<td><input type="text" value="" /></td>
		</tr>
		<tr>
			<th>Reserve Price:</th>
			<td><input type="text" value="" /></td>
		</tr>
		<tr>
			<th>Starting Bid:</th>
			<td><input type="text" value="" /></td>
		</tr>
		<tr>
			<th>Buy now Price:</th>
			<td><input type="text" value="" /></td>
		</tr>
		<tr>
			<th></th>
			<td><input type="button" value="Submit to market" /></td>
		</tr>
		</table>
		</div>
		<br/>
		<h3>Currently listed on the market</h3>
		<table id="current_listing">
		<tr>
			<th>Crops</th>
			<th>Reserve Price</th>
			<th>Starting Bid</th>
			<th>Buy now price</th>
			<th width="16px"></th>
		</tr>
		<tr>
			<td>Pesticides</td>
			<td>$1.00/g</td>
			<td>1000g</td>
			<td>$1000.00</td>
			<td><img src="images/delete.png" /></td>
		</tr>
		<tr>
			<td>Fertizers</td>
			<td>$20/kg</td>
			<td>500kg</td>
			<td>$10,000.00</td>
			<td><img src="images/delete.png" /></td>
		</tr>
		<tr>
			<td>Corn Seeds</td>
			<td>$1/gram</td>
			<td></td>
			<td></td>
			<td><img src="images/delete.png" /></td>
		</tr>
		<tr>
			<td>Corn Seeds</td>
			<td>$1/gram</td>
			<td></td>
			<td></td>
			<td><img src="images/delete.png" /></td>
		</tr>
		</table>
		</td>
		
		<td>
		<h2>Suppliers Market</h2>
		
		<table id="supplier_market">
		<tr>
			<th>Items</th>
			<th>Price</th>
			<th style="width:30px; line-height: 16px">Quantity Available</th>
			<th>Suppliers</th>
			<th>Location</th>
			<th width="16px"></th>
		</tr>
		<tr>
			<td>Pesticides</td>
			<td>$1.00/g</td>
			<td>1000g</td>
			<td>PestGoAway Pte. Ltd.</td>
			<td>Delhi</td>
			<td><img src="images/email.png" /></td>
		</tr>
		<tr>
			<td>Fertizers</td>
			<td>$10/kg</td>
			<td>500kg</td>
			<td>UnOrganic Pte. Ltd.</td>
			<td>Delhi</td>
			<td><img src="images/email.png" /></td>
		</tr>
		<tr>
			<td>Shovel</td>
			<td>$11/pc</td>
			<td>480pc</td>
			<td>NeverRust Pte. Ltd.</td>
			<td>Dabra</td>
			<td><img src="images/email.png" /></td>
		</tr>
		<tr>
			<td>Picks</td>
			<td>$16/pc</td>
			<td>680pc</td>
			<td>NeverBreak Pte. Ltd.</td>
			<td>Calcultta</td>
			<td><img src="images/email.png" /></td>
		</tr>
		<tr>
			<td>Hoes</td>
			<td>$63/pc</td>
			<td>475pc</td>
			<td>WillNotSpoil Pte. Ltd.</td>
			<td>Dewas</td>
			<td><img src="images/email.png" /></td>
		</tr>
		<tr>
			<td>Machete</td>
			<td>$17/pc</td>
			<td>670pc</td>
			<td>SureGood Pte. Ltd.</td>
			<td>Dibrugarh</td>
			<td><img src="images/email.png" /></td>
		</tr>
		<tr>
			<td>Rake</td>
			<td>$32/pc</td>
			<td>730pc</td>
			<td>FarmWithPeace Pte. Ltd.</td>
			<td>Guna</td>
			<td><img src="images/email.png" /></td>
		</tr>
		<tr>
			<td>Axe</td>
			<td>$23/pc</td>
			<td>350pc</td>
			<td>AxeElites Pte. Ltd.</td>
			<td>Haldwani</td>
			<td><img src="images/email.png" /></td>
		</tr>
		<tr>
			<td>Hammer</td>
			<td>$16/pc</td>
			<td>650pc</td>
			<td>UseOurTools Pte. Ltd.</td>
			<td>Hubli</td>
			<td><img src="images/email.png" /></td>
		</tr>
		<tr>
			<td>Hedge Shears</td>
			<td>$32/pc</td>
			<td>460pc</td>
			<td>Shears Pte. Ltd.</td>
			<td>Himatnagar</td>
			<td><img src="images/email.png" /></td>
		</tr>
		</table>
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
</body>
</html>
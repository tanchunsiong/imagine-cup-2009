<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="knowledgebase.aspx.cs" Inherits="WebService1.knowledgebase" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
	<title>SmartFarm&trade; - I'm a PC</title>
	<script src="javascripts/jquery-1.3.2.min.js" type="text/javascript"></script>
	<script src="javascripts/jquery.sparkline.min.js" type="text/javascript"></script>
	<script src="javascripts/jgcharts.js" type="text/javascript"></script>
	<script src="javascripts/thickbox-compressed.js" type="text/javascript"></script>
	
	<link href="styles/thickbox.css" rel="stylesheet" type="text/css">
	<link href="styles/style.css" rel="stylesheet" type="text/css">
	
	<script type="text/javascript">
	$(document).ready(function(){
		
		/*$('.composite').sparkline('html', {type: 'bar', barColor: '#aaf'} );*/
		$('.composite').sparkline('html', {composite: true, fillColor: false, lineColor: 'blue', width: '80px'} );
	
		var api = new jGCharts.Api(); 
		jQuery('<img>') 
		.attr('src', api.make({
		legend: ['Price'],
		size : '400x160', 
		data : [10.5,11.1,11.5,11.3,11.3,11.8,10.5,10.0,10.8,11.9,11.3,11.2,11.1,10.6,11.4,11.3,11.5,10.4,10.4,10.0,10.8,10.7,10.1,11.7,11.5,11.5,10.8,10.6,11.7,11.1],  
		type : 'lc'}
		)) 
		.appendTo("#owncrop");
		
		/* Search */
		
		$("input#suggest").focus(function(){
			$(this).val("");
		});
		
		$("input#suggest").blur(function(){
			if($(this).val() == ""){
				$(this).val("<enter crop name>");
			}
		});
		
		$("input#search").click(function(){
			$("#iframe_content").attr("src", "http://en.wikipedia.org/wiki/" + $("input#suggest").val());
		});
	});
	</script>
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
		<li><a href="knowledgebase.aspx" id="nav_selected">Knowledgebase</a></li>
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
		<td>
		<h2>Knowledgebase</h2>
		<p style="background-color: #ffc; padding: 10px 15px; margin-bottom: 25px;">
			<input size="45" id="suggest" value="<enter crop name>"> 
			<input type="button" alt="#TB_inline?height=510&amp;width=700&amp;inlineId=myOnPageContent" class="thickbox" id="search" 
			title="Wikipedia" value="search" /></p>
		
		<div id="myOnPageContent" style="display: none;">
		<iframe id="iframe_content" width="700" height="500" frameborder="0" style="margin:0; padding:0;">
		  <p>Your browser does not support iframes.</p>
		</iframe>
		</div>
		
		<h3>Top 10 searched crops</h3>
		<table id="top10">
		<tr>
			<td class="top10_num">1.</td>
			<td class="top10_img"><img src="images/icons/corn.jpg" style="width: 40px" /></td>
			<td class="top10_title">Corn</td>
			<td></td>
			<td class="top10_num">6.</td>
			<td class="top10_img"><img src="images/icons/lentils.jpg" style="width: 40px" /></td>
			<td class="top10_title">Lentils</td>
		</tr>
		<tr>
			<td class="top10_num">2.</td>
			<td class="top10_img"><img src="images/icons/barley.jpg" style="width: 40px" /></td>
			<td class="top10_title">Barley</td>
			<td></td>
			<td class="top10_num">7.</td>
			<td class="top10_img"><img src="images/icons/wheat.jpg" style="width: 40px" /></td>
			<td class="top10_title">Wheat</td>
		</tr>
		<tr>
			<td class="top10_num">3.</td>
			<td class="top10_img"><img src="images/icons/millet.jpg" style="width: 40px" /></td>
			<td class="top10_title">Millet</td>
			<td></td>
			<td class="top10_num">8.</td>
			<td class="top10_img"><img src="images/icons/drypeas.jpg" style="width: 40px" /></td>
			<td class="top10_title">Dry Peas</td>
		</tr>
		<tr>
			<td class="top10_num">4.</td>
			<td class="top10_img"><img src="images/icons/beans.jpg" style="width: 40px" /></td>
			<td class="top10_title">Beans</td>
			<td></td>
			<td class="top10_num">9.</td>
			<td class="top10_img"><img src="images/icons/potato.jpg" style="width: 40px" /></td>
			<td class="top10_title">Potato</td>
		</tr>
		<tr>
			<td class="top10_num">5.</td>
			<td class="top10_img"><img src="images/icons/tomato.jpg" style="width: 40px" /></td>
			<td class="top10_title">Tomato</td>
			<td></td>
			<td class="top10_num">10.</td>
			<td class="top10_img"><img src="images/icons/chili.jpg" style="width: 40px" /></td>
			<td class="top10_title">Chili</td>
		</tr>		
		</table>
				
		</td>
		<td width="35%">
		<h2>Recommendation</h2>
		<img src="images/corn.jpg" alt="corn" style="width:280px"/>
		
		<p>We recommends you to plan <strong>Corn</strong> based on the statistics and data collected by the system.</p>
		<p>For more information, please click 
			<a href="http://en.wikipedia.org/wiki/Maize" title="Corn">here</a>.</p>
		<p>Alternatively, you can try...</p>
		<ol>
			<li><a href="http://en.wikipedia.org/wiki/Barley" title="Barley">Barley</a></li>
			<li><a href="http://en.wikipedia.org/wiki/Wheat" title="Wheat">Wheat</a></li>
			<li><a href="http://en.wikipedia.org/wiki/Cotton" title="Cotton">Cotton</a></li>
		</ol>
		
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
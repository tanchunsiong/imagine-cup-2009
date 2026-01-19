<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
	<title>SmartFarm&trade; - I'm a PC</title>
	<script src="javascripts/jquery-1.3.2.min.js" type="text/javascript"></script>
	<script src="javascripts/jquery.sparkline.min.js" type="text/javascript"></script>
	<script src="javascripts/jgcharts.js" type="text/javascript"></script>
	<link href="styles/style.css" rel="stylesheet" type="text/css">
	
	<script type="text/javascript">
	$(document).ready(function(){
		
		/*$('.composite').sparkline('html', {type: 'bar', barColor: '#aaf'} );*/
		$('.composite').sparkline('html', {composite: true, fillColor: false, lineColor: 'blue', width: '80px'} );
	
		var api = new jGCharts.Api(); 
		jQuery('<img>') 
		.attr('src', api.make({
			size : '400x160', 
			data : [[18.71,24.86,40.41,56.04,81.59,33.83,12.87,22.33,12.49,15.18],[11.89,35.40,44.55,58.40,78.20,28.44,13.89,23.95,12.66,17.67],[14.68,24.80,51.00,57.17,78.54,26.29,13.47,24.56,12.46,15.30],[19.49,32.01,49.97,59.18,86.34,46.34,12.91,24.64,12.98,16.06],[17.01,28.27,48.85,55.72,82.93,37.08,13.72,23.69,12.11,12.88],[10.09,38.19,48.56,59.72,82.72,48.20,13.77,24.58,12.84,16.55],[12.55,30.72,43.23,56.35,87.47,25.06,13.53,24.93,12.68,13.11],[18.91,27.28,43.46,57.37,79.72,48.12,12.35,22.51,12.67,14.30],[18.68,38.66,53.31,57.19,84.57,30.77,12.23,24.36,12.30,12.21],[14.90,24.45,53.24,58.36,77.46,38.85,12.67,24.98,12.88,11.85],[10.69,35.34,54.97,59.86,85.32,34.36,12.66,22.68,12.11,16.03],[14.80,34.65,44.33,55.03,78.70,54.32,12.43,24.88,12.59,12.40],[10.41,39.51,43.99,57.44,82.81,53.55,12.15,24.13,12.83,15.06],[13.06,21.47,41.40,57.14,75.17,25.36,13.06,22.93,12.93,16.36],[17.27,31.19,43.50,58.39,84.44,50.66,12.61,22.11,12.35,15.44],[18.45,30.64,50.13,58.75,78.82,26.36,13.49,24.72,12.59,13.36],[15.57,22.02,48.81,55.03,77.15,44.74,13.81,22.98,12.19,13.99],[15.08,32.09,48.37,57.45,75.23,48.36,12.84,22.14,12.39,13.34],[13.22,36.02,52.55,55.42,87.45,43.54,13.69,22.70,12.94,16.26],[17.82,38.68,41.60,58.08,79.27,36.06,12.20,22.75,12.86,11.99],[12.11,37.01,47.17,59.43,81.58,48.82,13.29,23.25,12.42,15.96],[19.49,22.59,53.12,58.12,83.81,50.23,13.47,24.77,12.38,17.99],[13.30,30.04,52.31,55.99,82.40,37.61,12.83,22.76,12.28,14.79],[19.59,37.08,51.58,55.33,79.06,51.67,13.43,23.55,12.25,11.79],[15.71,36.86,54.54,55.22,81.27,53.21,13.94,22.99,12.97,15.97],[19.09,30.60,40.67,56.31,81.33,35.30,12.49,23.05,12.27,14.48],[11.00,26.27,54.02,59.87,86.24,47.81,13.61,23.76,12.06,12.66],[10.19,31.80,51.59,55.21,84.92,49.14,13.61,23.89,12.05,13.18],[13.76,29.27,54.51,57.41,78.14,33.80,13.15,23.93,12.13,15.87],[16.29,20.30,53.18,56.47,77.78,44.98,13.97,23.53,12.56,14.05]],  
			type : 'lc'})
		) 
		.appendTo("div#owncrop");
	});
	</script>
</head>

<body >
<form runat="server">
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
		<li><a href="marketinfo.aspx" id="nav_selected">Market Info</a></li>
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
		<h2>Region Market Map</h2>
		<div id="theMap" 
        style="position: relative; width: 100%; height: 400px;margin:0 auto "> </div> 
             

      
            
            <asp:ScriptManager ID="sm" runat="server">
        <Scripts>
            <asp:ScriptReference Path="http://dev.virtualearth.net/mapcontrol/mapcontrol.ashx?v=6.2" ScriptMode="Release" />
            <asp:ScriptReference Path="~/JS/Default.aspx.js" />
          
        </Scripts>
    </asp:ScriptManager>
     <script type="text/javascript">
         setTimeout("drawMarketBoundary()", 500);
        </script>
		</td>
	</tr>
	
	<tr>
		<td>
		<h2>World Crop Prices</h2>
		
		<table class="layout">
		<tr>
			<td>
				<table class="market_prices">
				<tr>
					<th>Crops</th>
					<th>Price</th>
					<th>+/-</th>
				</tr>
				<tr>
					<td>Millet</td>
					<td><span class="composite">18.71,11.89,14.68,19.49,17.01,10.09,12.55,18.91,18.68,14.90,10.69,14.80,10.41,13.06,17.27,18.45,15.57,15.08,13.22,17.82,12.11,19.49,13.30,19.59,15.71,19.09,11.00,10.19,13.76,16.29</span></td>
					<td><img src="images/add.png"></td>
				</tr>
				<tr>
					<td>Barley</td>
					<td><span class="composite">24.86,35.40,24.80,32.01,28.27,38.19,30.72,27.28,38.66,24.45,35.34,34.65,39.51,21.47,31.19,30.64,22.02,32.09,36.02,38.68,37.01,22.59,30.04,37.08,36.86,30.60,26.27,31.80,29.27,20.30</span></td>
					<td><img src="images/delete.png"></td>
				</tr>
				<tr>
					<td>Beans</td>
					<td><span class="composite">40.41,44.55,51.00,49.97,48.85,48.56,43.23,43.46,53.31,53.24,54.97,44.33,43.99,41.40,43.50,50.13,48.81,48.37,52.55,41.60,47.17,53.12,52.31,51.58,54.54,40.67,54.02,51.59,54.51,53.18</span></td>
					<td><img src="images/delete.png"></td>
				</tr>
				<tr>
					<td>Potato</td>
					<td><span class="composite">56.04,58.40,57.17,59.18,55.72,59.72,56.35,57.37,57.19,58.36,59.86,55.03,57.44,57.14,58.39,58.75,55.03,57.45,55.42,58.08,59.43,58.12,55.99,55.33,55.22,56.31,59.87,55.21,57.41,56.47</span></td>
					<td><img src="images/delete.png"></td>
				</tr>
				<tr>
					<td>Chili</td>
					<td><span class="composite">81.59,78.20,78.54,86.34,82.93,82.72,87.47,79.72,84.57,77.46,85.32,78.70,82.81,75.17,84.44,78.82,77.15,75.23,87.45,79.27,81.58,83.81,82.40,79.06,81.27,81.33,86.24,84.92,76.14,77.78</span></td>
					<td><img src="images/add.png"></td>
				</tr>
				</table>
			</td>
			<td>
				<table class="market_prices">
				<tr>
					<th>Crops</th>
					<th>Price</th>
					<th>+/-</th>
				</tr>
				<tr>
					<td>Wheat</td>
					<td><span class="composite">33.83,28.44,26.29,46.34,37.08,48.20,25.06,48.12,30.77,38.85,34.36,54.32,53.55,25.36,50.66,26.36,44.74,48.36,43.54,36.06,48.82,50.23,37.61,51.67,53.21,35.30,47.81,49.14,33.82,44.98</span></td>
					<td><img src="images/add.png"></td>
				</tr>
				<tr>
					<td>Tomato</td>
					<td><span class="composite">12.87,13.89,13.47,12.91,13.72,13.77,13.53,12.35,12.23,12.67,12.66,12.43,12.15,13.06,12.61,13.49,13.81,12.84,13.69,12.20,13.29,13.47,12.83,13.43,13.94,12.49,13.61,13.61,13.15,13.97</span></td>
					<td><img src="images/add.png"></td>
				</tr>
				<tr>
					<td>Corn (Maize)</td>
					<td><span class="composite">22.33,23.95,24.56,24.64,23.69,24.58,24.93,22.51,24.36,24.98,22.68,24.88,24.13,22.93,22.11,24.72,22.98,22.14,22.70,22.75,23.25,24.77,22.76,23.55,22.99,23.05,23.76,23.89,23.93,23.53</span></td>
					<td><img src="images/delete.png"></td>
				</tr>
				<tr>
					<td>Dry Peas</td>
					<td><span class="composite">12.49,12.66,12.46,12.98,12.11,12.84,12.68,12.67,12.30,12.88,12.11,12.59,12.83,12.93,12.35,12.59,12.19,12.39,12.94,12.86,12.42,12.38,12.28,12.25,12.97,12.27,12.06,12.05,12.13,12.56</span></td>
					<td><img src="images/add.png"></td>
				</tr>
				<tr>
					<td>Lentils</td>
					<td><span class="composite">15.18,17.67,15.30,16.06,12.88,16.55,13.11,14.30,12.21,11.85,16.03,12.40,15.06,16.36,15.44,13.36,13.99,13.34,16.26,11.99,15.96,17.99,14.79,11.79,15.97,14.48,12.66,13.18,15.87,14.05</span></td>
					<td><img src="images/delete.png"></td>
				</tr>
				</table>
			</td>
		</tr>
		</table>
		</td>
		
		<td width="50%">
		<h2>Corn (Maize) Market</h2>
		<div id="owncrop"></div>
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
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="alert.aspx.cs" Inherits="WebService1.alert" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
	<title>SmartFarm&trade; - I'm a PC</title>
	<link href="styles/style.css" rel="stylesheet" type="text/css">
	<script src="javascripts/jquery-1.3.2.min.js" type="text/javascript"></script>
	<script src="javascripts/jquery.iphone-switch.js" type="text/javascript"></script>
	<script src="javascripts/jquery.sparkline.min.js" type="text/javascript"></script>
	<!--<script src="javascripts/jquery.coda-popup.js" type="text/javascript"></script>-->
	<script src="javascripts/jgcharts.js" type="text/javascript"></script>
	<script type="text/javascript">
	$(document).ready(function(){
		
		/*$('.composite').sparkline('html', {type: 'bar', barColor: '#aaf'} );*/
		$('.composite').sparkline('html', {composite: true, fillColor: false, lineColor: 'blue', width: '330px'} );
	
		var api = new jGCharts.Api(); 
		
		// Temperature
		jQuery('<img>') 
		.attr('src', api.make({
		legend: ['Temperature'],
		size : '400x160', 
		data : [27.37,29.19,31.45,29.71,34.31,27.34,33.71,32.55,29.49,33.25,28.67,28.16,28.03,28.05,25.07,26.36,30.16,27.83,32.41,25.51,26.16,31.03,34.10,25.53,26.48,31.97,34.04,32.50,31.46,33.73],  
		type : 'lc'}
		)) 
		.appendTo("#graph_temperature");
		
		// Pressure
		jQuery('<img>') 
		.attr('src', api.make({
		legend: ['Pressure'],
		size : '400x160', 
		data : [10.5,11.1,11.5,11.3,11.3,11.8,10.5,10.0,10.8,11.9,11.3,11.2,11.1,10.6,11.4,11.3,11.5,10.4,10.4,10.0,10.8,10.7,10.1,11.7,11.5,11.5,10.8,10.6,11.7,11.1],  
		type : 'lc'}
		)) 
		.appendTo("#graph_pressure");
		
		
		// Humidity
		jQuery('<img>') 
		.attr('src', api.make({
		legend: ['Humidity'],
		size : '400x160', 
		data : [98.50,98.01,98.68,98.07,99.02,97.04,99.78,97.55,97.25,99.88,99.03,98.54,99.77,99.12,99.56,99.01,98.23,98.01,97.44,97.54,99.90,97.15,98.49,97.33,98.47,99.93,99.86,99.26,97.18,98.07],  
		type : 'lc'}
		)) 
		.appendTo("#graph_humidity");
		
		
		// Wind Strength
		jQuery('<img>') 
		.attr('src', api.make({
		legend: ['Wind Strength'],
		size : '400x160', 
		data : [19.84,18.05,8.206,12.34,8.066,6.375,7.082,9.914,19.86,10.46,8.529,18.90,9.752,9.800,10.65,10.44,13.07,16.41,6.066,7.238,12.95,19.24,11.29,10.39,15.14,13.86,16.35,19.60,7.423,11.31],  
		type : 'lc'}
		)) 
		.appendTo("#graph_wind_strength");
		
		
		// Haze Level
		jQuery('<img>') 
		.attr('src', api.make({
		legend: ['Haze Level'],
		size : '400x160', 
		data : [5.447,5.286,6.797,5.680,6.932,5.357,6.305,5.280,6.067,5.920,5.901,5.528,6.492,5.321,5.450,5.578,6.891,5.454,5.943,6.881,6.565,6.915,5.724,5.485,5.932,5.022,6.314,6.961,6.774,6.851],  
		type : 'lc'}
		)) 
		.appendTo("#graph_haze_level");
		
		
		// Water Pollution
		jQuery('<img>') 
		.attr('src', api.make({
		legend: ['Water Pollution'],
		size : '400x160', 
		data : [33.83,28.44,26.29,62.53,46.34,14.63,59.61,11.74,37.08,6.991,7.078,48.20,15.29,9.534,25.06,48.12,7.473,77.93,18.99,74.21,23.28,78.56,10.79,3.301,77.03,30.77,11.38,38.85,17.21,78.84],  
		type : 'lc'}
		)) 
		.appendTo("#graph_water_pollution");
		
		
		// Rainfall
		jQuery('<img>') 
		.attr('src', api.make({
		legend: ['Rainfall'],
		size : '400x160', 
		data : [86.07,83.88,80.22,71.98,71.22,75.73,77.74,71.53,83.96,70.99,73.77,73.29,71.03,83.32,70.96,80.65,85.32,77.70,76.82,80.61,74.26,84.10,74.52,86.84,76.00,77.24,77.50,87.57,70.79,82.07],  
		type : 'lc'}
		)) 
		.appendTo("#graph_rainfall");
		
		
		
		
		$(function () {
		  $('.bubbleInfo').each(function () {
		    // options
		    var distance = 10;
		    var time = 250;
		    var hideDelay = 150;
		
		    var hideDelayTimer = null;
		
		    // tracker
		    var beingShown = false;
		    var shown = false;
		    
		    var trigger = $('.trigger', this);
		    var popup = $('.popup', this).css('opacity', 0);
		
		    // set the mouseover and mouseout on both element
		    $([trigger.get(0), popup.get(0)]).mouseover(function (e) {
		      // stops the hide event if we move from the trigger to the popup element
		      if (hideDelayTimer) clearTimeout(hideDelayTimer);
		
		      // don't trigger the animation again if we're being shown, or already visible
		      if (beingShown || shown) {
		        return;
		      } else {
		        beingShown = true;
		
		        // reset position of popup box
		        popup.css({
		          top: 0,
		          left: 360,
		          display: 'block' // brings the popup back in to view
		          
		        })
		
		        // (we're using chaining on the popup) now animate it's opacity and position
		        .animate({
		          top: '-=' + distance + 'px',
		          opacity: 1
		        }, time, 'swing', function() {
		          // once the animation is complete, set the tracker variables
		          beingShown = false;
		          shown = true;
		        });
		      }
		    }).mouseout(function () {
		      // reset the timer if we get fired again - avoids double animations
		      if (hideDelayTimer) clearTimeout(hideDelayTimer);
		      
		      // store the timer so that it can be cleared in the mouseover if required
		      hideDelayTimer = setTimeout(function () {
		        hideDelayTimer = null;
		        popup.animate({
		          top: '-=' + distance + 'px',
		          opacity: 0
		        }, time, 'swing', function () {
		          // once the animate is complete, set the tracker variables
		          shown = false;
		          // hide the popup entirely after the effect (opacity alone doesn't do the job)
		          popup.css('display', 'none');
		        });
		      }, hideDelay);
		    });
		  });
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
		<li><a href="alert.aspx" id="nav_selected">Alert System</a></li>
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
		<div id="area">
		Area: 
		<select>
			<option>Corn 1</option>
			<option>Corn 2</option>
			<option>Corn 3</option>
			<option>Corn 4</option>
		</select>
		</div>
		
		<h2>Alert System</h2>
		
		<table id="alert_system">
		<tr>
			<th>Types</th>
			<th>History</th>
			<th>Average</th>
			<th>Low</th>
			<th>High</th>
			<th width="94px">Status</th>
		</tr>
		<tr>
			<td>Temperature</td>
			<td>
				<div class="bubbleInfo">
				<span class="trigger composite">27.37,29.19,31.45,29.71,34.31,27.34,33.71,32.55,29.49,33.25,28.67,28.16,28.03,28.05,25.07,26.36,30.16,27.83,32.41,25.51,26.16,31.03,34.10,25.53,26.48,31.97,34.04,32.50,31.46,33.73</span>
					<div class="popup">
						<div class="graph_title">Graph of Temperature over last 30 days</div>
				  		<div id="graph_temperature"></div>
					</div>
				</div>
			</td>
			<td>30 Celcius</td>
			<td class="low"><input type="text" value="26" /> Celcius</td>
			<td class="high"><input type="text" value="40" /> Celcius</td>
			<td>
			<div class="switch_default_on">	 
			</div>
			</td>
		</tr>
		<tr>
			<td>Pressure</td>
			<td>
				<div class="bubbleInfo">
				<span class="trigger composite">77.16,94.38,98.97,70.42,70.17,94.97,79.79,79.37,82.30,88.64,71.67,99.18,80.63,85.87,99.37,94.98,97.36,99.78,87.58,79.61,95.59,77.42,94.76,83.65,85.64,77.37,88.62,87.29,75.29,85.11</span>
					<div class="popup">
						<div class="graph_title">Graph of Temperature over last 30 days</div>
						<div id="graph_pressure"></div>
					</div>
				</div>
			</td>
			<td>30 Pascal</td>
			<td class="low"><input type="text" value="26" /> Pascal</td>
			<td class="high"><input type="text" value="40" /> Pascal</td>
			<td>
			<div class="switch_default_on">	 
			</div>
			</td>
		</tr>
		<tr>
			<td>Humidity</td>
			<td>
				<div class="bubbleInfo">
				<span class="trigger composite">98.50,98.01,98.68,98.07,99.02,97.04,99.78,97.55,97.25,99.88,99.03,98.54,99.77,99.12,99.56,99.01,98.23,98.01,97.44,97.54,99.90,97.15,98.49,97.33,98.47,99.93,99.86,99.26,97.18,98.07</span>
					<div class="popup">
						<div class="graph_title">Graph of Humidity over last 30 days</div>
						<div id="graph_humidity"></div>
					</div>
				</div>
			</td>
			<td>30 %</td>
			<td class="low"><input type="text" value="26" /> %</td>
			<td class="high"><input type="text" value="40" /> %</td>
			<td>
			<div class="switch_default_on">	 
			</div>
			</td>
		</tr>
		<tr>
			<td>Wind Strength</td>
			<td>
				<div class="bubbleInfo">
				<span class="trigger composite">19.84,18.05,8.206,12.34,8.066,6.375,7.082,9.914,19.86,10.46,8.529,18.90,9.752,9.800,10.65,10.44,13.07,16.41,6.066,7.238,12.95,19.24,11.29,10.39,15.14,13.86,16.35,19.60,7.423,11.31</span>
					<div class="popup">
						<div class="graph_title">Graph of Wind Strength over last 30 days</div>
						<div id="graph_wind_strength"></div>
					</div>
				</div>
			</td>
			<td>30 km/h</td>
			<td class="low"><input type="text" value="26" /> km/h</td>
			<td class="high"><input type="text" value="40" /> km/h</td>
			<td>
			<div class="switch_default_on">	 
			</div>
			</td>
		</tr>
		<tr>
			<td>Haze Level</td>
			<td>
				<div class="bubbleInfo">
				<span class="trigger composite">5.447,5.286,6.797,5.680,6.932,5.357,6.305,5.280,6.067,5.920,5.901,5.528,6.492,5.321,5.450,5.578,6.891,5.454,5.943,6.881,6.565,6.915,5.724,5.485,5.932,5.022,6.314,6.961,6.774,6.851</span>
					<div class="popup">
						<div class="graph_title">Graph of Haze Level over last 30 days</div>
						<div id="graph_haze_level"></div>
					</div>
				</div>
			</td>
			<td>30 PSI</td>
			<td class="low"><input type="text" value="26" /> PSI</td>
			<td class="high"><input type="text" value="40" /> PSI</td>
			<td>
			<div class="switch_default_on">	 
			</div>
			</td>
		</tr>
		<tr>
			<td>Water Pollution</td>
			<td>
				<div class="bubbleInfo">
				<span class="trigger composite">33.83,28.44,26.29,62.53,46.34,14.63,59.61,11.74,37.08,6.991,7.078,48.20,15.29,9.534,25.06,48.12,7.473,77.93,18.99,74.21,23.28,78.56,10.79,3.301,77.03,30.77,11.38,38.85,17.21,78.84</span>
					<div class="popup">
						<div class="graph_title">Graph of Water Pollution over last 30 days</div>
						<div id="graph_water_pollution"></div>
					</div>
				</div>
			</td>
			<td>30 index</td>
			<td class="low"><input type="text" value="26" /> index</td>
			<td class="high"><input type="text" value="40" /> index</td>
			<td>
			<div class="switch_default_on">	 
			</div>
			</td>
		</tr>
		<tr>
			<td>Rainfall</td>
			<td>
				<div class="bubbleInfo">
				<span class="trigger composite">86.07,83.88,80.22,71.98,71.22,75.73,77.74,71.53,83.96,70.99,73.77,73.29,71.03,83.32,70.96,80.65,85.32,77.70,76.82,80.61,74.26,84.10,74.52,86.84,76.00,77.24,77.50,87.57,70.79,82.07</span>
					<div class="popup">
						<div class="graph_title">Graph of Rainfall over last 30 days</div>
						<div id="graph_rainfall"></div>
					</div>
				</div>
			</td>
			<td>30 mm</td>
			<td class="low"><input type="text" value="26" /> mm</td>
			<td class="high"><input type="text" value="40" /> mm</td>
			<td>
			<div class="switch_default_on">	 
			</div>
			</td>
		</tr>
		</table>
		</td>
	</tr>
	</table>
	</div>	
</div>

<script type="text/javascript">
		$('.switch_default_on').iphoneSwitch("on", 
	      function() {
	        
	      },
	      function() {
	        
	      });
	   $('.switch_default_off').iphoneSwitch("off", 
	      function() {
	        
	      },
	      function() {
	        
	      });   
</script>
	
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
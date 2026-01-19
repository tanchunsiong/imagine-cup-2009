<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="settings.aspx.cs" Inherits="WebService1.settings" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
	<title>Farmer Monitoring Center - I'm a PC</title>
	<link href="styles/style.css" rel="stylesheet" type="text/css">
</head>

<body>
<div id="header">
	<div class="container">
	<div id="greetings">Welcome, <strong>mickeyckm</strong> <span style="font-size: 12px">(<a id="logout" href="#">logout</a>)</span></div>
	Farmer Monitoring Center
	</div>
</div>

<div id="navbar">
	<div class="container">
	<ul id="nav">
		<li><a href="index.aspx">Dashboard</a></li>
		<li><a href="alert.aspx">Alert System</a></li>
		<li><a href="knowledgebase.aspx">Knowledgebase</a></li>
		<li><a href="marketplace.aspx">Marketplace</a></li>
		<li><a href="settings.aspx" id="nav_selected">Settings</a></li>
		<div style="clear: both"></div>
	</ul>
	</div>
</div>
	
<div id="content">
	<div class="container">
	<table class="layout">
	<tr>
		<td>
		<h2>Control Settings</h2>
		
		<table>
		<tr>
			<th>Username:</th>
			<td>mickeyckm</td>
		</tr>
		<tr>
			<th>Password:</th>
			<td></td>
		</tr>
		</table>	
		</td>
	</tr>
	</table>
	</div>	
</div>
	
<div id="footer">
	<div class="container">
	&copy; 2009 I'm a PC. All Rights Reserved.
	</div>
</div>
</body>
</html>
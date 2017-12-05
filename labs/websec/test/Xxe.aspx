<%@ Page Language="C#" Inherits="test.Xxe" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" lang="en-US"><head>
	<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
	<title>Document signature</title>
	<link rel="stylesheet" id="wp-admin-css" href="Wordpress.aspx_files/wp-admin.css" type="text/css" media="all">
<link rel="stylesheet" id="colors-fresh-css" href="Wordpress.aspx_files/colors-fresh.css" type="text/css" media="all">
<meta name="robots" content="noindex,nofollow">
	</head>
	<body class="login">
	<div id="login">
		<h1><center>DocSign</center></h1></h1><br/>


<form name="loginform" id="loginform" action="" method="POST">
		<textarea name="xml" id="user_login" class="input" style="display:none"><?xml version="1.0"?><signDoc>Dolor sit amet</signDoc></textarea>

	<tt>Dolor sit amet, consectetur adipiscing elit. Etiam at nisl gravida, dapibus quam ut, dapibus lorem. Cras nec cursus metus. Aliquam euismod neque elit, ut accumsan diam viverra eget. Fusce dolor augue, ultrices vitae lectus sit amet, luctus lobortis libero.<br/><br/><br/></tt>

	<p>
	</p>
	<p class="forgetmenot"></p>
	<p class="submit">
		<input name="wp-submit" id="wp-submit" class="button-primary" value="Sign the document" tabindex="100" type="submit">
		<input name="redirect_to" value="http://wordpress.org/wp-admin/" type="hidden">
		<input name="testcookie" value="1" type="hidden">
			<%
Response.Write(getPage());
    %>
	</p>
</form>

	
		<div class="clear"></div>
	
	
	</body></html>
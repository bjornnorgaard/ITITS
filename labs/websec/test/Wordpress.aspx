﻿<%@ Page Language="C#" Inherits="test.Wordpress2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" lang="en-US"><head>
	<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
	<title>WordPress.org › Log In</title>
	<link rel="stylesheet" id="wp-admin-css" href="Wordpress.aspx_files/wp-admin.css" type="text/css" media="all">
<link rel="stylesheet" id="colors-fresh-css" href="Wordpress.aspx_files/colors-fresh.css" type="text/css" media="all">
<meta name="robots" content="noindex,nofollow">
	</head>
	<body class="login">
	<div id="login">
		<h1><a href="http://wordpress.org/" title="WordPress.org">WordPress.org</a></h1>
	<%
Response.Write(getPage());
    %>

<form name="loginform" id="loginform" action="" method="get">
	<p>
		<label for="user_login">Username<br>
		<input name="username" id="user_login" class="input" size="20" tabindex="10" type="text"></label>
	</p>
	<p>
		<label for="user_pass">Password<br>
		<input name="pwd" id="user_pass" class="input" value="" size="20" tabindex="20" type="password"></label>
	</p>
	<p class="forgetmenot"><label for="rememberme"><input name="rememberme" id="rememberme" value="forever" tabindex="90" type="checkbox"> Remember Me</label></p>
	<p class="submit">
		<input name="wp-submit" id="wp-submit" class="button-primary" value="Log In" tabindex="100" type="submit">
		<input name="redirect_to" value="http://wordpress.org/wp-admin/" type="hidden">
		<input name="testcookie" value="1" type="hidden">
	</p>
</form>

<p id="nav">
<a href="http://wordpress.org/wp-login.php?action=lostpassword" title="Password Lost and Found">Lost your password?</a>
</p>

<script type="text/javascript">
    function wp_attempt_focus() {
        setTimeout(function () {
            try {
                d = document.getElementById('user_login');
                d.focus();
                d.select();
            } catch (e) { }
        }, 200);
    }

    wp_attempt_focus();
    if (typeof wpOnload == 'function') wpOnload();
</script>

	<p id="backtoblog"><a href="http://wordpress.org/" title="Are you lost?">← Back to WordPress.org</a></p>
	</div>

	
		<div class="clear"></div>
	
	
	</body></html>
<html>
<head>
<title>Sikkerhed i Web-Applikationer</title>
<style>
body {font-family: arial;}
h2 { padding-bottom: 0px; margin-bottom: 0px;}
a { color: blue; }
</style>
</head>
<body>
<%@ Page Language="C#" %>
<%
if(Request["txt"] != null) {
Session["name"] = Request["txt"];
}
 %>
<h1>Please Log In</h1>
<form action=success.aspx method=post>
<table><tr><td>Username:</td><td><input type="text" id="txt" name="txt" value="" style="width:150px"/></td></tr><tr>
<td>Password:</td><td><input type="password" id="Text1" name="txt" value="" style="width:150px"/></td></tr></table>

<input type=submit value="Log in" /></form>
</body>

</html>
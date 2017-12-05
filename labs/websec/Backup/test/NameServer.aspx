<%@ Page Language="C#" validateRequest="false"%>
<%
if(Request["txt"] != null) {
Session["name"] = Request["txt"];
}
 %>
<html>
 <head><style>
body {font-family: arial;}
h2 { padding-bottom: 0px; margin-bottom: 0px;}
a { color: blue; }
</style>
</head>
<body>
<h1>DNS Manager</h1>
<h2>Change NameServer Records</h2>
<form action=NameServer.aspx method=post>
TXT Record: <input type="text" id="txt" name="txt" value="" style="width:500px"/><br />

<input type=submit value="Save Record" /></form>

 </body>
 </html>
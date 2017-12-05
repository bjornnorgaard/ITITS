<%@ Page Language="C#" Inherits="test.Clickjackingdeleted" %>
<% Response.AddHeader("Content-Security-Policy", "frame-ancestors 'none'");%> 
<img src="deletemessage.jpg" onclick="alert('All messages have been deleted')">
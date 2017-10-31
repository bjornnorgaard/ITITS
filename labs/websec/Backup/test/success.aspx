<%@ Page Language="C#" %>
<%
if(Request["txt"] != null) {
Session["name"] = Request["txt"];
}
 %>
<h1>Welcome</h1>
You are now logged in.
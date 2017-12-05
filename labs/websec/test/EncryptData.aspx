<%@ Page Language="C#" Inherits="test.EncryptData" %>
<!DOCTYPE html>
<html lang="en">    <meta charset="utf-8">
    <title>Encrypted Data</title>
    


  <body>
    <% if (Request["input"] != null)
        {
           Store(Protect(Request["input"]));
        } %>
    <% if (Request["id"] != null)
        {
            Response.Write(Unprotect(Fetch(Request["id"])));
        } %>
      <form><input type="text" name="input" /><input type="submit" value="Store" /></form>
  </body></html>
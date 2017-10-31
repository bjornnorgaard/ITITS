<%@ Page Language="C#" Inherits="test.HashData" %>
<!DOCTYPE html>
<html lang="en">    <meta charset="utf-8">
    <title>Hash Data</title>
    


  <body>
    <% if (Request["input"] != null)
        {
           Store(Hash(Request["input"]));
        } %>
    
      <form><input type="text" name="input" /><input type="submit" value="Hash" /></form>
  </body></html>
<%@ Page Language="C#" Inherits="test.Default" %>
<% if(Request.Url.Host == "www.googleanalytics.com") Response.Redirect("http://www.googleanalytics.com:51091/Analytics.aspx?id=1"); %>
<% if(Request.Url.Host == "www.scepticalcustomer.com") Response.Redirect("http://www.scepticalcustomer.com:51091/Wordpress.aspx"); %>

<!DOCTYPE html>
<html lang="en"><script type="text/javascript">                    window["_gaUserPrefs"] = { ioo: function () { return true; } }</script><head><meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta charset="utf-8">
    <title>A Bank</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="">

    <!-- Le styles -->
    <link href="bootstrap.css" rel="stylesheet">
    <style type="text/css">
      body {
        padding-top: 60px;
        padding-bottom: 40px;
      }
    </style>
    

    <!-- Le HTML5 shim, for IE6-8 support of HTML5 elements -->
    <!--[if lt IE 9]>
      <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
    <![endif]-->

    <!-- Le fav and touch icons -->
    <link rel="shortcut icon" href="http://twitter.github.com/bootstrap/assets/ico/favicon.ico">
    <link rel="apple-touch-icon-precomposed" sizes="144x144" href="http://twitter.github.com/bootstrap/assets/ico/apple-touch-icon-144-precomposed.png">
    <link rel="apple-touch-icon-precomposed" sizes="114x114" href="http://twitter.github.com/bootstrap/assets/ico/apple-touch-icon-114-precomposed.png">
    <link rel="apple-touch-icon-precomposed" sizes="72x72" href="http://twitter.github.com/bootstrap/assets/ico/apple-touch-icon-72-precomposed.png">
    <link rel="apple-touch-icon-precomposed" href="http://twitter.github.com/bootstrap/assets/ico/apple-touch-icon-57-precomposed.png">
  <link rel="stylesheet" type="text/css" href="chrome-extension://cgndfbhngibokieehnjhbjkkhbfmhojo/css/validation.css"></head>

  <body>

    <div class="navbar navbar-fixed-top">
      <div class="navbar-inner">
        <div class="container">
          <a class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse">
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
          </a>
          <a class="brand" href="http://twitter.github.com/bootstrap/examples/hero.html#">A Bank</a>
          <div class="nav-collapse">
            <div style="float:left"><ul class="nav">
              <li class="active"><a href="http://twitter.github.com/bootstrap/examples/hero.html#">Home</a></li>
              <li><a href="http://twitter.github.com/bootstrap/examples/hero.html#about">About</a></li>
              <li><a href="http://twitter.github.com/bootstrap/examples/hero.html#contact">Contact</a></li>
            </ul></div><div style="float:right" id="language" name="language"><a href="?lang=en" style="color:white">ENGLISH</a><% if(Request.QueryString.Count == 0 && Request.Form.Count == 0) { %><script src="flag.js"></script><% } %></div>
          </div><!--/.nav-collapse -->
        </div>
      </div>
    </div>

    <div class="container">

      <!-- Main hero unit for a primary marketing message or call to action -->

      <div class="hero-unit <%=GetLang() %>">
        <div style="float:left"><h1>Welcome!</h1>
        <p>This is a bank web-site.</p>
        <p><a class="btn btn-primary btn-large" href="outline.htm">Learn more >></a></p>
		</div>
		<div style="float:right">
		<img src="meeting.jpg" style="height:200px">
		</div>
		<div style="clear:both"></div>
      </div>

      <!-- Example row of columns -->
      <div class="row">
        <div class="span4">
          <h2>Private Banking</h2>
           <p>Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio dui. </p>
          <p><a class="btn" href="http://twitter.github.com/bootstrap/examples/hero.html#">View details »</a></p>
        </div>
        <div class="span4">
          <h2>Corperate Banking</h2>
           <p>Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio dui. </p>
          <p><a class="btn" href="http://twitter.github.com/bootstrap/examples/hero.html#">View details »</a></p>
       </div>
        <div class="span4">
          <h2>Become a Costumer</h2>
          <p>Donec sed odio dui. Cras justo odio, dapibus ac facilisis in, egestas eget quam. Vestibulum id ligula porta felis euismod semper. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus.</p>
          <p><a class="btn" href="http://twitter.github.com/bootstrap/examples/hero.html#">View details >></a></p>
        </div>
      </div>

      <hr>

      <footer>
        <p>© Company 2016</p>
      </footer>

    </div> <!-- /container -->

    <!-- Le javascript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="./Bootstrap, from Twitter_files/jquery.js"></script>
    <script src="./Bootstrap, from Twitter_files/bootstrap-transition.js"></script>
    <script src="./Bootstrap, from Twitter_files/bootstrap-alert.js"></script>
    <script src="./Bootstrap, from Twitter_files/bootstrap-modal.js"></script>
    <script src="./Bootstrap, from Twitter_files/bootstrap-dropdown.js"></script>
    <script src="./Bootstrap, from Twitter_files/bootstrap-scrollspy.js"></script>
    <script src="./Bootstrap, from Twitter_files/bootstrap-tab.js"></script>
    <script src="./Bootstrap, from Twitter_files/bootstrap-tooltip.js"></script>
    <script src="./Bootstrap, from Twitter_files/bootstrap-popover.js"></script>
    <script src="./Bootstrap, from Twitter_files/bootstrap-button.js"></script>
    <script src="./Bootstrap, from Twitter_files/bootstrap-collapse.js"></script>
    <script src="./Bootstrap, from Twitter_files/bootstrap-carousel.js"></script>
    <script src="./Bootstrap, from Twitter_files/bootstrap-typeahead.js"></script>

    <script>
        function a() {alert(1);}
        var s = '?debugid=' + <%=(GetDebugId()==null?"1":GetDebugId())%>;
        // do something with s...
    </script>


</div></div></body></html>
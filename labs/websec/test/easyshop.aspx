<%@ Page Language="C#" Inherits="test.Easyshop" %> 

<!DOCTYPE html>
<html lang="en"><script type="text/javascript">window["_gaUserPrefs"] = { ioo : function() { return true; } }</script><head><meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta charset="utf-8">
    <title>Web Shop</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="">

    <!-- Le styles -->
    
    <style type="text/css">
      body {
        padding-top: 60px;
        padding-bottom: 40px;
      }
      .sidebar-nav {
        padding: 9px 0;
      }
    </style>
    <link href="XSRF_files/bootstrap.css" rel="stylesheet">

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
        <div class="container-fluid">
          <a class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse">
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
          </a>
          <a class="brand" href="http://twitter.github.com/bootstrap/examples/fluid.html#">Project name</a>
          <div class="btn-group pull-right">
            <a class="btn dropdown-toggle" data-toggle="dropdown" href="http://twitter.github.com/bootstrap/examples/fluid.html#">
              <i class="icon-user"></i> Username
              <span class="caret"></span>
            </a>
            <ul class="dropdown-menu">
              <li><a href="http://twitter.github.com/bootstrap/examples/fluid.html#">Profile</a></li>
              <li class="divider"></li>
              <li><a href="http://twitter.github.com/bootstrap/examples/fluid.html#">Sign Out</a></li>
            </ul>
          </div>
          <div class="nav-collapse">
            <ul class="nav">
              <li class="active"><a href="http://twitter.github.com/bootstrap/examples/fluid.html#">Home</a></li>
              <li><a href="http://twitter.github.com/bootstrap/examples/fluid.html#about">About</a></li>
              <li><a href="http://twitter.github.com/bootstrap/examples/fluid.html#contact">Contact</a></li>
            </ul>
          </div><!--/.nav-collapse -->
        </div>
      </div>
    </div>

    <div class="container-fluid">
      <div class="row-fluid">
        <div class="span3">
          <div class="well sidebar-nav">
            <ul class="nav nav-list">
              <li class="nav-header">Sidebar</li>
              <li class="active"><a href="http://twitter.github.com/bootstrap/examples/fluid.html#">Link</a></li>
              <li><a href="http://twitter.github.com/bootstrap/examples/fluid.html#">Link</a></li>
              <li><a href="http://twitter.github.com/bootstrap/examples/fluid.html#">Link</a></li>
              <li><a href="http://twitter.github.com/bootstrap/examples/fluid.html#">Link</a></li>
              <li class="nav-header">Sidebar</li>
              <li><a href="http://twitter.github.com/bootstrap/examples/fluid.html#">Link</a></li>
              <li><a href="http://twitter.github.com/bootstrap/examples/fluid.html#">Link</a></li>
              <li><a href="http://twitter.github.com/bootstrap/examples/fluid.html#">Link</a></li>
              <li><a href="http://twitter.github.com/bootstrap/examples/fluid.html#">Link</a></li>
              <li><a href="http://twitter.github.com/bootstrap/examples/fluid.html#">Link</a></li>
              <li><a href="http://twitter.github.com/bootstrap/examples/fluid.html#">Link</a></li>
              <li class="nav-header">Sidebar</li>
              <li><a href="http://twitter.github.com/bootstrap/examples/fluid.html#">Link</a></li>
              <li><a href="http://twitter.github.com/bootstrap/examples/fluid.html#">Link</a></li>
              <li><a href="http://twitter.github.com/bootstrap/examples/fluid.html#">Link</a></li>
            </ul>
          </div><!--/.well -->
        </div><!--/span-->
        <div class="span9">
          <div class="hero-unit">
            <h1>Web shop</h1>
            <p><img src="laptop.jpg"> Price: 1000,- USD</p>
            <form action="buy.aspx" method="post">
            	<input type="hidden" name="currency" value="USD">
            	<input type="hidden" name="amount" value="1000">

            	<input type="submit" class="btn btn-primary btn-large" value="Buy">
            </form>
            <p></a></p>
          </div>

          </div><!--/row-->
        </div><!--/span-->
      </div><!--/row-->

      <hr>

      <footer>
        <p>© Company 2012</p>
      </footer>

    </div><!--/.fluid-container-->

    <!-- Le javascript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="./XSRF_files/jquery.js"></script>
    <script src="./XSRF_files/bootstrap-transition.js"></script>
    <script src="./XSRF_files/bootstrap-alert.js"></script>
    <script src="./XSRF_files/bootstrap-modal.js"></script>
    <script src="./XSRF_files/bootstrap-dropdown.js"></script>
    <script src="./XSRF_files/bootstrap-scrollspy.js"></script>
    <script src="./XSRF_files/bootstrap-tab.js"></script>
    <script src="./XSRF_files/bootstrap-tooltip.js"></script>
    <script src="./XSRF_files/bootstrap-popover.js"></script>
    <script src="./XSRF_files/bootstrap-button.js"></script>
    <script src="./XSRF_files/bootstrap-collapse.js"></script>
    <script src="./XSRF_files/bootstrap-carousel.js"></script>
    <script src="./XSRF_files/bootstrap-typeahead.js"></script>

  
</body></html>
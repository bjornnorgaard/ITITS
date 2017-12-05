
//jQuery onReady

$(document).ready(function(){


/*right-txt addclass "date first" */
$('.right-txt .news_latest_container .date:first-child').addClass('first')

/*right-txt addclass "h2 seneste" */
$('.right-txt:first h2').addClass('seneste')


/*---- 
	This function enables the menu with the id of ul_nav
	to show the submenu. Works only on 2 levels.


	if (document.all&&document.getElementById) {
		navRoot = document.getElementById("ul_nav");
		for (i=0; i<navRoot.childNodes.length; i++) {
			node = navRoot.childNodes[i];
			if (node.nodeName=="LI") {
				node.onmouseover=function() {
					this.className+=" over";
  				}
	  			node.onmouseout=function() {
  					this.className=this.className.replace(" over", "");
   				}
   			}
  		}
 	}

----*/


//----
// Accesskeys
//----

$('#accesskeys a').focus(function(){
		$('#accesskeys').attr("style","left: 10px; z-index:999;");
});
$('#accesskeys a').blur(function(){
		$('#accesskeys').attr("style","left: -9999px; z-index:0;");
});


	
	
//----- 	
// Switch stylesheets starts
//-----

var c = readCookie('style');

if (c) {
	
	switchStylestyle(c);
	/* 
	if (c == "font_11px") {
        	$('.big').each(function(i) {
			$(this).attr({
				rel: "font_12px"
        		});
        	});
        	$('.small').each(function(i) {
			$(this).attr({
				rel: "font_11px"
        		});
        	});
        } else if (c == "font_12px") {
        	$('.big').each(function(i) {
			$(this).attr({
				rel: "font_13px"
        		});
        	});
        	$('.small').each(function(i) {
			$(this).attr({
				rel: "font_11px"
        		});
        	});
        } else if (c == "font_13px") {
        	$('.big').each(function(i) {
			$(this).attr({
				rel: "font_13px"
        		});
        	});
        	$('.small').each(function(i) {
			$(this).attr({
				rel: "font_12px"
        		});
        	});
        }*/
}
	
$('.big').click(function() {

	var relatt = this.getAttribute("rel");
        
       	switchStylestyle(relatt);
       	$(this).attr({
		rel: "font_13px"
        });
        
        return false;
});

$('.normal').click(function() {

	var relatt = this.getAttribute("rel");
        
       	switchStylestyle(relatt);
       	$(this).attr({
		rel: "font_12px"
        });
        
        return false;
});	

$('.small').click(function() {

	var relatt = this.getAttribute("rel");
        
       	switchStylestyle(relatt);
	$(this).attr({
		rel: "font_11px"
        });
        return false;
}); 	

//-----
// Switch stylesheets ends
//-----

}); // End jQuery onReady

function switchStylestyle(styleName)
{
        $('link[@rel*=style][@title]').each(function(i)
        {
                this.disabled = true;
                if (this.getAttribute('title') == styleName) this.disabled = false;
        });
        createCookie('style', styleName, 365);
}

// Ends all jquery



// cookie functions http://www.quirksmode.org/js/cookies.html

function createCookie(name,value,days){
	if (days)	{
		var date = new Date();
		date.setTime(date.getTime()+(days*24*60*60*1000));
		var expires = "; expires="+date.toGMTString();
	}
	else var expires = "";
	document.cookie = name+"="+value+expires+"; path=/";
}

function readCookie(name){
	var nameEQ = name + "=";
	var ca = document.cookie.split(';');
	for(var i=0;i < ca.length;i++){
		var c = ca[i];
		while (c.charAt(0)==' ') c = c.substring(1,c.length);
		if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length,c.length);
	}
	return null;
}

function eraseCookie(name){
	createCookie(name,"",-1);
}

// cookie functions end

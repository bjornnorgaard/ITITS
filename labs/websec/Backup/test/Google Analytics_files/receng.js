var re_a=encodeURIComponent,re_b=window,re_c=document,re_d="prototype",re_;function re_e(){this.config=this.K;this.caller=this.M;this.lang=this.location=null;this.nRecs=1;this.strategy=this.g;this.excludedProducts=null;this.uri=this.L;this.layout=this.h;this.finished=null;this.showImg=!0;this.details=!1}re_=re_e[re_d];re_.g="we";re_.Q="tn";re_.O="business";re_.P="consumer";re_.m="config";re_.l="caller";re_.p="lang";re_.q="loc";re_.r="nRecs";re_.t="strategy";re_.o="excl";re_.n="details";re_.K="consumer";
re_.M="unknown";re_.L="http://www.google.com/receng";re_.N="/js/recommendations.js";re_.s="__RecEng";
re_.T=function(){re_b[this.s]=this;this.v=this.config;this.caller=this.caller;this.lang=this.lang;this.location=this.location;this.B=this.nRecs;this.C=this.strategy;this.z=this.excludedProducts;this.k=this.uri;this.e=this.layout;this.d=this.finished;this.j=this.showImg;this.b=this.details;this.c=this.divs;var a="",a=this.a(a,this.m,this.v),a=this.a(a,this.l,this.caller),a=this.a(a,this.r,this.B),a=this.a(a,this.p,this.lang),a=this.a(a,this.q,this.location),a=this.a(a,this.t,this.C),a=this.a(a,this.o,
this.z),a=this.u(a,this.n,this.b),a=this.w(a);this.A(a.toString())};re_.a=function(a,c,d){d&&(a&&(a+="&"),a+=re_a(c),a+="=",a+=re_a(d));return a};re_.u=function(a,c,d){return d?this.a(a,c,"1"):a};re_.w=function(a){var c="https:"==re_b.location.protocol?"https://":"http://",d=this.k.replace(/.*\/\//,"");return c+=d+this.N+"?"+a};re_.A=function(a){var c=re_c.createElement("script");c.type="text/javascript";c.src=a;this.S(c)};re_.S=function(a){var c=re_c.getElementsByTagName("head");c[0].appendChild(a)};
re_.R=function(a){if(a)for(var c=0;c<a.length&&c<this.c.length;c++){var d=a[c];d.J=d.shortTitle;d.H=d.longTitle;d.I=d.shortDescription;d.G=d.longDescription;d.V=d.shortProductName;d.F=d.iconImage;d.D=d.callToActionText;d.f=d.callToActionUrl;d.b=d.details;this.e(this.c[c],d)}this.d&&(a||(a=[]),this.d(a))};re_.h=function(a,c){this.i(a,c,c.H,c.G)};re_.U=function(a,c){this.i(a,c,c.J,c.I)};
re_.i=function(a,c,d,e){if(a=re_c.getElementById(a)){var b='<table width="100%" cellspacing="0" cellpadding="0" border="0">',b=b+"<tr><td>",b=b+'<div class="re-title">',b=b+d,b=b+"</div>";this.j&&(b+='<a href="'+c.f+'">',b+='<img src="'+c.F+'" alt="" class="re-img">',b+="</a>");b+='<div class="re-desc">';b+=e;b+="</div>";b+='<a href="'+c.f+'" class="re-link">';b+=c.D;b+="</a>";b+="<br/>";b+="</td></tr>";c.b&&(b+="<tr><td>",b+=c.b,b+="</td></tr>");b+="</table>";a.innerHTML=b}};re_b.RecEng=re_e;
re_e.prototype=re_e[re_d];re_e[re_d].genericLayout=re_e[re_d].R;re_e[re_d].recommend=re_e[re_d].T;re_e[re_d].layout=re_e[re_d].e;re_e[re_d].largeLayout=re_e[re_d].h;re_e[re_d].smallLayout=re_e[re_d].U;re_e[re_d].WEIGHTED=re_e[re_d].g;re_e[re_d].TOP_N=re_e[re_d].Q;re_e[re_d].BUSINESS=re_e[re_d].O;re_e[re_d].CONSUMER=re_e[re_d].P;var re_f=re_b.goog||{};re_b.goog=re_f;re_f.RecEng=re_e;
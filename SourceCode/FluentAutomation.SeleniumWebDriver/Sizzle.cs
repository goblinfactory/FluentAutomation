﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace FluentAutomation.SeleniumWebDriver
{
    public class BySizzle : By
    {
        private readonly string _selector;
        private string _compiledSizzleString = @"(function(){function y(a,b,c,d,f,e){for(var f=0,h=d.length;f<h;f++){var g=d[f];if(g){for(var i=!1,g=g[a];g;){if(g.sizcache===c){i=d[g.sizset];break}if(g.nodeType===1&&!e)g.sizcache=c,g.sizset=f;if(g.nodeName.toLowerCase()===b){i=g;break}g=g[a]}d[f]=i}}}function z(a,b,c,d,f,e){for(var f=0,h=d.length;f<h;f++){var g=d[f];if(g){for(var j=!1,g=g[a];g;){if(g.sizcache===c){j=d[g.sizset];break}if(g.nodeType===1){if(!e)g.sizcache=c,g.sizset=f;if(typeof b!==""string""){if(g===b){j=!0;break}}else if(i.filter(b,
[g]).length>0){j=g;break}}g=g[a]}d[f]=j}}}var w=/((?:\((?:\([^()]+\)|[^()]+)+\)|\[(?:\[[^\[\]]*\]|['""][^'""]*['""]|[^\[\]'""]+)+\]|\\.|[^ >+~,(\[\\]+)+|[>+~])(\s*,\s*)?((?:.|\r|\n)*)/g,x=0,A=Object.prototype.toString,t=!1,B=!0,p=/\\/g,u=/\W/;[0,0].sort(function(){B=!1;return 0});var i=function(a,b,c,d){var c=c||[],f=b=b||document;if(b.nodeType!==1&&b.nodeType!==9)return[];if(!a||typeof a!==""string"")return c;var e,h,g,l,s,m=!0,n=i.isXML(b),k=[],p=a;do if(w.exec(""""),e=w.exec(p))if(p=e[3],k.push(e[1]),
e[2]){l=e[3];break}while(e);if(k.length>1&&D.exec(a))if(k.length===2&&j.relative[k[0]])h=C(k[0]+k[1],b);else for(h=j.relative[k[0]]?[b]:i(k.shift(),b);k.length;)a=k.shift(),j.relative[a]&&(a+=k.shift()),h=C(a,h);else if(!d&&k.length>1&&b.nodeType===9&&!n&&j.match.ID.test(k[0])&&!j.match.ID.test(k[k.length-1])&&(e=i.find(k.shift(),b,n),b=e.expr?i.filter(e.expr,e.set)[0]:e.set[0]),b){e=d?{expr:k.pop(),set:o(d)}:i.find(k.pop(),k.length===1&&(k[0]===""~""||k[0]===""+"")&&b.parentNode?b.parentNode:b,n);h=
e.expr?i.filter(e.expr,e.set):e.set;for(k.length>0?g=o(h):m=!1;k.length;)e=s=k.pop(),j.relative[s]?e=k.pop():s="""",e==null&&(e=b),j.relative[s](g,e,n)}else g=[];g||(g=h);g||i.error(s||a);if(A.call(g)===""[object Array]"")if(m)if(b&&b.nodeType===1)for(a=0;g[a]!=null;a++)g[a]&&(g[a]===!0||g[a].nodeType===1&&i.contains(b,g[a]))&&c.push(h[a]);else for(a=0;g[a]!=null;a++)g[a]&&g[a].nodeType===1&&c.push(h[a]);else c.push.apply(c,g);else o(g,c);l&&(i(l,f,c,d),i.uniqueSort(c));return c};i.uniqueSort=function(a){if(v&&
(t=B,a.sort(v),t))for(var b=1;b<a.length;b++)a[b]===a[b-1]&&a.splice(b--,1);return a};i.matches=function(a,b){return i(a,null,null,b)};i.matchesSelector=function(a,b){return i(b,null,null,[a]).length>0};i.find=function(a,b,c){var d;if(!a)return[];for(var f=0,e=j.order.length;f<e;f++){var h,g=j.order[f];if(h=j.leftMatch[g].exec(a)){var i=h[1];h.splice(1,1);if(i.substr(i.length-1)!==""\\""&&(h[1]=(h[1]||"""").replace(p,""""),d=j.find[g](h,b,c),d!=null)){a=a.replace(j.match[g],"""");break}}}d||(d=typeof b.getElementsByTagName!==
""undefined""?b.getElementsByTagName(""*""):[]);return{set:d,expr:a}};i.filter=function(a,b,c,d){for(var f,e,h=a,g=[],l=b,o=b&&b[0]&&i.isXML(b[0]);a&&b.length;){for(var m in j.filter)if((f=j.leftMatch[m].exec(a))!=null&&f[2]){var n,k,p=j.filter[m];k=f[1];e=!1;f.splice(1,1);if(k.substr(k.length-1)!==""\\""){l===g&&(g=[]);if(j.preFilter[m])if(f=j.preFilter[m](f,l,c,g,d,o)){if(f===!0)continue}else e=n=!0;if(f)for(var q=0;(k=l[q])!=null;q++)if(k){n=p(k,f,q,l);var r=d^!!n;c&&n!=null?r?e=!0:l[q]=!1:r&&(g.push(k),
e=!0)}if(n!==void 0){c||(l=g);a=a.replace(j.match[m],"""");if(!e)return[];break}}}if(a===h)if(e==null)i.error(a);else break;h=a}return l};i.error=function(a){throw""Syntax error, unrecognized expression: ""+a;};var j=i.selectors={order:[""ID"",""NAME"",""TAG""],match:{ID:/#((?:[\w\u00c0-\uFFFF\-]|\\.)+)/,CLASS:/\.((?:[\w\u00c0-\uFFFF\-]|\\.)+)/,NAME:/\[name=['""]*((?:[\w\u00c0-\uFFFF\-]|\\.)+)['""]*\]/,ATTR:/\[\s*((?:[\w\u00c0-\uFFFF\-]|\\.)+)\s*(?:(\S?=)\s*(?:(['""])(.*?)\3|(#?(?:[\w\u00c0-\uFFFF\-]|\\.)*)|)|)\s*\]/,
TAG:/^((?:[\w\u00c0-\uFFFF\*\-]|\\.)+)/,CHILD:/:(only|nth|last|first)-child(?:\(\s*(even|odd|(?:[+\-]?\d+|(?:[+\-]?\d*)?n\s*(?:[+\-]\s*\d+)?))\s*\))?/,POS:/:(nth|eq|gt|lt|first|last|even|odd)(?:\((\d*)\))?(?=[^\-]|$)/,PSEUDO:/:((?:[\w\u00c0-\uFFFF\-]|\\.)+)(?:\((['""]?)((?:\([^\)]+\)|[^\(\)]*)+)\2\))?/},leftMatch:{},attrMap:{""class"":""className"",""for"":""htmlFor""},attrHandle:{href:function(a){return a.getAttribute(""href"")},type:function(a){return a.getAttribute(""type"")}},relative:{""+"":function(a,b){var c=
typeof b===""string"",d=c&&!u.test(b),c=c&&!d;d&&(b=b.toLowerCase());for(var d=0,f=a.length,e;d<f;d++)if(e=a[d]){for(;(e=e.previousSibling)&&e.nodeType!==1;);a[d]=c||e&&e.nodeName.toLowerCase()===b?e||!1:e===b}c&&i.filter(b,a,!0)},"">"":function(a,b){var c,d=typeof b===""string"",f=0,e=a.length;if(d&&!u.test(b))for(b=b.toLowerCase();f<e;f++){if(c=a[f])c=c.parentNode,a[f]=c.nodeName.toLowerCase()===b?c:!1}else{for(;f<e;f++)(c=a[f])&&(a[f]=d?c.parentNode:c.parentNode===b);d&&i.filter(b,a,!0)}},"""":function(a,
b,c){var d,f=x++,e=z;typeof b===""string""&&!u.test(b)&&(d=b=b.toLowerCase(),e=y);e(""parentNode"",b,f,a,d,c)},""~"":function(a,b,c){var d,f=x++,e=z;typeof b===""string""&&!u.test(b)&&(d=b=b.toLowerCase(),e=y);e(""previousSibling"",b,f,a,d,c)}},find:{ID:function(a,b,c){if(typeof b.getElementById!==""undefined""&&!c)return(a=b.getElementById(a[1]))&&a.parentNode?[a]:[]},NAME:function(a,b){if(typeof b.getElementsByName!==""undefined""){for(var c=[],d=b.getElementsByName(a[1]),f=0,e=d.length;f<e;f++)d[f].getAttribute(""name"")===
a[1]&&c.push(d[f]);return c.length===0?null:c}},TAG:function(a,b){if(typeof b.getElementsByTagName!==""undefined"")return b.getElementsByTagName(a[1])}},preFilter:{CLASS:function(a,b,c,d,f,e){a="" ""+a[1].replace(p,"""")+"" "";if(e)return a;for(var e=0,h;(h=b[e])!=null;e++)h&&(f^(h.className&&("" ""+h.className+"" "").replace(/[\t\n\r]/g,"" "").indexOf(a)>=0)?c||d.push(h):c&&(b[e]=!1));return!1},ID:function(a){return a[1].replace(p,"""")},TAG:function(a){return a[1].replace(p,"""").toLowerCase()},CHILD:function(a){if(a[1]===
""nth""){a[2]||i.error(a[0]);a[2]=a[2].replace(/^\+|\s*/g,"""");var b=/(-?)(\d*)(?:n([+\-]?\d*))?/.exec(a[2]===""even""&&""2n""||a[2]===""odd""&&""2n+1""||!/\D/.test(a[2])&&""0n+""+a[2]||a[2]);a[2]=b[1]+(b[2]||1)-0;a[3]=b[3]-0}else a[2]&&i.error(a[0]);a[0]=x++;return a},ATTR:function(a,b,c,d,f,e){b=a[1]=a[1].replace(p,"""");!e&&j.attrMap[b]&&(a[1]=j.attrMap[b]);a[4]=(a[4]||a[5]||"""").replace(p,"""");a[2]===""~=""&&(a[4]="" ""+a[4]+"" "");return a},PSEUDO:function(a,b,c,d,f){if(a[1]===""not"")if((w.exec(a[3])||"""").length>1||
/^\w/.test(a[3]))a[3]=i(a[3],null,null,b);else return a=i.filter(a[3],b,c,1^f),c||d.push.apply(d,a),!1;else if(j.match.POS.test(a[0])||j.match.CHILD.test(a[0]))return!0;return a},POS:function(a){a.unshift(!0);return a}},filters:{enabled:function(a){return a.disabled===!1&&a.type!==""hidden""},disabled:function(a){return a.disabled===!0},checked:function(a){return a.checked===!0},selected:function(a){return a.selected===!0},parent:function(a){return!!a.firstChild},empty:function(a){return!a.firstChild},
has:function(a,b,c){return!!i(c[3],a).length},header:function(a){return/h\d/i.test(a.nodeName)},text:function(a){var b=a.getAttribute(""type""),c=a.type;return a.nodeName.toLowerCase()===""input""&&""text""===c&&(b===c||b===null)},radio:function(a){return a.nodeName.toLowerCase()===""input""&&""radio""===a.type},checkbox:function(a){return a.nodeName.toLowerCase()===""input""&&""checkbox""===a.type},file:function(a){return a.nodeName.toLowerCase()===""input""&&""file""===a.type},password:function(a){return a.nodeName.toLowerCase()===
""input""&&""password""===a.type},submit:function(a){var b=a.nodeName.toLowerCase();return(b===""input""||b===""button"")&&""submit""===a.type},image:function(a){return a.nodeName.toLowerCase()===""input""&&""image""===a.type},reset:function(a){var b=a.nodeName.toLowerCase();return(b===""input""||b===""button"")&&""reset""===a.type},button:function(a){var b=a.nodeName.toLowerCase();return b===""input""&&""button""===a.type||b===""button""},input:function(a){return/input|select|textarea|button/i.test(a.nodeName)},focus:function(a){return a===
a.ownerDocument.activeElement}},setFilters:{first:function(a,b){return b===0},last:function(a,b,c,d){return b===d.length-1},even:function(a,b){return b%2===0},odd:function(a,b){return b%2===1},lt:function(a,b,c){return b<c[3]-0},gt:function(a,b,c){return b>c[3]-0},nth:function(a,b,c){return c[3]-0===b},eq:function(a,b,c){return c[3]-0===b}},filter:{PSEUDO:function(a,b,c,d){var f=b[1],e=j.filters[f];if(e)return e(a,c,b,d);else if(f===""contains"")return(a.textContent||a.innerText||i.getText([a])||"""").indexOf(b[3])>=
0;else if(f===""not""){b=b[3];c=0;for(d=b.length;c<d;c++)if(b[c]===a)return!1;return!0}else i.error(f)},CHILD:function(a,b){var c=b[1],d=a;switch(c){case ""only"":case ""first"":for(;d=d.previousSibling;)if(d.nodeType===1)return!1;if(c===""first"")return!0;d=a;case ""last"":for(;d=d.nextSibling;)if(d.nodeType===1)return!1;return!0;case ""nth"":var c=b[2],f=b[3];if(c===1&&f===0)return!0;var e=b[0],h=a.parentNode;if(h&&(h.sizcache!==e||!a.nodeIndex)){for(var g=0,d=h.firstChild;d;d=d.nextSibling)if(d.nodeType===
1)d.nodeIndex=++g;h.sizcache=e}d=a.nodeIndex-f;return c===0?d===0:d%c===0&&d/c>=0}},ID:function(a,b){return a.nodeType===1&&a.getAttribute(""id"")===b},TAG:function(a,b){return b===""*""&&a.nodeType===1||a.nodeName.toLowerCase()===b},CLASS:function(a,b){return("" ""+(a.className||a.getAttribute(""class""))+"" "").indexOf(b)>-1},ATTR:function(a,b){var c=b[1],c=j.attrHandle[c]?j.attrHandle[c](a):a[c]!=null?a[c]:a.getAttribute(c),d=c+"""",f=b[2],e=b[4];return c==null?f===""!="":f===""=""?d===e:f===""*=""?d.indexOf(e)>=
0:f===""~=""?("" ""+d+"" "").indexOf(e)>=0:!e?d&&c!==!1:f===""!=""?d!==e:f===""^=""?d.indexOf(e)===0:f===""$=""?d.substr(d.length-e.length)===e:f===""|=""?d===e||d.substr(0,e.length+1)===e+""-"":!1},POS:function(a,b,c,d){var f=j.setFilters[b[2]];if(f)return f(a,c,b,d)}}},D=j.match.POS,E=function(a,b){return""\\""+(b-0+1)},q;for(q in j.match)j.match[q]=RegExp(j.match[q].source+/(?![^\[]*\])(?![^\(]*\))/.source),j.leftMatch[q]=RegExp(/(^(?:.|\r|\n)*?)/.source+j.match[q].source.replace(/\\(\d+)/g,E));var o=function(a,
b){a=Array.prototype.slice.call(a,0);return b?(b.push.apply(b,a),b):a};try{Array.prototype.slice.call(document.documentElement.childNodes,0)}catch(F){o=function(a,b){var c=0,d=b||[];if(A.call(a)===""[object Array]"")Array.prototype.push.apply(d,a);else if(typeof a.length===""number"")for(var f=a.length;c<f;c++)d.push(a[c]);else for(;a[c];c++)d.push(a[c]);return d}}var v,r;document.documentElement.compareDocumentPosition?v=function(a,b){return a===b?(t=!0,0):!a.compareDocumentPosition||!b.compareDocumentPosition?
a.compareDocumentPosition?-1:1:a.compareDocumentPosition(b)&4?-1:1}:(v=function(a,b){if(a===b)return t=!0,0;else if(a.sourceIndex&&b.sourceIndex)return a.sourceIndex-b.sourceIndex;var c,d,f=[],e=[];c=a.parentNode;d=b.parentNode;var h=c;if(c===d)return r(a,b);else if(c){if(!d)return 1}else return-1;for(;h;)f.unshift(h),h=h.parentNode;for(h=d;h;)e.unshift(h),h=h.parentNode;c=f.length;d=e.length;for(h=0;h<c&&h<d;h++)if(f[h]!==e[h])return r(f[h],e[h]);return h===c?r(a,e[h],-1):r(f[h],b,1)},r=function(a,
b,c){if(a===b)return c;for(a=a.nextSibling;a;){if(a===b)return-1;a=a.nextSibling}return 1});i.getText=function(a){for(var b="""",c,d=0;a[d];d++)c=a[d],c.nodeType===3||c.nodeType===4?b+=c.nodeValue:c.nodeType!==8&&(b+=i.getText(c.childNodes));return b};(function(){var a=document.createElement(""div""),b=""script""+(new Date).getTime(),c=document.documentElement;a.innerHTML=""<a name='""+b+""'/>"";c.insertBefore(a,c.firstChild);if(document.getElementById(b))j.find.ID=function(a,b,c){if(typeof b.getElementById!==
""undefined""&&!c)return(b=b.getElementById(a[1]))?b.id===a[1]||typeof b.getAttributeNode!==""undefined""&&b.getAttributeNode(""id"").nodeValue===a[1]?[b]:void 0:[]},j.filter.ID=function(a,b){var c=typeof a.getAttributeNode!==""undefined""&&a.getAttributeNode(""id"");return a.nodeType===1&&c&&c.nodeValue===b};c.removeChild(a);c=a=null})();(function(){var a=document.createElement(""div"");a.appendChild(document.createComment(""""));if(a.getElementsByTagName(""*"").length>0)j.find.TAG=function(a,c){var d=c.getElementsByTagName(a[1]);
if(a[1]===""*""){for(var f=[],e=0;d[e];e++)d[e].nodeType===1&&f.push(d[e]);d=f}return d};a.innerHTML=""<a href='#'></a>"";if(a.firstChild&&typeof a.firstChild.getAttribute!==""undefined""&&a.firstChild.getAttribute(""href"")!==""#"")j.attrHandle.href=function(a){return a.getAttribute(""href"",2)};a=null})();document.querySelectorAll&&function(){var a=i,b=document.createElement(""div"");b.innerHTML=""<p class='TEST'></p>"";if(!(b.querySelectorAll&&b.querySelectorAll("".TEST"").length===0)){i=function(b,c,e,h){c=c||
document;if(!h&&!i.isXML(c)){var g=/^(\w+$)|^\.([\w\-]+$)|^#([\w\-]+$)/.exec(b);if(g&&(c.nodeType===1||c.nodeType===9))if(g[1])return o(c.getElementsByTagName(b),e);else if(g[2]&&j.find.CLASS&&c.getElementsByClassName)return o(c.getElementsByClassName(g[2]),e);if(c.nodeType===9){if(b===""body""&&c.body)return o([c.body],e);else if(g&&g[3]){var l=c.getElementById(g[3]);if(l&&l.parentNode){if(l.id===g[3])return o([l],e)}else return o([],e)}try{return o(c.querySelectorAll(b),e)}catch(p){}}else if(c.nodeType===
1&&c.nodeName.toLowerCase()!==""object""){var g=c,m=(l=c.getAttribute(""id""))||""__sizzle__"",n=c.parentNode,k=/^\s*[+~]/.test(b);l?m=m.replace(/'/g,""\\$&""):c.setAttribute(""id"",m);if(k&&n)c=c.parentNode;try{if(!k||n)return o(c.querySelectorAll(""[id='""+m+""'] ""+b),e)}catch(q){}finally{l||g.removeAttribute(""id"")}}}return a(b,c,e,h)};for(var c in a)i[c]=a[c];b=null}}();(function(){var a=document.documentElement,b=a.matchesSelector||a.mozMatchesSelector||a.webkitMatchesSelector||a.msMatchesSelector;if(b){var c=
!b.call(document.createElement(""div""),""div""),d=!1;try{b.call(document.documentElement,""[test!='']:sizzle"")}catch(f){d=!0}i.matchesSelector=function(a,f){f=f.replace(/\=\s*([^'""\]]*)\s*\]/g,""='$1']"");if(!i.isXML(a))try{if(d||!j.match.PSEUDO.test(f)&&!/!=/.test(f)){var g=b.call(a,f);if(g||!c||a.document&&a.document.nodeType!==11)return g}}catch(l){}return i(f,null,null,[a]).length>0}}})();(function(){var a=document.createElement(""div"");a.innerHTML=""<div class='test e'></div><div class='test'></div>"";
if(a.getElementsByClassName&&a.getElementsByClassName(""e"").length!==0&&(a.lastChild.className=""e"",a.getElementsByClassName(""e"").length!==1))j.order.splice(1,0,""CLASS""),j.find.CLASS=function(a,c,d){if(typeof c.getElementsByClassName!==""undefined""&&!d)return c.getElementsByClassName(a[1])},a=null})();i.contains=document.documentElement.contains?function(a,b){return a!==b&&(a.contains?a.contains(b):!0)}:document.documentElement.compareDocumentPosition?function(a,b){return!!(a.compareDocumentPosition(b)&
16)}:function(){return!1};i.isXML=function(a){return(a=(a?a.ownerDocument||a:0).documentElement)?a.nodeName!==""HTML"":!1};var C=function(a,b){for(var c,d=[],f="""",e=b.nodeType?[b]:b;c=j.match.PSEUDO.exec(a);)f+=c[0],a=a.replace(j.match.PSEUDO,"""");a=j.relative[a]?a+""*"":a;c=0;for(var h=e.length;c<h;c++)i(a,e[c],d);return i.filter(f,d)};window.Sizzle=i})();";

        public static new By CssSelector(string selector)
        {
            return new BySizzle(selector);
        }

        public BySizzle(string selector)
        {
            _selector = Newtonsoft.Json.JsonConvert.SerializeObject(selector);
        }

        public override ReadOnlyCollection<IWebElement> FindElements(ISearchContext context)
        {
            return new ReadOnlyCollection<IWebElement>(GetMatches((IJavaScriptExecutor)context, string.Format("return Sizzle({0})", _selector)).Cast<IWebElement>().ToList());
        }

        public override IWebElement FindElement(ISearchContext context)
        {
            return FindElements(context).First();
        }

        private IEnumerable<object> GetMatches(IJavaScriptExecutor scriptExecutor, string javascriptExpression)
        {
            EnsureSizzleIsLoaded(scriptExecutor);

            return ((IEnumerable<object>)scriptExecutor.ExecuteScript(javascriptExpression));
        }

        private void EnsureSizzleIsLoaded(IJavaScriptExecutor scriptExecutor)
        {
            if (!SizzleLoaded(scriptExecutor))
            {
                InjectSizzle(scriptExecutor);
            }
        }

        private bool SizzleLoaded(IJavaScriptExecutor scriptExecutor)
        {
            try
            {
                return (bool)scriptExecutor.ExecuteScript("return Sizzle()!=null");
            }
            catch (Exception) { }

            return false;
        }

        private void InjectSizzle(IJavaScriptExecutor driver)
        {
            driver.ExecuteScript(
                "var scriptSource = " + _compiledSizzleString + @"
var newScript = document.createElement('script');
newScript.type = 'text/javascript';

if (typeof (newScript.appendChild) == 'function') {
    var scriptContent = document.createTextNode(scriptSource);
    newScript.appendChild(scriptContent);
} else {
    newScript.text = scriptSource;
}

var headID = document.getElementsByTagName('head')[0];
headID.appendChild(newScript);");
        }
    }
}

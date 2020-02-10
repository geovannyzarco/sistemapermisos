;jQuery.ui_timepickr||(function($){var _remove=$.fn.remove,isFF2=false;$.ui_timepickr={version:"1.6rc5",plugin:{add:function(module,option,set){var proto=$.ui_timepickr[module].prototype;for(var i in set){proto.plugins[i]=proto.plugins[i]||[];proto.plugins[i].push([option,set[i]]);}},call:function(instance,name,args){var set=instance.plugins[name];if(!set){return;}
for(var i=0;i<set.length;i++){if(instance.options[set[i][0]]){set[i][1].apply(instance.element,args);}}}},contains:function(a,b){return document.compareDocumentPosition?a.compareDocumentPosition(b)&16:a!==b&&a.contains(b);},cssCache:{},css:function(name){if($.ui_timepickr.cssCache[name]){return $.ui_timepickr.cssCache[name];}
var tmp=$('<div class="ui-gen"></div>').addClass(name).css({position:'absolute',top:'-5000px',left:'-5000px',display:'block'}).appendTo('body');$.ui_timepickr.cssCache[name]=!!((!(/auto|default/).test(tmp.css('cursor'))||(/^[1-9]/).test(tmp.css('height'))||(/^[1-9]/).test(tmp.css('width'))||!(/none/).test(tmp.css('backgroundImage'))||!(/transparent|rgba\(0, 0, 0, 0\)/).test(tmp.css('backgroundColor'))));try{$('body').get(0).removeChild(tmp.get(0));}catch(e){}
return $.ui_timepickr.cssCache[name];},hasScroll:function(el,a){if($(el).css('overflow')=='hidden'){return false;}
var scroll=(a&&a=='left')?'scrollLeft':'scrollTop',has=false;if(el[scroll]>0){return true;}
el[scroll]=1;has=(el[scroll]>0);el[scroll]=0;return has;},isOverAxis:function(x,reference,size){return(x>reference)&&(x<(reference+size));},isOver:function(y,x,top,left,height,width){return $.ui_timepickr.isOverAxis(y,top,height)&&$.ui_timepickr.isOverAxis(x,left,width);},keyCode:{BACKSPACE:8,CAPS_LOCK:20,COMMA:188,CONTROL:17,DELETE:46,DOWN:40,END:35,ENTER:13,ESCAPE:27,HOME:36,INSERT:45,LEFT:37,NUMPAD_ADD:107,NUMPAD_DECIMAL:110,NUMPAD_DIVIDE:111,NUMPAD_ENTER:108,NUMPAD_MULTIPLY:106,NUMPAD_SUBTRACT:109,PAGE_DOWN:34,PAGE_UP:33,PERIOD:190,RIGHT:39,SHIFT:16,SPACE:32,TAB:9,UP:38}};$.ui_timepickr.ie=!!/msie [\w.]+/.exec(navigator.userAgent.toLowerCase());if(isFF2){var attr=$.attr,removeAttr=$.fn.removeAttr,ariaNS="http://www.w3.org/2005/07/aaa",ariaState=/^aria-/,ariaRole=/^wairole:/;$.attr=function(elem,name,value){var set=value!==undefined;return(name=='role'?(set?attr.call(this,elem,name,"wairole:"+value):(attr.apply(this,arguments)||"").replace(ariaRole,"")):(ariaState.test(name)?(set?elem.setAttributeNS(ariaNS,name.replace(ariaState,"aaa:"),value):attr.call(this,elem,name.replace(ariaState,"aaa:"))):attr.apply(this,arguments)));};$.fn.removeAttr=function(name){return(ariaState.test(name)?this.each(function(){this.removeAttributeNS(ariaNS,name.replace(ariaState,""));}):removeAttr.call(this,name));};}
$.fn.extend({remove:function(){$("*",this).add(this).each(function(){$(this).triggerHandler("remove");});return _remove.apply(this,arguments);},enableSelection:function(){return this.attr('unselectable','off').css('MozUserSelect','').unbind('selectstart.ui');},disableSelection:function(){return this.attr('unselectable','on').css('MozUserSelect','none').bind('selectstart.ui',function(){return false;});},scrollParent:function(){var scrollParent;if(($.ui_timepickr.ie&&(/(static|relative)/).test(this.css('position')))||(/absolute/).test(this.css('position'))){scrollParent=this.parents().filter(function(){return(/(relative|absolute|fixed)/).test($.curCSS(this,'position',1))&&(/(auto|scroll)/).test($.curCSS(this,'overflow',1)+$.curCSS(this,'overflow-y',1)+$.curCSS(this,'overflow-x',1));}).eq(0);}else{scrollParent=this.parents().filter(function(){return(/(auto|scroll)/).test($.curCSS(this,'overflow',1)+$.curCSS(this,'overflow-y',1)+$.curCSS(this,'overflow-x',1));}).eq(0);}
return(/fixed/).test(this.css('position'))||!scrollParent.length?$(document):scrollParent;}});$.extend($.expr[':'],{data:function(elem,i,match){return!!$.data(elem,match[3]);},tabbable:function(elem){var nodeName=elem.nodeName.toLowerCase();function isVisible(element){return!($(element).is(':hidden')||$(element).parents(':hidden').length);}
return(elem.tabIndex>=0&&(('a'==nodeName&&elem.href)||(/input|select|textarea|button/.test(nodeName)&&'hidden'!=elem.type&&!elem.disabled))&&isVisible(elem));}});function getter(namespace,plugin,method,args){function getMethods(type){var methods=$[namespace][plugin][type]||[];return(typeof methods=='string'?methods.split(/,?\s+/):methods);}
var methods=getMethods('getter');if(args.length==1&&typeof args[0]=='string'){methods=methods.concat(getMethods('getterSetter'));}
return($.inArray(method,methods)!=-1);}
$.widget_timepickr=function(name,prototype){var namespace=name.split(".")[0];name=name.split(".")[1];$.fn[name]=function(options){var isMethodCall=(typeof options=='string'),args=Array.prototype.slice.call(arguments,1);if(isMethodCall&&options.substring(0,1)=='_'){return this;}
if(isMethodCall&&getter(namespace,name,options,args)){var instance=$.data(this[0],name);return(instance?instance[options].apply(instance,args):undefined);}
return this.each(function(){var instance=$.data(this,name);(!instance&&!isMethodCall&&$.data(this,name,new $[namespace][name](this,options)));(instance&&isMethodCall&&$.isFunction(instance[options])&&instance[options].apply(instance,args));});};$[namespace]=$[namespace]||{};$[namespace][name]=function(element,options){var self=this;this.namespace=namespace;this.widgetName=name;this.widgetEventPrefix=$[namespace][name].eventPrefix||name;this.widgetBaseClass=namespace+'-'+name;this.options=$.extend({},$.widget_timepickr.defaults,$[namespace][name].defaults,$.metadata&&$.metadata.get(element)[name],options);this.element=$(element).bind('setData.'+name,function(event,key,value){if(event.target==element){return self._setData(key,value);}}).bind('getData.'+name,function(event,key){if(event.target==element){return self._getData(key);}}).bind('remove',function(){return self.destroy();});this._init();};$[namespace][name].prototype=$.extend({},$.widget_timepickr.prototype,prototype);$[namespace][name].getterSetter='option';};$.widget_timepickr.prototype={_init:function(){},destroy:function(){this.element.removeData(this.widgetName).removeClass(this.widgetBaseClass+'-disabled'+' '+this.namespace+'-state-disabled').removeAttr('aria-disabled');},option:function(key,value){var options=key,self=this;if(typeof key=="string"){if(value===undefined){return this._getData(key);}
options={};options[key]=value;}
$.each(options,function(key,value){self._setData(key,value);});},_getData:function(key){return this.options[key];},_setData:function(key,value){this.options[key]=value;if(key=='disabled'){this.element[value?'addClass':'removeClass'](this.widgetBaseClass+'-disabled'+' '+
this.namespace+'-state-disabled').attr("aria-disabled",value);}},enable:function(){this._setData('disabled',false);},disable:function(){this._setData('disabled',true);},_trigger:function(type,event,data){var callback=this.options[type],eventName=(type==this.widgetEventPrefix?type:this.widgetEventPrefix+type);event=$.Event(event);event.type=eventName;this.element.trigger(event,data);return!($.isFunction(callback)&&callback.call(this.element[0],event,data)===false||event.isDefaultPrevented());}};$.widget_timepickr.defaults={disabled:false};$.ui_timepickr.mouse={_mouseInit:function(){var self=this;this.element.bind('mousedown.'+this.widgetName,function(event){return self._mouseDown(event);}).bind('click.'+this.widgetName,function(event){if(self._preventClickEvent){self._preventClickEvent=false;return false;}});if($.ui_timepickr.ie){this._mouseUnselectable=this.element.attr('unselectable');this.element.attr('unselectable','on');}
this.started=false;},_mouseDestroy:function(){this.element.unbind('.'+this.widgetName);($.ui_timepickr.ie&&this.element.attr('unselectable',this._mouseUnselectable));},_mouseDown:function(event){(this._mouseStarted&&this._mouseUp(event));this._mouseDownEvent=event;var self=this,btnIsLeft=(event.which==1),elIsCancel=(typeof this.options.cancel=="string"?$(event.target).parents().add(event.target).filter(this.options.cancel).length:false);if(!btnIsLeft||elIsCancel||!this._mouseCapture(event)){return true;}
this.mouseDelayMet=!this.options.delay;if(!this.mouseDelayMet){this._mouseDelayTimer=setTimeout(function(){self.mouseDelayMet=true;},this.options.delay);}
if(this._mouseDistanceMet(event)&&this._mouseDelayMet(event)){this._mouseStarted=(this._mouseStart(event)!==false);if(!this._mouseStarted){event.preventDefault();return true;}}
this._mouseMoveDelegate=function(event){return self._mouseMove(event);};this._mouseUpDelegate=function(event){return self._mouseUp(event);};$(document).bind('mousemove.'+this.widgetName,this._mouseMoveDelegate).bind('mouseup.'+this.widgetName,this._mouseUpDelegate);event.preventDefault();return true;},_mouseMove:function(event){if($.ui_timepickr.ie&&!event.button){return this._mouseUp(event);}
if(this._mouseStarted){this._mouseDrag(event);return event.preventDefault();}
if(this._mouseDistanceMet(event)&&this._mouseDelayMet(event)){this._mouseStarted=(this._mouseStart(this._mouseDownEvent,event)!==false);(this._mouseStarted?this._mouseDrag(event):this._mouseUp(event));}
return!this._mouseStarted;},_mouseUp:function(event){$(document).unbind('mousemove.'+this.widgetName,this._mouseMoveDelegate).unbind('mouseup.'+this.widgetName,this._mouseUpDelegate);if(this._mouseStarted){this._mouseStarted=false;this._preventClickEvent=true;this._mouseStop(event);}
return false;},_mouseDistanceMet:function(event){return(Math.max(Math.abs(this._mouseDownEvent.pageX-event.pageX),Math.abs(this._mouseDownEvent.pageY-event.pageY))>=this.options.distance);},_mouseDelayMet:function(event){return this.mouseDelayMet;},_mouseStart:function(event){},_mouseDrag:function(event){},_mouseStop:function(event){},_mouseCapture:function(event){return true;}};$.ui_timepickr.mouse.defaults={cancel:null,distance:1,delay:0};})(jQuery);(function($){$.extend($.expr[':'],{icontains:function(a,i,m){return(a.textContent||a.innerText||jQuery(a).text()||"").toLowerCase().indexOf(m[3].toLowerCase())>=0;}});$.iterators={getText:function(){return $(this).text();},parseInt:function(v){return parseInt(v,10);}};$.extend({range:function(){if(!arguments.length){return[];}
var min,max,step;if(arguments.length==1){min=0;max=arguments[0]-1;step=1;}
else{min=arguments[0];max=arguments[1]-1;step=arguments[2]||1;}
if(step<0&&min>=max){step*=-1;var tmp=min;min=max;max=tmp;min+=((max-min)%step);}
var a=[];for(var i=min;i<=max;i+=step){a.push(i);}
return a;},keyCode:{BACKSPACE:8,CAPS_LOCK:20,COMMA:188,CONTROL:17,DELETE:46,DOWN:40,END:35,ENTER:13,ESCAPE:27,HOME:36,INSERT:45,LEFT:37,NUMPAD_ADD:107,NUMPAD_DECIMAL:110,NUMPAD_DIVIDE:111,NUMPAD_ENTER:108,NUMPAD_MULTIPLY:106,NUMPAD_SUBTRACT:109,PAGE_DOWN:34,PAGE_UP:33,PERIOD:190,RIGHT:39,SHIFT:16,SPACE:32,TAB:9,UP:38},keyIs:function(k,e){return parseInt($.keyCode[k.toUpperCase()],10)==parseInt((typeof(e)=='number')?e:e.keyCode,10);},keys:function(arr){var o=[];for(k in arr){o.push(k);}
return o;},redirect:function(url){window.location.href=url;return url;},stop:function(e,preventDefault,stopPropagation){if(preventDefault){e.preventDefault();}
if(stopPropagation){e.stopPropagation();}
return preventDefault&&false||true;},basename:function(path){var t=path.split('/');return t[t.length]===''&&s||t.slice(0,t.length).join('/');},filename:function(path){return path.split('/').pop();},filesizeformat:function(bytes,suffixes){var b=parseInt(bytes,10);var s=suffixes||['byte','bytes','KB','MB','GB'];if(isNaN(b)||b===0){return'0 '+s[0];}
if(b==1){return'1 '+s[0];}
if(b<1024){return b.toFixed(2)+' '+s[1];}
if(b<1048576){return(b/1024).toFixed(2)+' '+s[2];}
if(b<1073741824){return(b/1048576).toFixed(2)+' '+s[3];}
else{return(b/1073741824).toFixed(2)+' '+s[4];}},fileExtension:function(s){var tokens=s.split('.');return tokens[tokens.length-1]||false;},isString:function(o){return typeof(o)=='string'&&true||false;},isRegExp:function(o){return o&&o.constructor.toString().indexOf('RegExp()')!=-1||false;},isObject:function(o){return(typeof(o)=='object');},toCurrency:function(i){i=parseFloat(i,10).toFixed(2);return(i=='NaN')?'0.00':i;},pxToEm:function(i,settings){settings=jQuery.extend({scope:'body',reverse:false},settings);var pxVal=(i==='')?0:parseFloat(i);var scopeVal;var getWindowWidth=function(){var de=document.documentElement;return self.innerWidth||(de&&de.clientWidth)||document.body.clientWidth;};if(settings.scope=='body'&&$.ui_timepickr.ie&&(parseFloat($('body').css('font-size'))/getWindowWidth()).toFixed(1)>0.0){var calcFontSize=function(){return(parseFloat($('body').css('font-size'))/getWindowWidth()).toFixed(3)*16;};scopeVal=calcFontSize();}
else{scopeVal=parseFloat(jQuery(settings.scope).css("font-size"));}
var result=(settings.reverse===true)?(pxVal*scopeVal).toFixed(2)+'px':(pxVal/scopeVal).toFixed(2)+'em';return result;}});$.extend($.fn,{type:function(){try{return $(this).get(0).nodeName.toLowerCase();}
catch(e){return false;}},selectRange:function(start,end){if($(this).get(0).createTextRange){var range=$(this).get(0).createTextRange();range.collapse(true);range.moveEnd('character',end);range.moveStart('character',start);range.select();}
else if($(this).get(0).setSelectionRange){$(this).bind('focus',function(e){e.preventDefault();}).get(0).setSelectionRange(start,end);}
return $(this);},equalHeights:function(px){$(this).each(function(){var currentTallest=0;$(this).children().each(function(i){if($(this).height()>currentTallest){currentTallest=$(this).height();}});if(!px||!$.pxToEm){currentTallest=$.pxToEm(currentTallest);}
$(this).children().css({'min-height':currentTallest});});return this;},delay:function(time,callback){jQuery.fx.step.delay=function(){};return this.animate({delay:1},time,callback);}});})(jQuery);(function($){var strings={strConversion:{__repr:function(i){switch(this.__getType(i)){case'array':case'date':case'number':return i.toString();case'object':var o=[];for(x=0;x<i.length;i++){o.push(i+': '+this.__repr(i[x]));}
return o.join(', ');case'string':return i;default:return i;}},__getType:function(i){if(!i||!i.constructor){return typeof(i);}
var match=i.constructor.toString().match(/Array|Number|String|Object|Date/);return match&&match[0].toLowerCase()||typeof(i);},__pad:function(str,l,s,t){var p=s||' ';var o=str;if(l-str.length>0){o=new Array(Math.ceil(l/p.length)).join(p).substr(0,t=!t?l:t==1?0:Math.ceil(l/2))+str+p.substr(0,l-t);}
return o;},__getInput:function(arg,args){var key=arg.getKey();switch(this.__getType(args)){case'object':var keys=key.split('.');var obj=args;for(var subkey=0;subkey<keys.length;subkey++){obj=obj[keys[subkey]];}
if(typeof(obj)!='undefined'){if(strings.strConversion.__getType(obj)=='array'){return arg.getFormat().match(/\.\*/)&&obj[1]||obj;}
return obj;}
else{}
break;case'array':key=parseInt(key,10);if(arg.getFormat().match(/\.\*/)&&typeof args[key+1]!='undefined'){return args[key+1];}
else if(typeof args[key]!='undefined'){return args[key];}
else{return key;}
break;}
return'{'+key+'}';},__formatToken:function(token,args){var arg=new Argument(token,args);return strings.strConversion[arg.getFormat().slice(-1)](this.__getInput(arg,args),arg);},d:function(input,arg){var o=parseInt(input,10);var p=arg.getPaddingLength();if(p){return this.__pad(o.toString(),p,arg.getPaddingString(),0);}
else{return o;}},i:function(input,args){return this.d(input,args);},o:function(input,arg){var o=input.toString(8);if(arg.isAlternate()){o=this.__pad(o,o.length+1,'0',0);}
return this.__pad(o,arg.getPaddingLength(),arg.getPaddingString(),0);},u:function(input,args){return Math.abs(this.d(input,args));},x:function(input,arg){var o=parseInt(input,10).toString(16);o=this.__pad(o,arg.getPaddingLength(),arg.getPaddingString(),0);return arg.isAlternate()?'0x'+o:o;},X:function(input,arg){return this.x(input,arg).toUpperCase();},e:function(input,arg){return parseFloat(input,10).toExponential(arg.getPrecision());},E:function(input,arg){return this.e(input,arg).toUpperCase();},f:function(input,arg){return this.__pad(parseFloat(input,10).toFixed(arg.getPrecision()),arg.getPaddingLength(),arg.getPaddingString(),0);},F:function(input,args){return this.f(input,args);},g:function(input,arg){var o=parseFloat(input,10);return(o.toString().length>6)?Math.round(o.toExponential(arg.getPrecision())):o;},G:function(input,args){return this.g(input,args);},c:function(input,args){var match=input.match(/\w|\d/);return match&&match[0]||'';},r:function(input,args){return this.__repr(input);},s:function(input,args){return input.toString&&input.toString()||''+input;}},format:function(str,args){var end=0;var start=0;var match=false;var buffer=[];var token='';var tmp=(str||'').split('');for(start=0;start<tmp.length;start++){if(tmp[start]=='{'&&tmp[start+1]!='{'){end=str.indexOf('}',start);token=tmp.slice(start+1,end).join('');if(tmp[start-1]!='{'&&tmp[end+1]!='}'){var tokenArgs=(typeof arguments[1]!='object')?arguments2Array(arguments,2):args||[];buffer.push(strings.strConversion.__formatToken(token,tokenArgs));}
else{buffer.push(token);}}
else if(start>end||buffer.length<1){buffer.push(tmp[start]);}}
return(buffer.length>1)?buffer.join(''):buffer[0];},calc:function(str,args){return eval(format(str,args));},repeat:function(s,n){return new Array(n+1).join(s);},UTF8encode:function(s){return unescape(encodeURIComponent(s));},UTF8decode:function(s){return decodeURIComponent(escape(s));},tpl:function(){var out='';var render=true;if(arguments.length==2&&$.isArray(arguments[1])){this[arguments[0]]=arguments[1].join('');return $(this[arguments[0]]);}
if(arguments.length==2&&$.isString(arguments[1])){this[arguments[0]]=arguments[1];return $(this[arguments[0]]);}
if(arguments.length==1){return $(this[arguments[0]]);}
if(arguments.length==2&&arguments[1]==false){return this[arguments[0]];}
if(arguments.length==2&&$.isObject(arguments[1])){return $($.format(this[arguments[0]],arguments[1]));}
if(arguments.length==3&&$.isObject(arguments[1])){return(arguments[2]==true)?$.format(this[arguments[0]],arguments[1]):$($.format(this[arguments[0]],arguments[1]));}}};var Argument=function(arg,args){this.__arg=arg;this.__args=args;this.__max_precision=parseFloat('1.'+(new Array(32)).join('1'),10).toString().length-3;this.__def_precision=6;this.getString=function(){return this.__arg;};this.getKey=function(){return this.__arg.split(':')[0];};this.getFormat=function(){var match=this.getString().split(':');return(match&&match[1])?match[1]:'s';};this.getPrecision=function(){var match=this.getFormat().match(/\.(\d+|\*)/g);if(!match){return this.__def_precision;}
else{match=match[0].slice(1);if(match!='*'){return parseInt(match,10);}
else if(strings.strConversion.__getType(this.__args)=='array'){return this.__args[1]&&this.__args[0]||this.__def_precision;}
else if(strings.strConversion.__getType(this.__args)=='object'){return this.__args[this.getKey()]&&this.__args[this.getKey()][0]||this.__def_precision;}
else{return this.__def_precision;}}};this.getPaddingLength=function(){var match=false;if(this.isAlternate()){match=this.getString().match(/0?#0?(\d+)/);if(match&&match[1]){return parseInt(match[1],10);}}
match=this.getString().match(/(0|\.)(\d+|\*)/g);return match&&parseInt(match[0].slice(1),10)||0;};this.getPaddingString=function(){var o='';if(this.isAlternate()){o=' ';}
if(this.getFormat().match(/#0|0#|^0|\.\d+/)){o='0';}
return o;};this.getFlags=function(){var match=this.getString().matc(/^(0|\#|\-|\+|\s)+/);return match&&match[0].split('')||[];};this.isAlternate=function(){return!!this.getFormat().match(/^0?#/);};};var arguments2Array=function(args,shift){var o=[];for(l=args.length,x=(shift||0)-1;x<l;x++){o.push(args[x]);}
return o;};$.extend(strings);})(jQuery);(function($){$.tpl('timepickr.menu','<div class="ui-helper-reset ui-timepickr ui-widget" />');$.tpl('timepickr.row','<ol class="ui-timepickr-row ui-helper-clearfix" />');$.tpl('timepickr.button','<li class="{className:s}"><span class="ui-state-default">{label:s}</span></li>');$.widget_timepickr('ui_timepickr.timepickr',{plugins:{},_init:function(){this._dom={menu:$.tpl('timepickr.menu'),row:$.tpl('timepickr.menu')};this._trigger('initialize');this._trigger('initialized');},_trigger:function(type,e,ui){var ui=ui||this;$.ui_timepickr.plugin.call(this,type,[e,ui]);return $.widget_timepickr.prototype._trigger.call(this,type,e,ui);},_createButton:function(i,format,className){var o=format&&$.format(format,i)||i;var cn=className&&'ui-timepickr-button '+className||'ui-timepickr-button';return $.tpl('timepickr.button',{className:cn,label:o}).data('id',i).bind('mouseover',function(){$(this).siblings().find('span').removeClass('ui-state-hover').end().end().find('span').addClass('ui-state-hover');});},_addRow:function(range,format,className,insertAfter){var ui=this;var btn=false;var row=$.tpl('timepickr.row').bind('mouseover',function(){$(this).next().show();});if(className){$(row).addClass(className);}
$.each(range,function(idx,val){ui._createButton(val,format||false).appendTo(row);});if($(row).hasClass('hours')){h=10;}else{h=$('li',row).length;}
$(row).css("height",h=(22*Math.ceil(h/10)+6)+"px");if(this.options.corners){}
if(insertAfter){row.insertAfter(insertAfter);}
else{ui._dom.menu.append(row);}
return row;},_setVal:function(val){val=val||this._getVal();this.element.data('timepickr.initialValue',val);if(val.h||val.m||val.s){this.element.val(this._formatVal(val));}
if(this._dom.menu.is(':hidden')){this.element.trigger('change',[{},true]);}},_getVal:function(){var ols=this._dom.menu.find('ol');function get(unit){var u=ols.filter('.'+unit).find('.ui-state-hover:first').text();return u||ols.filter('.'+unit+'li:first span').text();}
return{h:get('hours'),m:get('minutes'),s:get('seconds'),a:get('prefix'),z:get('suffix'),f:this.options['format'+this.c],c:this.c};},_formatVal:function(ival){var val=ival||this._getVal();val.c=this.options.convention;if(this.options.seconds){val.f=val.c===12&&this.options.format12sec||this.options.format24sec;}else{val.f=val.c===12&&this.options.format12||this.options.format24;}
return(new Time(val)).getTime();},blur:function(){return this.element.blur();},focus:function(){return this.element.focus();},show:function(){this._trigger('show');this.element.trigger(this.options.trigger);},hide:function(){this._trigger('hide');this._dom.menu.hide();}});$.extend($.ui_timepickr.timepickr,{version:'0.7.0a',defaults:{convention:24,trigger:'mouseover',format12:'{h:02.d}:{m:02.d} {z:s}',format24:'{h:02.d}:{m:02.d}',format12sec:'{h:02.d}:{m:02.d}:{s:02.d}  {z:s}',format24sec:'{h:02.d}:{m:02.d}:{s:02.d}',hours:true,prefix:['AM','PM'],suffix:['AM','PM'],prefixVal:false,suffixVal:true,rangeHour12:$.range(1,13),rangeHour24:[$.range(0,12),$.range(12,24)],rangeMin:$.range(0,60,15),rangeSec:$.range(0,60,15),corners:'all',core:true,minutes:true,seconds:false,val:false,updateLive:true,resetOnBlur:true,keyboardnav:true,handle:false,handleEvent:'click'}});$.ui_timepickr.plugin.add('timepickr','core',{initialized:function(e,ui){var menu=ui._dom.menu;menu.appendTo("body");ui.element.bind(ui.options.trigger,function(){ui._dom.menu.show();ui._dom.menu.find('ol:first').show();ui._trigger('focus');if(ui.options.trigger!='focus'){ui.element.focus();}
ui._trigger('focus');}).bind('blur',function(){ui.hide();ui._trigger('blur');});menu.find('li').bind('mouseover.timepickr',function(){ui._trigger('refresh');});},refresh:function(e,ui){ui._dom.menu.find('ol').each(function(){var p=$(this).prev('ol');try{$(this).css('left',p.position().left+p.find('.ui-state-hover').position().left);}catch(e){};});}});$.ui_timepickr.plugin.add('timepickr','hours',{initialize:function(e,ui){if(ui.options.convention===24){ui._dom.prefix=ui._addRow(ui.options.prefix,false,'prefix');if($.isArray(ui.options.rangeHour24[0])){var range=[];$.merge(range,ui.options.rangeHour24[0]);$.merge(range,ui.options.rangeHour24[1]);ui._dom.hours=ui._addRow(range,'{0:0.2d}','hours');ui._dom.hours.find('li').slice(ui.options.rangeHour24[0].length,-1).hide();var lis=ui._dom.hours.find('li');var show=[function(){lis.slice(ui.options.rangeHour24[0].length).hide().end().slice(0,ui.options.rangeHour24[0].length).show().filter(':visible:first').trigger('mouseover');},function(){lis.slice(0,ui.options.rangeHour24[0].length).hide().end().slice(ui.options.rangeHour24[0].length).show().filter(':visible:first').trigger('mouseover');}];ui._dom.prefix.find('li').bind('mouseover.timepickr',function(){var index=ui._dom.menu.find('.prefix li').index(this);show[index].call();});}
else{ui._dom.hours=ui._addRow(ui.options.rangeHour24,'{0:0.2d}','hours');ui._dom.hours.find('li').slice(12,-1).hide();}}
else{ui._dom.hours=ui._addRow(ui.options.rangeHour12,'{0:0.2d}','hours');ui._dom.suffix=ui._addRow(ui.options.suffix,false,'suffix');}}});$.ui_timepickr.plugin.add('timepickr','minutes',{initialize:function(e,ui){var p=ui._dom.hours&&ui._dom.hours||false;ui._dom.minutes=ui._addRow(ui.options.rangeMin,'{0:0.2d}','minutes',p);}});$.ui_timepickr.plugin.add('timepickr','seconds',{initialize:function(e,ui){var p=ui._dom.minutes&&ui._dom.minutes||false;ui._dom.seconds=ui._addRow(ui.options.rangeSec,'{0:0.2d}','seconds',p);}});$.ui_timepickr.plugin.add('timepickr','val',{initialized:function(e,ui){ui._setVal(ui.options.val);}});$.ui_timepickr.plugin.add('timepickr','updateLive',{refresh:function(e,ui){ui._setVal();}});$.ui_timepickr.plugin.add('timepickr','resetOnBlur',{initialized:function(e,ui){ui.element.data('timepickr.initialValue',ui._getVal());ui._dom.menu.find('li > span').bind('mousedown.timepickr',function(){ui.element.data('timepickr.initialValue',ui._getVal());});},blur:function(e,ui){ui._setVal(ui.element.data('timepickr.initialValue'));}});$.ui_timepickr.plugin.add('timepickr','handle',{initialized:function(e,ui){$(ui.options.handle).bind(ui.options.handleEvent+'.timepickr',function(){ui.show();});}});$.ui_timepickr.plugin.add('timepickr','keyboardnav',{initialized:function(e,ui){ui.element.bind('keydown',function(e){if($.keyIs('enter',e)){ui._setVal();ui.blur();}
else if($.keyIs('escape',e)){ui.blur();}});}});var Time=function(){if(!(this instanceof arguments.callee)){throw Error("Constructor called as a function");}
if(arguments.length==1&&$.isObject(arguments[0])){this.h=arguments[0].h||0;this.m=arguments[0].m||0;this.s=arguments[0].s||0;this.c=arguments[0].c&&($.inArray(arguments[0].c,[12,24])>=0)&&arguments[0].c||24;this.f=arguments[0].f||((this.c==12)&&'{h:02.d}:{m:02.d} {z:02.d}'||'{h:02.d}:{m:02.d}');this.z=arguments[0].z||'am';}
else if(arguments.length<4&&$.isString(arguments[1])){this.c=arguments[2]&&($.inArray(arguments[0],[12,24])>=0)&&arguments[0]||24;this.f=arguments[3]||((this.c==12)&&'{h:02.d}:{m:02.d} {z:02.d}'||'{h:02.d}:{m:02.d}');this.z=arguments[4]||'am';this.h=arguments[1]||0;this.m=arguments[1]||0;this.s=arguments[1]||0;}
else if(arguments.length===0){}
else{this.h=arguments[0]||0;this.m=arguments[1]||0;this.s=arguments[2]||0;this.c=arguments[3]&&($.inArray(arguments[3],[12,24])>=0)&&arguments[3]||24;this.f=this.f||((this.c==12)&&'{h:02.d}:{m:02.d} {z:02.d}'||'{h:02.d}:{m:02.d}');this.z='am';}
return this;};Time.prototype.get=function(p,f,u){return u&&this.h||$.format(f,this.h);};Time.prototype.getHours=function(unformated){return this.get('h','{0:02.d}',unformated);};Time.prototype.getMinutes=function(unformated){return this.get('m','{0:02.d}',unformated);};Time.prototype.getSeconds=function(unformated){return this.get('s','{0:02.d}',unformated);};Time.prototype.setFormat=function(format){return this.f=format;};Time.prototype.getObject=function(){return{h:this.h,m:this.m,s:this.s,c:this.c,f:this.f,z:this.z};};Time.prototype.getTime=function(){return $.format(this.f,{h:this.h,m:this.m,s:this.s,z:this.z});};Time.prototype.parse=function(str){if(this.c===12){this.tokens=str.split(/\s|:/);this.h=this.tokens[0]||0;this.m=this.tokens[1]||0;this.s=this.tokens[2]||0;this.z=this.tokens[3]||'';return this.getObject();}
else{this.tokens=/:/.test(str)&&str.split(/:/)||str.match(/[0-9]{2}/g);this.h=this.tokens[0]||0;this.m=this.tokens[1]||0;this.s=this.tokens[2]||0;this.z=this.tokens[3]||'';return this.getObject();}};})(jQuery);
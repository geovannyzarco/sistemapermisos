
Runner.buttonEvents["Ver_Instrutivo"]=function(pageObj,proxy,pageid){pageObj.buttonNames[pageObj.buttonNames.length]='Ver_Instrutivo';if(!pageObj.buttonEventBefore['Ver_Instrutivo']){pageObj.buttonEventBefore['Ver_Instrutivo']=function(params,ctrl,pageObj,proxy,pageid,rowData,row){window.open("http://192.168.1.135/permisos/documentos/instrutivo.pdf","Normativa","width=800, height=500")}}
if(!pageObj.buttonEventAfter['Ver_Instrutivo']){pageObj.buttonEventAfter['Ver_Instrutivo']=function(result,ctrl,pageObj,proxy,pageid,rowData,row){}}
$('a[id="Ver_Instrutivo"]').each(function(){if($(this).closest('.gridRowAdd').length){return;}
this.id="Ver_Instrutivo"+"_"+Runner.genId();var button_Ver_Instrutivo=new Runner.form.Button({id:this.id,btnName:"Ver_Instrutivo"});button_Ver_Instrutivo.init({args:[pageObj,proxy,pageid]});});};
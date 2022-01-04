function showHide(secim){
    console.log(secim);

    switch(secim){
        case 1:
            document.getElementById("taban_yukseklik").style.display="block";
            document.getElementById("daire_yaricap").style.display="none";
            break;
        case 2:
            document.getElementById("taban_yukseklik").style.display="none";
            document.getElementById("daire_yaricap").style.display="block";
            break;
        default:
            document.getElementById("taban_yukseklik").style.display="block";
            document.getElementById("daire_yaricap").style.display="none";
            break;        
    }
   /* if(secim==1){
        console.log("Dikdorget ve Üçgen");
        document.getElementById("taban_yukseklik").style.display="block";
        document.getElementById("daire_yaricap").style.display="none";

    }else{
        console.log("Daire");
        document.getElementById("taban_yukseklik").style.display="none";
        document.getElementById("daire_yaricap").style.display="block";
    }*/
   
}

function calculate(){
   console.log("Hesaplama");
   var taban=document.getElementById("taban").value;
   var yukseklik=document.getElementById("yukseklik").value;
   var yaricap=document.getElementById("yaricap").value;
   //console.log(document.getElementById("dikdortgen").checked);
   //console.log(document.getElementById("ucgen").checked);
   //console.log(document.getElementById("daire").checked);
   if(document.getElementById("dikdortgen").checked){
      document.getElementById("sonuc").value=taban*yukseklik;
   }
   if(document.getElementById("ucgen").checked){
    console.log("ucgen seçildi");
    document.getElementById("sonuc").value=taban*yukseklik/2;
    
}
    if(document.getElementById("daire").checked){
        console.log("daire seçildi");
        document.getElementById("sonuc").value=3*yaricap*yaricap;
    }

}

function clearBoxes(){
    document.getElementById("taban").value="";
    document.getElementById("yukseklik").value="";
    document.getElementById("yaricap").value="";
    document.getElementById("sonuc").value="";
}


document.addEventListener('scroll', function(e) {
    //console.log(window.scrollY);
    if(window.scrollY>0){
        window.scrollTo(0,0);
    }
  });
//console.log("Parogram çalıştı");

//Bu bir fonksiyon. Bu yanlızca tetiklenince yada çağrılınca çalışır.
function closePromo(){
    //alert("Çalışrı");
    // console.log("Kapat fonksiyonu çalıştı");
     document.getElementById("promo").style.display="none";
}

function changeColor(){
    var r=Math.floor(Math.random() * 255);
    var g=Math.floor(Math.random() * 255);
    var b=Math.floor(Math.random() * 255);
    
    var renk="rgb("+r+","+g+","+b+")";
    document.getElementById("contentHead").style.color=renk;
}

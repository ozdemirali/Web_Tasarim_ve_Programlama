<<<<<<< HEAD

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

function closeAdver(){
    //alert("Çalıştı");
    // console.log("Kapat fonksiyonu çalıştı");
     document.getElementById("adver").style.display="none";
}

function moveAdver(){
    var element = document.getElementById("adver");
    element.classList.add("adver-move");
}

function changeColor(){
    var r=Math.floor(Math.random() * 255);
    var g=Math.floor(Math.random() * 255);
    var b=Math.floor(Math.random() * 255);
    
    var renk="rgb("+r+","+g+","+b+")";
    document.getElementById("contentHead").style.color=renk;
}



=======

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

function closeAdver(){
    //alert("Çalıştı");
    // console.log("Kapat fonksiyonu çalıştı");
     document.getElementById("adver").style.display="none";
}

function moveAdver(){
    var element = document.getElementById("adver");
    element.classList.add("adver-move");
}

function changeColor(){
    var r=Math.floor(Math.random() * 255);
    var g=Math.floor(Math.random() * 255);
    var b=Math.floor(Math.random() * 255);
    
    var renk="rgb("+r+","+g+","+b+")";
    document.getElementById("contentHead").style.color=renk;
}



>>>>>>> 7874f100013bcfcb0f849b4016e5d99552b5f48a

<<<<<<< HEAD
function showHide(){
    var a = document.getElementById("test").innerHTML;
    console.log(a);

    if(a=="[Göster]"){
        console.log("Göster");
        document.getElementById("info").style.display="block";
        document.getElementById("test").innerHTML="[Gizle]";
    }else
    {
        console.log("Gizle");
        document.getElementById("info").style.display="none";
        document.getElementById("test").innerHTML="[Göster]";
    }
}

function show(){
    document.getElementById("info").style.display="block";
}

function hide(){
    document.getElementById("info").style.display="none";
=======
function showHide(){
    var a = document.getElementById("test").innerHTML;
    console.log(a);

    if(a=="[Göster]"){
        console.log("Göster");
        document.getElementById("info").style.display="block";
        document.getElementById("test").innerHTML="[Gizle]";
    }else
    {
        console.log("Gizle");
        document.getElementById("info").style.display="none";
        document.getElementById("test").innerHTML="[Göster]";
    }
}

function show(){
    document.getElementById("info").style.display="block";
}

function hide(){
    document.getElementById("info").style.display="none";
>>>>>>> 7874f100013bcfcb0f849b4016e5d99552b5f48a
}
function hesapla(){
    console.log("Çalıştı");
    var long=parseInt(document.getElementById("long").value);
    var short=parseInt(document.getElementById("short").value);
    var result;

    result=long*short;
    document.getElementById("result").value=result;
    document.getElementById("info").style.display="block";
}
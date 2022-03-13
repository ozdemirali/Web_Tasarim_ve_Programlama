<<<<<<< HEAD
function Kontrol(){
    var name=document.getElementById("name").value;
    var email=document.getElementById("email").value;
    var phone=document.getElementById("phone").value;
    var mesaj=document.getElementById("mesaj").value;
  
    if(name==""){
        document.getElementById("vname").style.display="block";
        return false;
    }
    else{
        document.getElementById("vname").style.display="none";
    }

    if(email==""){
        document.getElementById("vemail").style.display="block";
        return false;
    }
    else{
        document.getElementById("vemail").style.display="none";
    }

    if(phone==""){
        document.getElementById("vphone").style.display="block";
        return false;
    }
    else{
        document.getElementById("vphone").style.display="none";
    }

    if(mesaj==""){
        document.getElementById("vmesaj").style.display="block";
        return false;
    }
    else{
        document.getElementById("vmesaj").style.display="none";
    }

    return true;
 
 
}


=======
function Kontrol(){
    var name=document.getElementById("name").value;
    var email=document.getElementById("email").value;
    var phone=document.getElementById("phone").value;
    var mesaj=document.getElementById("mesaj").value;
  
    if(name==""){
        document.getElementById("vname").style.display="block";
        return false;
    }
    else{
        document.getElementById("vname").style.display="none";
    }

    if(email==""){
        document.getElementById("vemail").style.display="block";
        return false;
    }
    else{
        document.getElementById("vemail").style.display="none";
    }

    if(phone==""){
        document.getElementById("vphone").style.display="block";
        return false;
    }
    else{
        document.getElementById("vphone").style.display="none";
    }

    if(mesaj==""){
        document.getElementById("vmesaj").style.display="block";
        return false;
    }
    else{
        document.getElementById("vmesaj").style.display="none";
    }

    return true;
 
 
}


>>>>>>> 7874f100013bcfcb0f849b4016e5d99552b5f48a

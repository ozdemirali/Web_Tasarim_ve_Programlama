const months = ["Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Agustos", "Eylül", "Ekim", "Kasım", "Aralık"];
const d = new Date();

document.getElementById("date-show") .innerHTML =d.getDate() +" "+months[d.getMonth()] + " "+d.getFullYear() ;
//document.getElementsByClassName("date-show")[0] .innerHTML =d.getDate() +" "+months[d.getMonth()] + " "+d.getFullYear() ;
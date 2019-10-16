// JavaScript source code
$(document).ready(
    function () {
        setInterval(atualizaData,1000);
    }
);

function atualizaData() {
    $('span[name = "data"]').text(Date());
}

function converte() {
    var n = document.getElementById("numeroC").value;
    alert("Resultado em Dolar: " + n / 4);
}
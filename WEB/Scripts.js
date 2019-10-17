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
    var d = document.getElementById("numeroR");
    d.value = "R$ " + n / 4.16;

//   alert("Obrigado por acessar nosso site");
}
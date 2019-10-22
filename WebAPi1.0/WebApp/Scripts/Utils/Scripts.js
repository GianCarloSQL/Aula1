// carrega o documento
$(document).ready(function () {
    $('#btn2').click(function () {
        $.getJSON("https://viacep.com.br/ws/RS/Porto%20Alegre/all/json/", function (object) {
            object[0].logradouro;
            $.each(object, function (k, v) {
                k.logradouro;
                $('#area').val
                ("Key: " + k + "\r\nVar: " + v);
            });
        });
    });
});
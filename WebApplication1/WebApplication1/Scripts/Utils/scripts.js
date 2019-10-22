//carregamento do documento
$(document).ready(function () {
    //adicionando uma função ao click do botão
    $('#Button1').click(function () {
        //conectando com api web
        $.getJSON("https://viacep.com.br/ws/RS/Porto%20Alegre/all/json/", function (data) {

            var templateContent = '';

            templateContent += '<div><table class="table"><tbody>' +
                '<th>Valor</th>' +
                '<th>Localidade</th>' +
                '<th>Código CEP</th>' +
                '<th>Logradouro</th>' +
                '<th>Bairro</th>' +
                '<th>IBGE</th>' +
                '<th>GIA</th>' +
                '<th>Complemento</th>' +

                '<td>';

            $.each(data, function (key, value) {
                templateContent += "<tr><td>" + key + "</td> "
                    + "<td>" + value.localidade + "</td>"
                    + "<td style='width:40px'>" + value.cep + "</td>"
                    + "<td>" + value.logradouro + "</td>"
                    + "<td>" + value.bairro + "</td>"
                    + "<td>" + value.ibge + "</td>"
                    + "<td>" + value.gia + "</td>"
                    + "<td>" + value.complemento + "</td></tr>";
            });
            $('#divContent').append("" + templateContent + "");
            templateContent += '</td></tbody></table></div>';
        });
    });
});

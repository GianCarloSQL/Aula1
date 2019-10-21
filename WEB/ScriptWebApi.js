$(document).ready(
    function () {
        $('input[type="button"]').click(
            function () {
               var x = $('input[name="cepName"]').val();
                $.getJSON("http://dummy.restapiexample.com/api/v1/employee/" + x + "", function (data) {
                    alert("Data: \r\n" + data.employee_name + "\r\n Status: " + status);
                    $('input[name="cepResult"]').val(data.data.employee_name);
                });
            }
        );

    });
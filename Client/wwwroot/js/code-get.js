$(function () {
    j = 0;
    $("#code-track").keyup(function () {
        j = j + 1;
        if (j == 7) {
            var url = "http://localhost:64794/api/Flight/GetByCode/".concat($("#code-track").val());

            $.ajax({
                type: "GET",
                url: url,
                contentType: "application/json; charset=utf-8",
                dataType: "json"
            }).done(function (data) {
                $("#code-track").val(data.flightCode);
                $("#origin").val(data.origin);
                $("#destination").val(data.destination);
                $("#departure").val(data.departure);
            }).fail(function () {
                alert("A flight with this code does not exists, and will be added.");
            });
        }
    });
});
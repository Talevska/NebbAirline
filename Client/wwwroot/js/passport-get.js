$(function () {
    i = 0;
    $("#passport-track").keyup(function () {
        i = i + 1;
        if (i == 9) {
            var url = "http://localhost:64794/api/Passenger/GetByPassport/".concat($("#passport-track").val());
            $.ajax({
                type: "GET",
                url: url,
                contentType: "application/json; charset=utf-8",
                dataType: "json"
            }).done(function (data) {
                $("#firstName").val(data.firstName);
                $("#lastName").val(data.lastName);

                var date = new Date(data.dateBirth);
                var year = date.getFullYear();
                var month = (1 + date.getMonth()).toString().padStart(2, '0');
                var day = date.getDate().toString().padStart(2, '0');
                var output = year + '-' + month + '-' + day;

                $("#dateBirth").val(output);
                $("#passport-track").val(data.passport);
            }).fail(function () {
                alert('Passenger with this passport # does not exists, and will be added.');
            });
        }
    });
});

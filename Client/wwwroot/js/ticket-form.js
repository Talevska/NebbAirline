$(function () {
    $("input").each(function () {
        if ($(this).attr("id") != "return" && $(this).attr("type") != "submit" && $(this).attr("type") != "reset" && $(this).attr("type") != "hidden") {
            $(this).after("<span style=\"color: red\" class=\"asterix\"> *</span>");
        }
    });
});
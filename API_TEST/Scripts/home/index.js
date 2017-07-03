var ApiUrl = "localhost:55307/";
$(function () {
    $.ajax({
        type: "get",
        url: ApiUrl + "api/Charging/GetAllChargingData",
        data: {},
        success: function (data, status) {
            if (status == "success") {
                $("#div_test").html(data);
            }
        },
        error: function (e) {
            alert(ApiUrl + "api/Charging/GetAllChargingData");
            alert(status);
            $("#div_test").html("Error");
        },
        complete: function () {

        }

    });
});
var ApiUrl = "http://localhost:55307/";
$(function () {
    $.ajax({
        type: "get",
        async: true,
        datatype: Text,
        //beforeSend: function (XHR) {
        //    //发送ajax请求之前向http的head里面加入验证信息
        //    XHR.setRequestHeader('Authorization', 'BasicAuth ' + Ticket);
        //},
        url: ApiUrl + "api/Charging/GetAllChargingData",
        data: {},
        success: function (data, status) {
            if (status == "success") {
                $("#div_test").html(data);
            }
        },
        error: function (e) {
           // alert(ApiUrl + "api/Charging/GetAllChargingData");
           // alert(status);
            $("#div_test").html("Error");
           // alert( $("#ticket").val());
        },
        complete: function () {

        }

    });
});
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
        url: ApiUrl + "User/GetUser",
        data: {},
        success: function (json) {
            {
                //alert(json.errorcode);
                //alert(json.data);
                //alert(json.data.UserName);
                var name = "";
               // alert(data.data.Password);
            $.each(json.data, function (i,person) {
                name = name + person.UserName;
            })
            $("#username").val(name);
            //alert(name)
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
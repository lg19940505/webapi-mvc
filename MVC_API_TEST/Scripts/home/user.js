function btnClick(){
    $.ajax({
        type: "get",
        async: true,
        datatype: Text,
        url: "http://localhost:55307/api/User/Login",
        data: { strUser: $("#txt_username").val(), strPwd: $("#txt_password").val() },
        success: function (data, status) {
            if (status == "success") {
               // alert(data);
                if (data=="false") {
                    alert("登录失败");
                    return;
                }
                //alert("登录成功");
                //登录成功之后将用户名和用户票据带到主界面
                window.location = "/Home/Index?UserName=" + "aaa" + "&Ticket=" + data;
            }
        },
        error: function (e) {
           // alert("error"); alert(data);
        },
        complete: function () {

        }

});};


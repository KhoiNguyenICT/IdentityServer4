function login() {
    var email = $("#Email").val();
    var password = $("#Password").val();
    debugger;
    var settings = {
        "async": true,
        "crossDomain": true,
        "url": "/connect/token",
        "method": "POST",
        "headers": {
            "cache-control": "no-cache"
        },
        "data": {
            "grant_type": "password",
            "client_id": "icp-web-app",
            "client_secret": "icp-web-app-secret",
            "username": email,
            "password": password,
            "scope": "IcpAPI"
        }
    }

    $.ajax(settings).done(function (response) {
        if (response !== null) {
            window.location.href = "http://localhost:4200/authenication/validate/" + response.access_token;
        } else {
            alert("Tài khoản hoặc mật khẩu không chính xác");
        }
    });
}
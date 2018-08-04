function login() {
    var email = $("#Email").val();
    var password = $("#Password").val();
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
            "client_id": "google-web-app",
            "client_secret": "google-web-app-secret",
            "username": email,
            "password": password,
            "scope": "GoogleAPI"
        }
    }

    $.ajax(settings).done(function (response) {
        if (response !== null) {
            window.location.href = "http://localhost:4200/authentication/login/" + response.access_token;
        } else {
            alert("Tài khoản hoặc mật khẩu không chính xác");
        }
    });
}
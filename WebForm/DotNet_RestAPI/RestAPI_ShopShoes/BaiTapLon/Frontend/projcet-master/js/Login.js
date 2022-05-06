function onSignIn(googleUser) {
    var profile = googleUser.getBasicProfile();
/*    form_element.classList.remove('active');
*/    localStorage.setItem("user", profile.getName());
    document.getElementById("sign-in1").innerHTML = '';
    document.getElementById("sign-in1").innerHTML = '<button style="background-color: cornflowerblue;"><a href="" id="logout" onClick="signOut()">Đăng xuất</a></button>';
    document.getElementById("log").textContent = profile.getName();
}

function signOut() {
    var auth2 = gapi.auth2.getAuthInstance();
    auth2.signOut().then(function () {
        localStorage.setItem("user", null);
    });
}

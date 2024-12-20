window.onload = function() {
    var userAgent = navigator.userAgent.toLowerCase();
    
    if (!/windows/i.test(userAgent)) {
        window.location.href = "notsupport.html";
    }

    if (window.innerWidth <= 800) {
        window.location.href = "notsupport.html";
    }
}

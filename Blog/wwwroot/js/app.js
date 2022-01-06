function highlightCode() {
    var pres = document.querySelectorAll("pre>code");
    for (var i = 0; i < pres.length; i++) {
        hljs.highlightBlock(pres[i]);
    }
}

var getTheme = function () {
    return JSON.parse(localStorage.getItem("darkmode") ?? "false") ? "dark" : "light";
}

var loadTheme = function () {
    var theme = JSON.parse(localStorage.getItem("darkmode") ?? "false") ? "dark" : "light";
    document.documentElement.setAttribute('data-theme', theme);
}

var toggleTheme = function () {
    var lsValue = JSON.parse(localStorage.getItem("darkmode") ?? "false");
    var theme = !lsValue ? "dark" : "light";
    localStorage.setItem("darkmode", !lsValue);
    document.documentElement.setAttribute('data-theme', theme);
    return theme;
}
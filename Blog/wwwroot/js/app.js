function highlightCode() {
    var pres = document.querySelectorAll("pre>code");
    for (var i = 0; i < pres.length; i++) {
        hljs.highlightBlock(pres[i]);
    }
}

var setDarkMode = function (isDarkModeEnabled) {
    document.documentElement.setAttribute('data-theme', isDarkModeEnabled ? "true" : "light");
}
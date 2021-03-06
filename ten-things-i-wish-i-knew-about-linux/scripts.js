function trimIndent(e) {
    var t = (e.match(INDENT_RE) || [""])[0].length;
    if (t > 0) {
        var n = e.substring(0, t);
        return e.replace(new RegExp(n, "g"), "")
    }
}
function renderSlide(e, t, n) {
    var i = t.split("\n"), r = -1, o = document.createElement("div"), d = document.createElement("div"), s = "";
    o.className = "slide slide-" + n, d.className = "slide-content";
    for (var l = 0; l < i.length; l++) {
        var a = i[l];
        if (a.startsWith("#")) s = s + "<h1>" + a.substring(1) + "</h1>";
        else if (a.startsWith("  ") || a.startsWith("	")) s = s + "<pre>" + a.replace(/^(  )|\t/, "") + "</pre>";
        else {
            a.startsWith(".") && (a = a.substring(1));
            for (var c = 0; c < a.length; c++) {
                var h = a.charAt(c); "*" == h ? -1 == r
                    ? (s += "<strong>", r = s.length)
                    : (r != s.length ? s += "</strong>"
                        : s = s.substring(0, s.length - 8) + "*", r = -1)
                    : s += h
            } s += "<br/>"
        }
    }
    d.innerHTML = s, o.appendChild(d), e.appendChild(o), o.style.visibility = "hidden"
}
function render(e) {
    var t = document.createElement("div");
    t.className = "slide-root", document.body.appendChild(t), e = trimIndent(e);
    for (var n = e.split(/[\s+]\n/gm), i = 0; i < n.length; i++) {
        var r = n[i].trim();
        renderSlide(t, r, i)
    }
    return t
}
function resize() {
    var e = window.innerWidth, t = window.innerHeight, n = document.body.offsetWidth, i = document.body.offsetHeight, r = n / i > e / t ? e / n : t / i;
    document.body.style.transform = "scale(" + r + ")"
}
function goTo(e) {
    currentSlide = e, window.location.hash = e;
    for (var t = document.querySelectorAll(".slide"), n = 0; n < t.length; n++) {
        var i = t[n], r = i.children[0], o = .8 * i.offsetWidth / r.offsetWidth, d = .8 * i.offsetHeight / r.offsetHeight;
        r.style.transform = "scale(" + Math.min(o, d) + ")", n == currentSlide
            ? i.style.visibility = ""
            : i.style.visibility = "hidden"
    }
}
function next() {
    goTo(Math.min(currentSlide + 1, document.querySelectorAll(".slide").length - 1))
}
function prev() {
    goTo(Math.max(currentSlide - 1, 0))
}
var INDENT_RE = /^(?:( )+|\t+)/, currentSlide = -1;
window.onload = function () {
    resize(),
        render(document.getElementById("slide").innerHTML),
        goTo(window.location.hash.substring(1) || 0)
    window.onclick = next,
        window.onresize = resize,
        window.onkeydown = function (e) {
            39 == e.keyCode ? next() : 37 == e.keyCode && prev()
        }
};
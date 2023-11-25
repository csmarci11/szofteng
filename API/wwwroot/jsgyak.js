window.onload = function () {
    for (var i = 0; i < 10; i++) {
        var ujdiv = document.createElement("div");
        ujdiv.classList.add("sor");
        var pascaldiv = document.getElementById("pascal");
        pascaldiv.appendChild(ujdiv);

        for (var j = 0; j <= i; j++) {
            var ujdiv2 = document.createElement("div");
            ujdiv2.classList.add("elem");
            ujdiv2.innerText = fac(i) / (fac(j) * fac(i - j));
            ujdiv.appendChild(ujdiv2);
        }
    }
};

var fac = function (n) {
    let er = 1;
    for (let i = 2; i <= n; i++) {
        er = er * i;
    }
    return er
};
$.fn.highlight = function (what, spanClass) {
    return this.each(function () {
        var orgText = this.innerHTML
        var index = orgText.indexOf(what);
        if (index >= 0) {
            this.innerHTML = orgText.substring(0, index) + "<span class='" + spanClass + "'>" +
                orgText.substring(index, index + what.length) + "</span>" +
                orgText.substring(index + what.length, orgText.length);
        }
    });
}
var simplemde = new SimpleMDE({
    element: document.getElementById('Content')
});

var imageLinks = "";
var clicks = 0;

$("#js-example-tags").select2({
    tags: true,
    width: 'resolve'
});

$(document).ready(function () {
    $('.custom-file-input').on("change", function () {
        var fileLabel = $(this).next('.custom-file-label');
        var files = $(this)[0].files;
        if (files.length > 1) {
            fileLabel.html(files.length + ' files selected');
        }
        else if (files.length == 1) {
            fileLabel.html(files[0].name);
            //function CallCsharpcode() {
            //    $.ajax({
            //        type: "POST",

            //    })
            //}
        }
    });
});

function setLogo(imageLink, img) {
    if (clicks == 0) {
        document.getElementById('logo').value = imageLink;
        img.style.border = "5px solid red";
        clicks++;
    }
    else {
        document.getElementById('logo').value = "";
        img.style.border = "0px";
        clicks--;
    }
}
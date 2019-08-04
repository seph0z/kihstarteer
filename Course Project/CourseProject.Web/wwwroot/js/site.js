var simplemde = new SimpleMDE({
    element: document.getElementById('Content')
});

var imageLinks = "";

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
        }
    });
});


function scrollRewardAdd() {
    $([document.documentElement, document.body]).animate({
        scrollTop: $("#elementtoScrollToID").offset().top
    }, 1000);
};

function scrollReward() {
    $([document.documentElement, document.body]).animate({
        scrollTop: $("#headContent").offset().top
    }, 1000);
};

function scrollRewardUpdate() {
    $([document.documentElement, document.body]).animate({
        scrollTop: $("#scrollUpdate").offset().top
    }, 1000);
};

function scrollRewardTake() {
    $([document.documentElement, document.body]).animate({
        scrollTop: $("#topScrollGet").offset().top
    }, 500);
};
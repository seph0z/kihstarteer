﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$("#js-example-tags").select2({
    tags: true,
    width: 'resolve'
});

var simplemde = new SimpleMDE({ element: document.getElementById("Content") });
// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let collapsedState = true;
$(function () {
    $("#collapse").click(function () {
        console.log("test");
        $(".fa-chevron-left").toggleClass("fa-chevron-right");
        if (collapsedState) {
            $(".asideMenu").hide();
            collapsedState = false;
            return;
        }

        $(".asideMenu").show();
        collapsedState = true;
    });
});

$(document).ready(function () {
    changeHeight();
});

function changeHeight() {
    $(window).resize(function () {
        if (screen.width < 768) {
            $(".asideMenu").hide();
            collapsedState = false;
        }
    });
}
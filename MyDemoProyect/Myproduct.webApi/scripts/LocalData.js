$(document).ready (function(){
    $("btnGetProduct").click(function(){
        GetAllProduct();
    });
});

function GetAllProduct(){
    $.ajax({
        type: 'GET',
        url: 'http://localhost:51184/api/product',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {

        },
        error: function (a, b, c) {

        }
    });
}
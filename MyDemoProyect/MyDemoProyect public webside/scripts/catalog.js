﻿//Create a JSON Object that contains my products information.

//Ready: After HTML loads
$(document).ready(function () {
    //$("#DynamicHTML").append(buildMyProduct(MyCatalogData));
    GetAllProducts();
});

//Dynamic build your collection
//function buildMyProduct(obj) {
//    var html = "";
//    $.each(obj, function (element, object) {
//        html += "<div class='Catalog ProducItem'>";
//        html += "<div><a href='details.html?id=" + object.id + "'>" + object.title + "</a></div>";
//        html += "<div><img class='Catalog' src='" + object.imgUrl + "' /></div>";
//        html += "<div>" + object.description + "</div></div>";
//    });
//    return html;
//}
function GetAllProducts() {
    $.ajax({
        type: 'GET',
        url: 'http://localhost:51184/api/product',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            var html = "";
                $.each(data, function (element, object) {
                    html += "<div class='Catalog ProducItem'>";
                    html += "<div><a href='details2.html?id=" + object.Id + "'>" + object.Description + "</a></div>";
                    html += "<div><img class='Catalog' src='" + object.imgUrl + "' /></div>";
                    html += "<div>" + object.Price + "</div></div>";
                });
                $("#DynamicHTML").append(html);
        },
        error: function (a, b, c) {

        }
    });
}
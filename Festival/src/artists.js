$(document).ready(function () {

    $.getJSON("./src/artists.json", function (data) {
        var vector = [];

        $.each(data, function (i, item) {

            var playlist = '<div class="card text-white mb-3 artist-card" data-aos="zoom-in">' +
                '<div class="card-img">' +
                '<img src="./src/img/artists/' + item.image + '" class="rounded artist-photo" alt="">' +
                '</div><div class="card-img-overlay">' +
                '<h5 class="card-title artist-name">' + item.name + '</h5>' +
                '<p class="card-text artist-quote">' + item.description + '</p></div></div>';

            vector.push(playlist);
        });

        $('#container').append(vector);
    });
});
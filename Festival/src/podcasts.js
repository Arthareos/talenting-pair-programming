$(document).ready(function () {

    $.getJSON("./src/podcasts.json", function (data) {
        var vector = [];

        $.each(data, function (i, item) {

            var playlist = '<div class="card text-white mb-3 podcaster-card">' +
                '<div class="card-img">' +
                '<img src="./src/img/podcasters/' + item.image + '" class="podcaster-photo" alt="">' +
                '</div>' +
                '<div class="card-img-overlay">' +
                '<h5 class="card-title podcaster-name" style="color: ' + item.colour + ';">' + item.name + '</h5>' +
                '<div class="card-text podcaster-iframe">' +
                '<iframe src="' + item.link + '" frameBorder="0" ' +
                'allowtransparency="true" allow="encrypted-media"></iframe>' +
                '</div></div></div>'

            vector.push(playlist);
        });

        $('#container').append(vector);
    });
});
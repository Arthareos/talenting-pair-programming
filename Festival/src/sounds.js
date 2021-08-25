$(document).ready(function () {
  
    $.getJSON("./src/sounds.json", function (data) {
        var vector = [];

        $.each(data, function(i, item) {

            var playlist = '<div class="col-4"><div class="card bg-dark text-white h-100"><a href=\"' +
                    item.link + '"><img src="./src/img/sounds/' + item.image + '">'
                    '</a></div></div>';

            vector.push(playlist);
        });

        $('#sounds_container').append(vector);
    });
});
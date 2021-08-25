// When the user scrolls down 20px from the top of the document, show the button
window.onscroll = function() {
	scrollFunction()
};

function scrollFunction() {

	if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
		$('#btn_top').css('display', 'block');
	} else {
		$('#btn_top').css('display', 'none');
	}

}

function topFunction() {
  document.body.scrollTop = 0; // For Safari
  document.documentElement.scrollTop = 0; // For Chrome, Firefox, IE and Opera
}

$(document).ready(function () {
  
    $.getJSON("./src/artists.json", function (data) {
        var vector = [];

        $.each(data, function(i, item) {

            var playlist = '<div class="card text-white mb-3" style="background-color: transparent;"><div class="card-img">' +
            '<img src="./src/img/artists/' + item.image + '" class="rounded float-end" alt="" style="width: 60%;">' +
            '</div><div class="card-img-overlay">' +
            '<h5 class="card-title artist-name">' + item.name + '</h5>' +
            '<p class="card-text artist-quote">' + item.description + '</p></div></div>';

            vector.push(playlist);
        });

        $('#container').append(vector);
    });
});
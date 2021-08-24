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
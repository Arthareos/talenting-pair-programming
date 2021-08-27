var modal = document.getElementById('buy-ticket-modal')
modal.addEventListener('show.bs.modal', function (event) {
  var button = event.relatedTarget

  var title = button.getAttribute('data-bs-title');
  var price = button.getAttribute('data-bs-price');


  var modal_title = modal.querySelector('#modal-title');

  modal_title.textContent = 'Buy ' + title;


//   var modalTitle = modal.querySelector('.modal-title')
//   var modalBodyInput = modal.querySelector('.modal-body input')

//   modalTitle.textContent = 'New message to ' + recipient
//   modalBodyInput.value = recipient
})

$('#input_dob').datepicker({
    autoclose: true,
    disableTouchKeyboard: true,
    defaultViewDate: {
        year: new Date().getFullYear() - 18,
    },
    startView: 2
});
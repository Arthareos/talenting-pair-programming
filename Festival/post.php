<?php

echo '<h3>Order</h3>Order';
if (isset($_POST['first-name']) && isset($_POST['last-name'])&& isset($_POST['address'])&& isset($_POST['state'])&& isset($_POST['postal-code'])&& isset($_POST['comments'])) {
	$fname = $_POST['first-name'];
    $lname = $_POST['last-name'];
	$address = $_POST['address'];
    $state = $_POST['state'];
    $postalcode = $_POST['postal-code'];
	$comments = $_POST['comments'];
	$order = $_POST['ticket-order'];

	// show the $name and $email
	echo "First-name: $fname <br>";
	echo "Last-name: $lname <br>";
    echo "Address: $address <br>";
	echo "State: $state <br>";
    echo "Postal-code: $postalcode <br>";
	echo "Comments: $comments <br>";
	echo "Order: $order <br>";
} else {
	echo 'You need to provide data';
}
 ?>
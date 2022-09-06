<?php 
//arrays
$abc = array('a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z');
$ABC = array('A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z');
$nums = array(0, 1, 2, 3, 4, 5, 6, 7, 8, 9);
$specs = ("!","@","{","}","?");
$gen_Pass = "your password is "
$blank = ""




public function password_gen($abc, $ABC, $nums, $specs)
{
	for ($i=0; $i < 10; $i++) {
		$type = randint(1, 5); 
		if (type == 1) {
			$letters = array_rand($abc);
			$generated[$i] = $letters
			return $generated
		}
	}
}

if isset($_POST['ok']){
	print("hey");
}


 ?>
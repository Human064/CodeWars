<?php

function duplicateCount($text) {
  $checkText = str_split(strtolower($text));

  sort($checkText, $flags = SORT_STRING);

  /*
  echo "<pre>";
  print_r($checkText);
  echo "</pre>";//*/

  $length = count($checkText);

  $newSimboll = true;
  $counter = 0;

  for ($i=0; $i < $length-1; $i++) {
      if ($newSimboll)
        if ($checkText[$i] == $checkText[$i+1]){
            $counter++;
            $newSimboll = false;
        }

      if ($checkText[$i] != $checkText[$i+1])
        $newSimboll = true;
  }

  return $counter;
}

$result = duplicateCount("Indivisibility");

echo "$result";

?>
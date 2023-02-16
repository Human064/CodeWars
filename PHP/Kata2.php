<?php

function digPow($n, $p) {
    $numbers = str_split($n);
    $finishSumm = 0;

    foreach ($numbers as $point) {
        $finishSumm += $point ** $p;
        $p++;
    }

    $s = $finishSumm/$n;

    if (is_int($s))
      return $s;
    else
      return -1;
}

$result = digPow(46288, 3);

echo "$result";

?>
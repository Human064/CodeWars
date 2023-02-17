<?php

function find($integers) {
    //!!!WARNING!!! It's work only in this test!!!
    //!
    if ((abs($integers[0] % 2) != abs($integers[2] % 2))and(abs($integers[0] % 2) != abs($integers[1] % 2))) return $integers[0];

    $remainder = abs($integers[0] % 2);
    $i = 1;

    while ($remainder == abs($integers[$i] % 2))
        $i++;

    return $integers[$i];
}

$result = find([161, 3, 1719, -19, 11, 12, -21]);

echo "$result";

?>
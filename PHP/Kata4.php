<?php

function human_readable($seconds) {

    if ($seconds<60){
        return "00:00:".offen_zero($seconds);
    }

    $minuts = intdiv($seconds, 60);
    $seconds %= 60;

    if ($minuts<60) {
        return "00:".offen_zero($minuts).":".offen_zero($seconds);
    }

    return offen_zero(intdiv($minuts, 60)).":".offen_zero($minuts % 60).":".offen_zero($seconds);
}

function offen_zero($num){
    if ($num < 10)
        return "0$num";
    return "$num";
}

$result = human_readable(359999);

echo "$result";

?>
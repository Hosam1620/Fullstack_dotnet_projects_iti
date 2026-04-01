"use strict";

function checkHumidity(humidity) {
    if (humidity < 30) {
        console.log("Very Dry")
    } else if (humidity < 60) {
        console.log("Comfortable")
    } else if (humidity >= 60) {
        console.log("Humid")
    }
}

function checkWeather(humidity, wind) {
    if (humidity < 60 && wind < 20)
        console.log("Pleasant");
    else if (humidity > 60 && wind > 20)
        console.log("Stormy");
    else
        console.log("Normal");
}

checkWeather(50, 10);
checkWeather(70, 30);
checkWeather(70, 10);
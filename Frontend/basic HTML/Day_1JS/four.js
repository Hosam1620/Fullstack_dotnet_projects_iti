"use strict";

function CheckAirQuality(AQI, PM2) {
    if (AQI < 50 && PM2 < 35) {
        console.log("Good Air")
    } else if (AQI < 100 && PM2 < 75) {
        console.log("Moderate")
    } else if (AQI >= 100 && PM2 > 75) {
        console.log("Unhealthy")
    }else{console.log("Data Inconsistent")}
}
CheckAirQuality(40, 20);
CheckAirQuality(80, 60);
CheckAirQuality(150, 90);
CheckAirQuality(40, 80);
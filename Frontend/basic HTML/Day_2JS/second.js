function GetCurrentTime() {
    let now = new Date();

    console.log(
        `Date: ${now.toDateString()}
         Time: ${now.toTimeString()}
         `);
    const time12 = now.toLocaleTimeString("en-US", {
        hour: "2-digit",
        minute: "2-digit",
        second: "2-digit",
        hour12: true
    });
    console.log(`12 Formatting:${time12}`);
    const time24 = now.toLocaleTimeString("en-US", {
        hour: "2-digit",
        minute: "2-digit",
        second: "2-digit",
        hour12: false
    });
    console.log(`24 Formatting:${time24}`);
    console.log(`Current Day Of The Week: ${now.getDay() + 1}`);

    let lastDayOfTheMonth = prompt("What is the day of the last day of the month?");

    console.log(`days to end of the month is: ${lastDayOfTheMonth - (now.getMonth() + 1)}`);

}

function getAge() {
    const now = new Date();
    const birthDay = prompt("When are you born enter the year that you born in it?");
    console.log(`
                 BirthDay:${birthDay}
                 and your age is: ${now.getFullYear() - birthDay}`);

}

function updateCountdown() {
    const now = new Date();
    const newYear = new Date("January 1, 2027 00:00:00");

    const diff = newYear - now;

    if (diff <= 0) {
        document.getElementById("countdown").textContent =
            " Happy New Year 2027!";
        return;
    }
    //cause diff return number of mall second
    const totalMinutes = Math.floor(diff / (1000 * 60));
    const totalHours = Math.floor(totalMinutes / 60);
    const days = Math.floor(totalHours / 24);

    const hours = totalHours % 24;
    const minutes = totalMinutes % 60;

    document.getElementById("countdown").textContent = `
                Days: ${days}
                Hours: ${hours}
                minutes: ${minutes}
            `;
}
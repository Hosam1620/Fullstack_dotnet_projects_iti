function calculate() {
  let input = document.getElementById("birth").value;
  let out = document.getElementById("output");


  if (input.length !== 10 || input[2] !== "-" || input[5] !== "-") {
    out.innerHTML = "Error: Please use DD-MM-YYYY format";
    return;
  }


  for (let i = 0; i < input.length; i++) {
    if (i !== 2 && i !== 5) {
      if (input[i] < '0' || input[i] > '9') {
        out.innerHTML = "Error: Invalid date values";
        return;
      }
    }
  }

  let day = Number(input.substring(0, 2));
  let month = Number(input.substring(3, 5));
  let year = Number(input.substring(6));


  if (day < 1 || day > 31 || month < 1 || month > 12 || year < 1900 || year > 2024) {
    out.innerHTML = "Error: Invalid date values";
    return;
  }

  let birthDate = new Date(year, month - 1, day);


  if (
    birthDate.getDate() !== day ||
    birthDate.getMonth() !== month - 1 ||
    birthDate.getFullYear() !== year
  ) {
    out.innerHTML = "Error: Invalid date values";
    return;
  }

  let today = new Date();


  if (birthDate > today) {
    out.innerHTML = "Error: Birth date cannot be in the future";
    return;
  }


  let fullDate = birthDate.toLocaleDateString("en-US", {
    weekday: "long",
    year: "numeric",
    month: "long",
    day: "numeric"
  });

  let years = today.getFullYear() - year;
  let months = today.getMonth() - (month - 1);
  let days = today.getDate() - day;

  if (days < 0) {
    months--;
    let prevMonth = new Date(today.getFullYear(), today.getMonth(), 0);
    days += prevMonth.getDate();
  }

  if (months < 0) {
    years--;
    months += 12;
  }


  let bornDay = birthDate.toLocaleDateString("en-US", { weekday: "long" });


  let nextBirthday = new Date(today.getFullYear(), month - 1, day);
  if (nextBirthday < today) {
    nextBirthday.setFullYear(today.getFullYear() + 1);
  }

  let nextDayName = nextBirthday.toLocaleDateString("en-US", { weekday: "long" });

  let diffDays = Math.ceil((nextBirthday - today) / (1000 * 60 * 60 * 24));


  out.innerHTML = `
    <b>Birth Date:</b> ${fullDate}<br>
    <b>Age:</b> ${years} years, ${months} months, ${days} days<br>
    <b>Born on:</b> ${bornDay}<br>
    <b>Next Birthday:</b> ${nextBirthday.toDateString()} (${nextDayName})<br>
    <b>Days until next birthday:</b> ${diffDays}
  `;
}

function resetAll() {
  document.getElementById("birth").value = "";
  document.getElementById("output").innerHTML = "";
}

"use strict";

//Username
let username;
do {
    username = prompt("Enter username:" + "   At least 3 characters No numbers");
} while (username === null || username.length < 3 || /\d/.test(username)//to write regex should use / between those two foreword slash write the regex /
    );

//Birth Year
let birthYear;
do {
    birthYear = parseInt(prompt("Enter birth year (1950 - 2024)"));
} while (isNaN(birthYear) || birthYear < 1950 || birthYear > 2024);

//  Phone Number
let phone;
do {
    phone = prompt("Enter phone number should be 11 digits)");
} while (!/\d{11}/.test(phone));

// Email
let email;
do {
    email = prompt("Enter email ");
} while (email === null || !email.includes("@") || !email.includes("."));

// Calculate age here we define the new object to get current date and calc the age
const currentYear = new Date().getFullYear();
const age = currentYear - birthYear;

// Display result
document.getElementById("output").textContent = "Registration Successful!";

document.getElementById("details").textContent = `Username: ${username}\n
Birth Year: ${birthYear}\n
Age: ${age}\n
Phone: ${phone}\n
Email: ${email}\n`;
"use strict";

"use strict";

// Function that performs the operation
function calculate(num1, num2, operation) {
    switch (operation) {
        case "+":
            return num1 + num2;
        case "-":
            return num1 - num2;
        case "*":
            return num1 * num2;
        case "/":
            return num2 !== 0 ? num1 / num2 : null;
        default:
            return null;
    }
}

// Function triggered by button click
function startCalculator() {
    let num1, num2, operation, result;

    // Validate first number
    do {
        num1 = parseInt(prompt("Enter first number:"));
    } while (isNaN(num1));

    // Validate second number
    do {
        num2 = parseInt(prompt("Enter second number:"));
    } while (isNaN(num2));

    // Validate operation
    do {
        operation = prompt("Choose operation (+, -, *, /)");
    } while (!["+", "-", "*", "/"].includes(operation));

    // Call function
    result = calculate(num1, num2, operation);

    // Handle division by zero
    if (result === null) {
        console.log("Error: Division by zero");
    } else {
        console.log(`Operation: ${num1} ${operation} ${num2} = ${result}`);
    }
}


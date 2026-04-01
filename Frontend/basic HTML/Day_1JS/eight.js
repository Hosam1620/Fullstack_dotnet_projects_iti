"use strict";

function calculateDiscount(price, discount) {
    console.log("Price type:", typeof price, "Discount type:", typeof discount);

    if (discount > 100 || discount < 0) {
        console.log("Invalid discount value:", discount);
        return null;
    }

    let finalPrice = price - (price * discount / 100);
    console.log("Calculated final price:", finalPrice);

    return finalPrice;
}

// Input
let userPrice = Number(prompt("Enter price:"));
let userDiscount = Number(prompt("Enter discount:"));

console.log("User Price:", userPrice);
console.log("User Discount:", userDiscount);

// Calculation
let result = calculateDiscount(userPrice, userDiscount);

// Output
if (result !== null) {
    console.log("Final Price: $" + result);
} else {
    console.log("Calculation failed due to invalid input.");
}

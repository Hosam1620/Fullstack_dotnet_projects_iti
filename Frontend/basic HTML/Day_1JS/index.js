"use strict";
alert(" Welcome to the Diploma!Let's get started!")

//prompt to take the input from the user

let email
do {
    email =prompt("Please enter a valid email address?")
}while (!email.includes("@"))

let favColor=prompt("Please enter your favourite color")
//to make an interpolation
document.getElementById("message").textContent = `Your email is: ${email} and Your favColor is: ${favColor}`;

if(confirm("Would you like to see this again?")){
location.reload();
}else{
    alert("Goodbye...!");
}

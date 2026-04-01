let arr = ["Python_Programming_language", "Java_Programming_language", "2_Programming_language",
    "4_Programming_language", "5_Programming_language", "6_Programming_language", "7_Programming_language", "8_Programming_language"
    , "9_Programming_language", "10_Programming_language", "11_Programming_language", "12_Programming_language"];
// let quote
// do {
//     quote  =prompt("enter the programming language with at least 12 characters long?");
// }while(quote.length() <0&& quote.length() !== 15);

// on click
let numb;

function GetInspired() {
    numb = Math.floor(Math.random() * arr.length);
    console.log(`Your programming lan is: ${arr[numb]}}\n some details:\n number of character: ${arr[numb].length}\n
    number of words: ${arr[numb].split("_").length}\n`);
    let countVao=0;

    if (/[ouiea]/g.test(arr[numb])) {
        countVao+=1;
    }
    console.log(`countVowels: ${countVao}\n`);
}

//favourite
let favourites = [];

function favourite() {
    favourites.push(arr[numb]);
}

function ShowAllFavourites() {
    for (favourite of favourites) {
        console.log(favourite);
    }
}
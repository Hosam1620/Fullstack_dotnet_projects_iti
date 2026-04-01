"use strict";
function analysis () {
    let element = document.getElementById("textAnalysis");
    console.log(element.value);
    let val = element.value;

    if (val.length < 50) {
        alert("minimum 50 characters");
    }
    const totalCharacters = val.length;
    const totalCharactersWithSpaces = val.split("").reduce((acc, curr) => {
        if (curr != " ") {
            acc++;
        }
         return acc;
    }, 0);

    const totalWord = val.split(" ").length;

    const totalSentences = val.split("").reduce((acc, curr) => {
        if (curr == "." || curr == "?" || curr == "!") {
            acc++;
        }
        return acc;
    }, 0)

    const totalParagraph = val.split("\n").length;

    let longestWord = "";
   
    const wordFreq = new Map();
    val.split(" ").forEach((w) => {

        if (w.length > longestWord.length) {
            longestWord = w;
        }
        const currentWord = w.toLocaleLowerCase();
        if (wordFreq.has(currentWord)) {
            wordFreq.set(currentWord, wordFreq.get(currentWord) + 1);
        } else {
            wordFreq.set(currentWord, 1);
        }
    });

    let shortestWord = val.split(" ")[0];
    val.split(" ").forEach((w) => {
        if (w.length < shortestWord.length) {
            shortestWord = w;
        }
    });

    let most = wordFreq.entries().next().value
    console.log(wordFreq);
    for (const entry of wordFreq.entries()) {
        if (entry[1] > most[1]) {
            most = entry;
        };
    }
    document.getElementById("textAnalysisResult").innerHTML =
    `
    <p>Total characters (including spaces): ${totalCharacters}</p>
    <p>Total characters (excluding spaces): ${totalCharactersWithSpaces}</p>
    <p>Total words: ${totalWord}</p>
    <p>Total sentences: ${totalSentences}</p>
    <p>Total paragraphs: ${totalParagraph}</p>
    <p>Longest word in the text: ${longestWord}</p>
    <p>Shortest word in the text: ${shortestWord}</p>
    <p>Most frequently used word (case-insensitive): ${most[0]}</p>
    `;
}



function ConverttoUppercase ()
{
    const el = document.getElementById("textAnalysis");
    const before = el.value;
    el.value = before.toUpperCase();
}
function ConverttoLowercase ()
{
    const el = document.getElementById("textAnalysis");
    const before = el.value;
    el.value = before.toLowerCase();
}
function TitleCase() {
  const el = document.getElementById("textAnalysis");
  const before = el.value;
  el.value = before.split(" ").map((word) => 
    word[0].toUpperCase() + word.slice(1).toLowerCase()
  ).join(" ");
}
function ReverseText ()
{
    const el = document.getElementById("textAnalysis");
    const before = el.value;
    el.value = before.split("").reverse().join("");
}
function RemoveExtra() {
    const el = document.getElementById("textAnalysis");
    const before = el.value;
    el.value = before.split(/\s+/).join(" ").trim();
}

function SearchWord() {
    const el = document.getElementById("textAnalysis");
    const searchTerm = document.getElementById("searchInput").value;
    const text = el.value;
    
    if (!searchTerm) {
        alert("Please enter a word to search");
        return;
    }
    const regex = new RegExp(searchTerm, "gi");
    const matches = text.match(regex);
    const count = matches ? matches.length : 0;
    
    document.getElementById("searchCount").textContent = 
        `Found "${searchTerm}" ${count} time(s)`;
    
    const highlighted = text.replace(regex, (match) => 
        `<mark>${match}</mark>`
    );
    
    document.getElementById("highlightedText").innerHTML = highlighted;
}

function ReplaceWord() {
    const el = document.getElementById("textAnalysis");
    const searchTerm = document.getElementById("searchInput").value;
    const replaceTerm = document.getElementById("replaceInput").value;
    const text = el.value;
    
    if (!searchTerm) {
        alert("Please enter a word to search");
        return;
    }
    
    const regex = new RegExp(searchTerm, "gi");
    el.value = text.replace(regex, replaceTerm);
    
    SearchWord();
}
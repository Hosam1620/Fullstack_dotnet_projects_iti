"use strict";

// Validate expression
function isValidExpression(expression) {
    // Allow only numbers, operators, parentheses, and spaces
    const regex = /^[0-9+\-*/().\s]+$/;
    return regex.test(expression);
}

// Evaluate safely
function evaluateExpression(expression) {
    if (!isValidExpression(expression)) {
        return null;
    }

    try {
        // Using Function constructor instead of eval
        return Function(`return (${expression})`)();
    } catch {
        return null;
    }
}

//  Button handler
function startEvaluation() {
    let expression;
    let result;

    do {
        expression = prompt(
            "Enter a mathematical expression"
        );
    } while (expression === null || !isValidExpression(expression));

    result = evaluateExpression(expression);

    if (result === null || isNaN(result)) {
        alert("Invalid mathematical expression");
    } else {
        alert(`Expression: ${expression} | Result: ${result}`);
    }
}

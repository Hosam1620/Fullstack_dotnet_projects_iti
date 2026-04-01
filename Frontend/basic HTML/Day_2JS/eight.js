function calculate() {
  let n1 = document.getElementById("num1").value.trim();
  let n2 = document.getElementById("num2").value.trim();
  let op = document.getElementById("operation").value;

  let resultBox = document.getElementById("result");
  let statusBox = document.getElementById("status");

  resultBox.innerHTML = "";
  statusBox.innerHTML = "";

  try {
    if (n1 === "" || (op !== "sqrt" && n2 === "")) {
      throw new Error("Empty input: Both fields are required");
    }

    if (isNaN(n1) || (op !== "sqrt" && isNaN(n2))) {
      throw new Error("Invalid input: Please enter numbers only");
    }

    let a = Number(n1);
    let b = Number(n2);
    let result;

    switch (op) {
      case "add":
        result = a + b;
        break;

      case "sub":
        result = a - b;
        break;

      case "mul":
        result = a * b;
        break;

      case "div":
        if (b === 0) {
          throw new Error("Math Error: Cannot divide by zero");
        }
        result = a / b;
        break;

      case "pow":
        if (a === 0 && b < 0) {
          throw new Error("Math Error: 0 cannot be raised to negative power");
        }
        result = Math.pow(a, b);
        break;

      case "sqrt":
        if (a < 0) {
          throw new Error("Math Error: Cannot calculate square root of negative number");
        }
        result = Math.sqrt(a);
        break;
    }

    if (!isFinite(result)) {
      throw new Error("Result is infinity");
    }

    if (Math.abs(result) > Number.MAX_SAFE_INTEGER) {
      throw new Error("Result too large to calculate accurately");
    }

    resultBox.style.color = "green";
    resultBox.innerHTML = "Result = " + result;

  } catch (err) {
    resultBox.style.color = "red";
    resultBox.innerHTML = err.name + ": " + err.message;

    logError(err.name + ": " + err.message);

  } finally {
    statusBox.innerHTML = "Calculation attempt completed";
  }
}

function logError(message) {
  let log = document.getElementById("errorLog");
  let li = document.createElement("li");
  let time = new Date().toLocaleString();
  li.textContent = `[${time}] ${message}`;
  log.appendChild(li);
}

function resetAll() {
  document.getElementById("num1").value = "";
  document.getElementById("num2").value = "";
  document.getElementById("result").innerHTML = "";
  document.getElementById("status").innerHTML = "";
}

//  Global Error Handler
window.onerror = function (message, source, lineno, colno, error) {
  console.error("Global Error:");
  console.error("Message:", message);
  console.error("Source:", source);
  console.error("Line:", lineno, "Column:", colno);
  console.error("Error object:", error);
};

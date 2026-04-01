let grades = [78, 95, 45, 32, 88, 100, 55, 73, 91, 18, 67, 82];



function sortElments() {
  let After = [];
  let Lowest = [];
  let total = 0;
  After = grades.sort((a, b) => b - a);
  for (let index = 0; index < After.length; index++) {
    const element = After[index];
    total += element;
    console.log(element);
  }

  let highest = grades.find((g) => g <= 100);
  console.log(" The highest Number is :" + highest);

  Lowest = grades.sort((a, b) => a - b);

  let LowNum = grades[0];
  console.log(" The Lowest Number is :" + LowNum);

  let av = total / After.length;

  console.log("The average :" + av);
}

// Filtering Operations

function allFailed() {
  let faled = [];

  for (let index = 0; index < grades.length; index++) {
    const element = grades[index];

    if (element < 60) {
      faled.push(element);
      console.log(element);
    }
  }
}

function Excellent() {
  let earr = [];

  for (let index = 0; index < grades.length; index++) {
    let element = grades[index];

    if (element >= 90) {
      earr.push(element);
    }
  }

for (let index = 0; index < earr.length; index++) {
  let element = earr[index];
  
console.log(element);


}


}

function gradeCategory(grade) {
  if (grade >= 90) {
    return "Excellent";
  } else if (grade >= 80) {
    return "Very Good";
  } else if (grade >= 70) {
    return "Good";
  } else if (grade >= 60) {
    return "Pass";
  } else {
    return "Fail";
  }
}

grades.forEach(g => {
  console.log(g + " → " + gradeCategory(g));
});


  function displayGrades() {
      document.getElementById("grades").innerText = grades.join(" , ");
    }

    function curveGrades() {
      grades = grades.map(g => {
        if (g < 60) {
          g += 5;
        }
        return g > 100 ? 100 : g;
      });

      displayGrades();
    }

     displayGrades();
let students = [{"name": "Ahmed Ali", "degree": 87, "major": "CS"}, {
    "name": "Fatma Hassan",
    "degree": 92,
    "major": "IT"
}, {"name": "Omar Khaled", "degree": 45, "major": "CS"}, {
    "name": "Layla Mohamed",
    "degree": 78,
    "major": "IS"
}, {"name": "Youssef Ibrahim", "degree": 56, "major": "IT"}, {"name": "Nour Ahmed", "degree": 95, "major": "CS"}];

//search operations
//
// function findTopStudent() {
//     const topStudent = students.find(s => s.degree >= 90 && s.degree <= 100);
//     console.log(topStudent);
// }

//all students
// function printStudentsAbove80() {
//     console.log(students.filter(s => s.major === "CS" && s.degree > 80));
// }

//by name
// function findName() {
//     prompt("What is your name?");
//     console.log(students.find(d => d.name === prompt("What is your name?")));
// }

// Display op
// note that map function make a new array of this values
// function DisplayNameOfFal() {
//     const failedStudents = students
//         .filter(s => s.degree < 60)
//         .map(s => s.name);
//
//     console.log(failedStudents);
// }

//display Array sorted
// function sortedByName() {
//     const sortedByName = [...students].sort(
//         (a, b) => a.name.localeCompare(b.name)
//     );
//
//     console.log(sortedByName);
// }
//
// // sortedByName();
// //display sorted degree
// function sortedByDegree() {
//     const sortedByDegree = [...students].sort(
//         (a, b) => a.degree.localeCompare(b.degree));
//     console.log(sortedByDegree);
// }

//sortedByDegree();

//Modification Operations
function AddItems() {
    let name = prompt("Enter your name");
    let degree = Number(prompt("Enter your degree"));
    let major = prompt("Enter your major");
    students.push({
        name: name,
        degree: degree,
        major: major
    });
}
function RemoveItem(name) {
    const removedStudent = students.pop();
    console.log("Removed:", removedStudent);

}
function AddTwoAfterTowStudents() {
    students.splice(2, 0,
        { name: "mohamed yehai", degree: 70, major: "CS" },
        { name: "Sara ahmed", degree: 85, major: "IT" }
    );
}
function remove4FromArr() {students.splice(3, 1);
}
//iteration
function displayIndexAndName() {
    for (let i = 0; i < students.length; i++) {
        console.log(i, students[i].name);
    }

}
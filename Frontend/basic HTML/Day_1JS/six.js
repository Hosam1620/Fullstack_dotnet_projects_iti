function checkCourseEligibility(grade) {

    grade = grade.toUpperCase();

    switch (grade) {
        case "A":
            console.log("Eligible for Advanced Programming Course");
            break;

        case "B":
            console.log("Eligible for Standard Programming Course");
            break;

        case "C":
            console.log("Eligible for Beginner Programming Course");
            break;

        case "D":
            console.log("Must take Prerequisite Course first");
            break;

        default:
            console.log("Invalid grade entered");
    }
}
function checkCourseEligibilityAdvanced(grade, completed) {
    grade = grade.toUpperCase();

    switch (grade) {
        case "A":
            console.log(
                completed
                    ? "Eligible for Advanced Programming Course"
                    : "Must take Prerequisite Course first"
            );
            break;

        case "B":
            console.log(
                completed
                    ? "Eligible for Standard Programming Course"
                    : "Must take Prerequisite Course first"
            );
            break;

        case "C":
            console.log(
                completed
                    ? "Eligible for Beginner Programming Course"
                    : "Must take Prerequisite Course first"
            );
            break;

        case "D":
            console.log("Must take Prerequisite Course first");
            break;

        default:
            console.log("Invalid grade entered");
    }
}

//easy function
checkCourseEligibility(prompt("enter your grade"));
checkCourseEligibility(prompt("enter your grade"));
checkCourseEligibility(prompt("enter your grade"));
checkCourseEligibility(prompt("enter your grade"));





//Advanced
checkCourseEligibilityAdvanced("A", true);
checkCourseEligibilityAdvanced("B", false);
checkCourseEligibilityAdvanced("C", true);
checkCourseEligibilityAdvanced("X", true);

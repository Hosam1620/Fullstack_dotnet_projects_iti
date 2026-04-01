function emailValid() {
    const email = prompt('Enter a valid email address');

    if (!email) {
        console.log('Please enter a valid email address');

    } else {

        const index = email.indexOf('@')
        const dotIndex = email.indexOf('.');
        if (!index && !dotIndex) {
            console.log('You should hav @ at least one letter and one dot');
        }
        //not First or last
        if (index === 0 || index === email.length - 1) {
            console.log('You should have the letter after @\nYou should have at last 2char before @');
        }
        //one dot
        if (dotIndex) {
            console.log('You should have at least one dot');
        }
        //3
        if (index > dotIndex) {
            console.log('You should @ be after dot.');
        }
        //4
        if ((dotIndex - index) <= 2) {
            console.log('number of letters between @and dont should be at least two letters');
        }
        //5
        if (((email.length - 1) - dotIndex) < 2) {
            console.log('number of letters after . should be at least two letters');
        } else {
            console.log("valid email ");
        }
    }

}


function userNameValid() {
    const name = prompt('Enter a valid name address');
    let firstChar = Number(name.charAt(0));
    if (!name) {
        console.log('Please enter a valid name ');
    } else if (name.length < 5 || name.length > 15) {
        console.log('Please enter a valid name between 5 and 15 characters');
    } else if (!firstChar >= 65 && !firstChar <= 90 || !firstChar >= 97 && !firstChar <= 122) {
        console.log('the first name is invalid');
    } else
        //cut the 
        console.log(name.slice(0, 3));
}


emailValid();
userNameValid();
// Complete the isPositive function.
function isPositive(a) {
    let number = a;
    let message = new Error();
    if (number > 0) {
        // If 'a' is positive, return "YES".
        return 'YES';
    } else if (number == 0) {
        // If 'a' is 0, throw an Error with the message "Zero Error"
        throw message = new Error('Zero Error');
    } else if (number < 0) {
        // If 'a' is negative, throw an Error with the message "Negative Error"
        throw message = new Error('Negative Error');
    }
}

try {
    console.log(isPositive(Number(-2)));
} catch (error) {
    console.log(error.message);
}


function Regex(input) {

    let re = /^[A-Za-z]{1,}\.[A-z]+$/;

    return re.test(input);

}

console.log(Regex('Mr.X'));
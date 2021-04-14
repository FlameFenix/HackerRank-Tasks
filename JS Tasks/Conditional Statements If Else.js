function getGrade(score) {
    let grade;
    // Write your code here
    let result = Number(score);
    if (result > 25 && result <= 30) {
        grade = 'A';
    } else if(result > 20 && result <= 25) {
        grade = 'B';
    } else if(result > 15 && result <= 20) {
        grade = 'C';
    } else if(result > 10 && result <= 15) {
        grade = 'D';
    } else if(result > 5 && result <= 10) {
        grade = 'E';
    } else if(result >= 0 && result <= 5)
    {
        grade = 'F';
    }

    return grade;
    
}

console.log(getGrade("20"));

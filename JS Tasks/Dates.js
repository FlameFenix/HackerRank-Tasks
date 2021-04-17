function Dates(input) {
    let date = new Date(input);
    let day = date.getDay();
    let dayName = '';
    switch (day) {
        case 1:
            dayName = 'Monday';
            break;
        case 2:
            dayName = 'Tuesday';
            break;
        case 3:
            dayName = 'Wednesday';
            break;
        case 4:
            dayName = 'Thursday';
            break;
        case 5:
            dayName = 'Friday';
            break;
        case 6:
            dayName = 'Saturday';
            break;
        case 0:
            dayName = 'Sunday';
            break;

        default:
            break;
    }
    console.log(dayName);
}


Dates('11/10/2010')
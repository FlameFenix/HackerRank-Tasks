function thirdRexgex(input) {
    let re = /[0-9]+/g;
    let str = String(input);
    let m = str.match(re);
    for (const item of m) {
        console.log(item);
    }
}

thirdRexgex('102, 1948948 and 1.3 and 4.5');
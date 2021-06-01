function modifyArray(nums) {
    return nums.map(x => x % 2 == 0 ? x*=2 : x*=3);
    return nums.forEach(e => {
        if(nums.indexOf(e) % 2 == 0) {
         e *= 3;
        } else {
            e *= 2;
        }
    });
}

console.log(modifyArray([1 ,2 ,3 ,4 ,5]));